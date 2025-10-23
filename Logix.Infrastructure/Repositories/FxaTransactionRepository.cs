using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaTransactionRepository : GenericRepository<FxaTransaction>, IFxaTransactionRepository
    {
        public FxaTransactionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}