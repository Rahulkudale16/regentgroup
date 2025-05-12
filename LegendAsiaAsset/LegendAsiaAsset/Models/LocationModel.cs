using System.ComponentModel.DataAnnotations;

namespace LegendAsiaAsset.Models
{
    public class LocationModel
    {
        public int IDLocation { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? Location { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationTimeStamp { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModificationTimeStamp { get; set; }
        public string? IDLocationDis { get; set; }

        public string? Status { get; set; }
    }
}