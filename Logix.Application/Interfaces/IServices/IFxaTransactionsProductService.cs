using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Application.Interfaces.IServices.FXA
{
	public interface IFxaTransactionsProductService : IGenericQueryService<FxaTransactionsProductDto, FxaTransactionsProductsVw>, IGenericWriteService<FxaTransactionsProductDto, FxaTransactionsProductEditDto>
    {
    }
}