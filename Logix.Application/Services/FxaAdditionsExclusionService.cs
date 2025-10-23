using AutoMapper;
using Logix.Application.Common;
using Logix.Application.DTOs.ACC;
using Logix.Application.DTOs.FXA;
using Logix.Application.Helpers.Acc;
using Logix.Application.Interfaces.IRepositories;
using Logix.Application.Interfaces.IServices;
using Logix.Application.Interfaces.IServices.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static QuestPDF.Helpers.Colors;

namespace Logix.Application.Services.FXA
{
    public class FxaAdditionsExclusionService : GenericQueryService<FxaAdditionsExclusion, FxaAdditionsExclusionDto, FxaAdditionsExclusionVw>, IFxaAdditionsExclusionService
    {
        private readonly IFxaRepositoryManager _fxaRepositoryManager;
        private readonly IAccRepositoryManager _accRepositoryManager;
        private readonly IMainRepositoryManager _mainRepositoryManager;
        private readonly IMapper _mapper;
        private readonly ICurrentData session;
        private readonly ILocalizationService localization;
        private readonly IGetAccountIDByCodeHelper getAccountIDByCodeHelper;
        private readonly IGetRefranceByCodeHelper getRefranceByCodeHelper;

        public FxaAdditionsExclusionService(IQueryRepository<FxaAdditionsExclusion> queryRepository,
            IMapper mapper,
            IFxaRepositoryManager fxaRepositoryManager,
            IAccRepositoryManager accRepositoryManager,
            IMainRepositoryManager mainRepositoryManager,
            ICurrentData session,
            ILocalizationService localization,
            IGetAccountIDByCodeHelper getAccountIDByCodeHelper,
            IGetRefranceByCodeHelper getRefranceByCodeHelper) : base(queryRepository, mapper)
        {
            this._fxaRepositoryManager = fxaRepositoryManager;
            this._accRepositoryManager = accRepositoryManager;
            this._mainRepositoryManager = mainRepositoryManager;
            this._mapper = mapper;
            this.session = session;
            this.localization = localization;
            this.getAccountIDByCodeHelper = getAccountIDByCodeHelper;
            this.getRefranceByCodeHelper = getRefranceByCodeHelper;
        }

        public async Task<IResult<FxaAdditionsExclusionDto>> Add(FxaAdditionsExclusionDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                //check if date in period
                if (!string.IsNullOrEmpty(entity.Date1))
                {
                    bool chkPeriod = await _accRepositoryManager.AccPeriodsRepository.CheckDateInPeriod(entity.PeriodId ?? 0, entity.Date1);
                    if (!chkPeriod)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync($"{localization.GetResource1("DateOutOfPERIOD")}");
                }

                long accountId = 0;
                long crdAccountId = 0;
                crdAccountId = await getAccountIDByCodeHelper.GetAccountIDByCode(entity.AccountTypeId ?? 0, entity.CrdAccountCode ?? "");
                if (crdAccountId == 0)
                    return await Result<FxaAdditionsExclusionDto>.FailAsync($"لا يوجد حساب بهذا الرقم");

                long refrance = 0;
                refrance = await getRefranceByCodeHelper.GetRefranceByCode(entity.AccountTypeId ?? 0, entity.CrdAccountCode ?? "");
                if (refrance == 0)
                    return await Result<FxaAdditionsExclusionDto>.FailAsync($"لا يوجد مرجع لهذا الرقم");

                string accJType = "";
                accJType = await GetPropertyValue(68);

                if (!string.IsNullOrEmpty(entity.AccountCode))
                {
                    accountId = await GetAccountIdByCode(entity.AccountCode);

                    if (accountId == 0)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync($"رقم حساب الأصل غير صحيح");
                }

                //check fixed asset id
                long fxId = 0;
                fxId = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(a => a.Id, a => a.No == entity.FxNo && a.IsDeleted == false);
                if (fxId == 0)
                    return await Result<FxaAdditionsExclusionDto>.FailAsync($"الاصل غير موجود في قائمة الاصول");

                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //Insert into FXAAdditionsExclusion table
                var item = _mapper.Map<FxaAdditionsExclusion>(entity);
                item.FixedAssetId = fxId;
                item.AccountId = accountId;
                item.CrdAccountId = crdAccountId;
                item.CrdAccountRefranceNo = refrance;

                if (entity.OperationType == 1)
                    item.Credit = entity.Amount;
                else
                    item.Debit = entity.Amount;

                item.EndDate = entity.AffectAgeDate;
                item.FacilityId = Convert.ToInt32(session.FacilityId);
                item.CreatedBy = session.UserId;
                item.CreatedOn = DateTime.Now;

                var newItem = await _fxaRepositoryManager.FxaAdditionsExclusionRepository.AddAndReturn(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                entity.Id = newItem.Id;

                // التقيد في المحاسبي
                if (entity.OperationType == 1)
                {
                    string desc = "   قيد اضافة راس مالي على الاصل رقم  " + entity.FxNo + " بتاريخ  " + entity.Date1 + " " + entity.Description;
                    AccJournalMasterDto accJournalMaster = new()
                    {
                        JDateHijri = entity.Date1,
                        JDateGregorian = entity.Date1,
                        Amount = entity.Amount,
                        AmountWrite = "",
                        JDescription = desc,
                        PaymentTypeId = 2,
                        PeriodId = entity.PeriodId,
                        StatusId = 1,
                        FinYear = session.FinYear,
                        FacilityId = session.FacilityId,
                        DocTypeId = 103, //نوع قيد اضافة راس مالية على الاصل
                        ReferenceNo = newItem.Id,
                        ReferenceCode = newItem.Id.ToString(),
                        JBian = desc,
                        BankId = 0,
                        CcId = session.BranchId,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalMaster.Succeeded)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalMaster.Status.message);

                    long jId = addJournalMaster.Data.JId;
                    entity.JId = addJournalMaster.Data.JId;
                    entity.JCode = addJournalMaster.Data.JCode;

                    AccJournalDetaileDto accJournalDetail1 = new()
                    {
                        JId = jId,
                        AccAccountId = accountId,
                        Credit = 0,
                        Debit = entity.Amount,
                        Description = desc,
                        CcId = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };
                    if (accJType == "2")
                    {
                        //القيد يكون نوعه حساب من الدليل
                        accJournalDetail1.ReferenceTypeId = 1;
                        accJournalDetail1.ReferenceNo = 0;
                    }
                    else
                    {
                        //القيد يكون نوعه نوع حركة الاصل 
                        accJournalDetail1.ReferenceTypeId = 12;
                        accJournalDetail1.ReferenceNo = fxId;
                    }

                    var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail1.Succeeded)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalDetail1.Status.message);

