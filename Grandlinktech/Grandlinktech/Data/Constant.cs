using Grandlinktech.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Grandlinktech.Data
{
    public class Constant
    {
        public const string ToEmail = "info@grandlinktech.com";
        //public const string ToEmail = "rahul.kudale@regentgroup.sg";

        //public const string FromEmail = "rahul.kudale@regentgroup.sg";

        public const string Subject = "Enquiry on GrandLinkTech";

        public const string Body = "<font> Dear Team, <br/><br> Below are the information:- <br/><br/><b>Name</b> :-  {0} <br/><br/><b>EmailID<b> :-  {1} <br/><br/><b>Subject</b> :-  {2} <br/><br/><b>Message</b> :-  {3}" +
            "</font>" +
            "<br/><br/><font size=2><i>[This is an automated message - Please do not reply directly to this email. " +
            "If you need additional help, please contact ]</i></font>";
    }
}
