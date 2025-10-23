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
	public class FxaTransactionsPaymentService : GenericQueryService<FxaTransactionsPayment, FxaTransactionsPaymentDto, FxaTransactionsPayment>, IFxaTransactionsPaymentService
	{
		private readonly IFxaRepositoryManager _fxaRepositoryManager;
		private readonly IMapper _mapper;
		private readonly ICurrentData session;
		private readonly ILocalizationService localization;

		public FxaTransactionsPaymentService(IQueryRepository<FxaTransactionsPayment> queryRepository,
			IMapper mapper,
			IFxaRepositoryManager fxaRepositoryManager,
			ICurrentData session,
			ILocalizationService localization) : base(queryRepository, mapper)
		{
			this._fxaRepositoryManager = fxaRepositoryManager;
			this._mapper = mapper;
			this.session = session;
			this.localization = localization;
		}

		public async Task<IResult<FxaTransactionsPaymentDto>> Add(FxaTransactionsPaymentDto entity, CancellationToken cancellationToken = default)
		{
			if (entity == null) return await Result<FxaTransactionsPaymentDto>.FailAsync($"{localization.GetMessagesResource("AddNullEntity")}");

			try
			{
				var item = _mapper.Map<FxaTransactionsPayment>(entity);

				item.CreatedBy = session.UserId;
				item.CreatedOn = DateTime.Now;

				var newEntity = await _fxaRepositoryManager.FxaTransactionsPaymentRepository.AddAndReturn(item);
				await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

				var entityMap = _mapper.Map<FxaTransactionsPaymentDto>(newEntity);
				return await Result<FxaTransactionsPaymentDto>.SuccessAsync(entityMap, "item added successfully");
			}
			catch (Exception exc)
			{
				return await Result<FxaTransactionsPaymentDto>.FailAsync($"EXP in {this.GetType()}, Meesage: {exc.Message}");
			}
		}

		public async Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
		{
			try
			{
				var item = await _fxaRepositoryManager.FxaTransactionsPaymentRepository.GetById(Id);
				if (item == null) return await Result.FailAsync($"{localization.GetMessagesResource("NoIdInDelete")}");

				item.ModifiedBy = session.UserId;
				item.ModifiedOn = DateTime.Now;
				item.IsDeleted = true;

				_fxaRepositoryManager.FxaTransactionsPaymentRepository.Update(item);
				await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

				return await Result<FxaTransactionsPaymentDto>.SuccessAsync(_mapper.Map<FxaTransactionsPaymentDto>(item), localization.GetMessagesResource("success"));
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

		public async Task<IResult<FxaTransactionsPaymentEditDto>> Update(FxaTransactionsPaymentEditDto entity, CancellationToken cancellationToken = default)
		{
			if (entity == null) return await Result<FxaTransactionsPaymentEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));

			try
			{
				var item = await _fxaRepositoryManager.FxaTransactionsPaymentRepository.GetById(entity.Id??0);
				if (item == null) return await Result<FxaTransactionsPaymentEditDto>.FailAsync(localization.GetMessagesResource("NoIdInUpdate"));


				_mapper.Map(entity, item);

				item.ModifiedBy = session.UserId;
				item.ModifiedOn = DateTime.Now;
				_fxaRepositoryManager.FxaTransactionsPaymentRepository.Update(item);
				await _fxaRepositoryManager.UnitOfWork.CompleteAsync(cancellationToken);

				return await Result<FxaTransactionsPaymentEditDto>.SuccessAsync(_mapper.Map<FxaTransactionsPaymentEditDto>(item), localization.GetMessagesResource("success"));
			}
			catch (Exception exp)
			{
				return await Result<FxaTransactionsPaymentEditDto>.FailAsync($"EXP in Update at ( {this.GetType()} ) , Message: {exp.Message} --- {(exp.InnerException != null ? "InnerExp: " + exp.InnerException.Message : "no inner")}");
			}
		}
	}
}
