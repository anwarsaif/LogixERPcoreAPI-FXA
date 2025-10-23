using Logix.Domain.FXA;
using System.Linq.Expressions;

namespace Logix.Application.Interfaces.IRepositories.FXA
{
    public interface IFxaFixedAssetTypeRepository : IGenericRepository<FxaFixedAssetType>
    {
        //scalar-valued function on sql server
        Task<string> FxaFixedAssetTypeId_DF(int TypeId);
    }
}