using System.Data;
using System.Data.SqlClient;

namespace LegendAsiaAsset.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly string _connectionStringNew;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("LegendAsiaAsset") ?? string.Empty;
            _connectionStringNew = _configuration.GetConnectionString("LegendAsiaAssetNew") ?? string.Empty;
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
        public IDbConnection CreateConnectionNew()
            => new SqlConnection(_connectionStringNew);
    }
}
