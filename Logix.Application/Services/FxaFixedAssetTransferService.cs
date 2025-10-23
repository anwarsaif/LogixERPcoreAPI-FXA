using AutoMapper;
using Logix.Application.Common;
using Logix.Application.DTOs.FXA;
using Logix.Application.Interfaces.IRepositories;
using Logix.Application.Interfaces.IServices.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.Services.FXA
{
    public class FxaFixedAssetTransferService : GenericQueryService<FxaFixedAssetTransfer, FxaFixedAssetTransferDto, FxaFixedAssetTransferVw>, IFxaFixedAssetTransferService
    {
        private readonly IFxaRepositoryManager _fxaRepositoryManager;
        private readonly IAccRepositoryManager _accRepositoryManager;
        private readonly IMainRepositoryManager _mainRepositoryManager;
        private readonly IMapper _mapper;
        private readonly ICurrentData session;
        private readonly ILocalizationService localization;

        public FxaFixedAssetTransferService(IQueryRepository<FxaFixedAssetTransfer> queryRepository,
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

        public async Task<IResult<FxaFixedAssetTransferDto>> Add(FxaFixedAssetTransferDto entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetTransferDto>.FailAsync($"{localization.GetMessagesResource("AddNullEntity")}");

            try
            {
                //get FxaFixedAssetId
                long FxaFixedAssetId = 0;
                if (entity.FxaFixedAssetNo > 0)
                {
                    FxaFixedAssetId = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(f => f.Id, f => f.No == entity.FxaFixedAssetNo);
                }

                //check cost centers
                long fromCcId = 0; long toCcId = 0;
                if (!(string.IsNullOrEmpty(entity.FromCcCode)))
                {
                    fromCcId = await GetCostCenterIdByCode(entity.FromCcCode);

                    if (fromCcId == 0)
                        return await Result<FxaFixedAssetTransferDto>.FailAsync($"رقم مركز التكلفة المنقول منه غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }
                if (!(string.IsNullOrEmpty(entity.ToCcCode)))
                {
                    toCcId = await GetCostCenterIdByCode(entity.ToCcCode);

                    if (toCcId == 0)
                        return await Result<FxaFixedAssetTransferDto>.FailAsync($"رقم مركز التكلفة المنقول إليه غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                //check empId
                long fromEmpId = 0; long toEmpId = 0;

                if (!(string.IsNullOrEmpty(entity.FromEmpCode)))
                {
                    fromEmpId = await GetEmpIdByCode(entity.FromEmpCode);

                    if (fromEmpId == 0)
                        return await Result<FxaFixedAssetTransferDto>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }
                if (!(string.IsNullOrEmpty(entity.ToEmpCode)))
                {
                    toEmpId = await GetEmpIdByCode(entity.ToEmpCode);

                    if (toEmpId == 0)
                        return await Result<FxaFixedAssetTransferDto>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }

                var item = _mapper.Map<FxaFixedAssetTransfer>(entity);

                item.FxaFixedAssetId = FxaFixedAssetId;
                item.FromCcId = fromCcId;
                item.ToCcId = toCcId;

                item.FromEmpId = fromEmpId;
                item.ToEmpId = toEmpId;

                item.CreatedBy = session.UserId;
                item.CreatedOn = DateTime.Now;

                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                var newEntity = await _fxaRepositoryManager.FxaFixedAssetTransferRepository.AddAndReturn(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                var entityMap = _mapper.Map<FxaFixedAssetTransferDto>(newEntity);

                var fixedAssetForEdit = await _fxaRepositoryManager.FxaFixedAssetRepository.GetById(item.FxaFixedAssetId ?? 0);
                if (fixedAssetForEdit != null)
                {
                    fixedAssetForEdit.BranchId = item.ToBranchId;
                    fixedAssetForEdit.FacilityId = item.ToFacilityId;
                    fixedAssetForEdit.CcId = item.ToCcId;
                    fixedAssetForEdit.OhdaEmpId = item.ToEmpId;
                    fixedAssetForEdit.LocationId = item.ToLocationId;

                    _fxaRepositoryManager.FxaFixedAssetRepository.Update(fixedAssetForEdit);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaFixedAssetTransferDto>.SuccessAsync(entityMap, "item added successfully");
            }
            catch (Exception exc)
            {
                return await Result<FxaFixedAssetTransferDto>.FailAsync($"EXP in {this.GetType()}, Meesage: {exc.Message}");
            }
        }

        public async Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var item = await _fxaRepositoryManager.FxaFixedAssetTransferRepository.GetById(Id);
                if (item == null) return await Result.FailAsync($"{localization.GetMessagesResource("NoIdInDelete")}");

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;
                item.IsDeleted = true;

                _fxaRepositoryManager.FxaFixedAssetTransferRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                return await Result<FxaFixedAssetTransferDto>.SuccessAsync(_mapper.Map<FxaFixedAssetTransferDto>(item), localization.GetMessagesResource("success"));
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

        public async Task<IResult<FxaFixedAssetTransferEditDto>> Update(FxaFixedAssetTransferEditDto entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetTransferEditDto>.FailAsync($"{localization.GetMessagesResource("NoIdInUpdate")}");

            try
            {
                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);

                var item = await _fxaRepositoryManager.FxaFixedAssetTransferRepository.GetById(entity.Id);
                if (item == null) return await Result<FxaFixedAssetTransferEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

                //get FxaFixedAssetId
                long FxaFixedAssetId = 0;
                if (entity.FxaFixedAssetNo > 0)
                {
                    FxaFixedAssetId = await _fxaRepositoryManager.FxaFixedAssetRepository.GetOne(f => f.Id, f => f.No == entity.FxaFixedAssetNo);
                }

                //check cost centers
                long fromCcId = 0; long toCcId = 0;
                if (!(string.IsNullOrEmpty(entity.FromCcCode)))
                {
                    fromCcId = await GetCostCenterIdByCode(entity.FromCcCode);

                    if (fromCcId == 0)
                        return await Result<FxaFixedAssetTransferEditDto>.FailAsync($"رقم مركز التكلفة المنقول منه غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }
                if (!(string.IsNullOrEmpty(entity.ToCcCode)))
                {
                    toCcId = await GetCostCenterIdByCode(entity.ToCcCode);

                    if (toCcId == 0)
                        return await Result<FxaFixedAssetTransferEditDto>.FailAsync($"رقم مركز التكلفة المنقول إليه غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                //check empId
                long fromEmpId = 0; long toEmpId = 0;

                if (!(string.IsNullOrEmpty(entity.FromEmpCode)))
                {
                    fromEmpId = await GetEmpIdByCode(entity.FromEmpCode);

                    if (fromEmpId == 0)
                        return await Result<FxaFixedAssetTransferEditDto>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }
                if (!(string.IsNullOrEmpty(entity.ToEmpCode)))
                {
                    toEmpId = await GetEmpIdByCode(entity.ToEmpCode);

                    if (toEmpId == 0)
                        return await Result<FxaFixedAssetTransferEditDto>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }

                _mapper.Map(entity, item);
                item.FxaFixedAssetId = FxaFixedAssetId;
                item.FromCcId = fromCcId;
                item.ToCcId = toCcId;

                item.FromEmpId = fromEmpId;
                item.ToEmpId = toEmpId;

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;

                _fxaRepositoryManager.FxaFixedAssetTransferRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                var fixedAssetForEdit = await _fxaRepositoryManager.FxaFixedAssetRepository.GetById(item.FxaFixedAssetId ?? 0);
                if (fixedAssetForEdit != null)
                {
                    fixedAssetForEdit.BranchId = item.ToBranchId;
                    fixedAssetForEdit.FacilityId = item.ToFacilityId;
                    fixedAssetForEdit.CcId = item.ToCcId;
                    fixedAssetForEdit.OhdaEmpId = item.ToEmpId;
                    fixedAssetForEdit.LocationId = item.ToLocationId;

                    _fxaRepositoryManager.FxaFixedAssetRepository.Update(fixedAssetForEdit);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                }

                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaFixedAssetTransferEditDto>.SuccessAsync(_mapper.Map<FxaFixedAssetTransferEditDto>(item), localization.GetMessagesResource("success"));
            }
            catch (Exception exc)
            {
                return await Result<FxaFixedAssetTransferEditDto>.FailAsync($"EXP in {this.GetType()}, Meesage: {exc.Message}");
            }
        }

        public async Task<IResult<FxaFixedAssetTransferDto2>> Add2(FxaFixedAssetTransferDto2 entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetTransferDto2>.FailAsync($"{localization.GetMessagesResource("AddNullEntity")}");

            try
            {
                //check cost centers
                long fromCcId = 0; long toCcId = 0;
                if (!(string.IsNullOrEmpty(entity.FromCcCode)))
                {
                    fromCcId = await GetCostCenterIdByCode(entity.FromCcCode);

                    if (fromCcId == 0)
                        return await Result<FxaFixedAssetTransferDto2>.FailAsync($"رقم مركز التكلفة المنقول منه غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }
                if (!(string.IsNullOrEmpty(entity.ToCcCode)))
                {
                    toCcId = await GetCostCenterIdByCode(entity.ToCcCode);

                    if (toCcId == 0)
                        return await Result<FxaFixedAssetTransferDto2>.FailAsync($"رقم مركز التكلفة المنقول إليه غير موجود في قائمة مراكز التكلفة فضلاً تأكد من الرقم الصحيح");
                }

                //check empId
                long fromEmpId = 0; long toEmpId = 0;

                if (!(string.IsNullOrEmpty(entity.FromEmpCode)))
                {
                    fromEmpId = await GetEmpIdByCode(entity.FromEmpCode);

                    if (fromEmpId == 0)
                        return await Result<FxaFixedAssetTransferDto2>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }
                if (!(string.IsNullOrEmpty(entity.ToEmpCode)))
                {
                    toEmpId = await GetEmpIdByCode(entity.ToEmpCode);

                    if (toEmpId == 0)
                        return await Result<FxaFixedAssetTransferDto2>.FailAsync($"{localization.GetResource1("EmployeeNotFound")}");
                }

                if(string.IsNullOrEmpty(entity.FxaFixedAssetIds))
                    return await Result<FxaFixedAssetTransferDto2>.FailAsync("لم يتم اختيار اي عملية لنقلها");

                var fxaFixedAssetIdsArr = entity.FxaFixedAssetIds.Split(',');
                await _fxaRepositoryManager.UnitOfWork.BeginTransactionAsync(cancellationToken);
                int count = 0;
                foreach (var fixedAssetId in fxaFixedAssetIdsArr)
                {
                    var item = _mapper.Map<FxaFixedAssetTransfer>(entity);

                    item.FxaFixedAssetId = Convert.ToInt64(fixedAssetId);
                    item.FromCcId = fromCcId;
                    item.ToCcId = toCcId;

                    item.FromEmpId = fromEmpId;
                    item.ToEmpId = toEmpId;

                    item.CreatedBy = session.UserId;
                    item.CreatedOn = DateTime.Now;

                    var newEntity = await _fxaRepositoryManager.FxaFixedAssetTransferRepository.AddAndReturn(item);
                    await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                    var fixedAssetForEdit = await _fxaRepositoryManager.FxaFixedAssetRepository.GetById(item.FxaFixedAssetId ?? 0);
                    if (fixedAssetForEdit != null)
                    {
                        fixedAssetForEdit.BranchId = item.ToBranchId;
                        fixedAssetForEdit.FacilityId = item.ToFacilityId;
                        fixedAssetForEdit.CcId = item.ToCcId;
                        fixedAssetForEdit.OhdaEmpId = item.ToEmpId;
                        fixedAssetForEdit.LocationId = item.ToLocationId;

                        _fxaRepositoryManager.FxaFixedAssetRepository.Update(fixedAssetForEdit);
                        await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    }
                    count += 1;
                }
                string msg = "تمت عملية النقل لعدد " + count + " نقل بنجاح";
                await _fxaRepositoryManager.UnitOfWork.CommitTransactionAsync(cancellationToken);
                return await Result<FxaFixedAssetTransferDto2>.SuccessAsync(entity, msg);
            }
            catch (Exception exc)
            {
                return await Result<FxaFixedAssetTransferDto2>.FailAsync($"EXP in {this.GetType()}, Meesage: {exc.Message}");
            }
        }

        #region ========================================== Private Functions ==========================================
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

        private async Task<long> GetEmpIdByCode(string code)
        {
            try
            {
                return await _mainRepositoryManager.InvestEmployeeRepository.GetOne(a => a.Id,
                        a => a.EmpId == code && a.IsDeleted == false);
            }
            catch
            {
                return 0;
            }
        }
        #endregion
    }
}