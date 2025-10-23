using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
	public class FxaTransactionsPaymentRepository : GenericRepository<FxaTransactionsPayment>, IFxaTransactionsPaymentRepository
	{
        private ApplicationDbContext _context;

        public FxaTransactionsPaymentRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        //public async Task<IEnumerable<FxaFixedAssetVw2>> GetAllVW2(Expression<Func<FxaFixedAssetVw2, bool>> expression)
        //{
        //    return await _context.Set<FxaFixedAssetVw2>().Where(expression).AsNoTracking().ToListAsync();
        //}
    }
}