namespace LegendAsiaAsset.Models
{
    public class ResponseModel
    {
       public bool Success { get; set; }

        public string? UserName { get; set; }

        public string? EmailID { get; set; }
        public int  ID { get; set; }
       public string?  Password { get; set; }
        public int OTP { get; set; }
        public bool Duplicate { get; set; }           //

        public string? ResponseMessage { get; set; }    //

    }
}
