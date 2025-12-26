using LegendAsiaAsset.Models;
namespace LegendAsiaAsset.Contracts
{
    public interface IITAssetDetailsRepository
    {
        public Task<List<ITAssetDetailsModel>> GetITAssetDetailsList(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<List<ITAssetDetailsModel>> GetAssignAssetList(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<bool> AddAssignDetails(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<List<ITAssetDetailsModel>> GetHostnameDropdownList();
        public Task<List<ITAssetDetailsModel>> GetAssetTypeDropdownList();
        public Task<List<ITAssetDetailsModel>> GetBrandDropdownList();
        public Task<List<ITAssetDetailsModel>> GetModelDropdownList();
        public Task<List<ITAssetDetailsModel>> GetUsernameDropdownList();
        public Task<List<ITAssetDetailsModel>> GetOfficeDropdownList();
        public Task<List<ITAssetDetailsModel>> GetStatusDropdownList();
        public Task<List<ITAssetDetailsModel>> GetFullNameDropdownList();
        public Task<List<ITAssetDetailsModel>> GetLastUserDropdownList();
        public Task<ResponseModel> SaveITAssetDetails(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<LocationModel> GetLocationfromID(int IDLocation);
        public Task<ResponseModel> UpdateITAssetDetails(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<int> GetITAssetCount(int ID);
        public Task<bool> GetStatusITAsset(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<List<ITAssetDetailsModel>> GetAssetTypeAssign();
        public Task<List<ITAssetDetailsModel>> GetBrandAssign();
        public Task<List<ITAssetDetailsModel>> GetModelAssign();
        public Task<List<ITAssetDetailsModel>> GetSerialNoAssign();
        public Task<List<ITAssetDetailsModel>> GetHostNameAssign();
        public Task<bool> UpdateAssetStatus(string SerialNr, string Status, int UserID);
        public Task<bool> LastUserValue(int userID, string SerialNr);
        public Task<bool> DeleteAssignedAssetByUserID(int userID, string SerialNR);
        public Task<bool> UpdateActivitiLogDetails(int ID, string msg);
        public Task<ITAssetDetailsModel> GeTAssetCountByRegion(string region);
        public Task<List<ITAssetDetailsModel>> GetSerialNrDropdownList();
        public Task<List<ITAssetDetailsModel>> GetCountryFinal();
        public Task<List<ITAssetDetailsModel>> GetDomainFinal();
        public Task<List<ITAssetDetailsModel>> GetAssetIDDetails();
        public Task<List<ITAssetDetailsModel>> GetAssetIDAsset();
        public Task<bool> DeleteITAssetDetails(int IDAsset);
        public Task<ResponseModel> TransferedToAnotherSystem(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<bool> TransferedAndDeleted(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<string> GetAssetID(string SerialNumber);
        public Task<string> GetRemark(string IDAsset);
        public Task<List<ITAssetDetailsModel>> GetScrappedAssetList(ITAssetDetailsModel iTAssetDetailsModel);
        public Task<List<ITAssetDetailsModel>> GetAssignedAssetList(ITAssetDetailsModel iTAssetDetailsModel);
    }
}