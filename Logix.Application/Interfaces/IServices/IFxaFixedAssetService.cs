using Logix.Application.DTOs.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;
using System.Linq.Expressions;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaFixedAssetService : IGenericQueryService<FxaFixedAssetDto, FxaFixedAssetVw>, IGenericWriteService<FxaFixedAssetDto, FxaFixedAssetEditDto>
    {
        //this table has another view "FxaFixedAssetVw2",, implement function for it
        Task<IResult<IEnumerable<FxaFixedAssetVw2>>> GetAllVW2(Expression<Func<FxaFixedAssetVw2, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<FxaFixedAssetVw>>> Search(FxaFixedAssetFilterDto filter, CancellationToken cancellationToken = default);
    }
}