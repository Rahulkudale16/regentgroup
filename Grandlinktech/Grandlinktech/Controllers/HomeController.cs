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
            MailMessage mail = new MailMessage();

            mail.To.Add(Constant.ToEmail);

            mail.From = new MailAddress(Constant.FromEmail);

            mail.Subject = string.Format(Constant.Subject, contactDetails.Subject);
            string Body = string.Format(Constant.Body, contactDetails.Name, contactDetails.Email, contactDetails.Subject, contactDetails.Message);
            mail.Body = Body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new()
            {
                Host = "smtp.office365.com",
                Port = 7266,
                UseDefaultCredentials = false,
                EnableSsl = true
            };

            smtp.Send(mail);
            return Json(new { success = true, msg = "Mail Request sent successfully" });
        }
    }
}
