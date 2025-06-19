using LegendAsiaAsset.Contracts;
using Dapper;
using LegendAsiaAsset.Context;
using LegendAsiaAsset.Models;
using System.Data;
using System.Security.Claims;

namespace LegendAsiaAsset.Repository
{
    public class InfrastructureRepository : IInfrastructureRepository
    {
        private readonly DapperContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public InfrastructureRepository(DapperContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<List<InfrastructureModel>> GetInfrastructureList(InfrastructureModel infrastructureModel)
        {
            try
            {
                string sp = "SP_SelectInfrastructureList";

                var parameter = new DynamicParameters();
                parameter.Add("SerialNumber", infrastructureModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameter.Add("Model", infrastructureModel.Model, DbType.String, ParameterDirection.Input);
                parameter.Add("Brand", infrastructureModel.Brand, DbType.String, ParameterDirection.Input);
                parameter.Add("AssetType", infrastructureModel.AssetType, DbType.String, ParameterDirection.Input);
                parameter.Add("Location", infrastructureModel.Location, DbType.String, ParameterDirection.Input);
                parameter.Add("Status", infrastructureModel.Status, DbType.String, ParameterDirection.Input);
                parameter.Add("IDLocations", infrastructureModel.Remark, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var infrastructureModels = await connection.QueryAsync<InfrastructureModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (infrastructureModels != null)
                    {
                        return infrastructureModels.AsList();
                    }
                    else
                    {
                        return new();
                    }
                }
                ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<InfrastructureModel>> GetSerialnumberDropdownList()
        {
            try
            {
                string? sp = "SP_GetSerialnumberFromInfrastructure";
                using (var connection = _context.CreateConnection())
                {
                    var InfrastructureSerialno = await connection.QueryAsync<InfrastructureModel>(sp, commandType: CommandType.StoredProcedure);
                    if (InfrastructureSerialno != null)
                    {
                        return InfrastructureSerialno.AsList();
                    }
                    else
                    {
                        return new List<InfrastructureModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<InfrastructureModel>> GetModelDropdownList()
        {
            try
            {
                string? sp = "SP_GetModelFromInfrastructure";
                using (var connection = _context.CreateConnection())
                {
                    var InfrastructureModel = await connection.QueryAsync<InfrastructureModel>(sp, commandType: CommandType.StoredProcedure);
                    if (InfrastructureModel != null)
                    {
                        return InfrastructureModel.AsList();
                    }
                    else
                    {
                        return new List<InfrastructureModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<InfrastructureModel>> GetBrandDropdownList()
        {
            try
            {
                string? sp = "SP_GetBrandFromInfrastructure";
                using (var connection = _context.CreateConnection())
                {
                    var InfrastructureBrand = await connection.QueryAsync<InfrastructureModel>(sp, commandType: CommandType.StoredProcedure);
                    if (InfrastructureBrand != null)
                    {
                        return InfrastructureBrand.AsList();
                    }
                    else
                    {
                        return new List<InfrastructureModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<InfrastructureModel>> GetAssetTypeDropdownList()
        {
            try
            {
                string? sp = "SP_GetAssetTypeFromInfrastructure";
                using (var connection = _context.CreateConnection())
                {
                    var InfrastructureAssetType = await connection.QueryAsync<InfrastructureModel>(sp, commandType: CommandType.StoredProcedure);
                    if (InfrastructureAssetType != null)
                    {
                        return InfrastructureAssetType.AsList();
                    }
                    else
                    {
                        return new List<InfrastructureModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<LocationModel> GetLocationfromID(int IDLocation)
        {
            try
            {
                string sp = "SP_GetLocationfromID";

                var parameters = new DynamicParameters();
                parameters.Add("IDLocation", IDLocation, DbType.Int32, ParameterDirection.Input);

                using (var connection = _context.CreateConnection())
                {
                    var location = await connection.QueryFirstOrDefaultAsync<LocationModel>(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (location != null)
                    {
                        return location;
                    }
                    else
                    {
                        return new LocationModel();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string GetUserName()
        {
            var claimName = _contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Name);
            string? currentUserName = claimName?.Value;
            return currentUserName ?? string.Empty;
        }

        public async Task<ResponseModel> SaveInfrastructure(InfrastructureModel infrastructureModel)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertUpdateInfrastructure";

                var parameters = new DynamicParameters();
                parameters.Add("IDInfra", infrastructureModel.IDInfra, DbType.Int16, ParameterDirection.Input);
                parameters.Add("AssetType", infrastructureModel.AssetType, DbType.String, ParameterDirection.Input);
                parameters.Add("Brand", infrastructureModel.Brand.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Model", infrastructureModel.Model.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", infrastructureModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameters.Add("PurchaseYear", infrastructureModel.PurchaseYear, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("Remark", infrastructureModel.Remark?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", infrastructureModel.Unit ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("IDLocation", infrastructureModel.Location, DbType.String, ParameterDirection.Input);
                //parameters.Add("Location", infrastructureModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Status", "AVAILABLE", DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                using (var connection = _context.CreateConnection())
                {
                    int infrastructure1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;
                    if (isDuplicateFound)
                    {
                        responseModel.Success = false;
                        responseModel.Duplicate = true;

                    }
                    else
                    {
                        string InfraQuery = string.Format("Select IDInfra From Infrastructure WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);

                        var infrastructureModel2 = await connection.QueryFirstOrDefaultAsync<InfrastructureModel>(InfraQuery);
                        if (infrastructureModel != null)
                        {
                            responseModel.ID = infrastructureModel2.IDInfra;
                            responseModel.Success = true;
                            string query = "Update Infrastructure set IDInfraDis = 'INF-00" + infrastructureModel2.IDInfra + "' WHERE IDInfra = " + infrastructureModel2.IDInfra;
                            _ = await connection.ExecuteAsync(query);
                        }
                        responseModel.Success = true;
                        responseModel.Duplicate = false;
                    }
                }
                ;
                return responseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResponseModel> UpdateInfrastructure(InfrastructureModel infrastructureModel)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_UpdateInfrastructure";

                var parameters = new DynamicParameters();
                parameters.Add("IDInfra", infrastructureModel.IDInfra, DbType.Int16, ParameterDirection.Input);
                //parameters.Add("IDLocation", infrastructureModel.IDLocation, DbType.String, ParameterDirection.Input);
                parameters.Add("AssetType", infrastructureModel.AssetType, DbType.String, ParameterDirection.Input);
                parameters.Add("Brand", infrastructureModel.Brand.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Model", infrastructureModel.Model.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", infrastructureModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameters.Add("PurchaseYear", infrastructureModel.PurchaseYear, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("IDLocation", infrastructureModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Remark", infrastructureModel.Remark?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", infrastructureModel.Unit ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("Status", infrastructureModel.Status, DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                using (var connection = _context.CreateConnection())
                {
                    int infrastructure1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;

                    if (isDuplicateFound)
                    {
                        responseModel.Success = false;
                        responseModel.Duplicate = true;

                    }
                    else
                    {
                        if (infrastructure1 == 1)
                        {
                            responseModel.Success = true;
                            responseModel.Duplicate = false;
                        }
                    }
                }
                ;
                return responseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> GetInfraCount(int id)
        {
            try
            {
                var parameter1 = new DynamicParameters();
                parameter1.Add("parameter", id, DbType.Int16, ParameterDirection.Input);
                string sp = "SP_GetInfraCount";
                using (var connection = _context.CreateConnection())
                {
                    int infraCount = await connection.QueryFirstOrDefaultAsync<int>(sp, parameter1, commandType: CommandType.StoredProcedure);
                    return infraCount;
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> GetStatusInfra(InfrastructureModel infrastructureModel)
        {
            try
            {
                string sp = "SP_GetStatusFromInfra";

                var parameters = new DynamicParameters();
                parameters.Add("IDInfra", infrastructureModel.IDInfra, DbType.Int16, ParameterDirection.Input);
                parameters.Add("Status", infrastructureModel.Status, DbType.String, ParameterDirection.Input);

                using (var connection = _context.CreateConnection())
                {
                    int userDetails1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (userDetails1 == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResponseModel> TransferInfraDetails(InfrastructureModel infrastructureModel)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertInfrastructure";

                var parameters = new DynamicParameters();
                parameters.Add("IDInfra", null, DbType.Int16, ParameterDirection.Input);
                parameters.Add("AssetType", infrastructureModel.AssetType, DbType.String, ParameterDirection.Input);
                parameters.Add("Brand", infrastructureModel.Brand, DbType.String, ParameterDirection.Input);
                parameters.Add("Model", infrastructureModel.Model, DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", infrastructureModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameters.Add("PurchaseYear", infrastructureModel.PurchaseYear, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("IDLocation", infrastructureModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Remark", infrastructureModel.Remark, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", infrastructureModel.Unit, DbType.String, ParameterDirection.Input);
                parameters.Add("Status", "AVAILABLE", DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                using (var connection = _context.CreateConnectionNew())
                {
                    int infrastructure1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;
                    if (isDuplicateFound)
                    {
                        responseModel.Success = false;
                        responseModel.Duplicate = true;

                    }
                    else
                    {
                        string InfraQuery = string.Format("Select IDInfra From Infrastructure WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);

                        var infrastructureModel2 = await connection.QueryFirstOrDefaultAsync<InfrastructureModel>(InfraQuery);
                        if (infrastructureModel != null)
                        {
                            responseModel.ID = infrastructureModel2.IDInfra;
                            responseModel.Success = true;
                            string query = "Update Infrastructure set IDInfraDis = 'INF-00" + infrastructureModel2.IDInfra + "' WHERE IDInfra = " + infrastructureModel2.IDInfra;
                            _ = await connection.ExecuteAsync(query);
                        }
                        responseModel.Success = true;
                        responseModel.Duplicate = false;
                    }
                }
                ;
                return responseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> TransferedAndDeletedInfra(InfrastructureModel infrastructureModel)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteInfraDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDInfra", infrastructureModel.IDInfra, DbType.Int16, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int userDetails1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (userDetails1 == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteInfra(int IDInfra)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteInfraDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDInfra", IDInfra, DbType.Int16, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int itassetDetails = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (itassetDetails == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetInfraID(string SerialNumber)
        {
            try
            {
                string query = string.Format("select distinct(IDInfra) from Infrastructure where SerialNumber = '{0}'", SerialNumber);

                using (var connection = _context.CreateConnection())
                {
                    var InfraData = await connection.QueryFirstOrDefaultAsync<string>(query);
                    return InfraData;
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetLocationfromID12(string Location)
        {
            try
            {
                string query = string.Format("select distinct(Location) from Location where IDLocation = '{0}'", Location);

                using (var connection = _context.CreateConnection())
                {
                    var InfraData = await connection.QueryFirstOrDefaultAsync<string>(query);
                    return InfraData;
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
