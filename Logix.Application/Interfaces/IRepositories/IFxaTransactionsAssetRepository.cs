using Logix.Domain.FXA;
using System.Linq.Expressions;

namespace Logix.Application.Interfaces.IRepositories.FXA
{
    public interface IFxaTransactionsAssetRepository : IGenericRepository<FxaTransactionsAsset>
    {
        Task<IEnumerable<FxaTransactionsAssetsVw>> GetAllVW(Expression<Func<FxaTransactionsAssetsVw, bool>> expression);
    }
}