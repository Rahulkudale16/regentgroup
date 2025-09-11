using Grandlinktech.Data;
using Grandlinktech.Models;
using System.Net.Mail;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Grandlinktech.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MailSend(ContactDetails contactDetails)
        {
            MailMessage mail = new();

            mail.To.Add(Constant.ToEmail);

            mail.From = new MailAddress("donotreply@regentgroup.sg");

            mail.Subject = string.Format(Constant.Subject, contactDetails.Subject);
            string Body = string.Format(Constant.Body, contactDetails.Name, contactDetails.Email, contactDetails.Subject, contactDetails.Message);
            mail.Body = Body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new()
            {
                Host = "smtp.office365.com",
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("donotreply@regentgroup.sg", "Regent@DR123"), // Enter senders User name and password  
                EnableSsl = true
            };

            smtp.Send(mail);
            return Json(new { success = true, msg = "Mail sent successfully" });
        }
    }
}
