using LegendAsiaAsset.Contracts;
using LegendAsiaAsset.Models;
using LegendAsiaAsset.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;
using System.Security.Claims;
using LegendAsiaAsset.Data;
using System.Net.Mail;

namespace LegendAsiaAsset.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserDetailsRepository _userDetailsRepository;
        private readonly ISQLTablesRepository _sqltablesRepository;
        public AccountController(IUserDetailsRepository userDetailsRepository, ISQLTablesRepository sqltablesRepository)
        {
            _userDetailsRepository = userDetailsRepository;
            _sqltablesRepository = sqltablesRepository;
        }
        public IActionResult Login()
        {
            try
            {
                var claimName = User.FindFirst(ClaimTypes.Name);
                string? currentUserName = claimName?.Value;
                if (currentUserName == null)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Home", "Home");
                }

            }
            catch (Exception)
            {
                return RedirectToAction("Maintenance", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserDetails userDetails)
        {
            bool isValid = false;
            userDetails.UserName = string.IsNullOrEmpty(userDetails.UserName) ? string.Empty : userDetails.UserName.ToUpperInvariant();
            ModelState.Remove<UserDetails>(x => x.EmailID);
            ModelState.Remove<UserDetails>(x => x.FullName);
            if (!ModelState.IsValid)
            {
                return View(userDetails);
            }
            isValid = await UserIsValid(userDetails);
            if (isValid)
            {
                await SignInUser(userDetails);
                if (userDetails.ReturnURL != null)
                {
                    return LocalRedirect(userDetails.ReturnURL);
                }
                else
                {
                    return RedirectToAction(nameof(HomeController.Home), "Home");
                }
            }
            else
            {
                TempData["Error"] = "Invalid UserName or Password";
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            TempData["LogoutUser"] = User.FindFirst(ClaimTypes.GivenName)?.Value;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        private async Task<bool> UserIsValid(UserDetails userDetails)
        {
            return await _userDetailsRepository.GetValidUser(userDetails);
        }
        private async Task SignInUser(UserDetails userDetails)
        {
            string userName = userDetails.UserName ?? string.Empty;

            userDetails = await _userDetailsRepository.GetUserDetailsFromName(userDetails);

            string userName1 = userDetails.UserName ?? string.Empty;
            string userID = userDetails.IDUser.ToString();
            //string userIDLocation = userDetails.IDLocation.ToString() ;
            //string userName = userDetails.FullName ?? string.Empty;
            string role = userDetails.Role ?? string.Empty;
            //string emailID = userDetails.EmailID ?? string.Empty;
            //string designation = userDetails.Designation ?? string.Empty;
            var claims = new List<Claim>()
            {
                 new Claim(ClaimTypes.Name, userName1),
                 new Claim(ClaimTypes.NameIdentifier, userID),
                 new Claim(ClaimTypes.Role, role),
                 //new Claim("FileType", await _sqltablesRepository.GetDBType());
                //new Claim("FileType", "DEV"),
                //new Claim(ClaimTypes.Role, role),
                //new Claim(ClaimTypes.Email, emailID),
                //new Claim("FileType",  await _fileMakerTablesRepository.GetFileType()),
            };
            claims.Add(new Claim("FileType", await _sqltablesRepository.GetDBType()));
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var authProperties = new AuthenticationProperties();
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);
        }
        // 20/08/2024  Create OTP
        public async Task<JsonResult> NewOTPDetails(UserDetails userDetails)
        {
            var OTP = await _userDetailsRepository.OTPDetails(userDetails);
            _ = OTPMail(OTP);
            return Json(OTP);
        }
        // 20/08/2024  Send OTP Mail
        public IActionResult OTPMail(ResponseModel responsemodel)
        {
            try
            {
                string body = string.Empty;
                string requestSendBy = User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
                MailMessage mail = new();

                mail.To.Add(responsemodel.EmailID ?? requestSendBy);
                mail.From = new MailAddress("infolegend@legendgloballogistics.com");
                mail.Subject = "OTP For Confirmation";
                body = string.Format("Dear {0},<br/><br/> Please find here with your OTP detail. <br/><br/>UserName: {0} <br/><br/> OTP: {1}", responsemodel.UserName, responsemodel.OTP);
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new()
                {
                    Host = "smtp.office365.com",
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("infolegend@legendgloballogistics.com", "IL@legend456"), // Enter senders User name and password  
                    EnableSsl = true
                };
                smtp.Send(mail);
            }
            catch (Exception)
            {

            }

            return Json(new { success = true, msg = "Mail Request Send successfully" });

        }
        [HttpGet]
        public async Task<IActionResult> GetOTPDetailsBack(string EmailID)
        {
            bool success = false;
            var data = await _userDetailsRepository.GetOTPDetailsBack(EmailID);
            return Json(new {data, success });
        }
        [HttpPost]
        public async Task<IActionResult> GetChangePassword(string EmailID, string Password)
        {
            bool success = await _userDetailsRepository.ChangePassword(EmailID, Password);
            return Json(new { success = true, msg = "Password Changed Successfully" });
        }
    }
}
