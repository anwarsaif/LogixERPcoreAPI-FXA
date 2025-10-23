using Logix.Application.Interfaces.IRepositories.FXA;
using Logix.Domain.FXA;
using Logix.Infrastructure.DbContexts;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Logix.Infrastructure.Repositories.FXA
{
    public class FxaFixedAssetTypeRepository : GenericRepository<FxaFixedAssetType>, IFxaFixedAssetTypeRepository
    {
        private ApplicationDbContext _context;
        private readonly IConfiguration configuration;

        public FxaFixedAssetTypeRepository(ApplicationDbContext context, IConfiguration _configuration) : base(context)
        {
            this._context = context;
            this.configuration = _configuration;
        }

        public async Task<string> FxaFixedAssetTypeId_DF(int TypeId)
        {
            string result = "";
            try
            {
                using (var connection = new SqlConnection(configuration.GetConnectionString("LogixLocal")))
                {
                    await connection.OpenAsync();

                    string sql = "SELECT dbo.FXA_FixedAsset_Type_ID(@Type_ID)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Type_ID", TypeId);
                        result = (string)command.ExecuteScalar();

                        return result;
                    }
                }
            }
            catch
            {
                return result;
            }
        }
    }
}