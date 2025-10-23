using Logix.Application.DTOs.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;
using System.Linq.Expressions;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaFixedAssetTypeService : IGenericQueryService<FxaFixedAssetTypeDto, FxaFixedAssetTypeVw>, IGenericWriteService<FxaFixedAssetTypeDto, FxaFixedAssetTypeEditDto>
    {
        //scalar-valued function on sql server
        Task<string> FxaFixedAssetTypeId_DF(int TypeId, CancellationToken cancellationToken = default);
    }
}