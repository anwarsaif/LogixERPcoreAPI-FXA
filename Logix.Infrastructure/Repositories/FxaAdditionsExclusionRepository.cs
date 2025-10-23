using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaAdditionsExclusionRepository : GenericRepository<FxaAdditionsExclusion>, IFxaAdditionsExclusionRepository
    {
        public FxaAdditionsExclusionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}