using Logix.Application.DTOs.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaFixedAssetTransferService : IGenericQueryService<FxaFixedAssetTransferDto, FxaFixedAssetTransferVw>, IGenericWriteService<FxaFixedAssetTransferDto, FxaFixedAssetTransferEditDto>
    {
        Task<IResult<FxaFixedAssetTransferDto2>> Add2(FxaFixedAssetTransferDto2 entity, CancellationToken cancellationToken = default);
    }
}