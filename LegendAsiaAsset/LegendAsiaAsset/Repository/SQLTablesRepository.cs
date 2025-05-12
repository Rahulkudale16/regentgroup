using LegendAsiaAsset.Contracts;
using Dapper;
using LegendAsiaAsset.Context;
using LegendAsiaAsset.Models;
using System.Data;
using System.Security.Claims;

namespace LegendAsiaAsset.Repository
{
    public class SQLTablesRepository : ISQLTablesRepository
    {
        private readonly DapperContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public SQLTablesRepository(DapperContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<string> GetDBType()
        {
            string fileType = string.Empty;

            try
            {
                using (var conn = _context.CreateConnection())
                {
                    string query = "SELECT DB_NAME() AS [Database]";

                    var fileDetails = await conn.QueryFirstOrDefaultAsync<string>(query);

                    if (fileDetails == "LegendITAsset_dev")
                    {
                        fileType = "DEV";
                    }
                    else
                    {
                        fileType = "PROD";
                    }
                };
            }
            catch (Exception)
            {
                //throw ex;
            }

            return fileType;
        }
    }
}
