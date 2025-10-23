using Logix.Domain.FXA;
using System.Linq.Expressions;

namespace Logix.Application.Interfaces.IRepositories.FXA
{
    public interface IFxaFixedAssetRepository : IGenericRepository<FxaFixedAsset>
    {
        Task<IEnumerable<FxaFixedAssetVw2>> GetAllVW2(Expression<Func<FxaFixedAssetVw2, bool>> expression);
    }
}