                    //حساب ضريبة القيمة المضافة مشتريات
                    if (entity.VatAmount > 0)
                    {
                        var purchasesVatAccountId = await _accRepositoryManager.AccFacilityRepository.GetOne(f => f.PurchasesVatAccountId,
                                f => f.FacilityId == session.FacilityId);
                        if (purchasesVatAccountId == null || purchasesVatAccountId == 0)
                            return await Result<FxaAdditionsExclusionDto>.FailAsync("Vat Purchases account did not specify حساب ضريبة القيمة المضافة مشتريات  لم يحدد.");

                        AccJournalDetaileDto accJournalDetail2 = new()
                        {
                            JId = jId,
                            AccAccountId = purchasesVatAccountId,
                            Credit = 0,
                            Debit = entity.VatAmount,
                            Description = desc,
                            CcId = 0,
                            ReferenceNo = 0,
                            ReferenceTypeId = 1,
                            CurrencyId = 1,
                            ExchangeRate = 1
                        };
                        var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        if (!addJournalDetail2.Succeeded)
                            return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalDetail2.Status.message);
                    }

                    //قيد حساب الدائن
                    AccJournalDetaileDto accJournalDetail3 = new()
                    {
                        JId = jId,
                        AccAccountId = crdAccountId,
                        Credit = entity.Amount + entity.VatAmount,
                        Debit = 0,
                        Description = desc,
                        CcId = 0,
                        ReferenceTypeId = entity.AccountTypeId,
                        ReferenceNo = refrance,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail3.Succeeded)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalDetail3.Status.message);
                }
                else
                {
                    string desc = "  قيد استبعاد راس مالي  من الاصل رقم   " + entity.FxNo + " بتاريخ  " + entity.Date1 + " " + entity.Description;
                    AccJournalMasterDto accJournalMaster = new()
                    {
                        JDateHijri = entity.Date1,
                        JDateGregorian = entity.Date1,
                        Amount = entity.Amount,
                        AmountWrite = "",
                        JDescription = desc,
                        PaymentTypeId = 2,
                        PeriodId = entity.PeriodId,
                        StatusId = 1,
                        FinYear = session.FinYear,
                        FacilityId = session.FacilityId,
                        DocTypeId = 104, //نوع قيد استبعاد راس مالية على الاصل
                        ReferenceNo = newItem.Id,
                        ReferenceCode = newItem.Id.ToString(),
                        JBian = desc,
                        BankId = 0,
                        CcId = session.BranchId,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalMaster.Succeeded)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalMaster.Status.message);

                    long jId = addJournalMaster.Data.JId;
                    entity.JId = addJournalMaster.Data.JId;
                    entity.JCode = addJournalMaster.Data.JCode;

                    //قيد حساب المدين
                    AccJournalDetaileDto accJournalDetail1 = new()
                    {
                        JId = jId,
                        AccAccountId = crdAccountId,
                        Credit = 0,
                        Debit = entity.Amount + entity.VatAmount,
                        Description = desc,
                        CcId = 0,
                        ReferenceTypeId = entity.AccountTypeId,
                        ReferenceNo = refrance,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail1.Succeeded)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalDetail1.Status.message);

                    //قيد الاصل
                    AccJournalDetaileDto accJournalDetail2 = new()
                    {
                        JId = jId,
                        AccAccountId = accountId,
                        Credit = entity.Amount,
                        Debit = 0,
                        Description = desc,
                        CcId = 0,
                        ReferenceNo = 0,
                        ReferenceTypeId = 1,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };
                    if (accJType == "2")
                    {
                        accJournalDetail2.ReferenceTypeId = 1;
                        accJournalDetail2.ReferenceNo = 0;
                    }
                    else
                    {
                        accJournalDetail2.ReferenceTypeId = 12;
                        accJournalDetail2.ReferenceNo = fxId;
                    }

                    var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail2.Succeeded)
                        return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalDetail2.Status.message);

                    //حساب ضريبة القيمة المضافة مشتريات
                    if (entity.VatAmount > 0)
                    {
                        var purchasesVatAccountId = await _accRepositoryManager.AccFacilityRepository.GetOne(f => f.PurchasesVatAccountId,
                                f => f.FacilityId == session.FacilityId);
                        if (purchasesVatAccountId == null || purchasesVatAccountId == 0)
                            return await Result<FxaAdditionsExclusionDto>.FailAsync("Vat Purchases account did not specify حساب ضريبة القيمة المضافة مشتريات  لم يحدد.");

                        AccJournalDetaileDto accJournalDetail3 = new()
                        {
                            JId = jId,
                            AccAccountId = purchasesVatAccountId,
                            Credit = entity.VatAmount,
                            Debit = 0,
                            Description = desc,
                            CcId = 0,
                            ReferenceNo = 0,
                            ReferenceTypeId = 1,
                            CurrencyId = 1,
                            ExchangeRate = 1
                        };

                        var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        if (!addJournalDetail3.Succeeded)
                            return await Result<FxaAdditionsExclusionDto>.FailAsync(addJournalDetail3.Status.message);
                    }
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);

                return await Result<FxaAdditionsExclusionDto>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaAdditionsExclusionDto>.FailAsync($"EXP in Add at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }


        public async Task<IResult<FxaAdditionsExclusionEditDto>> Update(FxaAdditionsExclusionEditDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                //check account journal,, if status=2 => can not edit
                int docTypeId = entity.OperationType == 1 ? 103 : 104;
                var journalStatus = await _accRepositoryManager.AccJournalMasterRepository.GetJournalMasterStatuse(entity.Id ?? 0, docTypeId);
                if (journalStatus == 2)
                    return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"لايمكن التعديل وذلك لترحيل القيد");

                //check if date in period
                if (!string.IsNullOrEmpty(entity.Date1))
                {
                    bool chkPeriod = await _accRepositoryManager.AccPeriodsRepository.CheckDateInPeriod(entity.PeriodId ?? 0, entity.Date1);
                    if (!chkPeriod)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"{localization.GetResource1("DateOutOfPERIOD")}");
                }

                long accountId = 0;
                long crdAccountId = 0;
                crdAccountId = await getAccountIDByCodeHelper.GetAccountIDByCode(entity.AccountTypeId ?? 0, entity.CrdAccountCode ?? "");
                if (crdAccountId == 0)
                    return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"لا يوجد حساب بهذا الرقم");

                long refrance = 0;
                refrance = await getRefranceByCodeHelper.GetRefranceByCode(entity.AccountTypeId ?? 0, entity.CrdAccountCode ?? "");
                if (refrance == 0)
                    return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"لا يوجد مرجع لهذا الرقم");

                string accJType = "";
                accJType = await GetPropertyValue(68);

                if (!string.IsNullOrEmpty(entity.AccountCode))
                {
                    accountId = await GetAccountIdByCode(entity.AccountCode);

                    if (accountId == 0)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"رقم حساب الأصل غير صحيح");
                }

                //check fixed asset id
                long fxId = 0;
                fxId = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(a => a.Id, a => a.No == entity.FxNo && a.IsDeleted == false);
                if (fxId == 0)
                    return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"الاصل غير موجود في قائمة الاصول");

                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //update FXAAdditionsExclusion
                var item = await _fxaRepositoryManager.FxaAdditionsExclusionRepository.GetById(entity.Id ?? 0);
                if (item == null)
                    return await Result<FxaAdditionsExclusionEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

                _mapper.Map(entity, item);

                item.FixedAssetId = fxId;
                item.AccountId = accountId;
                item.CrdAccountId = crdAccountId;
                item.CrdAccountRefranceNo = refrance;

                if (entity.OperationType == 1)
                    item.Credit = entity.Amount;
                else
                    item.Debit = entity.Amount;

                item.EndDate = entity.AffectAgeDate;
                item.FacilityId = Convert.ToInt32(session.FacilityId);
                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;

                _fxaRepositoryManager.FxaAdditionsExclusionRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                // التقيد في المحاسبي
                if (entity.OperationType == 1)
                {
                    string desc = "   قيد اضافة راس مالي على الاصل رقم  " + entity.FxNo + " بتاريخ  " + entity.Date1 + " " + entity.Description;
                    AccJournalMasterDto accJournalMaster = new()
                    {
                        JDateHijri = entity.Date1,
                        JDateGregorian = entity.Date1,
                        Amount = entity.Amount,
                        AmountWrite = "",
                        JDescription = desc,
                        PaymentTypeId = 2,
                        PeriodId = entity.PeriodId,
                        StatusId = 1,
                        FinYear = session.FinYear,
                        FacilityId = session.FacilityId,
                        DocTypeId = 103, //نوع قيد اضافة راس مالية على الاصل
                        ReferenceNo = entity.Id,
                        ReferenceCode = entity.Id.ToString(),
                        JBian = desc,
                        BankId = 0,
                        CcId = session.BranchId,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalMaster.Succeeded)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalMaster.Status.message);

                    long jId = addJournalMaster.Data.JId;
                    entity.JId = addJournalMaster.Data.JId;
                    entity.JCode = addJournalMaster.Data.JCode;

                    AccJournalDetaileDto accJournalDetail1 = new()
                    {
                        JId = jId,
                        AccAccountId = accountId,
                        Credit = 0,
                        Debit = entity.Amount,
                        Description = desc,
                        CcId = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };
                    if (accJType == "2")
                    {
                        //القيد يكون نوعه حساب من الدليل
                        accJournalDetail1.ReferenceTypeId = 1;
                        accJournalDetail1.ReferenceNo = 0;
                    }
                    else
                    {
                        //القيد يكون نوعه نوع حركة الاصل 
                        accJournalDetail1.ReferenceTypeId = 12;
                        accJournalDetail1.ReferenceNo = fxId;
                    }

                    var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail1.Succeeded)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalDetail1.Status.message);

                    //حساب ضريبة القيمة المضافة مشتريات
                    if (entity.VatAmount > 0)
                    {
                        var purchasesVatAccountId = await _accRepositoryManager.AccFacilityRepository.GetOne(f => f.PurchasesVatAccountId,
                                f => f.FacilityId == session.FacilityId);
                        if (purchasesVatAccountId == null || purchasesVatAccountId == 0)
                            return await Result<FxaAdditionsExclusionEditDto>.FailAsync("Vat Purchases account did not specify حساب ضريبة القيمة المضافة مشتريات  لم يحدد.");

                        AccJournalDetaileDto accJournalDetail2 = new()
                        {
                            JId = jId,
                            AccAccountId = purchasesVatAccountId,
                            Credit = 0,
                            Debit = entity.VatAmount,
                            Description = desc,
                            CcId = 0,
                            ReferenceNo = 0,
                            ReferenceTypeId = 1,
                            CurrencyId = 1,
                            ExchangeRate = 1
                        };
                        var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        if (!addJournalDetail2.Succeeded)
                            return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalDetail2.Status.message);
                    }

                    //قيد حساب الدائن
                    AccJournalDetaileDto accJournalDetail3 = new()
                    {
                        JId = jId,
                        AccAccountId = crdAccountId,
                        Credit = entity.Amount + entity.VatAmount,
                        Debit = 0,
                        Description = desc,
                        CcId = 0,
                        ReferenceTypeId = entity.AccountTypeId,
                        ReferenceNo = refrance,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail3.Succeeded)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalDetail3.Status.message);
                }
                else
                {
                    string desc = "  قيد استبعاد راس مالي  من الاصل رقم   " + entity.FxNo + " بتاريخ  " + entity.Date1 + " " + entity.Description;
                    AccJournalMasterDto accJournalMaster = new()
                    {
                        JDateHijri = entity.Date1,
                        JDateGregorian = entity.Date1,
                        Amount = entity.Amount,
                        AmountWrite = "",
                        JDescription = desc,
                        PaymentTypeId = 2,
                        PeriodId = entity.PeriodId,
                        StatusId = 1,
                        FinYear = session.FinYear,
                        FacilityId = session.FacilityId,
                        DocTypeId = 104, //نوع قيد استبعاد راس مالية على الاصل
                        ReferenceNo = entity.Id,
                        ReferenceCode = entity.Id.ToString(),
                        JBian = desc,
                        BankId = 0,
                        CcId = session.BranchId,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalMaster.Succeeded)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalMaster.Status.message);

                    long jId = addJournalMaster.Data.JId;
                    entity.JId = addJournalMaster.Data.JId;
                    entity.JCode = addJournalMaster.Data.JCode;

                    //قيد حساب المدين
                    AccJournalDetaileDto accJournalDetail1 = new()
                    {
                        JId = jId,
                        AccAccountId = crdAccountId,
                        Credit = 0,
                        Debit = entity.Amount + entity.VatAmount,
                        Description = desc,
                        CcId = 0,
                        ReferenceTypeId = entity.AccountTypeId,
                        ReferenceNo = refrance,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail1.Succeeded)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalDetail1.Status.message);

                    //قيد الاصل
                    AccJournalDetaileDto accJournalDetail2 = new()
                    {
                        JId = jId,
                        AccAccountId = accountId,
                        Credit = entity.Amount,
                        Debit = 0,
                        Description = desc,
                        CcId = 0,
                        ReferenceNo = 0,
                        ReferenceTypeId = 1,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };
                    if (accJType == "2")
                    {
                        accJournalDetail2.ReferenceTypeId = 1;
                        accJournalDetail2.ReferenceNo = 0;
                    }
                    else
                    {
                        accJournalDetail2.ReferenceTypeId = 12;
                        accJournalDetail2.ReferenceNo = fxId;
                    }

                    var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail2.Succeeded)
                        return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalDetail2.Status.message);

                    //حساب ضريبة القيمة المضافة مشتريات
                    if (entity.VatAmount > 0)
                    {
                        var purchasesVatAccountId = await _accRepositoryManager.AccFacilityRepository.GetOne(f => f.PurchasesVatAccountId,
                                f => f.FacilityId == session.FacilityId);
                        if (purchasesVatAccountId == null || purchasesVatAccountId == 0)
                            return await Result<FxaAdditionsExclusionEditDto>.FailAsync("Vat Purchases account did not specify حساب ضريبة القيمة المضافة مشتريات  لم يحدد.");

                        AccJournalDetaileDto accJournalDetail3 = new()
                        {
                            JId = jId,
                            AccAccountId = purchasesVatAccountId,
                            Credit = entity.VatAmount,
                            Debit = 0,
                            Description = desc,
                            CcId = 0,
                            ReferenceNo = 0,
                            ReferenceTypeId = 1,
                            CurrencyId = 1,
                            ExchangeRate = 1
                        };

                        var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        if (!addJournalDetail3.Succeeded)
                            return await Result<FxaAdditionsExclusionEditDto>.FailAsync(addJournalDetail3.Status.message);
                    }
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);

                return await Result<FxaAdditionsExclusionEditDto>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaAdditionsExclusionEditDto>.FailAsync($"EXP in Add at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }


        public async Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var item = await _fxaRepositoryManager.FxaAdditionsExclusionRepository.GetById(Id);
                if (item == null) return await Result.FailAsync($"{localization.GetMessagesResource("NoIdInDelete")}");

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;
                item.IsDeleted = true;

                _fxaRepositoryManager.FxaAdditionsExclusionRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                return await Result<FxaAdditionsExclusionDto>.SuccessAsync(_mapper.Map<FxaAdditionsExclusionDto>(item), localization.GetMessagesResource("success"));
            }
            catch (Exception exp)
            {
                return await Result.FailAsync($"EXP in Remove at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }

        public Task<IResult> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }



        private async Task<long> GetAccountIdByCode(string code)
        {
            try
            {
                return await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                            a => a.AccAccountCode == code && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);
            }
            catch
            {
                return 0;
            }
        }
        private async Task<string> GetPropertyValue(long propertyId)
        {
            try
            {
                string? propertyValue;
                propertyValue = await _mainRepositoryManager.SysPropertyValueRepository.GetOne(p => p.PropertyValue, p => p.PropertyId == propertyId && p.FacilityId == session.FacilityId);
                return propertyValue ?? "";
            }
            catch
            {
                return "";
            }
        }
    }
}