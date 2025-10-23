using AutoMapper;
using Logix.Application.Common;
using Logix.Application.DTOs.ACC;
using Logix.Application.DTOs.FXA;
using Logix.Application.Interfaces.IRepositories;
using Logix.Application.Interfaces.IServices.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;

namespace Logix.Application.Services.FXA
{
    // this service will called from multi controllers
    // all controllers need semi shared functions (add fxaTransaction & fxaTransactionAsset, and add journal)
    public class FxaTransactionService : GenericQueryService<FxaTransaction, FxaTransactionDto, FxaTransactionsVw>, IFxaTransactionService
    {
        private readonly IFxaRepositoryManager _fxaRepositoryManager;
        private readonly IAccRepositoryManager _accRepositoryManager;
        private readonly IMainRepositoryManager _mainRepositoryManager;
        private readonly IMapper _mapper;
        private readonly ICurrentData session;
        private readonly ILocalizationService localization;

        public FxaTransactionService(IQueryRepository<FxaTransaction> queryRepository,
            IMapper mapper,
            IFxaRepositoryManager fxaRepositoryManager,
            IAccRepositoryManager accRepositoryManager,
            IMainRepositoryManager mainRepositoryManager,
            ICurrentData session,
            ILocalizationService localization) : base(queryRepository, mapper)
        {
            this._fxaRepositoryManager = fxaRepositoryManager;
            this._accRepositoryManager = accRepositoryManager;
            this._mainRepositoryManager = mainRepositoryManager;
            this._mapper = mapper;
            this.session = session;
            this.localization = localization;
        }

        public Task<IResult<FxaTransactionDto>> Add(FxaTransactionDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<FxaTransactionEditDto>> Update(FxaTransactionEditDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
        {
            //this function transfer to RemoveTransaction function to use it from several functions
            throw new NotImplementedException();
        }

        public Task<IResult> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        public async Task<IResult> RemoveTransaction(long Id, int DocTypeId, CancellationToken cancellationToken = default)
        {
            try
            {
                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                var item = await _fxaRepositoryManager.FxaTransactionRepository.GetById(Id);
                if (item == null) return await Result.FailAsync($"{localization.GetMessagesResource("NoIdInDelete")}");

                //check account journal,, if status=2 => can not delete the transaction, else=> delete master journal and its details
                var journalStatus = await _accRepositoryManager.AccJournalMasterRepository.GetJournalMasterStatuse(Id, DocTypeId);
                if (journalStatus == 2)
                {
                    if (DocTypeId == 21)
                        return await Result.FailAsync($"لايمكن حذف عملية الإستبعاد وذلك لترحيلها");
                    else if (DocTypeId == 18)
                        return await Result.FailAsync($"لايمكن حذف الإهلاك وذلك لترحيلها");
                    else if (DocTypeId == 41)
                        return await Result.FailAsync($"لايمكن حذف إعادة التقييم وذلك لترحيلها");
                }

                var deleteJournal = await _accRepositoryManager.AccJournalMasterRepository.DeleteJournalWithDetailsbyReference(Id, DocTypeId);
                if (!deleteJournal)
                    return await Result.FailAsync($"حدث خطأ أثناء حذف القيد");

                //Get FxaTransactionsAssest for updating the statusId of its fixed assets
                var getFxaTranAssets = await _fxaRepositoryManager.FxaTransactionsAssetRepository.GetAll(t => t.TransactionId == Id && t.IsDeleted == false);
                foreach (var transaction in getFxaTranAssets)
                {
                    var getAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(a => a.Id == transaction.FixedAssetId);
                    if (getAsset != null)
                    {
                        getAsset.StatusId = 1;
                        getAsset.ModifiedBy = session.UserId;
                        getAsset.ModifiedOn = DateTime.Now;
                        _fxaRepositoryManager.FxaFixedAssetRepository.Update(getAsset);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    }

                    // delete from FXA_Transactions_Assest
                    transaction.IsDeleted = true;
                    transaction.ModifiedBy = session.UserId;
                    transaction.ModifiedOn = DateTime.Now;
                    _fxaRepositoryManager.FxaTransactionsAssetRepository.Update(transaction);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                }

                // delete from FxaTransaction
                item.IsDeleted = true;
                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;
                _fxaRepositoryManager.FxaTransactionRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                // delete from FXA_Transactions_Products
                var getFxaTranProducts = await _fxaRepositoryManager.FxaTransactionsProductRepository.GetAll(p => p.TransactionId == Id && p.IsDeleted == false);
                foreach (var tranProduct in getFxaTranProducts)
                {
                    tranProduct.IsDeleted = true;
                    tranProduct.ModifiedBy = session.UserId;
                    tranProduct.ModifiedOn = DateTime.Now;
                    _fxaRepositoryManager.FxaTransactionsProductRepository.Update(tranProduct);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                }

                //التشييك هل العملية اعادة تقييم ليتم اعادة القيمة قبل اعادة التقييم
                if (item.TransTypeId == 8)
                {
                    long fixedAssetId = 0;
                    decimal oldAmount = 0;

                    //حذف حركة التقييم
                    var getTranRevaluation = await _fxaRepositoryManager.FxaTransactionsRevaluationRepository.GetAll(r => r.TransactionId == Id && r.IsDeleted == false);
                    foreach (var revaluation in getTranRevaluation)
                    {
                        fixedAssetId = revaluation.FixedAssetId ?? 0;
                        oldAmount = revaluation.AmountOld ?? 0;

                        //delete
                        revaluation.IsDeleted = true;
                        revaluation.ModifiedBy = session.UserId;
                        revaluation.ModifiedOn = DateTime.Now;
                        _fxaRepositoryManager.FxaTransactionsRevaluationRepository.Update(revaluation);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    }

                    //اعادة قيمة الاصل السابقة
                    var getFixedAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(f => f.Id == fixedAssetId);
                    if (getFixedAsset != null)
                    {
                        getFixedAsset.Amount = oldAmount;
                        getFixedAsset.ModifiedBy = session.UserId;
                        getFixedAsset.ModifiedOn = DateTime.Now;
                        _fxaRepositoryManager.FxaFixedAssetRepository.Update(getFixedAsset);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    }
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);

                return await Result<FxaTransactionDto>.SuccessAsync(_mapper.Map<FxaTransactionDto>(item), localization.GetMessagesResource("success"));
            }
            catch (Exception exp)
            {
                return await Result.FailAsync($"EXP in RemoveTransaction at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }


        #region ======================================================= Assets sale (assets exclusion) =======================================================
        public async Task<IResult<FxaTransactionDto_Sale>> Add_Sale(FxaTransactionDto_Sale entity, CancellationToken cancellationToken = default)
        {
            try
            {
                entity.SaleAmount ??= 0; entity.Balance ??= 0;
                decimal total = entity.SaleAmount ?? 0;

                // check accounts, and get ids
                long debAccountId = 0; long profLossAccountId = 0; long accountId = 0; long depreAccountId = 0;

                if (!(string.IsNullOrEmpty(entity.DebAccCode)))
                {
                    debAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.DebAccCode, session.FacilityId);

                    if (debAccountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم الحساب المدين غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.ProfitLossAccCode)))
                {
                    profLossAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.ProfitLossAccCode, session.FacilityId);

                    if (profLossAccountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم حساب الأرباح والخسائر غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccCode)))
                {
                    accountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.AccCode, session.FacilityId);

                    if (accountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم حساب الاصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccCode2)))
                {
                    depreAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.AccCode2, session.FacilityId);

                    if (depreAccountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                // check cost centers, and get ids
                long ccId = 0; long ccId2 = 0; long ccId3 = 0; long ccId4 = 0; long ccId5 = 0;

                if (!(string.IsNullOrEmpty(entity.CcCode)))
                {
                    ccId = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode, session.FacilityId);

                    if (ccId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode2)))
                {
                    ccId2 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode2, session.FacilityId);

