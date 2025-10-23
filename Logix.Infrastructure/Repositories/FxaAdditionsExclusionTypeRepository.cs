using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaAdditionsExclusionTypeRepository : GenericRepository<FxaAdditionsExclusionType>, IFxaAdditionsExclusionTypeRepository
    {
        public FxaAdditionsExclusionTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}