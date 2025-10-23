using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaTransactionsTypeRepository : GenericRepository<FxaTransactionsType>, IFxaTransactionsTypeRepository
    {
        public FxaTransactionsTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}