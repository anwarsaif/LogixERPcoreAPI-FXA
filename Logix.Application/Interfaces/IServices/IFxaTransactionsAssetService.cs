using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaTransactionsAssetService : IGenericQueryService<FxaTransactionsAssetDto, FxaTransactionsAssetsVw>, IGenericWriteService<FxaTransactionsAssetDto, FxaTransactionsAssetEditDto>
    {

    }
}