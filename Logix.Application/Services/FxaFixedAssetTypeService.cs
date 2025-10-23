using AutoMapper;
using Logix.Application.Common;
using Logix.Application.DTOs.FXA;
using Logix.Application.DTOs.Main;
using Logix.Application.Interfaces.IRepositories;
using Logix.Application.Interfaces.IServices.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;
using Logix.Domain.Main;

namespace Logix.Application.Services.FXA
{
    public class FxaFixedAssetTypeService : GenericQueryService<FxaFixedAssetType, FxaFixedAssetTypeDto, FxaFixedAssetTypeVw>, IFxaFixedAssetTypeService
    {
        private readonly IFxaRepositoryManager _fxaRepositoryManager;
        private readonly IAccRepositoryManager _accRepositoryManager;
        private readonly IMapper _mapper;
        private readonly ICurrentData session;
        private readonly ILocalizationService localization;

        public FxaFixedAssetTypeService(IQueryRepository<FxaFixedAssetType> queryRepository,
            IMapper mapper,
            IFxaRepositoryManager fxaRepositoryManager,
            IAccRepositoryManager accRepositoryManager,
            ICurrentData session,
            ILocalizationService localization) : base(queryRepository, mapper)
        {
            this._fxaRepositoryManager = fxaRepositoryManager;
            this._accRepositoryManager = accRepositoryManager;
            this._mapper = mapper;
            this.session = session;
            this.localization = localization;
        }

        public async Task<IResult<FxaFixedAssetTypeDto>> Add(FxaFixedAssetTypeDto entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetTypeDto>.FailAsync($"{localization.GetMessagesResource("AddNullEntity")}");

            try
            {
                long AccountId = 0;
                long Account2Id = 0;
                long Account3Id = 0;

                if (!(string.IsNullOrEmpty(entity.AccountCode)))
                {
                    AccountId = await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                        a => a.AccAccountCode == entity.AccountCode && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);

                    if (AccountId == 0)
                        return await Result<FxaFixedAssetTypeDto>.FailAsync($"رقم حساب الأصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode2)))
                {
                    Account2Id = await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                        a => a.AccAccountCode == entity.AccountCode2 && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);

                    if (Account2Id == 0)
                        return await Result<FxaFixedAssetTypeDto>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode3)))
                {
                    Account3Id = await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                        a => a.AccAccountCode == entity.AccountCode3 && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);

                    if (Account3Id == 0)
                        return await Result<FxaFixedAssetTypeDto>.FailAsync($"رقم حساب مصروف الاهلاك غير صحيح");
                }

                if (!string.IsNullOrEmpty(entity.Code))
                {
                    var chkCodeExist = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetAll(t => t.Id, t => t.Code == entity.Code && t.IsDeleted == false);
                    if (chkCodeExist.Any())
                    {
                        return await Result<FxaFixedAssetTypeDto>.FailAsync("رقم النوع موجود مسبقا");
                    }
                }

                var item = _mapper.Map<FxaFixedAssetType>(entity);

                item.AccountId = AccountId;
                item.Account2Id = Account2Id;
                item.Account3Id = Account3Id;

                item.FacilityId = session.FacilityId;
                item.CreatedBy = session.UserId;
                item.CreatedOn = DateTime.Now;

                var newEntity = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.AddAndReturn(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                var entityMap = _mapper.Map<FxaFixedAssetTypeDto>(newEntity);
                return await Result<FxaFixedAssetTypeDto>.SuccessAsync(entityMap, "item added successfully");
            }
            catch (Exception exc)
            {
                return await Result<FxaFixedAssetTypeDto>.FailAsync($"EXP in {this.GetType()}, Meesage: {exc.Message}");
            }
        }

        public async Task<IResult<FxaFixedAssetTypeEditDto>> Update(FxaFixedAssetTypeEditDto entity, CancellationToken cancellationToken = default)
        {
            if (entity == null) return await Result<FxaFixedAssetTypeEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

            try
            {
                var item = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetById(entity.Id);
                if (item == null) return await Result<FxaFixedAssetTypeEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

                long AccountId = 0;
                long Account2Id = 0;
                long Account3Id = 0;

                if (!(string.IsNullOrEmpty(entity.AccountCode)))
                {
                    AccountId = await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                        a => a.AccAccountCode == entity.AccountCode && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);

                    if (AccountId == 0)
                        return await Result<FxaFixedAssetTypeEditDto>.FailAsync($"رقم حساب الأصل غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode2)))
                {
                    Account2Id = await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                        a => a.AccAccountCode == entity.AccountCode2 && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);

                    if (Account2Id == 0)
                        return await Result<FxaFixedAssetTypeEditDto>.FailAsync($"رقم حساب مجمع الاهلاك غير صحيح");
                }

                if (!(string.IsNullOrEmpty(entity.AccountCode3)))
                {
                    Account3Id = await _accRepositoryManager.AccAccountsSubHelpeVwRepository.GetOne(a => a.AccAccountId,
                        a => a.AccAccountCode == entity.AccountCode3 && a.Isdel == false && a.FacilityId == session.FacilityId && a.IsActive == true);

                    if (Account3Id == 0)
                        return await Result<FxaFixedAssetTypeEditDto>.FailAsync($"رقم حساب مصروف الاهلاك غير صحيح");
                }

                if (!string.IsNullOrEmpty(entity.Code))
                {
                    var chkCodeExist = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetAll(t => t.Id, t => t.Id != entity.Id && t.Code == entity.Code && t.IsDeleted == false);
                    if (chkCodeExist.Any())
                    {
                        return await Result<FxaFixedAssetTypeEditDto>.FailAsync("رقم النوع موجود مسبقا");
                    }
                }

                _mapper.Map(entity, item);
                item.AccountId = AccountId;
                item.Account2Id = Account2Id;
                item.Account3Id = Account3Id;

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;
                _fxaRepositoryManager.FxaFixedAssetTypeRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                return await Result<FxaFixedAssetTypeEditDto>.SuccessAsync(_mapper.Map<FxaFixedAssetTypeEditDto>(item), localization.GetMessagesResource("success"));
            }
            catch (Exception exp)
            {
                return await Result<FxaFixedAssetTypeEditDto>.FailAsync($"EXP in Update at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
            }
        }

        public async Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var item = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetById(Id);
                if (item == null) return await Result.FailAsync($"{localization.GetMessagesResource("NoIdInDelete")}");

                var chkTypeIsParent = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.GetAll(t => t.Id, t => t.ParentId == Id && t.IsDeleted == false);
                if (chkTypeIsParent.Any())
                    return await Result.FailAsync("لا يمكن حذف هذا النوع لارتباطه بأنواع أخرى");

                item.ModifiedBy = session.UserId;
                item.ModifiedOn = DateTime.Now;
                item.IsDeleted = true;

                _fxaRepositoryManager.FxaFixedAssetTypeRepository.Update(item);
                await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

                return await Result<FxaFixedAssetTypeDto>.SuccessAsync(_mapper.Map<FxaFixedAssetTypeDto>(item), localization.GetMessagesResource("success"));
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

        public async Task<string> FxaFixedAssetTypeId_DF(int TypeId, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await _fxaRepositoryManager.FxaFixedAssetTypeRepository.FxaFixedAssetTypeId_DF(TypeId);

                return result;
            }
            catch
            {
                return "";
            }
        }
    }
}