using System.ComponentModel.DataAnnotations;

namespace LegendAsiaAsset.TranslatedModels
{
    public class TranslatedITAssetDetailsModel
    {
        public string? IDAsset { get; set; }
        public string? IDAssign { get; set; }
        public string? UserID { get; set; }
        public string? LocationID { get; set; }

        public string? IDLocation { get; set; }
        public string? HostName { get; set; }

        public string? AssetType { get; set; }
        public string? Brand { get; set; }

        public string? Model { get; set; }

        public string? SerialNumber { get; set; }

        public string? PurchaseYear { get; set; }

        public string? FullName { get; set; }

        public string? LastUser { get; set; }

        public string? Location { get; set; }

        public string? Unit { get; set; }

        public string? CPU { get; set; }

        public string? Memory { get; set; }

        public string? HDD { get; set; }

        public string? OS { get; set; }

        public string? Software { get; set; }

        public string? Remark { get; set; }

        public string? Status { get; set; }

        public string? CreatedBy { get; set; }

        public string? CreationTimeStamp { get; set; }

        public string? ModifiedBy { get; set; }

        public string? ModificationTimeStamp { get; set; }
        public string? IDAssetDis { get; set; }
        public string? ActivityLog { get; set; }
        [Display(Name = "Email Id")]
        public string? EmailID { get; set; }

        public string? Designation { get; set; }
        public string? MSOffice { get; set; }

        public string? Monitor { get; set; }
        public string? Keyboard { get; set; }
        public string? Mouse { get; set; }

        public string? HeadPhone { get; set; }
        public string? Department { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? Domain { get; set; }
        public string? AssetID { get; set; }
        public string? LastAssetLocation { get; set; }
    }
}
