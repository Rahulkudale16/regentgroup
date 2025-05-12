using System.ComponentModel.DataAnnotations;
using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace LegendAsiaAsset.TranslatedModels
{
    public class TranslatedUserDetails
    {
        public string? IDUser { get; set; }
        public string?  IDLocation { get; set; }
        public string? FullName { get; set; }
        public string? Role { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }
        [Display(Name = "UserName")]
        public string? UserName { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must contain minimum 6 digits")]
        public string? Password { get; set; }
        public string? Unit { get; set; }
        [Display(Name = "Email Id")]
        public string? EmailID { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreationTimeStamp { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModificationTimeStamp { get; set; }
        public string? ReturnURL { get; set; }
        public string? Location { get; set; }

        public string? IDUserDis { get; set; }

        public string? File { get; set; }

        public string? IDDoc { get; set; }
        public string? DocType { get; set; }

        public string? DocName { get; set; }

        public string? DocSize { get; set; }

        public string? ContentType { get; set; }

        public string? Domain { get; set; }
    }
}
