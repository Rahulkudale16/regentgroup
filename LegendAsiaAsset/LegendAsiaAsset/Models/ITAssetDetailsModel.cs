using System.ComponentModel.DataAnnotations;

namespace LegendAsiaAsset.Models
{
    public class ITAssetDetailsModel
    {
        public int IDAsset { get; set; }
        public int IDAssign { get; set; }
        public int UserID { get; set; }
        public int LocationID { get; set; }
        public int IDLocation { get; set; }
        [Display(Name = "Host Name")]
        public string? HostName { get; set; }
        [Display(Name = "Asset Type")]
        public string? AssetType { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        [Display(Name = "Serial No")]
        public string? SerialNumber { get; set; }
        [Display(Name = "Purchase Year")]
        public DateTime? PurchaseYear { get; set; }
        [Display(Name = "User Name")]
        public string? UserName { get; set; }
        [Display(Name = "Last User")]
        public string? LastUser { get; set; }
        public string? Location { get; set; }
        [Display(Name = "Unit No")]
        public string? Unit { get; set; }
        public string? CPU { get; set; }
        public string? Memory { get; set; }
        public string? HDD { get; set; }
        public string? OS { get; set; }
        public string? Software { get; set; }
        public string? Remark { get; set; }
        public List<string?> RemarkList { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreationTimeStamp { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModificationTimeStamp { get; set; }
        public int ITAssetCount { get; set; }
        public double ActiveITAssetPec { get; set; }
        [Display(Name = "Additional ID")]
        public string? IDAssetDis { get; set; }
        public string? ActivityLog { get; set; }
        public int ITAssetAvailable { get; set; }
        public int ITAssetAssigned { get; set; }
        public int ITAssetLaptop { get; set; }
        public int ITAssetDesktop { get; set; }
        public string? Region { get; set; }
        public string? FullName { get; set; }
        [Display(Name = "Email Id")]
        public string? EmailID { get; set; }
        public string? Designation { get; set; }
        public int MSOffice { get; set; }
        public string? Monitor { get; set; }
        public string? Keyboard { get; set; }
        public string? Mouse { get; set; }
        public string? HeadPhone { get; set; }
        public string? Department { get; set; }
        public string? Country { get; set; }
        [Display(Name = "Domain")]
        public string? Domain { get; set; }
        public string? AssetID { get; set; }
        [Display(Name = "Previous Location")]
        public string? LastAssetLocation { get; set; }
        [Display(Name = "Invoice No")]
        public string? InvoiceNo { get; set; }
        [Display(Name = "Paid By")]
        public string? PaidBy { get; set; }
    }
}
