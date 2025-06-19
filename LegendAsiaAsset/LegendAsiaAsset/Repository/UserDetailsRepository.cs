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
using DocumentFormat.OpenXml.Office2010.Excel;

namespace LegendAsiaAsset.Repository
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly DapperContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserDetailsRepository(DapperContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }
        public async Task<bool> GetValidUser(UserDetails userDetails)
        {
            string? currentUserName = GetUserName();
            try
            {
                string sp = "SP_FindUsernamePassword";
                //    string query = "Select \"UserName\", Password from UserAccountManagement where upper(\"UserName\") = ? AND Status = 'ACTIVE'";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Password", userDetails.Password, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    //var valid = await connection.QueryFirstOrDefaultAsync<UserDetails>(query, parameters);
                    var valid = await connection.QueryFirstOrDefaultAsync<UserDetails>(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (valid != null)
                    {
                        string dbUserName = valid.UserName ?? string.Empty;
                        string dbpassword = valid.Password ?? string.Empty;

                        if (dbUserName.ToUpper() == userDetails.UserName && dbpassword == userDetails.Password)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
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
        public async Task<UserDetails> GetUserDetailsFromName(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_FindUsernamePassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Password", userDetails.Password, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var valid1 = await connection.QueryFirstOrDefaultAsync<UserDetails>(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (valid1 != null)
                    {
                        return valid1;
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
        private string GetUserName()
        {
            var claimName = _contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Name);
            string? currentUserName = claimName?.Value;
            return currentUserName ?? string.Empty;
        }
        private string GetRole()
        {
            var claimName = _contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Role);
            string? currentUserName = claimName?.Value;
            return currentUserName ?? string.Empty;
        }
        public async Task<List<UserDetails>> GetUserList(UserDetails userDetails)
        {
            try
            {
                string sp = "SP_SelectUserList";

                var parameter = new DynamicParameters();
                parameter.Add("Role", userDetails.Role, DbType.String, ParameterDirection.Input);
                parameter.Add("Department", userDetails.Department, DbType.String, ParameterDirection.Input);
                parameter.Add("Designation", userDetails.Designation, DbType.String, ParameterDirection.Input);
                parameter.Add("UserName", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameter.Add("Location", userDetails.Location, DbType.String, ParameterDirection.Input);
                parameter.Add("EmailID", userDetails.EmailID, DbType.String, ParameterDirection.Input);
                parameter.Add("Domain", userDetails.Domain, DbType.String, ParameterDirection.Input);
                parameter.Add("Status", userDetails.Status, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var userDetails1 = await connection.QueryAsync<UserDetails>(sp, parameter, commandType: CommandType.StoredProcedure);
                    if (userDetails1 != null)
                    {
                        return userDetails1.AsList();
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
        public async Task<List<UserDetails>> GetRoleFromUserDetails()
        {
            try
            {
                string sp = "SP_GetRoleFromUserDetails";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryAsync<UserDetails>(sp, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails.AsList();
                    }
                    else
                    {
                        return new List<UserDetails>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<UserDetails>> GetDepartmentFromUserDetails()
        {
            try
            {
                string sp = "SP_GetDepartmentFromUserDetails";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryAsync<UserDetails>(sp, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails.AsList();
                    }
                    else
                    {
                        return new List<UserDetails>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<UserDetails>> GetDesignationUserDetails()
        {
            try
            {
                string sp = "SP_GetDesignationFromUserDetails";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryAsync<UserDetails>(sp, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails.AsList();
                    }
                    else
                    {
                        return new List<UserDetails>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<UserDetails>> GetEmailIDUserDetails()
        {
            try
            {
                string sp = "SP_GetEmailIDFromUserDetails";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryAsync<UserDetails>(sp, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails.AsList();
                    }
                    else
                    {
                        return new List<UserDetails>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<UserDetails>> GetFullNameUserDetails()
        {
            try
            {
                string sp = "SP_GetFullNameFromUserDetails";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryAsync<UserDetails>(sp, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails.AsList();
                    }
                    else
                    {
                        return new List<UserDetails>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<UserDetails>> GetUserNameUserDetails()
        {
            try
            {
                string sp = "SP_GetUserNameFromUserDetails";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryAsync<UserDetails>(sp, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails.AsList();
                    }
                    else
                    {
                        return new List<UserDetails>();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ResponseModel> SaveUserDetails(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertUpdateUserDetails1";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
                parameters.Add("FullName", userDetails.FullName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Role", userDetails.Role.ToUpper() ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("Department", userDetails.Department.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", userDetails.Designation.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("UserName", userDetails.UserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("IDLocation", userDetails.IDLocation, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", userDetails.Unit?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Domain", userDetails.Domain?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Status", "ACTIVE", DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", userDetails.EmailID ?? string.Empty.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Password", userDetails.Password, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", userDetails.ModificationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
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
                        string passwordQuery = string.Format("Select IDUser ,Password From UserDetails WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);

                        var userDetails2 = await connection.QueryFirstOrDefaultAsync<UserDetails>(passwordQuery);
                        if (userDetails != null)
                        {

                            responseModel.ID = userDetails2.IDUser;
                            responseModel.Password = userDetails2.Password;
                            responseModel.Success = true;
                            string query = "Update UserDetails set IDUserDis = 'USR-00" + userDetails2.IDUser + "' WHERE IDUser  = " + userDetails2.IDUser;
                            _ = await connection.ExecuteAsync(query);
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
        public async Task<ResponseModel> UpdateUserDetails(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_UpdateUserDetails"; 

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
                parameters.Add("FullName", userDetails.FullName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Role", userDetails.Role.ToUpper() , DbType.String, ParameterDirection.Input);
                parameters.Add("Department", userDetails.Department.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", userDetails.Designation.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("UserName", userDetails.UserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("IDLocation", userDetails.IDLocation, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", userDetails.Unit, DbType.String, ParameterDirection.Input);
                parameters.Add("Domain", userDetails.Domain?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Status", userDetails.Status?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", userDetails.EmailID.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Password", userDetails.Password?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", userDetails.ModificationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
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
        public async Task<bool> UpdateAssetDetails(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_UpdateAssetDetailsfromUser";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
                parameters.Add("FullName", userDetails.FullName.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Department", userDetails.Department.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", userDetails.Designation.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Domain", userDetails.Domain?.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", userDetails.EmailID.ToUpper(), DbType.String, ParameterDirection.Input);
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
        public async Task<bool> DeleteUserDetails(int IDUser)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteUserDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", IDUser, DbType.Int16, ParameterDirection.Input);
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
        public async Task<bool> DeleteAssignAssetDetails(int IDUser)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteAssignAssetDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", IDUser, DbType.Int16, ParameterDirection.Input);
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
        public async Task<ResponseModel> ResetUserDetails(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertUpdateUserDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
                parameters.Add("FullName", userDetails.FullName, DbType.String, ParameterDirection.Input);
                parameters.Add("Role", userDetails.Role ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("Department", userDetails.Department, DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", userDetails.Designation, DbType.String, ParameterDirection.Input);
                parameters.Add("UserName", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("IDLocation", userDetails.Location, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", userDetails.Unit ?? string.Empty.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Status", "RESET", DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", userDetails.EmailID?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Password", userDetails.Password?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", userDetails.ModificationTimeStamp, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int userDetails1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (userDetails1 == 1)
                    {
                        string passwordQuery = string.Format("Select IDUser ,Password,UserName,EmailID From UserDetails WHERE IDUser = {0} ORDER BY CreationTimeStamp", userDetails.IDUser);

                        var userDetails2 = await connection.QueryFirstOrDefaultAsync<UserDetails>(passwordQuery);
                        responseModel.UserName = userDetails2.UserName;
                        responseModel.EmailID = userDetails2.EmailID;
                        responseModel.Password = userDetails2.Password;
                        responseModel.Success = true;

                        return responseModel;
                    }
                    else
                    {
                        responseModel.Success = false;
                        return responseModel;
                    }
                };
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
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> GetUserCount(int id)
        {
            try
            {
                var parameter1 = new DynamicParameters();
                parameter1.Add("parameter", id, DbType.Int16, ParameterDirection.Input);
                string sp = "SP_GetUserCount";
                using (var connection = _context.CreateConnection())
                {
                    int userCount = await connection.QueryFirstOrDefaultAsync<int>(sp, parameter1, commandType: CommandType.StoredProcedure);
                    return userCount;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> GetStatusUD(UserDetails userDetails)
        {
            try
            {
                string sp = "SP_GetStatusFromUserDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
                parameters.Add("Status", userDetails.Status, DbType.String, ParameterDirection.Input);

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
        public async Task<bool> SaveFile(UserDetails userDetails)  //30/10
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_InsertUpdateUserDocuments";
                var parameters = new DynamicParameters();
                parameters.Add("IDDoc", userDetails.IDDoc, DbType.Int16, ParameterDirection.Input);
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
                parameters.Add("DocType", userDetails.DocType, DbType.String, ParameterDirection.Input);
                parameters.Add("DocName", userDetails.DocName, DbType.String, ParameterDirection.Input);
                parameters.Add("ContentType", userDetails.ContentType, DbType.String, ParameterDirection.Input);
                parameters.Add("DocSize", userDetails.DocSize, DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int userfile = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (userfile == 1)
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
        public async Task<List<UserDetails>> GetFiles(int IDUser)
        {
            string currentUserName = GetUserName();
            string currentRole = GetRole();
            try
            {
                string sp = "SP_GetDocUploadData";
                var parameters = new DynamicParameters();
                parameters.Add("IDUser", IDUser, DbType.Int16, ParameterDirection.Input);
                //parameters.Add("CreatedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Role", currentRole, DbType.String, ParameterDirection.Input);


                using (var connection = _context.CreateConnection())
                {
                    var userDetails1 = await connection.QueryAsync<UserDetails>(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (userDetails1 != null)
                    {
                        return userDetails1.AsList();
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
        public async Task<List<UserDetails>> GetFileNameByID(List<int> AllData)
        {
            string currentUserName = GetUserName();

            List<UserDetails> userDetailList = new List<UserDetails>();
            try
            {
                foreach (var fileID in AllData)
                {
                    string sp = "SP_GetDocNameByID";
                    var parameters = new DynamicParameters();
                    parameters.Add("IDDoc", fileID, DbType.Int16, ParameterDirection.Input);
                    //string queryVessel = "SELECT FileName FROM ShipmentFileUpload WHERE IDShipmentFile = ?";
                    using (var connection = _context.CreateConnection())
                    {
                        var fileData = await connection.QueryFirstOrDefaultAsync<UserDetails>(sp, parameters, commandType: CommandType.StoredProcedure);
                        if (fileData != null)
                        {
                            userDetailList.Add(fileData);
                        }
                    };
                }

            }
            catch (Exception)
            {
                //string errorMessage = string.Format(Constants.ErrorMessage, DateTime.Now);
                //LogModel logModel = ObjectTranslation.ConvertErrorLog(string.Empty, Environment.StackTrace, Constants.ShipmentFileUpload, Constants.Error,
                //           Constants.Select, errorMessage, currentUserName, ex.Message);
                //_ = await _logging.LogError(logModel);
                throw;
            }
            return userDetailList;
        }
        public async Task<bool> DeleteFile(UserDetails userDetails)
        {
            string? currentUserName = GetUserName();
            try
            {
                //using (var connection = _context.CreateConnection())
                //{
                string sp = "DeleteFromUserDocumemntsByID";
                var parameters = new DynamicParameters();
                parameters.Add("IDDoc", userDetails.IDDoc, DbType.String, ParameterDirection.Input);

                using (var connection = _context.CreateConnection())
                {
                    var fileData = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (fileData == 1)
                    {
                        return true;
                        //return true;
                    }
                    else
                    {
                        return false;
                    }
                };

                //string idQuery = "Delete from userdocuments where IDDoc = ?";

                //var id = await connection.QueryFirstOrDefaultAsync<string>(idQuery, parameters);                    

                //int rowsAffected = await connection.ExecuteAsync(idQuery,parameters);

                //if (rowsAffected > 0)
                //{
                //string? message = string.Format(Constants.SuccessDeleteShipmentFile, currentUserName, fileName, universalSerialNr, DateTime.Now);
                //LogModel logModel = ObjectTranslation.ConvertInfoLog(id, Environment.StackTrace, Constants.ShipmentFileUpload, Constants.Info, Constants.Delete, message, currentUserName);
                //_ = await _logging.LogInfo(logModel);
                //return true;
                //}
                //else
                //{
                //string? message = string.Format(Constants.ErrorDeleteShipmentFile, currentUserName, fileName, universalSerialNr, DateTime.Now);
                //LogModel logModel = ObjectTranslation.ConvertInfoLog(id, Environment.StackTrace, Constants.ShipmentFileUpload, Constants.Info, Constants.Delete, message, currentUserName);
                //_ = await _logging.LogInfo(logModel);
                //return false;
                //}
                //};
            }
            catch (Exception)
            {
                //string errorMessage = string.Format(Constants.ErrorMessage, DateTime.Now);
                //LogModel logModel = ObjectTranslation.ConvertErrorLog(string.Empty, Environment.StackTrace, Constants.ShipmentFileUpload, Constants.Error,
                //Constants.Select, errorMessage, currentUserName, ex.Message);
                //_ = await _logging.LogError(logModel);
                throw;
            }
        }
        public async Task<UserDetails> GetUserDetailsById(int id)
        {
            try
            {
                var parameter1 = new DynamicParameters();
                parameter1.Add("IDUser", id, DbType.Int16, ParameterDirection.Input);
                string sp = "SP_GetUserDetailsByID";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryFirstOrDefaultAsync<UserDetails>(sp, parameter1, commandType: CommandType.StoredProcedure);
                    if (userDetails != null)
                    {
                        return userDetails;
                    }
                    else
                    {
                        return new UserDetails();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<UserDetails>> GetAdminEmailID()
        {
            //List<UserDetails> AdminMailList = new List<UserDetails>();
            try
            {
                string sp = "SP_GetAdminEmailID";
                var parameters = new DynamicParameters();
                using (var connection = _context.CreateConnection())
                {
                    var valid1 = await connection.QueryAsync<UserDetails>(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (valid1 != null)
                    {
                        return valid1.AsList();
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
        public async Task<string> GetContentTypeByDocName(string DocName)
        {
            try
            {
                string sp = "SP_GetContentTypeByDocName";
                var parameters = new DynamicParameters();
                parameters.Add("DocName", DocName, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    var FileContentType = await connection.QueryFirstOrDefaultAsync<string>(sp, parameters, commandType: CommandType.StoredProcedure);
                    //if (FileContentType != null)
                    //{
                        return FileContentType;
                    //}
                    //else
                    //{
                       // return ;
                    //}
                };
            }
            catch(Exception)
            {
                throw;
            }
        }
        public async Task<bool> UpdateDocType(UserDetails userDetails)
        {
            string? currentUserName = GetUserName();

            try
            {
                string sp = "SP_UpdateDocTypeInUserDocuments";
                var parameters = new DynamicParameters();
                parameters.Add("IDDoc", userDetails.IDDoc, DbType.Int16, ParameterDirection.Input);
                parameters.Add("DocType", userDetails.DocType, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedOn", userDetails.ModificationTimeStamp, DbType.DateTime, ParameterDirection.Input);

                using (var connection = _context.CreateConnection())
                {

                    int rowsAffected = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (rowsAffected > 0)
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
        public async Task<ResponseModel> TransferUserDetails(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_InsertUpdateUserDetails1";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", null, DbType.Int16, ParameterDirection.Input);
                parameters.Add("FullName", userDetails.FullName, DbType.String, ParameterDirection.Input);
                parameters.Add("Role", userDetails.Role ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("Department", userDetails.Department, DbType.String, ParameterDirection.Input);
                parameters.Add("Designation", userDetails.Designation, DbType.String, ParameterDirection.Input);
                parameters.Add("UserName", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("IDLocation", userDetails.IDLocation, DbType.String, ParameterDirection.Input);
                parameters.Add("Unit", userDetails.Unit ?? string.Empty.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("Status", userDetails.Status, DbType.String, ParameterDirection.Input);
                //parameters.Add("Domain", userDetails.Domain ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", userDetails.EmailID ?? string.Empty.ToUpper(), DbType.String, ParameterDirection.Input);
                parameters.Add("CreatedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", currentUserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Password", userDetails.Password, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", userDetails.ModificationTimeStamp, DbType.String, ParameterDirection.Input);
                parameters.Add("IsDuplicateFound", DbType.Boolean, direction: ParameterDirection.Output);
                using (var connection = _context.CreateConnectionNew())
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
                        string passwordQuery = string.Format("Select IDUser ,Password From UserDetails WHERE CreatedBy = '{0}' ORDER BY CreationTimeStamp DESC", currentUserName);

                        var userDetails2 = await connection.QueryFirstOrDefaultAsync<UserDetails>(passwordQuery);
                        if (userDetails != null)
                        {

                            responseModel.ID = userDetails2.IDUser;
                            responseModel.Password = userDetails2.Password;
                            responseModel.Success = true;
                            string query = "Update UserDetails set IDUserDis = 'USR-00" + userDetails2.IDUser + "' WHERE IDUser  = " + userDetails2.IDUser;
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
        public async Task<bool> TransferedAndDeletedUser(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                string sp = "SP_DeleteUserDetails";

                var parameters = new DynamicParameters();
                parameters.Add("IDUser", userDetails.IDUser, DbType.Int16, ParameterDirection.Input);
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
        // 20/08/2024
        public async Task<ResponseModel> OTPDetails(UserDetails userDetails)
        {
            string currentUserName = GetUserName();
            try
            {
                ResponseModel responseModel = new();
                string sp = "SP_OTPUserDetails";

                var parameters = new DynamicParameters();
                parameters.Add("OTP", userDetails.OTP, DbType.Int32, ParameterDirection.Input);
                parameters.Add("Status", "OTP", DbType.String, ParameterDirection.Input);
                parameters.Add("EmailID", userDetails.EmailID ?? string.Empty, DbType.String, ParameterDirection.Input);
                parameters.Add("ModifiedBy", userDetails.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("ModificationTimeStamp", userDetails.ModificationTimeStamp, DbType.String, ParameterDirection.Input);
                using (var connection = _context.CreateConnection())
                {
                    int userDetails1 = await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                    if (userDetails1 == 1)
                    {
                        string passwordQuery = string.Format("Select UserName, OTP, EmailID From UserDetails WHERE EmailID = '{0}' ORDER BY CreationTimeStamp", userDetails.EmailID);

                        var userDetails2 = await connection.QueryFirstOrDefaultAsync<UserDetails>(passwordQuery, parameters);
                        responseModel.UserName = userDetails2.UserName;
                        responseModel.OTP = userDetails2.OTP;
                        responseModel.EmailID = userDetails2.EmailID;
                        responseModel.Success = true;

                        return responseModel;
                    }
                    else
                    {
                        responseModel.Success = false;
                        return responseModel;
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        // 21/08/2024
        public async Task<int> GetOTPDetailsBack(string EmailID)
        {
            try
            {
                var parameter1 = new DynamicParameters();
                parameter1.Add("EmailID", EmailID, DbType.String, ParameterDirection.Input);
                //parameter1.Add("OTP", OTP, DbType.Int32, ParameterDirection.Input);
                string sp = "SP_GetOTPDetailsBack";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.QueryFirstOrDefaultAsync<int>(sp, parameter1, commandType: CommandType.StoredProcedure);
                    //if(userDetails != null)
                    //{
                        return userDetails; 
                    //}
                    //else
                    //{
                    //    return new UserDetails();
                   // }
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        // 21/08/2024
        public async Task<bool> ChangePassword(string EmailID, string Password)
        {
            try
            {
                
                var parameter1 = new DynamicParameters();
                parameter1.Add("EmailID", EmailID, DbType.String, ParameterDirection.Input);
                parameter1.Add("Password", Password, DbType.String, ParameterDirection.Input);
                string sp = "SP_ChangePassword";
                using (var connection = _context.CreateConnection())
                {
                    var userDetails = await connection.ExecuteAsync(sp, parameter1, commandType: CommandType.StoredProcedure);
                    if (userDetails == 1)
                    {
                        return true;
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
        public async Task<string> GetUserID(string EmailID)
        {
            try
            {
                string query = string.Format("select distinct(IDUser) from UserDetails where EmailID = '{0}' AND Status = 'ACTIVE'", EmailID);

                using (var connection = _context.CreateConnection())
                {
                    var UserID = await connection.QueryFirstOrDefaultAsync<string>(query);
                    return UserID;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public async Task<UserDetails> GetActualOTPBack(string EmailID, int OTP)
        //{
        //    try
        //    {
        //        var parameter1 = new DynamicParameters();
        //        parameter1.Add("IDUser", id, DbType.Int16, ParameterDirection.Input);
        //        string sp = "SP_GetUserDetailsByID";
        //        using (var connection = _context.CreateConnection())
        //        {
        //            var userDetails = await connection.QueryFirstOrDefaultAsync<UserDetails>(sp, parameter1, commandType: CommandType.StoredProcedure);
        //            if (userDetails != null)
        //            {
        //                return userDetails;
        //            }
        //            else
        //            {
        //                return new UserDetails();
        //            }
        //        };
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public async Task<string> GetLocationfromID13(int IDLocation)
        {
            try
            {
                string query = string.Format("select distinct(Location) from Location where IDLocation = '{0}'", IDLocation);

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

        public async Task<List<ITAssetDetailsModel>> GetDomainFinalUser()
        {
            try
            {
                string sp = "SP_GetDomainfromUser";
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