                    if (ccId2 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 2 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode3)))
                {
                    ccId3 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode3, session.FacilityId);

                    if (ccId3 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 3 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode4)))
                {
                    ccId4 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode4, session.FacilityId);

                    if (ccId4 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 4 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode5)))
                {
                    ccId5 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode5, session.FacilityId);

                    if (ccId5 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 5 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                var fixedAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(f => f.No == entity.FxNo && f.FacilityId == session.FacilityId && f.StatusId == 1);
                if (fixedAsset == null)
                    return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم الأصل غير صحيح");

                long fxId = fixedAsset.Id;

                var branchsId = session.Branches.Split(',');

                var childActiveAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetAll(a => a.Id,
                    a => a.StatusId != 2 && a.IsDeleted == false && a.FacilityId == session.FacilityId
                        && (branchsId.Contains(a.BranchId.ToString())) //Exclude any records that its branch not in user banches
                        && a.MainAssetId == fxId);

                if (childActiveAsset.Any())
                    return await Result<FxaTransactionDto_Sale>.FailAsync("يجب استبعاد الاصول الفرعية لهذا الاصل قبل إستبعاد هذا الاصل");


                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //add transaction
                FxaTransaction fxaTransaction = new()
                {
                    TransDate = entity.TransDate,
                    Total = total,
                    StartDate = "",
                    EndDate = "",
                    FacilityId = session.FacilityId,
                    BranchId = entity.BranchId,
                    AccountId = debAccountId,
                    AccountId2 = profLossAccountId,
                    TransTypeId = entity.TransTypeId,
                    CcId = ccId,
                    CcId2 = ccId2,
                    CcId3 = ccId3,
                    CcId4 = ccId4,
                    CcId5 = ccId5,
                    Note = entity.Note,
                };
                var addTransaction = await AddTransaction(fxaTransaction, cancellationToken);
                if (!addTransaction.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addTransaction.Status.message);

                entity.Id = addTransaction.Data.Id;

                //add transaction asset
                FxaTransactionsAsset fxaTransactionsAsset = new()
                {
                    TransactionId = addTransaction.Data.Id,
                    FixedAssetId = fxId,
                    Debet = total,
                    Credit = 0,
                    Description = " استبعاد الاصل ",

                };
                var addTransactionAsset = await AddTransactionAsset(fxaTransactionsAsset, cancellationToken);
                if (!addTransactionAsset.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addTransactionAsset.Status.message);

                //add master journal
                string desc = "  قيد استبعاد الأصل رقم   " + entity.FxNo + " بتاريخ  " + entity.TransDate;

                AccJournalMasterDto accJournalMaster = new()
                {
                    JDateHijri = entity.TransDate,
                    JDateGregorian = entity.TransDate,
                    Amount = total,
                    AmountWrite = "",
                    JDescription = desc,
                    PaymentTypeId = 2,
                    PeriodId = entity.PeriodId,
                    StatusId = 1,
                    FinYear = session.FinYear,
                    FacilityId = session.FacilityId,
                    DocTypeId = 21,
                    ReferenceNo = addTransaction.Data.Id,
                    JBian = desc,
                    BankId = 0,
                    CcId = entity.BranchId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalMaster.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalMaster.Status.message);

                entity.JCode = addJournalMaster.Data.JCode;
                entity.JId = addJournalMaster.Data.JId;
                long jId = addJournalMaster.Data.JId;

                //add journal details
                //الحساب المدين
                AccJournalDetaileDto accJournalDetail1 = new()
                {
                    JId = jId,
                    AccAccountId = debAccountId,
                    Credit = 0,
                    Debit = total,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 1,
                    ReferenceNo = 0,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };
                var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail1.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail1.Status.message);

                //حساب مجمع الإهلاك
                AccJournalDetaileDto accJournalDetail2 = new()
                {
                    JId = jId,
                    AccAccountId = depreAccountId,
                    Credit = 0,
                    Debit = entity.DeprecAmount,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 13,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };
                var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail2.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail2.Status.message);

                //حساب الأرباح والخسائر
                if (entity.SaleAmount != entity.Balance)
                {
                    AccJournalDetaileDto accJournalDetail3 = new()
                    {
                        JId = jId,
                        AccAccountId = profLossAccountId,

                        Description = desc,
                        CcId = ccId,
                        Cc2Id = ccId2,
                        Cc3Id = ccId3,
                        Cc4Id = ccId4,
                        Cc5Id = ccId5,
                        ReferenceTypeId = 1,
                        ReferenceNo = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    if (entity.SaleAmount < entity.Balance)
                    {
                        accJournalDetail3.Credit = 0;
                        accJournalDetail3.Debit = entity.Balance - entity.SaleAmount;
                    }
                    else if (entity.SaleAmount > entity.Balance)
                    {
                        accJournalDetail3.Credit = entity.SaleAmount - entity.Balance;
                        accJournalDetail3.Debit = 0;
                    }

                    var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail3.Succeeded)
                        return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail3.Status.message);
                }

                //حساب الأصل
                AccJournalDetaileDto accJournalDetail4 = new()
                {
                    JId = jId,
                    AccAccountId = accountId,
                    Credit = entity.Amount,
                    Debit = 0,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 12,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalDetail4 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail4, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail4.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail4.Status.message);

                //update status of fixed asset
                fixedAsset.StatusId = 2;
                fixedAsset.ModifiedBy = session.UserId;
                fixedAsset.ModifiedOn = DateTime.Now;
                _fxaRepositoryManager.FxaFixedAssetRepository.Update(fixedAsset);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);


                //save files
                if (entity.FileDtos != null && entity.FileDtos.Count() > 0)
                {
                    var addFiles = await _mainRepositoryManager.SysFileRepository.SaveFiles(entity.FileDtos, addTransaction.Data.Id, 44);
                    await _mainRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaTransactionDto_Sale>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaTransactionDto_Sale>.FailAsync($"EXP in Add_Sale at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }

        public async Task<IResult<FxaTransactionDto_Sale>> Update_Sal(FxaTransactionDto_Sale entity, CancellationToken cancellationToken = default)
        {
            try
            {
                //check account journal,, if status=2 => can not delete the transaction, else=> delete master journal and its details
                var journalStatus = await _accRepositoryManager.AccJournalMasterRepository.GetJournalMasterStatuse(entity.Id ?? 0, 21);
                if (journalStatus == 2)
                    return await Result<FxaTransactionDto_Sale>.FailAsync($"لايمكن تعديل عملية الإستبعاد وذلك لترحيلها");

                entity.SaleAmount ??= 0; entity.Balance ??= 0;
                decimal total = entity.SaleAmount ?? 0;

                // check accounts, and get ids
                long debAccountId = 0; long profLossAccountId = 0; long accountId = 0; long depreAccountId = 0;

                if (!(string.IsNullOrEmpty(entity.DebAccCode)))
                {
                    debAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.DebAccCode, session.FacilityId);

                    if (debAccountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم الحساب المدين غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.ProfitLossAccCode)))
                {
                    profLossAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.ProfitLossAccCode, session.FacilityId);

                    if (profLossAccountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم حساب الأرباح والخسائر غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccCode)))
                {
                    accountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.AccCode, session.FacilityId);

                    if (accountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم حساب الاصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccCode2)))
                {
                    depreAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.AccCode2, session.FacilityId);

                    if (depreAccountId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                // check cost centers, and get ids
                long ccId = 0; long ccId2 = 0; long ccId3 = 0; long ccId4 = 0; long ccId5 = 0;

                if (!(string.IsNullOrEmpty(entity.CcCode)))
                {
                    ccId = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode, session.FacilityId);

                    if (ccId == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode2)))
                {
                    ccId2 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode2, session.FacilityId);

                    if (ccId2 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 2 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode3)))
                {
                    ccId3 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode3, session.FacilityId);

                    if (ccId3 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 3 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode4)))
                {
                    ccId4 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode4, session.FacilityId);

                    if (ccId4 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 4 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode5)))
                {
                    ccId5 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode5, session.FacilityId);

                    if (ccId5 == 0)
                        return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم مركز التكلفة 5 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                var fixedAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(f => f.No == entity.FxNo && f.FacilityId == session.FacilityId);
                if (fixedAsset == null)
                    return await Result<FxaTransactionDto_Sale>.FailAsync($"رقم الأصل غير صحيح");

                long fxId = fixedAsset.Id;

                var branchsId = session.Branches.Split(',');

                var childActiveAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetAll(a => a.Id,
                    a => a.StatusId != 2 && a.IsDeleted == false && a.FacilityId == session.FacilityId
                        && (branchsId.Contains(a.BranchId.ToString())) //Exclude any records that its branch not in user banches
                        && a.MainAssetId == fxId);

                if (childActiveAsset.Any())
                    return await Result<FxaTransactionDto_Sale>.FailAsync("يجب استبعاد الاصول الفرعية لهذا الاصل قبل إستبعاد هذا الاصل");


                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //Update FXA_Transaction
                FxaTransactionEditDto transEditDto = new FxaTransactionEditDto()
                {
                    Id = entity.Id ?? 0,
                    TransDate = entity.TransDate,
                    Total = total,
                    BranchId = entity.BranchId,
                    AccountId = debAccountId,
                    AccountId2 = profLossAccountId,
                    CcId = ccId,
                    CcId2 = ccId2,
                    CcId3 = ccId3,
                    CcId4 = ccId4,
                    CcId5 = ccId5,
                    Note = entity.Note
                };
                var updateTransaction = await UpdateTransaction(transEditDto);
                if (!updateTransaction.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync($"{updateTransaction.Status.message}");

                //Update FXA_Transaction_Assest
                FxaTransactionsAssetEditDto transAssetEditDto = new()
                {
                    TransactionId = entity.Id,
                    FixedAssetId = fxId,
                    Debet = total,
                    Credit = 0,
                    Description = " استبعاد الاصل "
                };
                var updateTransactionAsset = await UpdateTransactionAsset(transAssetEditDto);
                if (!updateTransactionAsset.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync($"{updateTransactionAsset.Status.message}");

                //add master journal
                string desc = "  قيد استبعاد الأصل رقم   " + entity.FxNo + " بتاريخ  " + entity.TransDate;
                AccJournalMasterDto accJournalMaster = new()
                {
                    JDateHijri = entity.TransDate,
                    JDateGregorian = entity.TransDate,
                    Amount = total,
                    AmountWrite = "",
                    JDescription = desc,
                    PaymentTypeId = 2,
                    PeriodId = entity.PeriodId,
                    StatusId = 1,
                    FinYear = session.FinYear,
                    FacilityId = session.FacilityId,
                    DocTypeId = 21,
                    ReferenceNo = entity.Id,
                    JBian = desc,
                    BankId = 0,
                    CcId = entity.BranchId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalMaster.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalMaster.Status.message);

                entity.JCode = addJournalMaster.Data.JCode;
                entity.JId = addJournalMaster.Data.JId;
                long jId = addJournalMaster.Data.JId;

                //add journal details
                //الحساب المدين
                AccJournalDetaileDto accJournalDetail1 = new()
                {
                    JId = jId,
                    AccAccountId = debAccountId,
                    Credit = 0,
                    Debit = total,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 1,
                    ReferenceNo = 0,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };
                var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail1.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail1.Status.message);

                //حساب مجمع الإهلاك
                AccJournalDetaileDto accJournalDetail2 = new()
                {
                    JId = jId,
                    AccAccountId = depreAccountId,
                    Credit = 0,
                    Debit = entity.DeprecAmount,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 13,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };
                var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail2.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail2.Status.message);

                //حساب الأرباح والخسائر
                if (entity.SaleAmount != entity.Balance)
                {
                    AccJournalDetaileDto accJournalDetail3 = new()
                    {
                        JId = jId,
                        AccAccountId = profLossAccountId,

                        Description = desc,
                        CcId = ccId,
                        Cc2Id = ccId2,
                        Cc3Id = ccId3,
                        Cc4Id = ccId4,
                        Cc5Id = ccId5,
                        ReferenceTypeId = 1,
                        ReferenceNo = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    if (entity.SaleAmount < entity.Balance)
                    {
                        accJournalDetail3.Credit = 0;
                        accJournalDetail3.Debit = entity.Balance - entity.SaleAmount;
                    }
                    else if (entity.SaleAmount > entity.Balance)
                    {
                        accJournalDetail3.Credit = entity.SaleAmount - entity.Balance;
                        accJournalDetail3.Debit = 0;
                    }

                    var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail3.Succeeded)
                        return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail3.Status.message);
                }

                //حساب الأصل
                AccJournalDetaileDto accJournalDetail4 = new()
                {
                    JId = jId,
                    AccAccountId = accountId,
                    Credit = entity.Amount,
                    Debit = 0,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 12,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalDetail4 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail4, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail4.Succeeded)
                    return await Result<FxaTransactionDto_Sale>.FailAsync(addJournalDetail4.Status.message);

                //update status of fixed asset
                fixedAsset.StatusId = 2;
                fixedAsset.ModifiedBy = session.UserId;
                fixedAsset.ModifiedOn = DateTime.Now;
                _fxaRepositoryManager.FxaFixedAssetRepository.Update(fixedAsset);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaTransactionDto_Sale>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaTransactionDto_Sale>.FailAsync($"EXP in Update_Sale at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }
        #endregion ==================================================== End Assets sale (assets exclusion) ===================================================


        #region ============================================================= Assets Depreciation ============================================================
        public async Task<IResult<AssetsDeprecAddDto>> Add_Depreciation(AssetsDeprecAddDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                decimal total = 0;
                decimal newTotal = 0;
                bool checkSelect = false;
                foreach (var item in entity.AssetList)
                {
                    if (item.IsSelected)
                    {
                        checkSelect = true;
                        total += item.DeprecValue;

                        if (entity.DeprecFilter.PeriodTypeId == 1)
                            newTotal += item.DeprecValue;
                        else if (entity.DeprecFilter.PeriodTypeId == 2)
                            newTotal += item.DeprecValueDialy;
                    }
                }

                if (!checkSelect)
                    return await Result<AssetsDeprecAddDto>.FailAsync($"{localization.GetResource1("AssetsAreIdentifiedFirst")}");

                //هل يتم التقييد كل اصل على حده في المالية ام إجمالي
                string accJType = "0";
                accJType = await GetPropertyValue(68);

                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //add transaction
                FxaTransaction fxaTransaction = new()
                {
                    TransDate = entity.DeprecFilter.TransDate,
                    Total = newTotal,
                    StartDate = entity.DeprecFilter.StartDate,
                    EndDate = entity.DeprecFilter.EndDate,
                    FacilityId = session.FacilityId,
                    TransTypeId = 5
                };

                var addTransaction = await AddTransaction(fxaTransaction, cancellationToken);
                if (!addTransaction.Succeeded)
                    return await Result<AssetsDeprecAddDto>.FailAsync(addTransaction.Status.message);

                long transactionId = addTransaction.Data.Id;
                string transactionCode = addTransaction.Data.Code ?? "";
                entity.DeprecFilter.Code = transactionCode;

                string assetsNO = "";

                foreach (var item in entity.AssetList)
                {
                    if (item.IsSelected)
                    {
                        assetsNO = assetsNO + item.No + ",";
                        string lastDeprecDate = item.LastDeprecDate ?? "";
                        string TransDesc = localization.GetResource1("DepreciationPeriodfromDate") + lastDeprecDate + localization.GetResource1("ToDate") + entity.DeprecFilter.EndDate;
                        TransDesc = TransDesc + localization.GetResource1("ForAssetsNumber") + item.No;

                        //add transaction asset
                        FxaTransactionsAsset fxaTransactionsAsset = new()
                        {
                            TransactionId = transactionId,
                            FixedAssetId = item.Id,
                            Debet = item.DeprecValue,
                            Credit = 0,
                            Description = TransDesc,
                        };
                        var addTransactionAsset = await AddTransactionAsset(fxaTransactionsAsset, cancellationToken);
                        if (!addTransactionAsset.Succeeded)
                            return await Result<AssetsDeprecAddDto>.FailAsync(addTransactionAsset.Status.message);
                    }
                }

                if (!string.IsNullOrEmpty(assetsNO))
                {
                    assetsNO = assetsNO.Substring(0, assetsNO.Length - 1);
                }


                //التقيد في المحاسبي
                string desc = localization.GetResource1("AssetDepreciationEntryNo") + transactionCode + localization.GetResource1("ToDate") + entity.DeprecFilter.EndDate;
                var checkProperty = await GetPropertyValue(361);
                if (checkProperty == "1")
                {
                    desc = desc + localization.GetResource1("ForAssets") + assetsNO;
                }

                //add master journal
                AccJournalMasterDto accJournalMaster = new()
                {
                    JDateHijri = entity.DeprecFilter.TransDate,
                    JDateGregorian = entity.DeprecFilter.TransDate,
                    Amount = total,
                    AmountWrite = "",
                    JDescription = desc,
                    PaymentTypeId = 2,
                    PeriodId = entity.DeprecFilter.PeriodId,
                    StatusId = 1,
                    FinYear = session.FinYear,
                    FacilityId = session.FacilityId,
                    DocTypeId = 18,
                    ReferenceNo = transactionId,
                    JBian = desc,
                    BankId = 0,
                    CcId = entity.DeprecFilter.BranchId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalMaster.Succeeded)
                    return await Result<AssetsDeprecAddDto>.FailAsync(addJournalMaster.Status.message);

                long jId = addJournalMaster.Data.JId;
                entity.DeprecFilter.JId = jId;
                entity.DeprecFilter.JCode = addJournalMaster.Data.JCode;

                List<AssetsDeprecAccountsAndCostCenters> deprecAccountList = new();
                foreach (var item in entity.AssetList)
                {
                    if (item.IsSelected)
                    {
                        deprecAccountList.Add(new AssetsDeprecAccountsAndCostCenters
                        {
                            FxId = item.Id,
                            AccountId2 = item.Account2Id,
                            AccountId3 = item.Account3Id,
                            CcId = item.CcId,
                            CcId2 = item.CcId2,
                            CcId3 = item.CcId3,
                            CcId4 = item.CcId4,
                            CcId5 = item.CcId5,
                            Value = item.DeprecValue,
                        });
                    }
                }

                //القيد يكون نوعه حساب من الدليل
                if (accJType == "2")
                {
                    var resultDebit = deprecAccountList.GroupBy(l => new
                    {
                        l.AccountId3,
                        l.CcId,
                        l.CcId2,
                        l.CcId3,
                        l.CcId4,
                        l.CcId5,
                    }).Select(g => new
                    {
                        AccountId = g.Select(p => p.AccountId3).FirstOrDefault(),
                        CcId = g.Select(p => p.CcId).FirstOrDefault(),
                        CcId2 = g.Select(p => p.CcId2).FirstOrDefault(),
                        CcId3 = g.Select(p => p.CcId3).FirstOrDefault(),
                        CcId4 = g.Select(p => p.CcId4).FirstOrDefault(),
                        CcId5 = g.Select(p => p.CcId5).FirstOrDefault(),
                        ValueTotal = g.Sum(p => p.Value)
                    }).OrderBy(x => x.AccountId).ToList();

                    foreach (var x in resultDebit)
                    {
                        if (x.ValueTotal > 0)
                        {
                            // add journal details 1
                            AccJournalDetaileDto accJournalDetail = new()
                            {
                                JId = jId,
                                AccAccountId = x.AccountId,
                                Credit = 0,
                                Debit = x.ValueTotal,
                                Description = desc,
                                CcId = x.CcId,
                                Cc2Id = x.CcId2,
                                Cc3Id = x.CcId3,
                                Cc4Id = x.CcId4,
                                Cc5Id = x.CcId5,
                                ReferenceTypeId = 1,
                                ReferenceNo = 0,
                                CurrencyId = 1,
                                ExchangeRate = 1
                            };
                            var addJournalDetail = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail, cancellationToken);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                            if (!addJournalDetail.Succeeded)
                                return await Result<AssetsDeprecAddDto>.FailAsync(addJournalDetail.Status.message);
                        }
                    }

                    var resultCredit = deprecAccountList.GroupBy(l => new
                    {
                        l.AccountId2,
                        l.CcId,
                        l.CcId2,
                        l.CcId3,
                        l.CcId4,
                        l.CcId5,
                    }).Select(g => new
                    {
                        AccountId = g.Select(p => p.AccountId2).FirstOrDefault(),
                        CcId = g.Select(p => p.CcId).FirstOrDefault(),
                        CcId2 = g.Select(p => p.CcId2).FirstOrDefault(),
                        CcId3 = g.Select(p => p.CcId3).FirstOrDefault(),
                        CcId4 = g.Select(p => p.CcId4).FirstOrDefault(),
                        CcId5 = g.Select(p => p.CcId5).FirstOrDefault(),
                        ValueTotal = g.Sum(p => p.Value)
                    }).OrderBy(x => x.AccountId).ToList();

                    foreach (var x in resultCredit)
                    {
                        if (x.ValueTotal > 0)
                        {
                            // add journal details 2
                            AccJournalDetaileDto accJournalDetail2 = new()
                            {
                                JId = jId,
                                AccAccountId = x.AccountId,
                                Credit = x.ValueTotal,
                                Debit = 0,
                                Description = desc,
                                CcId = 0,
                                Cc2Id = x.CcId2,
                                Cc3Id = x.CcId3,
                                Cc4Id = x.CcId4,
                                Cc5Id = x.CcId5,
                                ReferenceTypeId = 1,
                                ReferenceNo = 0,
                                CurrencyId = 1,
                                ExchangeRate = 1
                            };
                            var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                            if (!addJournalDetail2.Succeeded)
                                return await Result<AssetsDeprecAddDto>.FailAsync(addJournalDetail2.Status.message);
                        }
                    }
                }
                else
                {
                    foreach (var asset in entity.AssetList)
                    {
                        if (asset.IsSelected)
                        {
                            // add journal details 1
                            AccJournalDetaileDto accJournalDetail = new()
                            {
                                JId = jId,
                                AccAccountId = asset.Account3Id,
                                Credit = 0,
                                Debit = asset.DeprecValue,
                                Description = desc,
                                CcId = asset.CcId,
                                Cc2Id = asset.CcId2,
                                Cc3Id = asset.CcId3,
                                Cc4Id = asset.CcId4,
                                Cc5Id = asset.CcId5,
                                ReferenceTypeId = 14,
                                ReferenceNo = asset.Id,
                                CurrencyId = 1,
                                ExchangeRate = 1
                            };
                            var addJournalDetail = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail, cancellationToken);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                            if (!addJournalDetail.Succeeded)
                                return await Result<AssetsDeprecAddDto>.FailAsync(addJournalDetail.Status.message);

                            // add journal details 2
                            AccJournalDetaileDto accJournalDetail2 = new()
                            {
                                JId = jId,
                                AccAccountId = asset.Account2Id,
                                Credit = asset.DeprecValue,
                                Debit = 0,
                                Description = desc,
                                CcId = 0,
                                Cc2Id = asset.CcId2,
                                Cc3Id = asset.CcId3,
                                Cc4Id = asset.CcId4,
                                Cc5Id = asset.CcId5,
                                ReferenceTypeId = 13,
                                ReferenceNo = asset.Id,
                                CurrencyId = 1,
                                ExchangeRate = 1
                            };
                            var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                            if (!addJournalDetail2.Succeeded)
                                return await Result<AssetsDeprecAddDto>.FailAsync(addJournalDetail2.Status.message);
                        }
                    }
                }

                //here save files


                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<AssetsDeprecAddDto>.SuccessAsync(entity);

            }
            catch (Exception exp)
            {
                return await Result<AssetsDeprecAddDto>.FailAsync($"EXP in Add_Depreciation at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");

            }
        }

        #endregion ========================================================== End Assets Depreciation ========================================================


        #region ============================================================= Assets Revaluation ============================================================
        public async Task<IResult<FxaTransactionDto_Revaluation>> Add_Revaluation(FxaTransactionDto_Revaluation entity, CancellationToken cancellationToken = default)
        {
            try
            {
                entity.SaleAmount ??= 0; entity.Amount ??= 0; entity.Balance ??= 0; entity.DeprecAmount ??= 0;
                decimal total = entity.SaleAmount ?? 0;

                // check accounts, and get ids
                long profLossAccountId = 0; long accountId = 0; long depreAccountId = 0;

                if (!(string.IsNullOrEmpty(entity.ProfitLossAccCode)))
                {
                    profLossAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.ProfitLossAccCode, session.FacilityId);

                    if (profLossAccountId == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم حساب الأرباح والخسائر غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccCode)))
                {
                    accountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.AccCode, session.FacilityId);

                    if (accountId == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم حساب الاصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccCode2)))
                {
                    depreAccountId = await _accRepositoryManager.AccAccountRepository.GetAccountIdByCode(entity.AccCode2, session.FacilityId);

                    if (depreAccountId == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                // check cost centers, and get ids
                long ccId = 0; long ccId2 = 0; long ccId3 = 0; long ccId4 = 0; long ccId5 = 0;

                if (!(string.IsNullOrEmpty(entity.CcCode)))
                {
                    ccId = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode, session.FacilityId);

                    if (ccId == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم مركز التكلفة غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode2)))
                {
                    ccId2 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode2, session.FacilityId);

                    if (ccId2 == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم مركز التكلفة 2 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode3)))
                {
                    ccId3 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode3, session.FacilityId);

                    if (ccId3 == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم مركز التكلفة 3 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode4)))
                {
                    ccId4 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode4, session.FacilityId);

                    if (ccId4 == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم مركز التكلفة 4 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode5)))
                {
                    ccId5 = await _accRepositoryManager.AccAccountsCostcenterRepository.GetCostCenterIdByCode(entity.CcCode5, session.FacilityId);

                    if (ccId5 == 0)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم مركز التكلفة 5 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                var fixedAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(f => f.No == entity.FxNo && f.FacilityId == session.FacilityId && f.StatusId == 1);
                if (fixedAsset == null)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync($"رقم الأصل غير صحيح");

                long fxId = fixedAsset.Id;

                if (entity.SaleAmount == entity.Amount)
                {
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync("القيمة الجديدة مساوية لقيمة الأصل");
                }

                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //add transaction
                FxaTransaction fxaTransaction = new()
                {
                    TransDate = entity.TransDate,
                    Total = total,
                    StartDate = "",
                    EndDate = "",
                    FacilityId = session.FacilityId,
                    BranchId = entity.BranchId,
                    AccountId = accountId,
                    //AccountId2 = profLossAccountId,
                    TransTypeId = entity.TransTypeId,
                    CcId = ccId,
                    CcId2 = ccId2,
                    CcId3 = ccId3,
                    CcId4 = ccId4,
                    CcId5 = ccId5
                };
                var addTransaction = await AddTransaction(fxaTransaction, cancellationToken);
                if (!addTransaction.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addTransaction.Status.message);

                entity.Id = addTransaction.Data.Id;
                entity.Code = addTransaction.Data.Code;
                long transactionId = addTransaction.Data.Id;

                //add transaction asset
                FxaTransactionsAsset fxaTransactionsAsset = new()
                {
                    TransactionId = addTransaction.Data.Id,
                    FixedAssetId = fxId,
                    Description = " إعادة تقييم اصل ",
                    AssetAmountOld = entity.Amount
                };

                if (entity.SaleAmount < entity.Amount)
                {
                    fxaTransactionsAsset.Credit = 0;
                    fxaTransactionsAsset.Debet = entity.Amount - entity.SaleAmount;
                }
                else if (entity.SaleAmount > entity.Amount)
                {
                    fxaTransactionsAsset.Credit = entity.SaleAmount - entity.Amount;
                    fxaTransactionsAsset.Debet = 0;
                }

                var addTransactionAsset = await AddTransactionAsset(fxaTransactionsAsset, cancellationToken);
                if (!addTransactionAsset.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addTransactionAsset.Status.message);

                //Insert into FXATransactionsRevaluation table
                FxaTransactionsRevaluation fxaTransactionsRevaluation = new()
                {
                    TransactionId = transactionId,
                    Date = entity.TransDate,
                    FixedAssetId = fxId,
                    AmountOld = entity.Amount,
                    AmountNew = entity.SaleAmount,
                    AmountDepreciation = entity.DeprecAmount,
                    Balance = entity.Balance,
                    ProfitAndLoss = entity.SaleAmount - entity.Balance,
                };

                var addTransactionsRevaluation = await AddTransactionsRevaluation(fxaTransactionsRevaluation, cancellationToken);
                if (!addTransactionsRevaluation.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addTransactionsRevaluation.Status.message);

                //التقيد في المحاسبي
                //add master journal
                string desc = "  قيد إعادة تقييم أصل رقم   " + entity.FxNo + " بتاريخ  " + entity.TransDate;
                AccJournalMasterDto accJournalMaster = new()
                {
                    JDateHijri = entity.TransDate,
                    JDateGregorian = entity.TransDate,
                    Amount = total,
                    AmountWrite = "",
                    JDescription = desc,
                    PaymentTypeId = 2,
                    PeriodId = entity.PeriodId,
                    StatusId = 1,
                    FinYear = session.FinYear,
                    FacilityId = session.FacilityId,
                    DocTypeId = 41,
                    ReferenceNo = transactionId,
                    JBian = desc,
                    BankId = 0,
                    CcId = entity.BranchId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalMaster = await _accRepositoryManager.AccJournalMasterRepository.AddACCJournalMaster(accJournalMaster, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalMaster.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addJournalMaster.Status.message);

                entity.JCode = addJournalMaster.Data.JCode;
                entity.JId = addJournalMaster.Data.JId;
                long jId = addJournalMaster.Data.JId;

                //add journal details
                //حساب الاصل الحساب المدين
                AccJournalDetaileDto accJournalDetail1 = new()
                {
                    JId = jId,
                    AccAccountId = accountId,
                    Credit = 0,
                    Debit = total,
                    Description = desc,
                    CcId = 0,
                    ReferenceTypeId = 1,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 12
                };
                var addJournalDetail1 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail1, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail1.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addJournalDetail1.Status.message);

                //حساب مجمع الإهلاك
                AccJournalDetaileDto accJournalDetail2 = new()
                {
                    JId = jId,
                    AccAccountId = depreAccountId,
                    Credit = 0,
                    Debit = entity.DeprecAmount,
                    Description = desc,
                    CcId = 0,
                    ReferenceTypeId = 13,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };
                var addJournalDetail2 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail2, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail2.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addJournalDetail2.Status.message);

                //حساب الأرباح والخسائر
                if (entity.SaleAmount != entity.Balance)
                {
                    AccJournalDetaileDto accJournalDetail3 = new()
                    {
                        JId = jId,
                        AccAccountId = profLossAccountId,
                        Description = desc,
                        CcId = ccId,
                        Cc2Id = ccId2,
                        Cc3Id = ccId3,
                        Cc4Id = ccId4,
                        Cc5Id = ccId5,
                        ReferenceTypeId = 1,
                        ReferenceNo = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    if (entity.SaleAmount < entity.Balance)
                    {
                        accJournalDetail3.Credit = 0;
                        accJournalDetail3.Debit = entity.Balance - entity.SaleAmount;
                    }
                    else if (entity.SaleAmount > entity.Balance)
                    {
                        accJournalDetail3.Credit = entity.SaleAmount - entity.Balance;
                        accJournalDetail3.Debit = 0;
                    }

                    var addJournalDetail3 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail3, cancellationToken);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    if (!addJournalDetail3.Succeeded)
                        return await Result<FxaTransactionDto_Revaluation>.FailAsync(addJournalDetail3.Status.message);
                }

                //حساب الأصل
                AccJournalDetaileDto accJournalDetail4 = new()
                {
                    JId = jId,
                    AccAccountId = accountId,
                    Credit = entity.Amount,
                    Debit = 0,
                    Description = desc,
                    CcId = 0,
                    Cc2Id = ccId2,
                    Cc3Id = ccId3,
                    Cc4Id = ccId4,
                    Cc5Id = ccId5,
                    ReferenceTypeId = 12,
                    ReferenceNo = fxId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var addJournalDetail4 = await _accRepositoryManager.AccJournalDetaileRepository.AddAccJournalDetail(accJournalDetail4, cancellationToken);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                if (!addJournalDetail4.Succeeded)
                    return await Result<FxaTransactionDto_Revaluation>.FailAsync(addJournalDetail4.Status.message);


                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaTransactionDto_Revaluation>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaTransactionDto_Revaluation>.FailAsync($"EXP in Add_Revaluation at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }
        #endregion ========================================================== End Assets Revaluation ========================================================

        #region =============================================================== Shared Functions =============================================================
        private async Task<IResult<FxaTransactionDto>> AddTransaction(FxaTransaction entity, CancellationToken cancellationToken = default)
        {
            long no = 0;
            string code = "";

            var allTransations = await _fxaRepositoryManager.FxaTransactionRepository.GetAll(t => t.TransTypeId == entity.TransTypeId);

            if (allTransations.Any())
                no = allTransations.Max(t => Convert.ToInt64(t.No));

            no += 1;
            var transationTypeCode = await _fxaRepositoryManager.FxaTransactionsTypeRepository.GetOne(t => t.Code, t => t.Id == entity.TransTypeId);
            code = (transationTypeCode ?? "") + no.ToString();

            entity.No = no;
            entity.Code = code;
            entity.CreatedBy = session.UserId;
            entity.CreatedOn = DateTime.Now;

            var newTrans = await _fxaRepositoryManager.FxaTransactionRepository.AddAndReturn(entity);
            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
            return await Result<FxaTransactionDto>.SuccessAsync(_mapper.Map<FxaTransactionDto>(newTrans));
        }

        private async Task<IResult<FxaTransactionsAssetDto>> AddTransactionAsset(FxaTransactionsAsset entity, CancellationToken cancellationToken = default)
        {
            entity.CreatedBy = session.UserId;
            entity.CreatedOn = DateTime.Now;

            var newTransAsset = await _fxaRepositoryManager.FxaTransactionsAssetRepository.AddAndReturn(entity);
            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
            return await Result<FxaTransactionsAssetDto>.SuccessAsync(_mapper.Map<FxaTransactionsAssetDto>(newTransAsset));
        }


        private async Task<IResult<FxaTransactionEditDto>> UpdateTransaction(FxaTransactionEditDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var item = await _fxaRepositoryManager.FxaTransactionRepository.GetById(entity.Id);
                if (item == null)
                    return await Result<FxaTransactionEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

                item.TransDate = entity.TransDate;
                item.Total = entity.Total;
                item.BranchId = entity.BranchId;
                item.AccountId = entity.AccountId;
                item.AccountId2 = entity.AccountId2;
                item.CcId = entity.CcId;
                item.CcId2 = entity.CcId2;
                item.CcId3 = entity.CcId3;
                item.CcId4 = entity.CcId4;
                item.CcId5 = entity.CcId5;
                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;

                _fxaRepositoryManager.FxaTransactionRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return await Result<FxaTransactionEditDto>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaTransactionEditDto>.FailAsync($"=== Exp in UpdateTransaction: {exp.Message}");
            }
        }

        private async Task<IResult<FxaTransactionsAssetEditDto>> UpdateTransactionAsset(FxaTransactionsAssetEditDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var item = await _fxaRepositoryManager.FxaTransactionsAssetRepository.GetOne(a => a.TransactionId == entity.TransactionId && a.IsDeleted == false); ;
                if (item == null)
                    return await Result<FxaTransactionsAssetEditDto>.FailAsync("FxaTransactionsAsset not found");

                item.Debet = entity.Debet;
                item.Credit = entity.Credit;
                item.Description = entity.Description;
                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;

                _fxaRepositoryManager.FxaTransactionsAssetRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return await Result<FxaTransactionsAssetEditDto>.SuccessAsync(entity);
            }
            catch (Exception exp)
            {
                return await Result<FxaTransactionsAssetEditDto>.FailAsync($"=== Exp in UpdateTransactionAsset: {exp.Message}");
            }
        }


        private async Task<IResult<FxaTransactionsRevaluationDto>> AddTransactionsRevaluation(FxaTransactionsRevaluation entity, CancellationToken cancellationToken = default)
        {
            try
            {
                entity.CreatedBy = session.UserId;
                entity.CreatedOn = DateTime.Now;

                var newTransRevaluation = await _fxaRepositoryManager.FxaTransactionsRevaluationRepository.AddAndReturn(entity);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return await Result<FxaTransactionsRevaluationDto>.SuccessAsync(_mapper.Map<FxaTransactionsRevaluationDto>(newTransRevaluation));
            }
            catch (Exception exp)
            {
                return await Result<FxaTransactionsRevaluationDto>.FailAsync($"=== Exp in AddTransactionsRevaluation: {exp.Message}");
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

        #endregion ============================================================ End Shared Functions =========================================================
    }
}