using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaTransactionsRevaluationRepository : GenericRepository<FxaTransactionsRevaluation>, IFxaTransactionsRevaluationRepository
    {
        public FxaTransactionsRevaluationRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}