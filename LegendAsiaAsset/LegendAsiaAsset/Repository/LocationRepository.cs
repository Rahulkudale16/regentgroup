using Dapper;
using System.Data;
using LegendAsiaAsset.Contracts;
using System.Security.Claims;
using LegendAsiaAsset.Context;
using LegendAsiaAsset.Models;
using LegendAsiaAsset.Data;
using Microsoft.VisualBasic;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace LegendAsiaAsset.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DapperContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        public LocationRepository(DapperContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }
        private string GetUserName()
        {
            var claimName = _contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Name);
            string? currentUserName = claimName?.Value;
            return currentUserName ?? string.Empty;
        }
        public async Task<List<LocationModel>> GetLocationList(LocationModel locationModel)
        {
            try
            {
                string sp = "SP_SelectLocationList";
                var parameter = new DynamicParameters();
                parameter.Add("Region", locationModel.Region, DbType.String, ParameterDirection.Input);
                parameter.Add("Country", locationModel.Country, DbType.String, ParameterDirection.Input);
                parameter.Add("Location", locationModel.Location, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var locationModel1 = await connection.QueryAsync<LocationModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (locationModel1 != null)
                    {
                        return locationModel1.AsList();
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
        public async Task<List<LocationModel>> GetRegionFromLocation()
        {
            try
            {
                string sp = "SP_GetRegionFromLocation";
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<LocationModel>(sp, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<LocationModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<LocationModel>> GetCountryFromLocation()
        {
            try
            {
                string sp = "SP_GetCountryFromLocation";
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<LocationModel>(sp, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<LocationModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<LocationModel>> GetLocationFromLocation(string Region)
        {
            try
            {
                string sp = "SP_GetLocationFromLocation1";
                var parameter = new DynamicParameters();
                parameter.Add("CountryData", Region, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<LocationModel>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<LocationModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<LocationModel>> GetLocationFromLocation1()
        {
            try
            {
                string sp = "SP_GetLocationFromLocation";
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<LocationModel>(sp, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<LocationModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<LocationModel>> GetLocationFinal()
        {
            try
            {
                string sp = "SP_GetLocationFromLocation3";
                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<LocationModel>(sp, commandType: CommandType.StoredProcedure);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<LocationModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ResponseModel> SaveLocation(LocationModel locationModel)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertUpdateLocation2";

                var parameters = new DynamicParameters();
                parameters.Add("IDLocation", locationModel.IDLocation, DbType.Int16, ParameterDirection.Input);
                parameters.Add("Region", locationModel.Region.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Country", locationModel.Country.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Location", locationModel.Location.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreationTimeStamp", locationModel.CreationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", locationModel.CreationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                parameters.Add("Status", "ACTIVE", DbType.String, ParameterDirection.Input);

                using (var connection = _context.CreateConnection())
                {
                    //
                    //string query2 = "SELECT count(*) from Location where Region ='" + locationModel.Region + "' and Country = '" + locationModel.Country + "' and Location = '" + locationModel.Location +"'";
                    //var duplicatelocation = await connection.QueryFirstOrDefaultAsync<int>(query2, parameters);
                    //if (duplicatelocation > 0)
                    //{
                    //    responseModel.Duplicate = true;
                    // //
                    //}
                    //else
                    //{


                    var locationModel1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    //bool isDuplicateFound = Convert.ToBoolean(parameters.Get<bool>("@IsDuplicateFound"));


                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;

                    if (isDuplicateFound)
                    {

                        responseModel.Success = false;
                        responseModel.Duplicate = true;
                        //responseModel.ResponseMessage = "DUPLICATE RECORD FOUND";
                        //

                        //string sp2 = "SP_CheckForDuplicateLocation";
                        //var parameters2 = new DynamicParameters();
                        //parameters2.Add("Region", locationModel.Region, DbType.String, ParameterDirection.Input);
                        //parameters2.Add("Country", locationModel.Country, DbType.String, ParameterDirection.Input);
                        //parameters2.Add("Location", locationModel.Location, DbType.String, ParameterDirection.Input);
                        //using (var connection2 = _context.CreateConnection())
                        //{
                        //    int locationmodel3 = await connection2.ExecuteAsync(sp2, parameters2, commandType: CommandType.StoredProcedure);
                        //    if (locationmodel3 == -1)
                        //    {
                        //        responseModel.Duplicate = true;
                        //        responseModel.ResponseMessage = string.Format(Constant.LocationDuplicateMessage, locationModel.Location);
                        //    }
                        //}

                    }
                    else
                    {

                        //
                        string LocationQuery = string.Format("Select IDLocation From Location WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);

                        var locationModel2 = await connection.QueryFirstOrDefaultAsync<LocationModel>(LocationQuery);
                        if (locationModel != null)
                        {
                            responseModel.ID = locationModel2.IDLocation;
                            responseModel.Success = true;
                            string query = "Update Location set IDLocationDis = 'LOC-00" + locationModel2.IDLocation + "' WHERE IDLocation = " + locationModel2.IDLocation;
                            _ = await connection.ExecuteAsync(query);
                        }
                        responseModel.Success = true;
                        responseModel.Duplicate = false;
                        //responseModel.ResponseMessage = "RECORD SAVED SUCCESSFULLY";

                    }
                    //}
                }
                ;
                return responseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ResponseModel> UpdateLocation(LocationModel locationModel)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertUpdateLocation2";

                var parameters = new DynamicParameters();
                parameters.Add("IDLocation", locationModel.IDLocation, DbType.Int16, ParameterDirection.Input);
                parameters.Add("Region", locationModel.Region.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Country", locationModel.Country.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Location", locationModel.Location.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreationTimeStamp", locationModel.CreationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", locationModel.CreationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                parameters.Add("Status", locationModel.Status?.ToUpper(), DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int userDetails1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);

                    int isDuplicateFoundInt = parameters.Get<int>("@IsDuplicateFound"); // Convert INT value to
                    bool isDuplicateFound = isDuplicateFoundInt == 1 ? true : false;

                    if (isDuplicateFound)
                    {

                        responseModel.Success = false;
                        responseModel.Duplicate = true;
                    }
                    else
                    {
                        if (userDetails1 == 1)
                        {
                            responseModel.Success = true;
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
        public async Task<List<string>> GetCoutriesData(string regionName)
        {

            try
            {
                string query = string.Format("select distinct(Country) from Location");

                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<string>(query);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<string>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<string>> GetLocationData(string countryName)
        {

            try
            {
                string query = string.Format("select distinct(Location) from Location where Country = '{0}' AND Status = 'ACTIVE'", countryName);

                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<string>(query);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<string>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<LocationModel>> GetLocationID(string Region, string Country, string Location1)
        {

            try
            {
                string query = string.Format("select IDLocation from Location");
                if (!string.IsNullOrEmpty(Region) || !string.IsNullOrEmpty(Country) || !string.IsNullOrEmpty(Location1))
                {
                    query += " where";
                    if (!string.IsNullOrEmpty(Region))
                    {
                        query += string.Format(" Region = '{0}' AND", Region);
                    }
                    if (!string.IsNullOrEmpty(Country))
                    {
                        query += string.Format(" Country = '{0}' AND", Country);
                    }
                    if (!string.IsNullOrEmpty(Location1))
                    {
                        query += string.Format(" Location = '{0}' AND", Location1);
                    }
                    if (query.LastIndexOf("AND") > 0)
                    {
                        query = query.Remove(query.LastIndexOf("AND"));
                    }
                }

                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryAsync<LocationModel>(query);
                    if (locationDetails != null)
                    {
                        return locationDetails.AsList();
                    }
                    else
                    {
                        return new List<LocationModel>();
                    }
                }
                ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> GetStatusLoc(LocationModel locationModel)
        {
            try
            {
                string sp = "SP_GetStatusFromLocation";

                var parameters = new DynamicParameters();
                parameters.Add("IDLocation", locationModel.IDLocation, DbType.Int16, ParameterDirection.Input);
                parameters.Add("Status", locationModel.Status, DbType.String, ParameterDirection.Input);

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
        public async Task<string> GetLocationID(string Location)
        {
            try
            {
                string query = string.Format("select distinct(IDLocation) from Location where Location = '{0}' AND Status = 'ACTIVE'", Location);

                using (var connection = _context.CreateConnection())
                {
                    var locationDetails = await connection.QueryFirstOrDefaultAsync<string>(query);
                    return locationDetails;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
