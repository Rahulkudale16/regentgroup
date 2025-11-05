using Dapper;
using System.Data;
using LegendAsiaAsset.Context;
using LegendAsiaAsset.Models;
using System.Security.Claims;
using LegendAsiaAsset.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using LegendAsiaAsset.Contracts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;

namespace LegendAsiaAsset.Repository
{
    public class ITAssetDetailsRepository : IITAssetDetailsRepository
    {
        private readonly DapperContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public ITAssetDetailsRepository(DapperContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<List<ITAssetDetailsModel>> GetITAssetDetailsList(ITAssetDetailsModel iTAssetDetailsModel)
        {
            try
            {
                string sp = "SP_GetColumnsITAsseTDetails";
                var parameter = new DynamicParameters();
                parameter.Add("HostName", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                parameter.Add("Assettype", iTAssetDetailsModel.AssetType, DbType.String, ParameterDirection.Input);
                parameter.Add("Brand", iTAssetDetailsModel.Brand, DbType.String, ParameterDirection.Input);
                parameter.Add("Model", iTAssetDetailsModel.Model, DbType.String, ParameterDirection.Input);
                parameter.Add("Status", iTAssetDetailsModel.Status, DbType.String, ParameterDirection.Input);
                parameter.Add("Location", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameter.Add("FullName", iTAssetDetailsModel.FullName, DbType.String, ParameterDirection.Input);
                parameter.Add("LastUser", iTAssetDetailsModel.LastUser, DbType.String, ParameterDirection.Input);
                parameter.Add("SerialNumber", iTAssetDetailsModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameter.Add("Country", iTAssetDetailsModel.Country, DbType.String, ParameterDirection.Input);
                parameter.Add("Domain", iTAssetDetailsModel.Domain, DbType.String, ParameterDirection.Input);
                parameter.Add("IDLocations", iTAssetDetailsModel.Remark, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var iTAssetDetailsModel1 = await connection.QueryAsync<ITAssetDetailsModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (iTAssetDetailsModel1 != null)
                    {
                        return iTAssetDetailsModel1.AsList();
                    }
                    else
                    {
                        return new();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ITAssetDetailsModel>> GetAssignedAssetList(ITAssetDetailsModel iTAssetDetailsModel)
        {
            try
            {
                string sp = "SP_GetAssignedAssetDetails";
                var parameter = new DynamicParameters();
                parameter.Add("HostName", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                parameter.Add("Assettype", iTAssetDetailsModel.AssetType, DbType.String, ParameterDirection.Input);
                parameter.Add("Brand", iTAssetDetailsModel.Brand, DbType.String, ParameterDirection.Input);
                parameter.Add("Model", iTAssetDetailsModel.Model, DbType.String, ParameterDirection.Input);
                parameter.Add("Status", iTAssetDetailsModel.Status, DbType.String, ParameterDirection.Input);
                parameter.Add("Location", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameter.Add("FullName", iTAssetDetailsModel.FullName, DbType.String, ParameterDirection.Input);
                parameter.Add("LastUser", iTAssetDetailsModel.LastUser, DbType.String, ParameterDirection.Input);
                parameter.Add("SerialNumber", iTAssetDetailsModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameter.Add("Country", iTAssetDetailsModel.Country, DbType.String, ParameterDirection.Input);
                parameter.Add("Domain", iTAssetDetailsModel.Domain, DbType.String, ParameterDirection.Input);
                parameter.Add("IDLocations", iTAssetDetailsModel.Remark, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var iTAssetDetailsModel1 = await connection.QueryAsync<ITAssetDetailsModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (iTAssetDetailsModel1 != null)
                    {
                        return iTAssetDetailsModel1.AsList();
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

        public async Task<List<ITAssetDetailsModel>> GetScrappedAssetList(ITAssetDetailsModel iTAssetDetailsModel)
        {
            try
            {
                string sp = "SP_GetScrappedAssetDetails";
                var parameter = new DynamicParameters();
                parameter.Add("HostName", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                parameter.Add("Assettype", iTAssetDetailsModel.AssetType, DbType.String, ParameterDirection.Input);
                parameter.Add("Brand", iTAssetDetailsModel.Brand, DbType.String, ParameterDirection.Input);
                parameter.Add("Model", iTAssetDetailsModel.Model, DbType.String, ParameterDirection.Input);
                parameter.Add("Status", iTAssetDetailsModel.Status, DbType.String, ParameterDirection.Input);
                parameter.Add("Location", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameter.Add("FullName", iTAssetDetailsModel.FullName, DbType.String, ParameterDirection.Input);
                parameter.Add("LastUser", iTAssetDetailsModel.LastUser, DbType.String, ParameterDirection.Input);
                parameter.Add("SerialNumber", iTAssetDetailsModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameter.Add("Country", iTAssetDetailsModel.Country, DbType.String, ParameterDirection.Input);
                parameter.Add("Domain", iTAssetDetailsModel.Domain, DbType.String, ParameterDirection.Input);
                parameter.Add("IDLocations", iTAssetDetailsModel.Remark, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var iTAssetDetailsModel1 = await connection.QueryAsync<ITAssetDetailsModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (iTAssetDetailsModel1 != null)
                    {
                        return iTAssetDetailsModel1.AsList();
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
        public async Task<List<ITAssetDetailsModel>> GetAssignAssetList(ITAssetDetailsModel iTAssetDetailsModel)
        {
            try
            {
                string sp = "SP_SelectAssignAssetList";
                var parameter = new DynamicParameters();
                parameter.Add("UserID", iTAssetDetailsModel.UserID, DbType.Int16, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var iTAssetDetailsModel1 = await connection.QueryAsync<ITAssetDetailsModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (iTAssetDetailsModel1 != null)
                    {
                        return iTAssetDetailsModel1.AsList();
                    }
                    else
                    {
                        return new();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetHostnameDropdownList()
        {
            try
            {
                string? sp = "SP_GetHostnameFromITAssetDetails";
                //var parameter = new DynamicParameters();
                //parameter.Add("Hostname", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetHostname = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetHostname != null)
                    {
                        return ITAssetHostname.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<List<ITAssetDetailsModel>> GetAssetTypeDropdownList()
        {
            try
            {
                string? sp = "SP_GetAssetTypeFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetType = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetType != null)
                    {
                        return ITAssetType.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Assign Dropdowns Starts --------------------------------------------------------------
        public async Task<List<ITAssetDetailsModel>> GetAssetTypeAssign()
        {
            try
            {

                string? sp = "SP_GetAssetTypeAssign";

                using (var connection = _context.CreateConnection())
                {
                    var ITAssetType = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetType != null)
                    {
                        return ITAssetType.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetBrandAssign()
        {
            try
            {

                string? sp = "SP_GetBrandAssign";

                using (var connection = _context.CreateConnection())
                {
                    var ITAssetType = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetType != null)
                    {
                        return ITAssetType.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetModelAssign()
        {
            try
            {

                string? sp = "SP_GetModelAssign";

                using (var connection = _context.CreateConnection())
                {
                    var ITAssetType = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetType != null)
                    {
                        return ITAssetType.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetSerialNoAssign()
        {
            try
            {
                string? sp = "SP_GetSerialNoAssign";

                using (var connection = _context.CreateConnection())
                {
                    var ITAssetType = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetType != null)
                    {
                        return ITAssetType.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetHostNameAssign()
        {
            try
            {
                string? sp = "SP_GetHostNameAssign";

                using (var connection = _context.CreateConnection())
                {
                    var ITAssetType = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetType != null)
                    {
                        return ITAssetType.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Assign Dropdowns Ends --------------------------------------------------------------
        public async Task<List<ITAssetDetailsModel>> GetBrandDropdownList()
        {
            try
            {
                string? sp = "SP_GetBrandFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetBrand = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetBrand != null)
                    {
                        return ITAssetBrand.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetModelDropdownList()
        {
            try
            {
                string? sp = "SP_GetModelFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetModel = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetModel != null)
                    {
                        return ITAssetModel.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<List<ITAssetDetailsModel>> GetUsernameDropdownList()
        {
            try
            {
                string? sp = "SP_GetUsernameFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetUsername = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetUsername != null)
                    {
                        return ITAssetUsername.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetOfficeDropdownList()
        {
            try
            {
                string? sp = "SP_GetOfficeFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetOffice = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetOffice != null)
                    {
                        return ITAssetOffice.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetStatusDropdownList()
        {
            try
            {
                string? sp = "SP_GetStatusFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetOffice = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetOffice != null)
                    {
                        return ITAssetOffice.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetFullNameDropdownList()
        {
            try
            {
                string? sp = "SP_GetFullNameFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetOffice = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetOffice != null)
                    {
                        return ITAssetOffice.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetLastUserDropdownList()
        {
            try
            {
                string? sp = "SP_GetLastUserFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetOffice = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetOffice != null)
                    {
                        return ITAssetOffice.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetSerialNrDropdownList()
        {
            try
            {
                string? sp = "SP_GetSerialNrFromITAssetDetails";
                using (var connection = _context.CreateConnection())
                {
                    var ITAssetOffice = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (ITAssetOffice != null)
                    {
                        return ITAssetOffice.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ResponseModel> SaveITAssetDetails(ITAssetDetailsModel iTAssetDetailsModel)
        {
            string currentUserName = GetUserName();
            try
            {
                var activity = string.Format("ASSET IS CREATED BY {0} ON {1}.", currentUserName.ToUpper(), DateTime.Now);
                ResponseModel responseModel = new();
                string sp = "SP_InsertITAssetDetails";

                var parameters = new DynamicParameters();
               
                parameters.Add("IDAsset", iTAssetDetailsModel.IDAsset, DbType.Int16, ParameterDirection.Input);
                parameters.Add("HostName", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                parameters.Add("AssetType", iTAssetDetailsModel.AssetType, DbType.String, ParameterDirection.Input);
                parameters.Add("Brand", iTAssetDetailsModel.Brand, DbType.String, ParameterDirection.Input);
                parameters.Add("Model", iTAssetDetailsModel.Model, DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", iTAssetDetailsModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameters.Add("PurchaseYear", iTAssetDetailsModel.PurchaseYear, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("IDLocation", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Location", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Region", iTAssetDetailsModel.Region, DbType.String, ParameterDirection.Input);
                parameters.Add("Country", iTAssetDetailsModel.Country, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", iTAssetDetailsModel.Unit?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("CPU", iTAssetDetailsModel.CPU, DbType.String, ParameterDirection.Input);
                parameters.Add("Memory", iTAssetDetailsModel.Memory, DbType.String, ParameterDirection.Input);
                parameters.Add("HDD", iTAssetDetailsModel.HDD, DbType.String, ParameterDirection.Input);
                parameters.Add("OS", iTAssetDetailsModel.OS, DbType.String, ParameterDirection.Input);
                parameters.Add("Software", iTAssetDetailsModel.Software, DbType.String, ParameterDirection.Input);
                parameters.Add("Remark", iTAssetDetailsModel.Remark, DbType.String, ParameterDirection.Input);
                parameters.Add("Domain", iTAssetDetailsModel.Domain, DbType.String, ParameterDirection.Input);
                parameters.Add("Status", "AVAILABLE", DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ActivityLog", activity, DbType.String, ParameterDirection.Input);
                parameters.Add("Monitor", iTAssetDetailsModel.Monitor, DbType.String, ParameterDirection.Input);
                parameters.Add("Keyboard", iTAssetDetailsModel.Keyboard, DbType.String, ParameterDirection.Input);
                parameters.Add("Mouse", iTAssetDetailsModel.Mouse, DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", iTAssetDetailsModel.EmailID, DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", iTAssetDetailsModel.Designation, DbType.String, ParameterDirection.Input);
                parameters.Add("HeadPhone", iTAssetDetailsModel.HeadPhone, DbType.String, ParameterDirection.Input);
                parameters.Add("Department", iTAssetDetailsModel.Department, DbType.String, ParameterDirection.Input);
                parameters.Add("MSOffice", iTAssetDetailsModel.MSOffice, DbType.String, ParameterDirection.Input);
                parameters.Add("LastUser", iTAssetDetailsModel.LastUser, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                using (var connection = _context.CreateConnection())
                {
                    int iTAssetDetailsModel1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;
                    if (isDuplicateFound)
                    {
                        responseModel.Success = false;
                        responseModel.Duplicate = true;
                        
                    }
                    else
                    {
                        string passwordQuery = string.Format("Select IDAsset From ITAssetDetails WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);
                        var iTAssetDetailsModel2 = await connection.QueryFirstOrDefaultAsync<ITAssetDetailsModel>(passwordQuery);
                        if (iTAssetDetailsModel != null)
                        {
                            responseModel.ID = iTAssetDetailsModel2.IDAsset;
                            responseModel.Success = true;
                            string query = "Update ITAssetDetails set IDAssetDis = 'ASD-00" + iTAssetDetailsModel2.IDAsset + "' WHERE IDAsset = " + iTAssetDetailsModel2.IDAsset;
                            _ = await connection.ExecuteAsync(query);
                        }
                        responseModel.Success = true;
                        responseModel.Duplicate = false;
                    }
                };
                return responseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ResponseModel> UpdateITAssetDetails(ITAssetDetailsModel iTAssetDetailsModel)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_UpdateITAssetDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDAsset", iTAssetDetailsModel.IDAsset, DbType.Int16, ParameterDirection.Input);
                parameters.Add("HostName", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                parameters.Add("AssetType", iTAssetDetailsModel.AssetType, DbType.String, ParameterDirection.Input);
                parameters.Add("Brand", iTAssetDetailsModel.Brand ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("Model", iTAssetDetailsModel.Model, DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", iTAssetDetailsModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameters.Add("PurchaseYear", iTAssetDetailsModel.PurchaseYear, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("IDLocation", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", iTAssetDetailsModel.Unit ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("CPU", iTAssetDetailsModel.CPU, DbType.String, ParameterDirection.Input);
                parameters.Add("Memory", iTAssetDetailsModel.Memory, DbType.String, ParameterDirection.Input);
                parameters.Add("HDD", iTAssetDetailsModel.HDD, DbType.String, ParameterDirection.Input);
                parameters.Add("OS", iTAssetDetailsModel.OS, DbType.String, ParameterDirection.Input);
                parameters.Add("Software", iTAssetDetailsModel.Software, DbType.String, ParameterDirection.Input);
                parameters.Add("Remark", iTAssetDetailsModel.Remark, DbType.String, ParameterDirection.Input);
                parameters.Add("Domain", iTAssetDetailsModel.Domain, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Monitor", iTAssetDetailsModel.Monitor, DbType.String, ParameterDirection.Input);
                parameters.Add("Keyboard", iTAssetDetailsModel.Keyboard, DbType.String, ParameterDirection.Input);
                parameters.Add("Mouse", iTAssetDetailsModel.Mouse, DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", iTAssetDetailsModel.EmailID, DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", iTAssetDetailsModel.Designation, DbType.String, ParameterDirection.Input);
                parameters.Add("Department", iTAssetDetailsModel.Department, DbType.String, ParameterDirection.Input);
                parameters.Add("HeadPhone", iTAssetDetailsModel.HeadPhone, DbType.String, ParameterDirection.Input);
                parameters.Add("MSOffice", iTAssetDetailsModel.MSOffice, DbType.String, ParameterDirection.Input);
                parameters.Add("LastUser", iTAssetDetailsModel.LastUser, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                using (var connection = _context.CreateConnection())
                {
                    var iTAssetDetailsModel1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;

                    if (isDuplicateFound)
                    {
                        responseModel.Success = false;
                        responseModel.Duplicate = true;
                    }
                    else
                    {
                        if (iTAssetDetailsModel1 == 1)
                        {
                            responseModel.Success = true;
                            responseModel.Duplicate = false;
                        }
                    }
                };
                return responseModel;
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
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> GetITAssetCount(int id)
        {
            try
            {
                var parameter1 = new DynamicParameters();
                parameter1.Add("parameter", id, DbType.Int16, ParameterDirection.Input);
                string sp = "SP_GetITAssetCount";
                using (var connection = _context.CreateConnection())
                {
                    int itAssetCount = await connection.QueryFirstOrDefaultAsync<int>(sp, parameter1, commandType: CommandType.StoredProcedure);
                    return itAssetCount;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> AddAssignDetails(ITAssetDetailsModel iTAssetDetailsModel)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_InsertAssignData";

                var parameters = new DynamicParameters();
                parameters.Add("UserID", iTAssetDetailsModel.FullName, DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", iTAssetDetailsModel.SerialNumber, DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName, DbType.String, ParameterDirection.Input);
 
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
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> LastUserValue(int userID , string SerialNr)
        {
            try
            {
                var parameter = new DynamicParameters();
                parameter.Add("UserID", userID, DbType.Int16, ParameterDirection.Input);
                parameter.Add("SerialNR", SerialNr, DbType.String, ParameterDirection.Input);

                string SP = "SP_AddLastUserName";
                using (var connection = _context.CreateConnection())
                {
                    int dataDeleted = await connection.ExecuteAsync(SP, parameter, commandType: CommandType.StoredProcedure);
                    if (dataDeleted == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> DeleteAssignedAssetByUserID(int userID, string SerialNr)
        {
            try
            {
                var parameter = new DynamicParameters();
                parameter.Add("UserID", userID, DbType.Int16, ParameterDirection.Input);
                parameter.Add("SerialNR", SerialNr, DbType.String, ParameterDirection.Input);

                string SP = "SP_DeleteUserAsset";
                using (var connection = _context.CreateConnection())
                {
                    int dataDeleted = await connection.ExecuteAsync(SP, parameter, commandType: CommandType.StoredProcedure);
                    if (dataDeleted == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> GetStatusITAsset(ITAssetDetailsModel iTAssetDetailsModel)
        {
            try
            {
                string sp = "SP_GetStatusFromITAsset";

                var parameters = new DynamicParameters();
                parameters.Add("IDAsset", iTAssetDetailsModel.IDAsset, DbType.Int16, ParameterDirection.Input);
                parameters.Add("Status", iTAssetDetailsModel.Status, DbType.String, ParameterDirection.Input);

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
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> UpdateAssetStatus(string SerialNr, string Status, int UserID)
        {
            string currentUserName = GetUserName();
            try
            {
                string SP = "SP_UpdateStatusAfterAssign";

                var parameter = new DynamicParameters();

                parameter.Add("IDUser", UserID, DbType.String, ParameterDirection.Input);
                parameter.Add("Status", Status, DbType.String, ParameterDirection.Input);
                parameter.Add("SerialNr", SerialNr, DbType.String, ParameterDirection.Input);
                parameter.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameter.Add("ActivityLog", currentUserName, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int userDetails1 = await connection.ExecuteAsync(SP, parameter, commandType: CommandType.StoredProcedure);
                    if (userDetails1 == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> UpdateActivitiLogDetails(int ID, string msg)
        {
            try
            {
                var parameter = new DynamicParameters();
                parameter.Add("ActivityLog", msg, DbType.String, ParameterDirection.Input);
                parameter.Add("IDAsset", ID, DbType.Int16, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    string query1 = string.Format("UPDATE ITAssetDetails SET ActivityLog = '{0}' + ActivityLog  WHERE IDAsset = '{1}'", msg, ID);
                    var iTAssetDetailsModel2 = await connection.ExecuteAsync(query1);
                    if (iTAssetDetailsModel2 == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ITAssetDetailsModel> GeTAssetCountByRegion(string region)
        {
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    string query1 = string.Format("SELECT COUNT(AssetType) from ITAssetDetails WHERE AssetType = 'LAPTOP' AND Region = '{0}'", region);
                    string query2 = string.Format("SELECT COUNT(AssetType) from ITAssetDetails WHERE AssetType = 'DESKTOP' AND Region = '{0}'", region);
                    var Laptops = await connection.QueryFirstOrDefaultAsync<int>(query1);
                    var DeskTops = await connection.QueryFirstOrDefaultAsync<int>(query2);

                    ITAssetDetailsModel iTAssetDetailsModel = new();

                    iTAssetDetailsModel.IDAssign = Laptops;
                    iTAssetDetailsModel.IDAsset = DeskTops;

                    return iTAssetDetailsModel;

                };
            }
            catch (Exception)
            {
                throw;

            }
        }
        public async Task<List<ITAssetDetailsModel>> GetCountryFinal()
        {
            try
            {
                string sp = "SP_GetCountryfromITAsset";
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<ITAssetDetailsModel>> GetDomainFinal()
        {
            try
            {
                string sp = "SP_GetDomainfromITAsset";
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<ITAssetDetailsModel>(sp, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<ITAssetDetailsModel>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> DeleteITAssetDetails(int IDAsset)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteITAssetDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDAsset", IDAsset, DbType.Int16, ParameterDirection.Input);
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
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ResponseModel> TransferedToAnotherSystem(ITAssetDetailsModel iTAssetDetailsModel)
        {
            string currentUserName = GetUserName();
            try
            {
                var activity = string.Format("ASSET IS CREATED BY {0} ON {1}.", currentUserName.ToUpper(), DateTime.Now);
                ResponseModel responseModel = new();
                string sp = "SP_InsertITAssetDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDAsset", iTAssetDetailsModel.IDAsset, DbType.String, ParameterDirection.Input);
                parameters.Add("IDLocation", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("HostName", iTAssetDetailsModel.HostName, DbType.String, ParameterDirection.Input);
                parameters.Add("AssetType", iTAssetDetailsModel.AssetType, DbType.String, ParameterDirection.Input);
                parameters.Add("Brand", iTAssetDetailsModel.Brand, DbType.String, ParameterDirection.Input);
                parameters.Add("Model", iTAssetDetailsModel.Model, DbType.String, ParameterDirection.Input);
                parameters.Add("SerialNumber", iTAssetDetailsModel.SerialNumber ?? string.Empty.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("PurchaseYear", iTAssetDetailsModel.PurchaseYear, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("Unit", iTAssetDetailsModel.Unit, DbType.String, ParameterDirection.Input);
                parameters.Add("CPU", iTAssetDetailsModel.CPU, DbType.String, ParameterDirection.Input);
                parameters.Add("Memory", iTAssetDetailsModel.Memory, DbType.String, ParameterDirection.Input);
                parameters.Add("HDD", iTAssetDetailsModel.HDD, DbType.String, ParameterDirection.Input);
                parameters.Add("OS", iTAssetDetailsModel.OS, DbType.String, ParameterDirection.Input);
                parameters.Add("Software", iTAssetDetailsModel.Software, DbType.String, ParameterDirection.Input);
                parameters.Add("Remark", iTAssetDetailsModel.Remark, DbType.String, ParameterDirection.Input);
                parameters.Add("Status", "AVAILABLE", DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ActivityLog", activity, DbType.String, ParameterDirection.Input);
                parameters.Add("Region", iTAssetDetailsModel.Region, DbType.String, ParameterDirection.Input);
                parameters.Add("Location", iTAssetDetailsModel.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Country", iTAssetDetailsModel.Country, DbType.String, ParameterDirection.Input);
                parameters.Add("LastUser", iTAssetDetailsModel.LastUser, DbType.String, ParameterDirection.Input);
                parameters.Add("Monitor", iTAssetDetailsModel.Monitor, DbType.String, ParameterDirection.Input);
                parameters.Add("Keyboard", iTAssetDetailsModel.Keyboard, DbType.String, ParameterDirection.Input);
                parameters.Add("Mouse", iTAssetDetailsModel.Mouse, DbType.String, ParameterDirection.Input);
                parameters.Add("MSOffice", iTAssetDetailsModel.MSOffice, DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", iTAssetDetailsModel.EmailID, DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", iTAssetDetailsModel.Designation, DbType.String, ParameterDirection.Input);
                parameters.Add("HeadPhone", iTAssetDetailsModel.HeadPhone, DbType.String, ParameterDirection.Input);
                parameters.Add("Department", iTAssetDetailsModel.Department, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);

                using (var connection = _context.CreateConnectionNew())
                {
                    int iTAssetDetailsModel1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;
                    if (isDuplicateFound)
                    {
                        responseModel.Success = false;
                        responseModel.Duplicate = true;

                    }
                    else
                    {
                        string passwordQuery = string.Format("Select IDAsset From ITAssetDetails WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);
                        var iTAssetDetailsModel2 = await connection.QueryFirstOrDefaultAsync<ITAssetDetailsModel>(passwordQuery);
                        if (iTAssetDetailsModel != null)
                        {
                            responseModel.ID = iTAssetDetailsModel2.IDAsset;
                            responseModel.Success = true;
                            string query = "Update ITAssetDetails set IDAssetDis = 'ASD-00" + iTAssetDetailsModel2.IDAsset + "' WHERE IDAsset = " + iTAssetDetailsModel2.IDAsset;
                            _ = await connection.ExecuteAsync(query);
                        }
                        responseModel.Success = true;
                        responseModel.Duplicate = false;
                    }
                };
                return responseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> TransferedAndDeleted(ITAssetDetailsModel iTAssetDetailsModel)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteITAssetDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDAsset", iTAssetDetailsModel.IDAsset, DbType.Int16, ParameterDirection.Input);
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
                };
            }
            catch (Exception)
            {
                throw;

            }
        }
        public async Task<string> GetAssetID(string SerialNumber)
        {
            try
            {
                string query = string.Format("select distinct(IDAsset) from ITAssetDetails where SerialNumber = '{0}'", SerialNumber);

                using (var connection = _context.CreateConnection())
                {
                    var ITAssetData = await connection.QueryFirstOrDefaultAsync<string>(query);
                    return ITAssetData;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> GetRemark(string IDAsset)
        {
            try
            {
                string query = string.Format("select distinct(Remark) from ITAssetDetails where IDAsset = '{0}'", IDAsset);

                using (var connection = _context.CreateConnection())
                {
                    var Remark = await connection.QueryFirstOrDefaultAsync<string>(query);
                    return Remark;
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