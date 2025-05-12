using System.ComponentModel.DataAnnotations;

namespace LegendAsiaAsset.TranslatedModels
{
    public class TranslatedLocationModel
    {
        public string? IDLocation { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? Location { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreationTimeStamp { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModificationTimeStamp { get; set; }
        public string? IDLocationDis { get; set; }
        public string? Status { get; set;}
    }
}
