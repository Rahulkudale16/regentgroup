using LegendALP.Data;
using LegendALP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace LegendALP.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MailSend(ContactDetails contactDetails)
        {
            MailMessage mail = new MailMessage();

            mail.To.Add(Constant.ToEmail);

            mail.From = new MailAddress(Constant.FromEmail);

            mail.Subject = string.Format(Constant.Subject, contactDetails.Subject);
            string Body = string.Format(Constant.Body, contactDetails.Name, contactDetails.Email, contactDetails.Subject, contactDetails.Message);
            mail.Body = Body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient
            {
                Host = "relay-hosting.secureserver.net",
                Port = 25,
                UseDefaultCredentials = false
            };

            smtp.Send(mail);
            return Json(new { success = true, msg = "Mail Request sent successfully" }, JsonRequestBehavior.AllowGet);
        }
    }
}