using System.ComponentModel.DataAnnotations;

namespace LegendAsiaAsset.Models
{
    public class InfrastructureModel
    {
        public int IDInfra { get; set; }
        public int IDLocation { get; set; }
        [Display(Name = "Asset Type")]

        public string? AssetType { get; set; }
        public string? Brand { get; set; }  

        public string? Model { get; set; }
        [Display(Name = "Serial No")]

        public string? SerialNumber { get; set; }

        [Display(Name = "Purchase Year")]
        public DateTime? PurchaseYear { get; set; }

        public string? Remark { get; set; }
        public string? Status { get; set; }

        public string? CreatedBy { get; set;}
        public DateTime CreationTimeStamp { get; set; }
        public string? Location { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime ModificationTimeStamp { get; set;}

        public int InfraCount { get; set; }

        public int InfraCountActive { get; set; }

        public int InfraCountDeactive { get; set; }
        public double ActiveInfraPec { get; set; }

        public string? IDAssetDis { get; set; }

        public string? IDInfraDis { get; set; }
        public string? Unit { get; set; }
    }
}
