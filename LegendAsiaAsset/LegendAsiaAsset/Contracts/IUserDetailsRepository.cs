using LegendAsiaAsset.Models;

namespace LegendAsiaAsset.Contracts
{
    public interface IUserDetailsRepository
    {
        public Task<bool> GetValidUser(UserDetails userDetails);
        public Task<UserDetails> GetUserDetailsFromName(UserDetails userDetails);
        public Task<List<UserDetails>> GetUserList(UserDetails userDetails);
        public Task<List<UserDetails>> GetRoleFromUserDetails();
        public Task<List<UserDetails>> GetDepartmentFromUserDetails();
        public Task<List<UserDetails>> GetDesignationUserDetails();
        public Task<List<UserDetails>> GetEmailIDUserDetails();
        public Task<List<UserDetails>> GetUserNameUserDetails();
        public Task<List<UserDetails>> GetFullNameUserDetails();
        public Task<ResponseModel> SaveUserDetails(UserDetails userDetails);
        //public Task<bool> GeneratePassword(UserDetails userDetails);
        public Task<ResponseModel> UpdateUserDetails(UserDetails userDetails);
        public Task<bool> UpdateAssetDetails(UserDetails userDetails);
        public Task<LocationModel> GetLocationfromID(int IDLocation);
        public Task<ResponseModel> ResetUserDetails(UserDetails userDetails);
        //  public Task<bool> SetActiveDeactive(int iduser);
        //  public Task<bool> SetActiveDeactive(int iduser);
        public Task<int> GetUserCount(int ID);
        public Task<bool> GetStatusUD(UserDetails userDetails);
        public Task<bool> SaveFile(UserDetails userDetails);  //30/10
        public Task<List<UserDetails>> GetFiles(int UserID);
        public Task<List<UserDetails>> GetFileNameByID(List<int> AllData);
        public Task<bool> DeleteFile(UserDetails userDetails);
        public Task<UserDetails> GetUserDetailsById(int id);
        public Task<List<UserDetails>> GetAdminEmailID();
        public Task<string> GetContentTypeByDocName(string DocName);
        public Task<bool> UpdateDocType(UserDetails userDetails);
        public Task<bool> DeleteUserDetails(int IDUser);
        public Task<bool> DeleteAssignAssetDetails(int IDUser);
        public Task<ResponseModel> TransferUserDetails(UserDetails userDetails);
        public Task<bool> TransferedAndDeletedUser(UserDetails userDetails);
        public Task<ResponseModel> OTPDetails(UserDetails userDetails);
        public Task<int> GetOTPDetailsBack(string EmailID);
        public Task<bool> ChangePassword(string EmailID, string Password);
        public Task<string> GetUserID(string EmailID);
        public Task<string> GetLocationfromID13(int IDLocation);
        public Task<List<ITAssetDetailsModel>> GetDomainFinalUser();

    }
}
