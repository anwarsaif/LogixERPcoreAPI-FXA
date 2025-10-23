using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaTransactionsProductRepository : GenericRepository<FxaTransactionsProduct>, IFxaTransactionsProductRepository
    {
        public FxaTransactionsProductRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}