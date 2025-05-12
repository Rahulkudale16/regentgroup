using System.ComponentModel.DataAnnotations;
using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace LegendAsiaAsset.Models
{
    public class UserDetails
    {
        public int IDUser { get; set; }
        public int IDLocation { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        public string? Role { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }
        [Display(Name = "User Name")]
        public string? UserName { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must contain minimum 6 digits")]
        public string? Password { get; set; }
        [Display(Name = "Unit No")]
        public string? Unit { get; set; }
        [Display(Name = "Email ID")]

        //[DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string? EmailID { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationTimeStamp { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModificationTimeStamp { get; set; }
        public string? ReturnURL { get; set; }
        public string? Location { get; set; }
        public int UserCount { get; set; }
        public int DeactiveCount { get; set; }
        public int ActiveCount { get; set; }
        public double ActiveUserPec { get; set; }
        [Display(Name = "File Name")]
        public List<IFormFile>? File { get; set; }
        public string? IDUserDis { get; set; }

        //for upload doc

        public int IDDoc { get; set; }
        public string? DocType { get; set; }

        public string? DocName { get; set; }

        public double DocSize { get; set; }

        public string? ContentType { get; set; }

        public string? Domain { get; set; }

        public int OTP { get; set; }

    }
}
