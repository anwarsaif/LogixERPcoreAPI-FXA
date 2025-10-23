using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaFixedAssetTransferRepository : GenericRepository<FxaFixedAssetTransfer>, IFxaFixedAssetTransferRepository
    {
        public FxaFixedAssetTransferRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}