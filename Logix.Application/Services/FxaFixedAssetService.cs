using AutoMapper;
using Logix.Application.Common;
using Logix.Application.DTOs.ACC;
using Logix.Application.DTOs.FXA;
using Logix.Application.Interfaces.IRepositories;
using Logix.Application.Interfaces.IServices.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.ACC;
using Logix.Domain.FXA;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Logix.Application.Services.FXA
{
    public class FxaFixedAssetService : GenericQueryService<FxaFixedAsset, FxaFixedAssetDto, FxaFixedAssetVw>, IFxaFixedAssetService
    {
        private readonly IFxaRepositoryManager _fxaRepositoryManager;
        private readonly IAccRepositoryManager _accRepositoryManager;
        private readonly IMainRepositoryManager _mainRepositoryManager;
        private readonly IMapper _mapper;
        private readonly ICurrentData session;
        private readonly ILocalizationService localization;
        private readonly IQueryRepository<FxaFixedAssetVw> qRepository;

        public FxaFixedAssetService(IQueryRepository<FxaFixedAsset> queryRepository,
            IMapper mapper,
            IFxaRepositoryManager fxaRepositoryManager,
            IAccRepositoryManager accRepositoryManager,
            IMainRepositoryManager mainRepositoryManager,
            ICurrentData session,
            ILocalizationService localization,
            IQueryRepository<FxaFixedAssetVw> qRepository) : base(queryRepository, mapper)
        {
            this._fxaRepositoryManager = fxaRepositoryManager;
            this._accRepositoryManager = accRepositoryManager;
            this._mainRepositoryManager = mainRepositoryManager;
            this._mapper = mapper;
            this.session = session;
            this.localization = localization;
            this.qRepository = qRepository;
        }

        public async Task<IResult<FxaFixedAssetDto>> Add(FxaFixedAssetDto entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetDto>.FailAsync($"{localization.GetMessagesResource("AddNullEntity")}");

            try
            {
                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                //check if date in period
                if (!string.IsNullOrEmpty(entity.PurchaseDate))
                {
                    bool chkPeriod = await _accRepositoryManager.AccPeriodsRepository.CheckDateInPeriod(entity.PeriodId ?? 0, entity.PurchaseDate);
                    if (!chkPeriod)
                        return await Result<FxaFixedAssetDto>.FailAsync($"{localization.GetResource1("DateOutOfPERIOD")}");
                }

                //check asset type
                int typeId = 0;
                if (!string.IsNullOrEmpty(entity.TypeCode))
                {
                    var getId = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetOne(t => t.Id, t => t.Code == entity.TypeCode
                        && t.FacilityId == session.FacilityId && t.IsDeleted == false);
                    if (getId > 0)
                    {
                        var chkIsParent = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetAll(t => t.Id, t => t.ParentId == getId && t.IsDeleted == false);
                        if (chkIsParent.Any())
                            return await Result<FxaFixedAssetDto>.FailAsync("نوع الأصل غير ممكن أن يكون اصل رئيسي");
                        else
                            typeId = Convert.ToInt32(getId);
                    }
                    else return await Result<FxaFixedAssetDto>.FailAsync("رقم نوع الأصل غير صحيح");
                }

                //check accounts
                long accountId = 0; long accountId2 = 0; long accountId3 = 0; long creditAccountId = 0;

                if (!(string.IsNullOrEmpty(entity.PurchaseAccountCode)))
                {
                    creditAccountId = await GetAccountIdByCode(entity.PurchaseAccountCode);

                    if (creditAccountId == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم الحساب الدائن غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode)))
                {
                    accountId = await GetAccountIdByCode(entity.AccountCode);

                    if (accountId == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم حساب الاصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode2)))
                {
                    accountId2 = await GetAccountIdByCode(entity.AccountCode2);

                    if (accountId2 == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode3)))
                {
                    accountId3 = await GetAccountIdByCode(entity.AccountCode3);

                    if (accountId3 == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم حساب مصروف الإهلاك غير صحيح");
                }

                //check cost centers
                long ccId = 0; long ccId2 = 0; long ccId3 = 0; long ccId4 = 0; long ccId5 = 0;

                if (!(string.IsNullOrEmpty(entity.CcCode)))
                {
                    ccId = await GetCostCenterIdByCode(entity.CcCode);

                    if (ccId == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم مركز التكلفة غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode2)))
                {
                    ccId2 = await GetCostCenterIdByCode(entity.CcCode2);

                    if (ccId2 == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم مركز التكلفة 2 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode3)))
                {
                    ccId3 = await GetCostCenterIdByCode(entity.CcCode3);

                    if (ccId3 == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم مركز التكلفة 3 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode4)))
                {
                    ccId4 = await GetCostCenterIdByCode(entity.CcCode4);

                    if (ccId4 == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم مركز التكلفة 4 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode5)))
                {
                    ccId5 = await GetCostCenterIdByCode(entity.CcCode5);

                    if (ccId5 == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"رقم مركز التكلفة 5 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                //check empId
                long empId = 0;

                if (!(string.IsNullOrEmpty(entity.EmpCode)))
                {
                    empId = await _mainRepositoryManager.InvestEmployeeRepository.GetOne(a => a.Id,
                        a => a.EmpId == entity.EmpCode && a.IsDeleted == false);

                    if (empId == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }

                long mainAssetId = 0;
                if (entity.AdditionType == true)
                {
                    mainAssetId = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(a => a.Id,
                        a => a.No == entity.MainAssetNo && a.IsDeleted == false);

                    if (mainAssetId == 0)
                        return await Result<FxaFixedAssetDto>.FailAsync("رقم الاصل الرئيسي غير صحيح");
                }

                // add asset
                entity.InitialBalance = entity.Amount - entity.DeprecAmount;
                var item = _mapper.Map<FxaFixedAsset>(entity);

                item.TypeId = typeId;
                item.AccountId = accountId;
                item.Account2Id = accountId2;
                item.Account3Id = accountId3;
                item.PurchaseAccountId = creditAccountId;

                item.CcId = ccId;
                item.CcId2 = ccId2;
                item.CcId3 = ccId3;
                item.CcId4 = ccId4;
                item.CcId5 = ccId5;

                item.OhdaEmpId = empId;
                item.MainAssetId = mainAssetId;

                item.FacilityId = session.FacilityId;
                item.CreatedBy = session.UserId;
                item.CreatedOn = DateTime.Now;

                var getLocation = await _mainRepositoryManager.SysDepartmentRepository.GetById(item.LocationId ?? 0);
                var locationName = getLocation != null ? getLocation.Name : "";
                item.Location = locationName;

                // create No and code for asset
                string codeFormat = "";
                string? numberingByBranch = await GetPropertyValue(100);
                if (numberingByBranch == "1")
                {
                    string? branchCode = await _mainRepositoryManager.InvestBranchRepository.GetOne(b => b.BranchCode, b => b.BranchId == item.BranchId);
                    codeFormat = branchCode ?? "";
                }

                string? numberingByAssetType = await GetPropertyValue(101);
                if (numberingByAssetType == "1")
                {
                    string? assetTypeCode = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetOne(t => t.Code, t => t.Id == item.TypeId);
                    codeFormat += assetTypeCode;
                }

                string? numberingAssetDigit = await GetPropertyValue(102);

                var allAssets = await _fxaRepositoryManager.FxaFixedAssetRepository.GetAll(f => f.FacilityId == session.FacilityId);
                long No = 0;
                string code = "0";

                No = allAssets.Max(f => f.No ?? 0);
                No += 1;

                var allAssetsRes = allAssets;

                if (numberingByBranch == "1")
                    allAssetsRes = allAssetsRes.Where(f => f.BranchId == item.BranchId);

                if (numberingByAssetType == "1")
                    allAssetsRes = allAssetsRes.Where(f => f.TypeId == item.TypeId);

                var codeCount = allAssetsRes.Count();
                codeCount += 1;
                code = codeCount.ToString();

                if (!string.IsNullOrEmpty(numberingAssetDigit))
                    code = code.PadLeft(Convert.ToInt32(numberingAssetDigit), '0');

                if (!string.IsNullOrEmpty(codeFormat))
                    code = codeFormat + code;

                if (string.IsNullOrEmpty(code))
                    code = No.ToString();

                item.No = No;
                item.Code = code;
                var newEntity = await _fxaRepositoryManager.FxaFixedAssetRepository.AddAndReturn(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                var entityMap = _mapper.Map<FxaFixedAssetDto>(newEntity);

                // Transactions
                FxaTransactionFxaTransactionsAssetDto transactionObj = new();

                //add faxTransaction 1
                transactionObj.TransDate = item.PurchaseDate;
                transactionObj.Total = item.Amount ?? 0;
                transactionObj.StartDate = item.StartDate;
                transactionObj.EndDate = item.EndDate;
                transactionObj.FacilityId = session.FacilityId;
                transactionObj.CreatedBy = session.UserId;
                transactionObj.CreatedOn = DateTime.Now;
                transactionObj.AccountId = item.PurchaseAccountId;
                transactionObj.TransTypeId = 1;
                var FxaTransaction1 = await AddFxaTransaction(transactionObj, cancellationToken);

                //add faxTransactionAsset 1
                transactionObj.TransactionId = FxaTransaction1.Id;
                transactionObj.FixedAssetId = newEntity.Id;
                transactionObj.Debet = 0;
                transactionObj.Credit = item.Amount;
                transactionObj.Description = "القيمة الأصلية للأصل";
                var FxaTransactionAsset1 = await _fxaRepositoryManager.FxaTransactionsAssetRepository.AddAndReturn(_mapper.Map<FxaTransactionsAsset>(transactionObj));
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                if (entity.DeprecAmount > 0)
                {
                    //add faxTransaction 2
                    transactionObj.Total = entity.DeprecAmount;
                    transactionObj.TransDate = entity.LastDepreciationDate;
                    transactionObj.StartDate = item.StartDate;
                    transactionObj.EndDate = entity.LastDepreciationDate;
                    transactionObj.TransTypeId = 5;
                    var FxaTransaction2 = await AddFxaTransaction(transactionObj, cancellationToken);

                    //add faxTransactionAsset 2
                    transactionObj.TransactionId = FxaTransaction2.Id;
                    transactionObj.Debet = entity.DeprecAmount;
                    transactionObj.Credit = 0;
                    transactionObj.Description = "مجمع اهلاك فترات سابقة";
                    var FxaTransactionAsset2 = await _fxaRepositoryManager.FxaTransactionsAssetRepository.AddAndReturn(_mapper.Map<FxaTransactionsAsset>(transactionObj));
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                }

                // add acc gournal
                long jId = 0; string jCode = "";
                if (entity.ChkLinkWithAcc == true)
                {
                    var addJournal = await AddJournalWithDetails(newEntity, entity.PeriodId ?? 0, FxaTransaction1.Id, entity.DeprecAmount ?? 0, cancellationToken);
                    if (!addJournal.Succeeded)
                        return await Result<FxaFixedAssetDto>.FailAsync(addJournal.Status.message);

                    jId = addJournal.Data.JId;
                    jCode = addJournal.Data.JCode ?? "";
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);

                var returnObj = _mapper.Map<FxaFixedAssetDto>(newEntity);
                returnObj.JId = jId;
                returnObj.JCode = jCode;
                return await Result<FxaFixedAssetDto>.SuccessAsync(returnObj, "item added successfully");
            }
            catch (Exception exc)
            {
                return await Result<FxaFixedAssetDto>.FailAsync($"EXP in {this.GetType()}, Meesage: {exc.Message}");
            }
        }


        public async Task<IResult<FxaFixedAssetEditDto>> Update(FxaFixedAssetEditDto entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

            try
            {
                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                var item = await _fxaRepositoryManager.FxaFixedAssetRepository.GetById(entity.Id);
                if (item == null) return await Result<FxaFixedAssetEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

                long HidTransactionId = 0;
                long HidTransactionAssestId = 0;
                long HidTransactionId2 = 0;
                long HidTransactionAssestId2 = 0;
                int HidTransTypeId = 0;
                bool HidCreateNewId = false;

                var getFxaTransAssets = await _fxaRepositoryManager.FxaTransactionsAssetRepository.GetAllVW(t => t.FixedAssetId == entity.Id && t.IsDeleted == false);
                foreach (var fxaTransItem in getFxaTransAssets)
                {
                    if (fxaTransItem.TransTypeId == 1 || fxaTransItem.TransTypeId == 2)
                    {
                        HidTransactionId = fxaTransItem.TransactionId ?? 0;
                        HidTransactionAssestId = fxaTransItem.Id;
                    }
                    else if (fxaTransItem.TransTypeId == 5 && HidTransactionId2 == 0)
                    {
                        HidTransactionId2 = fxaTransItem.TransactionId ?? 0;
                        HidTransactionAssestId2 = fxaTransItem.Id;
                    }

                    HidTransTypeId = fxaTransItem.TransTypeId ?? 0;
                    HidCreateNewId = fxaTransItem.CreateNewId ?? false;
                }

                if (HidTransactionId > 0)
                {
                    var journalData = await _accRepositoryManager.AccJournalMasterRepository.GetOne(j => j.StatusId, j => j.ReferenceNo == HidTransactionId && j.DocTypeId == 20 && j.FlagDelete == false);
                    if (journalData == 2)
                        return await Result<FxaFixedAssetEditDto>.FailAsync(localization.GetMessagesResource("لايمكن تعديل الأصل وذلك لترحيل القيد"));
                }

                //check asset type
                int typeId = 0;
                if (!string.IsNullOrEmpty(entity.TypeCode))
                {
                    var getId = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetOne(t => t.Id, t => t.Code == entity.TypeCode
                        && t.FacilityId == session.FacilityId && t.IsDeleted == false);
                    if (getId > 0)
                    {
                        var chkIsParent = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetAll(t => t.Id, t => t.ParentId == getId && t.IsDeleted == false);
                        if (chkIsParent.Any())
                            return await Result<FxaFixedAssetEditDto>.FailAsync("نوع الأصل غير ممكن أن يكون اصل رئيسي");
                        else
                            typeId = Convert.ToInt32(getId);
                    }
                    else return await Result<FxaFixedAssetEditDto>.FailAsync("رقم نوع الأصل غير صحيح");
                }

                //check cost centers
                long ccId = 0; long ccId2 = 0; long ccId3 = 0; long ccId4 = 0; long ccId5 = 0;

                if (!(string.IsNullOrEmpty(entity.CcCode)))
                {
                    ccId = await GetCostCenterIdByCode(entity.CcCode);

                    if (ccId == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم مركز التكلفة غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode2)))
                {
                    ccId2 = await GetCostCenterIdByCode(entity.CcCode2);

                    if (ccId2 == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم مركز التكلفة 2 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode3)))
                {
                    ccId3 = await GetCostCenterIdByCode(entity.CcCode3);

                    if (ccId3 == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم مركز التكلفة 3 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode4)))
                {
                    ccId4 = await GetCostCenterIdByCode(entity.CcCode4);

                    if (ccId4 == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم مركز التكلفة 4 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                if (!(string.IsNullOrEmpty(entity.CcCode5)))
                {
                    ccId5 = await GetCostCenterIdByCode(entity.CcCode5);

                    if (ccId5 == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم مركز التكلفة 5 غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                long mainAssetId = 0;
                if (entity.AdditionType == true)
                {
                    //code is filled with (no of asset) when getByIdForEdit and display in edit page
                    if (entity.MainAssetNo == Convert.ToInt64(entity.Code))
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"يجب ان لا يكون الاصل فرع من الاصل نفسة");

                    mainAssetId = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(a => a.Id,
                        a => a.No == entity.MainAssetNo && a.IsDeleted == false);

                    if (mainAssetId == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync("رقم الاصل الرئيسي غير صحيح");
                }

                //check accounts
                long accountId = 0; long accountId2 = 0; long accountId3 = 0; long creditAccountId = 0;

                if (!(string.IsNullOrEmpty(entity.PurchaseAccountCode)))
                {
                    creditAccountId = await GetAccountIdByCode(entity.PurchaseAccountCode);

                    if (creditAccountId == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم الحساب الدائن غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode)))
                {
                    accountId = await GetAccountIdByCode(entity.AccountCode);

                    if (accountId == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم حساب الاصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode2)))
                {
                    accountId2 = await GetAccountIdByCode(entity.AccountCode2);

                    if (accountId2 == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode3)))
                {
                    accountId3 = await GetAccountIdByCode(entity.AccountCode3);

                    if (accountId3 == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"رقم حساب مصروف الإهلاك غير صحيح");
                }

                //check Supplier Id
                long supplierId = 0;
                if (!string.IsNullOrEmpty(entity.SupplierCode))
                {
                    var getSupplierId = await _mainRepositoryManager.SysCustomerRepository.GetOne(c => c.Id, c => c.Code == entity.SupplierCode && c.CusTypeId == 1 && c.IsDeleted == false);
                    supplierId = getSupplierId;
                }

                //check empId
                long empId = 0;

                if (!(string.IsNullOrEmpty(entity.EmpCode)))
                {
                    empId = await _mainRepositoryManager.InvestEmployeeRepository.GetOne(a => a.Id,
                        a => a.EmpId == entity.EmpCode && a.IsDeleted == false);

                    if (empId == 0)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }

                _mapper.Map(entity, item);

                item.TypeId = typeId;
                item.OhdaEmpId = empId;
                //item.No = Convert.ToInt64(entity.Code);
                item.Code = entity.FxCode;
                // TxtAssetsCode is typeId as ddl

                item.AccountId = accountId;
                item.Account2Id = accountId2;
                item.Account3Id = accountId3;
                item.SupplierId = supplierId;
                item.PurchaseAccountId = creditAccountId;

                item.CcId = ccId;
                item.CcId2 = ccId2;
                item.CcId3 = ccId3;
                item.CcId4 = ccId4;
                item.CcId5 = ccId5;

                item.MainAssetId = mainAssetId;

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;

                var getLocation = await _mainRepositoryManager.SysDepartmentRepository.GetById(item.LocationId ?? 0);
                var locationName = getLocation != null ? getLocation.Name : "";
                item.Location = locationName;

                _fxaRepositoryManager.FxaFixedAssetRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                long Transaction_ID = 0;

                if (HidTransactionId > 0)
                {
                    Transaction_ID = HidTransactionId;

                    //update FXATransactions & FXATransactionsAssest
                    var TransForEdit = await _fxaRepositoryManager.FxaTransactionRepository.GetOne(t => t.Id == HidTransactionId);
                    if (TransForEdit != null)
                    {
                        TransForEdit.TransDate = entity.PurchaseDate;
                        TransForEdit.Total = entity.Amount;
                        TransForEdit.StartDate = entity.StartDate;
                        TransForEdit.EndDate = entity.StartDate;
                        TransForEdit.FacilityId = session.FacilityId;
                        TransForEdit.CreatedBy = session.UserId;
                        TransForEdit.PurchaseOrder = entity.PurchaseDate;
                        TransForEdit.PurchaseDate = entity.PurchaseDate;
                        TransForEdit.SupplierId = supplierId;
                        TransForEdit.AccountId = creditAccountId;
                        TransForEdit.TransTypeId = 1;
                        TransForEdit.BranchId = entity.BranchId;

                        TransForEdit.CreateNewId = HidCreateNewId;
                        if (HidTransTypeId == 1)
                        {
                            _fxaRepositoryManager.FxaTransactionRepository.Update(TransForEdit);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        }
                    }

                    var TransAssetForEdit = await _fxaRepositoryManager.FxaTransactionsAssetRepository.GetOne(t => t.Id == HidTransactionAssestId);
                    if (TransAssetForEdit != null)
                    {
                        TransAssetForEdit.TransactionId = HidTransactionId;
                        TransAssetForEdit.FixedAssetId = entity.Id;
                        TransAssetForEdit.Debet = 0;
                        TransAssetForEdit.Credit = entity.Amount;
                        TransAssetForEdit.CreatedBy = session.UserId;
                        TransAssetForEdit.Description = "القيمة الأصلية للأصل";
                        _fxaRepositoryManager.FxaTransactionsAssetRepository.Update(TransAssetForEdit);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    }
                }
                else
                {
                    //Insert FXA_Transactions & InsertFXA_Transactions_Assest
                    FxaTransactionDto fxaTransactionDto = new()
                    {
                        TransDate = entity.PurchaseDate,
                        Total = entity.Amount,
                        StartDate = entity.StartDate,
                        EndDate = entity.StartDate,
                        FacilityId = session.FacilityId,
                        AccountId = creditAccountId,
                        TransTypeId = 1
                    };

                    var newFxaTrans = await AddFxaTransactionFromEdit(fxaTransactionDto, cancellationToken);
                    if (!newFxaTrans.Succeeded)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"{newFxaTrans.Status.message}");

                    FxaTransactionsAssetDto fxaTransactionsAssetDto = new()
                    {
                        TransactionId = newFxaTrans.Data.Id,
                        FixedAssetId = entity.Id,
                        Debet = 0,
                        Credit = entity.Amount,
                        Description = "القيمة الأصلية للأصل",
                        Total = entity.Amount,
                    };

                    var newFxaTransAsset = await AddFxaTransactionAssetFromEdit(fxaTransactionsAssetDto, cancellationToken);
                    if (!newFxaTransAsset.Succeeded)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"{newFxaTransAsset.Status.message}");

                    Transaction_ID = newFxaTrans.Data.Id;
                }

                if (entity.InitialBalance < entity.Amount)
                {
                    if (HidTransactionId2 > 0)
                    {
                        //update FXATransactions & FXATransactionsAssest
                        var TransForEdit2 = await _fxaRepositoryManager.FxaTransactionRepository.GetOne(t => t.Id == HidTransactionId2);
                        if (TransForEdit2 != null)
                        {
                            TransForEdit2.TransDate = entity.LastDepreciationDate;
                            TransForEdit2.Total = entity.Amount - entity.InitialBalance;
                            TransForEdit2.StartDate = entity.StartDate;
                            TransForEdit2.EndDate = entity.LastDepreciationDate;
                            TransForEdit2.FacilityId = session.FacilityId;
                            TransForEdit2.CreatedBy = session.UserId;
                            TransForEdit2.AccountId = creditAccountId;
                            TransForEdit2.TransTypeId = 5;

                            if (HidTransactionId > 0)
                            {
                                TransForEdit2.PurchaseOrder = entity.PurchaseDate;
                                TransForEdit2.PurchaseDate = entity.PurchaseDate;
                                TransForEdit2.SupplierId = supplierId;
                                TransForEdit2.BranchId = entity.BranchId;
                                TransForEdit2.CreateNewId = HidCreateNewId;
                            }

                            _fxaRepositoryManager.FxaTransactionRepository.Update(TransForEdit2);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        }

                        var TransAssetForEdit2 = await _fxaRepositoryManager.FxaTransactionsAssetRepository.GetOne(t => t.Id == HidTransactionAssestId2);
                        if (TransAssetForEdit2 != null)
                        {
                            TransAssetForEdit2.TransactionId = HidTransactionId2;
                            TransAssetForEdit2.FixedAssetId = entity.Id;
                            TransAssetForEdit2.Debet = entity.Amount - entity.InitialBalance;
                            TransAssetForEdit2.Credit = 0;
                            TransAssetForEdit2.CreatedBy = session.UserId;
                            TransAssetForEdit2.Description = "مجمع اهلاك فترات سابقة";
                            _fxaRepositoryManager.FxaTransactionsAssetRepository.Update(TransAssetForEdit2);
                            await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        }
                    }
                    else
                    {
                        //Insert FXA_Transactions & InsertFXA_Transactions_Assest
                        FxaTransactionDto fxaTransactionDto2 = new()
                        {
                            TransDate = entity.LastDepreciationDate,
                            Total = entity.Amount - entity.InitialBalance,
                            StartDate = entity.StartDate,
                            EndDate = entity.LastDepreciationDate,
                            FacilityId = session.FacilityId,
                            AccountId = creditAccountId,
                            TransTypeId = 5
                        };

                        if (HidTransactionId > 0)
                        {
                            fxaTransactionDto2.PurchaseOrder = entity.PurchaseDate;
                            fxaTransactionDto2.PurchaseDate = entity.PurchaseDate;
                            fxaTransactionDto2.SupplierId = supplierId;
                            fxaTransactionDto2.BranchId = entity.BranchId;
                            fxaTransactionDto2.CreateNewId = HidCreateNewId;
                        }

                        var newFxaTrans2 = await AddFxaTransactionFromEdit(fxaTransactionDto2, cancellationToken);
                        if (!newFxaTrans2.Succeeded)
                            return await Result<FxaFixedAssetEditDto>.FailAsync($"{newFxaTrans2.Status.message}");

                        FxaTransactionsAssetDto fxaTransactionsAssetDto = new()
                        {
                            TransactionId = newFxaTrans2.Data.Id,
                            FixedAssetId = entity.Id,
                            Debet = entity.Amount - entity.InitialBalance,
                            Credit = 0,
                            Description = "مجمع اهلاك فترات سابقة",
                            Total = entity.Amount - entity.InitialBalance,
                        };

                        var newFxaTransAsset2 = await AddFxaTransactionAssetFromEdit(fxaTransactionsAssetDto, cancellationToken);
                        if (!newFxaTransAsset2.Succeeded)
                            return await Result<FxaFixedAssetEditDto>.FailAsync($"{newFxaTransAsset2.Status.message}");
                    }
                }

                if (entity.ChkLinkWithAcc == true)
                {
                    var accJournalType = await GetPropertyValue(68);
                    string desc = "  قيد اضافة اصل رقم   " + entity.Code + " بتاريخ  " + entity.PurchaseDate + " " + entity.Description;

                    AccJournalMasterDto accJournalMasterDto = new()
                    {
                        JDateHijri = entity.PurchaseDate,
                        JDateGregorian = entity.PurchaseDate,
                        Amount = entity.Amount,
                        AmountWrite = "",
                        JDescription = desc,
                        JTime = "",
                        PaymentTypeId = 2,
                        PeriodId = entity.PeriodId,
                        StatusId = 1,
                        FinYear = session.FinYear,
                        FacilityId = session.FacilityId,
                        DocTypeId = 20,
                        ReferenceNo = Transaction_ID,
                        JBian = desc,
                        BankId = 0,
                        CcId = entity.BranchId,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    var addMasterJournal = await AddMasterJournal(accJournalMasterDto, cancellationToken);
                    if (!addMasterJournal.Succeeded)
                        return await Result<FxaFixedAssetEditDto>.FailAsync($"{addMasterJournal.Status.message}");

                    AccJournalDetaileDto jDetaileDto = new AccJournalDetaileDto()
                    {
                        JId = addMasterJournal.Data.JId,
                        AccAccountId = accountId,
                        Credit = 0,
                        Debit = entity.Amount,
                        Description = desc,
                        CreatedBy = Convert.ToInt32(session.UserId),
                        CreatedOn = DateTime.Now,
                        CcId = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1,
                        JDateGregorian = entity.PurchaseDate
                    };

                    if (!string.IsNullOrEmpty(accJournalType) && accJournalType == "2")
                    {
                        jDetaileDto.ReferenceTypeId = 1;
                        jDetaileDto.ReferenceNo = 0;
                    }
                    else
                    {
                        jDetaileDto.ReferenceTypeId = 12;
                        jDetaileDto.ReferenceNo = entity.Id;
                    }

                    var jDetail = await AddJournalDetail(jDetaileDto, cancellationToken);
                    if (!jDetail.Succeeded)
                        await Result<FxaFixedAssetEditDto>.FailAsync($"{jDetail.Status.message}");

                    //في حال وجود اهلاك سابق
                    if (entity.InitialBalance < entity.Amount)
                    {
                        AccJournalDetaileDto jDetaileDto2 = new AccJournalDetaileDto()
                        {
                            JId = addMasterJournal.Data.JId,
                            AccAccountId = accountId2,
                            Credit = entity.Amount - entity.InitialBalance,
                            Debit = 0,
                            Description = desc,
                            CreatedBy = Convert.ToInt32(session.UserId),
                            CreatedOn = DateTime.Now,
                            CcId = 0,
                            CurrencyId = 1,
                            ExchangeRate = 1,
                            JDateGregorian = entity.PurchaseDate
                        };

                        if (!string.IsNullOrEmpty(accJournalType) && accJournalType == "2")
                        {
                            jDetaileDto2.ReferenceTypeId = 1;
                            jDetaileDto2.ReferenceNo = 0;
                        }
                        else
                        {
                            jDetaileDto2.ReferenceTypeId = 13;
                            jDetaileDto2.ReferenceNo = entity.Id;
                        }

                        var jDetail2 = await AddJournalDetail(jDetaileDto, cancellationToken);
                        if (!jDetail2.Succeeded)
                            await Result<FxaFixedAssetEditDto>.FailAsync($"{jDetail2.Status.message}");
                    }

                    AccJournalDetaileDto jDetaileDto3 = new AccJournalDetaileDto()
                    {
                        JId = addMasterJournal.Data.JId,
                        AccAccountId = creditAccountId,
                        Credit = entity.InitialBalance,
                        Debit = 0,
                        Description = desc,
                        CreatedBy = Convert.ToInt32(session.UserId),
                        CreatedOn = DateTime.Now,
                        CcId = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1,
                        JDateGregorian = entity.PurchaseDate,
                        ReferenceTypeId = 1,
                        ReferenceNo = 0,
                    };

                    var jDetail3 = await AddJournalDetail(jDetaileDto3, cancellationToken);
                    if (!jDetail3.Succeeded)
                        await Result<FxaFixedAssetEditDto>.FailAsync($"{jDetail3.Status.message}");
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaFixedAssetEditDto>.SuccessAsync(_mapper.Map<FxaFixedAssetEditDto>(item), localization.GetMessagesResource("success"));
            }
            catch (Exception exp)
            {
                return await Result<FxaFixedAssetEditDto>.FailAsync($"EXP in Update at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
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

        private async Task<long> GetCostCenterIdByCode(string code)
        {
            try
            {
                return await _accRepositoryManager.AccCostCenterRepository.GetOne(c => c.CcId,
                        c => c.CostCenterCode == code && c.IsDeleted == false && c.FacilityId == session.FacilityId && c.IsActive == true);
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


        private async Task<FxaTransaction> AddFxaTransaction(FxaTransactionFxaTransactionsAssetDto transObj, CancellationToken cancellationToken)
        {
            try
            {
                long no = 0;
                string code = "";

                var allTransations = await _fxaRepositoryManager.FxaTransactionRepository.GetAll(t => t.TransTypeId == transObj.TransTypeId);
                
                if (allTransations.Any())
                    no = allTransations.Max(t => Convert.ToInt64(t.No));
                
                no += 1;
                var transationTypeCode = await _fxaRepositoryManager.FxaTransactionsTypeRepository.GetOne(t => t.Code, t => t.Id == transObj.TransTypeId);
                code = (transationTypeCode ?? "") + no.ToString();

                transObj.No = no;
                transObj.Code = code;

                var FxaTransaction = await _fxaRepositoryManager.FxaTransactionRepository.AddAndReturn(_mapper.Map<FxaTransaction>(transObj));
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return FxaTransaction;
            }
            catch
            {
                throw;
            }
        }

        private async Task<IResult<FxaTransaction>> AddFxaTransactionFromEdit(FxaTransactionDto entity, CancellationToken cancellationToken)
        {
            try
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

                var mapItem = _mapper.Map<FxaTransaction>(entity);
                mapItem.CreatedBy = session.UserId;
                mapItem.CreatedOn = DateTime.Now;

                var FxaTransaction = await _fxaRepositoryManager.FxaTransactionRepository.AddAndReturn(mapItem);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return await Result<FxaTransaction>.SuccessAsync(FxaTransaction, "item added successfully");
            }
            catch (Exception ex)
            {
                return await Result<FxaTransaction>.FailAsync($"{ex.Message}");
            }
        }

        private async Task<IResult<FxaTransactionsAsset>> AddFxaTransactionAssetFromEdit(FxaTransactionsAssetDto entity, CancellationToken cancellationToken)
        {
            try
            {
                var mapItem = _mapper.Map<FxaTransactionsAsset>(entity);
                mapItem.CreatedBy = session.UserId;
                mapItem.CreatedOn = DateTime.Now;

                var FxaTransaction = await _fxaRepositoryManager.FxaTransactionsAssetRepository.AddAndReturn(mapItem);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return await Result<FxaTransactionsAsset>.SuccessAsync(FxaTransaction, "item added successfully");
            }
            catch (Exception ex)
            {
                return await Result<FxaTransactionsAsset>.FailAsync($"{ex.Message}");
            }
        }

        private async Task<IResult<AccJournalMaster>> AddJournalWithDetails(FxaFixedAsset fxaFixedAsset, long periodId, long transactionId, decimal deprecAmount, CancellationToken cancellationToken)
        {
            try
            {
                List<string> res = new List<string>();
                //هل يتم التقييد كل اصل على حده في المالية ام إجمالي
                var accJournalType = await GetPropertyValue(68);

                string desc = "  قيد اضافة اصل رقم   " + fxaFixedAsset.No.ToString() + " بتاريخ  " + fxaFixedAsset.PurchaseDate + " " + fxaFixedAsset.Description;
                AccJournalMasterDto jMasterDto = new AccJournalMasterDto()
                {
                    JDateHijri = fxaFixedAsset.PurchaseDate,
                    JDateGregorian = fxaFixedAsset.PurchaseDate,
                    Amount = fxaFixedAsset.Amount,
                    JDescription = desc,
                    JTime = "",
                    PaymentTypeId = 2,
                    PeriodId = periodId,
                    StatusId = 1,
                    CreatedBy = Convert.ToInt32(session.UserId),
                    CreatedOn = DateTime.Now,
                    //insertuserid,
                    //insertuserdate,
                    FinYear = session.FinYear,
                    FacilityId = session.FacilityId,
                    DocTypeId = 20,
                    ReferenceNo = transactionId,
                    JBian = desc,
                    BankId = 0,
                    CcId = fxaFixedAsset.BranchId,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var jMaster = await AddMasterJournal(jMasterDto, cancellationToken);
                if (!jMaster.Succeeded)
                    return jMaster; //one of checks is false, or an exception occured.

                AccJournalDetaileDto jDetaileDto = new AccJournalDetaileDto()
                {
                    JId = jMaster.Data.JId,
                    AccAccountId = fxaFixedAsset.AccountId,
                    Credit = 0,
                    Debit = fxaFixedAsset.Amount,
                    Description = desc,
                    CreatedBy = Convert.ToInt32(session.UserId),
                    CreatedOn = DateTime.Now,
                    CcId = 0,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                if (!string.IsNullOrEmpty(accJournalType) && accJournalType == "2")
                {
                    jDetaileDto.ReferenceTypeId = 1;
                    jDetaileDto.ReferenceNo = 0;
                }
                else
                {
                    jDetaileDto.ReferenceTypeId = 12;
                    jDetaileDto.ReferenceNo = fxaFixedAsset.Id;
                }

                var jDetail = await AddJournalDetail(jDetaileDto, cancellationToken);
                if (!jDetail.Succeeded)
                    await Result<AccJournalMaster>.FailAsync($"{jDetail.Status.message}");

                //في حال وجود اهلاك سابق
                if (deprecAmount > 0)
                {
                    AccJournalDetaileDto jDetaileDto2 = new AccJournalDetaileDto()
                    {
                        JId = jMaster.Data.JId,
                        AccAccountId = fxaFixedAsset.Account2Id,
                        Credit = deprecAmount,
                        Debit = 0,
                        Description = desc,
                        CreatedBy = Convert.ToInt32(session.UserId),
                        CreatedOn = DateTime.Now,
                        CcId = 0,
                        CurrencyId = 1,
                        ExchangeRate = 1
                    };

                    if (!string.IsNullOrEmpty(accJournalType) && accJournalType == "2")
                    {
                        jDetaileDto2.ReferenceTypeId = 1;
                        jDetaileDto2.ReferenceNo = 0;
                    }
                    else
                    {
                        jDetaileDto2.ReferenceTypeId = 13;
                        jDetaileDto2.ReferenceNo = fxaFixedAsset.Id;
                    }

                    var jDetail2 = await AddJournalDetail(jDetaileDto2, cancellationToken);
                    if (!jDetail2.Succeeded)
                        await Result<AccJournalMaster>.FailAsync($"{jDetail2.Status.message}");
                }

                AccJournalDetaileDto jDetaileDto3 = new AccJournalDetaileDto()
                {
                    JId = jMaster.Data.JId,
                    AccAccountId = fxaFixedAsset.PurchaseAccountId,
                    Credit = fxaFixedAsset.Amount - deprecAmount,
                    Debit = 0,
                    Description = desc,
                    CreatedBy = Convert.ToInt32(session.UserId),
                    CreatedOn = DateTime.Now,
                    CcId = 0,
                    ReferenceTypeId = 1,
                    ReferenceNo = 0,
                    CurrencyId = 1,
                    ExchangeRate = 1
                };

                var jDetail3 = await AddJournalDetail(jDetaileDto3, cancellationToken);
                if (!jDetail3.Succeeded)
                    await Result<AccJournalMaster>.FailAsync($"{jDetail3.Status.message}");

                return jMaster; //journal added successful, so return it to take its id and code>.
            }
            catch (Exception ex)
            {
                return await Result<AccJournalMaster>.FailAsync($"{ex.Message}");
            }
        }

        private async Task<IResult<AccJournalMaster>> AddMasterJournal(AccJournalMasterDto entity, CancellationToken cancellationToken)
        {
            try
            {
                var masterItem = _mapper.Map<AccJournalMaster>(entity);
                masterItem.InsertUserId = Convert.ToInt32(session.UserId);
                masterItem.InsertDate = DateTime.Now;


                //create code
                var numberByDocType = await GetPropertyValue(91);
                if (numberByDocType == "0")
                    return await Result<AccJournalMaster>.FailAsync("Please Adjust Numbering from configration for journal enteries if you wont by documnet type or not #91.");

                var numberByPeriod = await GetPropertyValue(197);

                var numberByBranch = await GetPropertyValue(92);
                if (numberByBranch == "0")
                    return await Result<AccJournalMaster>.FailAsync("Please Adjust Numbering from configration for journal enteries if you wont by branch or not #92.");

                var numberDocByBranch = await GetPropertyValue(93);
                if (numberDocByBranch == "0")
                    return await Result<AccJournalMaster>.FailAsync("Please Adjust Numbering from configration for documentes if you wont by branch or not #93.");

                var saveOldNo = await GetPropertyValue(90);
                if (saveOldNo == "0")
                    return await Result<AccJournalMaster>.FailAsync("Please Adjust Numbering from configration for jounral enteries auto if you wont creat new numner or not #90.");

                var chkPeriodAndYear = await _accRepositoryManager.AccPeriodsRepository.GetOne(p => p.PeriodId, p => p.FinYear == masterItem.FinYear && p.FlagDelete == false && p.PeriodId == masterItem.PeriodId);
                if (!(chkPeriodAndYear > 0))
                    return await Result<AccJournalMaster>.FailAsync("السنة المالية تختلف على الفترة المحاسبية المحددة");

                if (!string.IsNullOrEmpty(entity.JDateGregorian))
                {
                    bool chkFinYear = await _accRepositoryManager.AccFinancialYearRepository.CheckDateInFinancialYear(entity.FinYear ?? 0, entity.JDateGregorian);
                    if (!chkFinYear)
                        return await Result<AccJournalMaster>.FailAsync($"{localization.GetResource1("التاريخ للقيد خارج إطار تاريخ السنة")}");

                    bool chkPeriod = await _accRepositoryManager.AccPeriodsRepository.CheckDateInPeriodByYear(entity.FinYear ?? 0, entity.JDateGregorian);
                    if (!chkPeriod)
                        return await Result<AccJournalMaster>.FailAsync("التاريخ للقيد خارج إطار تاريخ الفترة");
                }

                if (masterItem.CcId == null || masterItem.CcId == 0)
                    return await Result<AccJournalMaster>.FailAsync("الفرع غير محدد التسجيل");

                if (masterItem.ExchangeRate == 0)
                    return await Result<AccJournalMaster>.FailAsync("التعادل يجب ان يكون اكبر من الصفر");

                var chkPeriodState = await _accRepositoryManager.AccPeriodsRepository.GetOne(p => p.PeriodId, p => p.PeriodId == masterItem.PeriodId && p.FlagDelete == false && p.PeriodState == 2);
                if (chkPeriodState > 0)
                    return await Result<AccJournalMaster>.FailAsync("حالة الفترة المحاسبية مغلقة ولايمكن العمل عليها");

                var chkFinYearState = await _accRepositoryManager.AccFinancialYearRepository.GetOne(f => f.FinYear, p => p.FinYear == masterItem.FinYear && p.IsDeleted == false && p.FinState == 2);
                if (chkFinYearState > 0)
                    return await Result<AccJournalMaster>.FailAsync("حالة السنة المالية مغلقة ولايمكن العمل عليها");


                long jCodeAut = 0;
                var allMasterJournals = await _accRepositoryManager.AccJournalMasterRepository.GetAll(j => j.JCode,
                        j => (numberByDocType != "1" || j.DocTypeId == masterItem.DocTypeId)
                        && (numberByBranch != "1" || j.CcId == masterItem.CcId)
                        && (numberByPeriod != "1" || j.PeriodId == masterItem.PeriodId)
                        && j.FacilityId == masterItem.FacilityId && j.FinYear == masterItem.FinYear
                        );

                if (allMasterJournals.Any())
                    jCodeAut = allMasterJournals.Max(j => Convert.ToInt64(j));

                jCodeAut += 1;

                var numberingTheSequence = await GetPropertyValue(333);
                if (numberingTheSequence == "1" && masterItem.DocTypeId == 2)
                {
                    string year = ""; string month = "";
                    if (!string.IsNullOrEmpty(masterItem.JDateGregorian))
                    {
                        year = masterItem.JDateGregorian.Substring(0, 4).Substring(2);
                        month = masterItem.JDateGregorian.Substring(0, 7).Substring(5, 2);

                        var allMasterJournalsRef = await _accRepositoryManager.AccJournalMasterRepository.GetAll(j => j.ReferenceNo,
                            j => j.DocTypeId == masterItem.DocTypeId && j.FacilityId == masterItem.FacilityId && j.FinYear == masterItem.FinYear
                                   && !string.IsNullOrEmpty(j.JDateGregorian) && j.JDateGregorian.Substring(1, 7) == masterItem.JDateGregorian.Substring(1, 7));

                        masterItem.ReferenceNo = 0;
                        if (allMasterJournalsRef.Any())
                            masterItem.ReferenceNo = allMasterJournalsRef.Max(j => Convert.ToInt64(j));
                        masterItem.ReferenceNo += 1;
                        if (masterItem.ReferenceNo == 1)
                            masterItem.ReferenceNo = Convert.ToInt64(year + month + masterItem.ReferenceNo ?? 0.ToString().PadLeft(4, '0'));
                    }
                }
                else
                {
                    if (masterItem.DocTypeId == 1 || masterItem.DocTypeId == 2 || masterItem.DocTypeId == 3)
                    {
                        var allMasterJournalsRef = await _accRepositoryManager.AccJournalMasterRepository.GetAll(j => j.ReferenceNo,
                            j => j.DocTypeId == masterItem.DocTypeId && j.PeriodId == masterItem.PeriodId && j.FacilityId == masterItem.FacilityId && j.FinYear == masterItem.FinYear
                                   && (numberDocByBranch != "1" || j.CcId == masterItem.CcId));

                        masterItem.ReferenceNo = 0;
                        if (allMasterJournalsRef.Any())
                            masterItem.ReferenceNo = allMasterJournalsRef.Max(j => Convert.ToInt64(j));
                        masterItem.ReferenceNo += 1;
                    }
                }

                string stringJCodeAut = jCodeAut.ToString();
                if (stringJCodeAut.Length <= 5)
                    masterItem.JCode = $"{jCodeAut:D5}";
                else
                    masterItem.JCode = stringJCodeAut;

                string jCodeOld = "";
                var allJournal = await _accRepositoryManager.AccJournalMasterRepository.GetAll(j => j.DocTypeId == masterItem.DocTypeId
                    && j.ReferenceNo == masterItem.ReferenceNo && j.FlagDelete == false);

                int[] excludeDocTypes = new int[] { 1, 2, 3, 4, 27, 35 };
                var chkJournalExist = allJournal.Where(j => !excludeDocTypes.Contains(j.DocTypeId ?? 0) && j.FacilityId == masterItem.FacilityId);
                if (chkJournalExist.Any())
                {
                    jCodeOld = allJournal.Last().JCode ?? "";
                    List<long> jIds = new();
                    //delete master journal
                    foreach (var journalItem in allJournal)
                    {
                        jIds.Add(journalItem.JId);

                        journalItem.FlagDelete = true;
                        _accRepositoryManager.AccJournalMasterRepository.Update(journalItem);
                        await _accRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    }
                    //delete details
                    var allDetail = await _accRepositoryManager.AccJournalDetaileRepository.GetAll(d => d.IsDeleted == false && jIds.Contains(d.JId ?? 0));
                    if (allDetail.Any())
                    {
                        foreach (var detail in allDetail)
                        {
                            detail.IsDeleted = true;
                            _accRepositoryManager.AccJournalDetaileRepository.Update(detail);
                            await _accRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        }
                    }
                }

                if (saveOldNo == "1" && !string.IsNullOrEmpty(jCodeOld))
                {
                    masterItem.JCode = jCodeOld;
                }

                var journal = await _accRepositoryManager.AccJournalMasterRepository.AddAndReturn(masterItem);
                await _accRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return await Result<AccJournalMaster>.SuccessAsync(journal, "item added successfully");
            }
            catch (Exception ex)
            {
                return await Result<AccJournalMaster>.FailAsync($"{ex.Message}");
            }
        }

        private async Task<IResult<AccJournalDetaile>> AddJournalDetail(AccJournalDetaileDto entity, CancellationToken cancellationToken)
        {
            try
            {
                if (entity.AccAccountId == null || entity.AccAccountId == 0)
                    return await Result<AccJournalDetaile>.FailAsync($"الحساب الموجود في طرف القيد غير موجود في قائمة الحسابات");

                long facilityId = 0;
                facilityId = await _accRepositoryManager.AccJournalMasterRepository.GetOne(j => j.FacilityId, j => j.JId == entity.JId) ?? 0;

                var chkAccountExist = await _accRepositoryManager.AccAccountRepository.GetOne(a => a.AccAccountId, a => a.AccAccountId == entity.AccAccountId && a.IsDeleted == false && a.FacilityId == facilityId);
                if (chkAccountExist == 0)
                {
                    string msg = "الحساب الموجود في طرف القيد غير موجود في قائمة الحسابات لهذه المنشآة. Acc_Account_ID = ";
                    msg += entity.AccAccountId.ToString();
                    return await Result<AccJournalDetaile>.FailAsync(msg);
                }

                var masterItem = _mapper.Map<AccJournalDetaile>(entity);
                var jDetaile = await _accRepositoryManager.AccJournalDetaileRepository.AddAndReturn(masterItem);
                await _accRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                //return jDetaile;
                return await Result<AccJournalDetaile>.SuccessAsync(jDetaile, "item added successfully");
            }
            catch (Exception ex)
            {
                return await Result<AccJournalDetaile>.FailAsync($"{ex.Message}");
            }
        }



        public async Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
        {
            try
            {
                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                var item = await _fxaRepositoryManager.FxaFixedAssetRepository.GetById(Id);
                if (item == null) return await Result.FailAsync($"{localization.GetMessagesResource("NoIdInDelete")}");

                var chkIsMainAsset = await _fxaRepositoryManager.FxaFixedAssetRepository.GetAll(a => a.Id, a => a.MainAssetId == Id && a.IsDeleted == false);
                if (chkIsMainAsset.Any())
                    return await Result.FailAsync($"لايمكن حذف الأصل وذلك لأنه أصل رئيسي لأصول أخرى");

                //var allDetails = await _accRepositoryManager.AccJournalDetaileRepository.GetAllFromView(d => d.FlagDelete == false && d.ParentId == 5 && d.ReferenceNo == Id);
                //int count = allDetails.Count();
                //if (count > 0) return await Result.FailAsync($"لا يمكن حذف الأصل لوجود حركة عليه");

                //check account journal,, if status=2 => can not delete the asset, else=> delete master journal and its details
                var journalData = await _accRepositoryManager.AccJournalMasterRepository.GetOne(j => j.ReferenceNo == Id && j.DocTypeId == 20 && j.FlagDelete == false);
                if (journalData != null)
                {
                    if (journalData.StatusId == 2) return await Result.FailAsync($"لايمكن حذف الأصل وذلك لترحيله");
                    else
                    {
                        //delete from master
                        journalData.FlagDelete = true;
                        journalData.DeleteUserId = Convert.ToInt32(session.UserId);
                        journalData.DeleteDate = DateTime.Now;
                        _accRepositoryManager.AccJournalMasterRepository.Update(journalData);
                        await _accRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                        //delete from details
                        var details = await _accRepositoryManager.AccJournalDetaileRepository.GetAll(d => d.IsDeleted == false && d.JId == journalData.JId);
                        foreach (var detail in details)
                        {
                            detail.IsDeleted = true;
                            detail.DeleteUserId = Convert.ToInt32(session.UserId);
                            detail.DeleteDate = DateTime.Now;
                            _accRepositoryManager.AccJournalDetaileRepository.Update(detail);
                            await _accRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                        }
                    }
                }

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;
                item.IsDeleted = true;

                _fxaRepositoryManager.FxaFixedAssetRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);

                return await Result<FxaFixedAssetDto>.SuccessAsync(_mapper.Map<FxaFixedAssetDto>(item), localization.GetMessagesResource("success"));
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


        public async Task<IResult<IEnumerable<FxaFixedAssetVw2>>> GetAllVW2(Expression<Func<FxaFixedAssetVw2, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var items = await _fxaRepositoryManager.FxaFixedAssetRepository.GetAllVW2(expression);
                if (items == null) return await Result<IEnumerable<FxaFixedAssetVw2>>.FailAsync("No Data Found");

                return await Result<IEnumerable<FxaFixedAssetVw2>>.SuccessAsync(items, "records retrieved");

            }
            catch (Exception exc)
            {
                return await Result<IEnumerable<FxaFixedAssetVw2>>.FailAsync($"EXP in {GetType()}, Meesage: {exc.Message}");
            }
        }

        public async Task<IResult<IEnumerable<FxaFixedAssetVw>>> Search(FxaFixedAssetFilterDto filter, CancellationToken cancellationToken = default)
        {
            try
            {
                var branchsId = session.Branches.Split(',');
                bool additionType = filter.AdditionTypeFilter == 2; //true if type = 2, otherwhise false
                filter.LocationId ??= 0;
                filter.BranchId ??= 0;
                filter.StatusId ??= 0;
                filter.ClassificationId ??= 0;
                filter.AdditionTypeFilter ??= 0;

                var items = await qRepository.GetAllFrom<FxaFixedAssetVw>(a => a.IsDeleted == false && a.FacilityId == session.FacilityId
                    && (string.IsNullOrEmpty(filter.Code) || (!string.IsNullOrEmpty(a.Code) && a.Code.Contains(filter.Code)))
                    && (string.IsNullOrEmpty(filter.Name) || (!string.IsNullOrEmpty(a.Name) && a.Name.Contains(filter.Name)))
                    && (filter.LocationId == 0 || (a.LocationId == filter.LocationId))
                    && (filter.BranchId == 0 || (a.BranchId == filter.BranchId))
                    && ((filter.BranchId != 0) || branchsId.Contains(a.BranchId.ToString())) //Exclude any records that its branch not in user banches
                    && (filter.StatusId == 0 || (a.StatusId == filter.StatusId))
                    && (filter.ClassificationId == 0 || (a.ClassificationId == filter.ClassificationId))
                    && (string.IsNullOrEmpty(filter.OhdaEmpCode) || (!string.IsNullOrEmpty(a.OhdaEmpCode) && a.OhdaEmpCode == filter.OhdaEmpCode))
                    && (filter.AdditionTypeFilter == 0 || a.AdditionType == additionType));

                List<FxaFixedAssetVw> final = new();
                if (items.Any())
                {
                    var res = items.OrderBy(r => r.Id).AsQueryable();
                    if (!string.IsNullOrEmpty(filter.StartDate) && !string.IsNullOrEmpty(filter.EndDate))
                    {
                        DateTime startDate = DateTime.ParseExact(filter.StartDate ?? "", "yyyy/MM/dd", CultureInfo.InvariantCulture);
                        DateTime endDate = DateTime.ParseExact(filter.EndDate ?? "", "yyyy/MM/dd", CultureInfo.InvariantCulture);

                        res = res.Where(r => !string.IsNullOrEmpty(r.PurchaseDate) && DateTime.ParseExact(r.PurchaseDate, "yyyy/MM/dd", CultureInfo.InvariantCulture) >= startDate
                            && DateTime.ParseExact(r.PurchaseDate, "yyyy/MM/dd", CultureInfo.InvariantCulture) <= endDate);
                    }

                    foreach (var item in res)
                    {
                        bool shouldAddItem = (filter.TypeId == null || filter.TypeId == 0 || item.TypeId == filter.TypeId);

                        if (!shouldAddItem)
                        {
                            var typesBasedOnParents = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.FxaFixedAssetTypeId_DF(filter.TypeId ?? 0);
                            shouldAddItem = typesBasedOnParents.Contains((item.TypeId ?? 0).ToString());
                        }

                        if (shouldAddItem)
                        {
                            final.Add(item);
                        }
                    }
                }
                return await Result<IEnumerable<FxaFixedAssetVw>>.SuccessAsync(final, "records retrieved");
            }
            catch (Exception exc)
            {
                return await Result<IEnumerable<FxaFixedAssetVw>>.FailAsync($"EXP in {GetType()}, Meesage: {exc.Message}");
            }
        }

    }
}