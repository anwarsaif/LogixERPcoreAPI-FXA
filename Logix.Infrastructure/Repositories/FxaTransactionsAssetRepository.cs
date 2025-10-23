using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaTransactionsAssetRepository : GenericRepository<FxaTransactionsAsset>, IFxaTransactionsAssetRepository
    {
        private ApplicationDbContext _context;

        public FxaTransactionsAssetRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<FxaTransactionsAssetsVw>> GetAllVW(Expression<Func<FxaTransactionsAssetsVw, bool>> expression)
        {
            return await _context.Set<FxaTransactionsAssetsVw>().Where(expression).AsNoTracking().ToListAsync();
        }
    }
}