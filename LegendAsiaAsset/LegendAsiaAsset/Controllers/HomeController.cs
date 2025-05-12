using ClosedXML.Excel;
using LegendAsiaAsset.Contracts;
using LegendAsiaAsset.Data;
using LegendAsiaAsset.Models;
using LegendAsiaAsset.TranslatedModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Claims;

namespace LegendAsiaAsset.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserDetailsRepository _userDetailsRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IITAssetDetailsRepository _ITAssetDetailsRepository;
        private readonly IInfrastructureRepository _infrastructureRepository;
        public HomeController(ILogger<HomeController> logger, IUserDetailsRepository userDetailsRepository, ILocationRepository locationRepository, IITAssetDetailsRepository iTAssetDetailsRepository, IInfrastructureRepository infrastructureRepository)
        {
            _logger = logger;
            _userDetailsRepository = userDetailsRepository;
            _locationRepository = locationRepository;
            _ITAssetDetailsRepository = iTAssetDetailsRepository;
            _infrastructureRepository = infrastructureRepository;
        }
        [Authorize]
        public async Task<IActionResult> Home()
        {
            // Constant Methods Dropdowns Starts
            ViewBag.RoleUserDetails = Constant.GetRoleDropdown();
            //ViewBag.DepartmentUserDetails = Constant.GetDepartmentDropdown();
            ViewBag.RegionLocation = Constant.GetRegion();
            ViewBag.CountryLocation = Constant.GetCountry("");
            //ViewBag.CountryLocation = new SelectList(string.Empty, "Text", "Text");
            ViewBag.AssetType = Constant.GetAssetType();
            //ViewBag.Brand = Constant.GetBrand();
            //ViewBag.Designation = Constant.GetDesignationDropdown();

            // Constant Methods Dropdowns Ends

            // User List Dropdowns Starts
            ViewBag.EmailUserDetails = (await _userDetailsRepository.GetEmailIDUserDetails()).Where(x => !string.IsNullOrEmpty(x.EmailID)).Select(x => new SelectListItem { Text = x.EmailID, Value = x.EmailID });
            ViewBag.DesignationUserDetails = (await _userDetailsRepository.GetDesignationUserDetails()).Where(x => !string.IsNullOrEmpty(x.Designation)).Select(x => new SelectListItem { Text = x.Designation, Value = x.Designation });
            ViewBag.DepartmentUserDetails = (await _userDetailsRepository.GetDepartmentFromUserDetails()).Where(x => !string.IsNullOrEmpty(x.Department)).Select(x => new SelectListItem { Text = x.Department, Value = x.Department });
            ViewBag.UserNameUserDetails = (await _userDetailsRepository.GetUserNameUserDetails()).Where(x => !string.IsNullOrEmpty(x.UserName)).Select(x => new SelectListItem { Text = x.UserName, Value = x.UserName });
            ViewBag.FullNameUserDetails = (await _userDetailsRepository.GetFullNameUserDetails()).Where(x => !string.IsNullOrEmpty(x.FullName)).Select(x => new SelectListItem { Text = x.IDUser.ToString(), Value = x.FullName });
            ViewBag.LocationUD = (await _locationRepository.GetLocationFromLocation1()).Where(x => !string.IsNullOrEmpty(x.Location)).Select(x => new SelectListItem { Text = x.IDLocation.ToString(), Value = x.Location });
            // User List Dropdowns Ends

            // ITAsset List Dropdown Starts
            //ViewBag.EmailIDITAsset = (await _ITAssetDetailsRepository.GetEmailIDITAsset()).Where(x => !string.IsNullOrEmpty(x.EmailID)).Select(x => new SelectListItem { Text = x.EmailID, Value = x.EmailID });
            ViewBag.HostnameITAsset = (await _ITAssetDetailsRepository.GetHostnameDropdownList()).Where(x => !string.IsNullOrEmpty(x.HostName)).Select(x => new SelectListItem { Text = x.HostName, Value = x.HostName });
            ViewBag.AssetTypeITAsset = (await _ITAssetDetailsRepository.GetAssetTypeDropdownList()).Where(x => !string.IsNullOrEmpty(x.AssetType)).Select(x => new SelectListItem { Text = x.AssetType, Value = x.AssetType });
            ViewBag.BrandITAsset = (await _ITAssetDetailsRepository.GetBrandDropdownList()).Where(x => !string.IsNullOrEmpty(x.Brand)).Select(x => new SelectListItem { Text = x.Brand, Value = x.Brand });
            ViewBag.ModelITAsset = (await _ITAssetDetailsRepository.GetModelDropdownList()).Where(x => !string.IsNullOrEmpty(x.Model)).Select(x => new SelectListItem { Text = x.Model, Value = x.Model });
            ViewBag.Office = (await _ITAssetDetailsRepository.GetOfficeDropdownList()).Where(x => !string.IsNullOrEmpty(x.Location)).Select(x => new SelectListItem { Text = x.Location, Value = x.Location });
            ViewBag.LocationITAsset = (await _locationRepository.GetLocationFromLocation1()).Where(x => !string.IsNullOrEmpty(x.Location)).Select(x => new SelectListItem { Text = x.IDLocation.ToString(), Value = x.Location });
            ViewBag.StatusITAsset = (await _ITAssetDetailsRepository.GetStatusDropdownList()).Where(x => !string.IsNullOrEmpty(x.Status)).Select(x => new SelectListItem { Text = x.Status, Value = x.Status });
            ViewBag.FullNameITAsset = (await _ITAssetDetailsRepository.GetFullNameDropdownList()).Where(x => !string.IsNullOrEmpty(x.FullName)).Select(x => new SelectListItem { Text = x.FullName, Value = x.FullName });
            ViewBag.SerialNrITAsset = (await _ITAssetDetailsRepository.GetSerialNrDropdownList()).Where(x => !string.IsNullOrEmpty(x.SerialNumber)).Select(x => new SelectListItem { Text = x.SerialNumber, Value = x.SerialNumber });
            ViewBag.LocationOnly = (await _locationRepository.GetLocationFinal()).Where(x => !string.IsNullOrEmpty(x.Location)).Select(x => new SelectListItem { Text = x.Location, Value = x.Location });
            ViewBag.CountryOnly = (await _ITAssetDetailsRepository.GetCountryFinal()).Where(x => !string.IsNullOrEmpty(x.Country)).Select(x => new SelectListItem { Text = x.Country, Value = x.Country });
            ViewBag.LastUserITAsset = (await _ITAssetDetailsRepository.GetLastUserDropdownList()).Where(x => !string.IsNullOrEmpty(x.LastUser)).Select(x => new SelectListItem { Text = x.LastUser, Value = x.LastUser });
            ViewBag.DomainOnly = (await _ITAssetDetailsRepository.GetDomainFinal()).Where(x => !string.IsNullOrEmpty(x.Domain)).Select(x => new SelectListItem { Text = x.Domain, Value = x.Domain });
            // ITAsset List Dropdown Ends

            // Asset List Dropdown Starts
            ViewBag.AssetTypeAssign = (await _ITAssetDetailsRepository.GetAssetTypeAssign()).Where(x => !string.IsNullOrEmpty(x.AssetType)).Select(x => new SelectListItem { Text = x.AssetType, Value = x.AssetType });
            ViewBag.BrandAssign = (await _ITAssetDetailsRepository.GetBrandAssign()).Where(x => !string.IsNullOrEmpty(x.Brand)).Select(x => new SelectListItem { Text = x.Brand, Value = x.Brand });
            ViewBag.ModelAssign = (await _ITAssetDetailsRepository.GetModelAssign()).Where(x => !string.IsNullOrEmpty(x.Model)).Select(x => new SelectListItem { Text = x.Model, Value = x.Model });
            ViewBag.SerialNoAssign = (await _ITAssetDetailsRepository.GetSerialNoAssign()).Where(x => !string.IsNullOrEmpty(x.SerialNumber)).Select(x => new SelectListItem { Text = x.SerialNumber, Value = x.SerialNumber });
            ViewBag.HostNameAssign = (await _ITAssetDetailsRepository.GetHostNameAssign()).Where(x => !string.IsNullOrEmpty(x.HostName)).Select(x => new SelectListItem { Text = x.HostName, Value = x.HostName });

            // Asset List Dropdown Ends

            //Location List Dropdown Starts
            string region = string.Empty;
            ViewBag.LocationLOC = (await _locationRepository.GetLocationFromLocation1()).Where(x => !string.IsNullOrEmpty(x.Location)).Select(x => new SelectListItem { Text = x.Location, Value = x.Location });
            //Location List Dropdown Ends

            // Infrastructure List Dropdown Starts
            ViewBag.SerialnumberInfra = (await _infrastructureRepository.GetSerialnumberDropdownList()).Where(x => !string.IsNullOrEmpty(x.SerialNumber)).Select(x => new SelectListItem { Text = x.SerialNumber, Value = x.SerialNumber });
            ViewBag.ModelInfra = (await _infrastructureRepository.GetModelDropdownList()).Where(x => !string.IsNullOrEmpty(x.Model)).Select(x => new SelectListItem { Text = x.Model, Value = x.Model });
            ViewBag.BrandInfra = (await _infrastructureRepository.GetBrandDropdownList()).Where(x => !string.IsNullOrEmpty(x.Brand)).Select(x => new SelectListItem { Text = x.Brand, Value = x.Brand });
            ViewBag.AssetTypeInfra = (await _infrastructureRepository.GetAssetTypeDropdownList()).Where(x => !string.IsNullOrEmpty(x.AssetType)).Select(x => new SelectListItem { Text = x.AssetType, Value = x.AssetType });
            ViewBag.LocationInfra = (await _locationRepository.GetLocationFromLocation1()).Where(x => !string.IsNullOrEmpty(x.Location)).Select(x => new SelectListItem { Text = x.IDLocation.ToString(), Value = x.Location });
            // Infrastructure List Dropdown Ends

            //-------------------- Dashboard Count Methods Starts -----------------
            // User Count
            Home home = new();
            home.UserDetails.UserCount = await _userDetailsRepository.GetUserCount(1);
            home.UserDetails.ActiveCount = await _userDetailsRepository.GetUserCount(2);
            home.UserDetails.DeactiveCount = await _userDetailsRepository.GetUserCount(3);
            var activeCount = await _userDetailsRepository.GetUserCount(2);
            home.UserDetails.ActiveUserPec = (activeCount * 100) / home.UserDetails.UserCount;

            // IT Asset Count
            home.ITAssetDetailsModel.ITAssetCount = await _ITAssetDetailsRepository.GetITAssetCount(2) + await _ITAssetDetailsRepository.GetITAssetCount(3);
            home.ITAssetDetailsModel.ITAssetAvailable = await _ITAssetDetailsRepository.GetITAssetCount(2);
            home.ITAssetDetailsModel.ITAssetAssigned = await _ITAssetDetailsRepository.GetITAssetCount(3);
            var activeCount1 = await _ITAssetDetailsRepository.GetITAssetCount(3);
            home.ITAssetDetailsModel.ActiveITAssetPec = (activeCount1 * 100) / home.ITAssetDetailsModel.ITAssetCount;

            // Infrastructure Count
            home.InfrastructureModel.InfraCount = await _infrastructureRepository.GetInfraCount(1);
            home.InfrastructureModel.InfraCountActive = await _infrastructureRepository.GetInfraCount(2);
            var activeCount2 = await _infrastructureRepository.GetInfraCount(2);
            home.InfrastructureModel.InfraCountDeactive = (home.InfrastructureModel.InfraCount - activeCount2);
            home.InfrastructureModel.ActiveInfraPec = (activeCount2 * 100) / home.InfrastructureModel.InfraCount;
            //-------------------- Dashboard Count Methods Ends -----------------

            List<string> RegionList = new();
            RegionList.Add("ASIA");
            RegionList.Add("EUROPE");
            RegionList.Add("SOUTH AMERICA");
            RegionList.Add("NORTH AMERICA");
            RegionList.Add("OCEANIA");
            foreach (var item in RegionList)
            {
                var details = await _ITAssetDetailsRepository.GeTAssetCountByRegion(item);
                home.LaptopList.Add(details.IDAssign);
                home.DeskTopList.Add(details.IDAsset);
            }
            return View(home);
        }
        public async Task<IActionResult> Logout()
        {
            TempData["LogoutUser"] = User.FindFirst(ClaimTypes.GivenName)?.Value;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        public async Task<IActionResult> Dashboard()
        {
            Home home = new();

            // User Count
            home.UserDetails.UserCount = await _userDetailsRepository.GetUserCount(1);
            var activeCount = await _userDetailsRepository.GetUserCount(2);
            home.UserDetails.ActiveUserPec = (activeCount * 100) / home.UserDetails.UserCount;

            // IT Asset Count
            home.ITAssetDetailsModel.ITAssetCount = await _ITAssetDetailsRepository.GetITAssetCount(1);
            var activeCount1 = await _ITAssetDetailsRepository.GetITAssetCount(2) + await _ITAssetDetailsRepository.GetITAssetCount(3);
            home.ITAssetDetailsModel.ActiveITAssetPec = (activeCount1 * 100) / home.ITAssetDetailsModel.ITAssetCount;

            // Infrastructure Count
            home.InfrastructureModel.InfraCount = await _infrastructureRepository.GetInfraCount(1);
            var activeCount2 = await _infrastructureRepository.GetInfraCount(2);
            home.InfrastructureModel.ActiveInfraPec = (activeCount2 * 100) / home.InfrastructureModel.InfraCount;

            return PartialView(home);
        }
        public IActionResult UserDetails()
        {
            UserDetails userDetails = new();
            TempData["UserDetails"] = JsonConvert.SerializeObject(userDetails);
            return PartialView(userDetails);
        }
        public IActionResult Location()
        {
            LocationModel locationModel = new();
            TempData["LocationModel"] = JsonConvert.SerializeObject(locationModel);
            return PartialView();
        }
        public IActionResult ITAsset()
        {
            ITAssetDetailsModel iTAssetDetailsModel = new();
            TempData["ITAssetDetailsModel"] = JsonConvert.SerializeObject(iTAssetDetailsModel);
            return PartialView();
        }
        public IActionResult Infrastructure()
        {
            InfrastructureModel infrastructureModel = new();
            TempData["InfrastructureModel"] = JsonConvert.SerializeObject(infrastructureModel);
            return PartialView();
        }
        public async Task<JsonResult> GetCountryLocation(string regionvalue, string countryvalue)
        {
            var CountryDrop = Constant.GetCountry(regionvalue);
            var LocationDrop = new List<LocationModel>();
            if (!string.IsNullOrEmpty(countryvalue))
            {
                LocationDrop = await _locationRepository.GetLocationFromLocation(countryvalue);
            }
            bool success = true;
            return Json(new { CountryDrop, LocationDrop, success });
        }
        //-------------------------------------------------------------------------------User List View Methods Starts
        public async Task<JsonResult> GetUserdata(string sidx, string sort, int page, int rows)
        {
            UserDetails userDetails = new();
            if (TempData["UserDetails"] != null)
            {
                var user = TempData["UserDetails"]?.ToString() ?? string.Empty;
                userDetails = JsonConvert.DeserializeObject<UserDetails>(user) ?? new UserDetails();
            }
            var UserList = await _userDetailsRepository.GetUserList(userDetails);
            foreach (var item in UserList)
            {
                var LocationDet = (await _userDetailsRepository.GetLocationfromID(item.IDLocation));
                item.Location = LocationDet.Location;
            }

            //var UserList = ObjectTranslation.ConvertUserList(await _userDetailsRepository.GetUserList(userDetails));
            var userDetails1 = ObjectTranslation.ConvertUserList(UserList);
            int totalRecords = 5;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (from UserDetailsGrid in userDetails1
                        select new
                        {
                            UserDetailsGrid.IDUser,
                            cell = new string[]
                            {
                                UserDetailsGrid.IDUser ?? string.Empty,
                                string.Empty,
                                 UserDetailsGrid.IDUserDis ?? string.Empty,
                                UserDetailsGrid.IDLocation ?? string.Empty,
                                UserDetailsGrid.FullName ?? string.Empty,
                                UserDetailsGrid.Role ?? string.Empty,
                                UserDetailsGrid.Department ?? string.Empty,
                                UserDetailsGrid.Designation ?? string.Empty,
                                UserDetailsGrid.UserName ?? string.Empty,
                                UserDetailsGrid.Password ?? string.Empty,
                                UserDetailsGrid.Location ?? string.Empty,
                                UserDetailsGrid.Unit ?? string.Empty,
                                UserDetailsGrid.EmailID ?? string.Empty,
                                UserDetailsGrid.Domain ?? string.Empty,
                                UserDetailsGrid.Status ?? string.Empty,
                                UserDetailsGrid.CreatedBy ?? string.Empty,
                                UserDetailsGrid.CreationTimeStamp ?? string.Empty,
                                UserDetailsGrid.ModifiedBy ?? string.Empty,
                                UserDetailsGrid.ModificationTimeStamp ?? string.Empty,
                            }
                        })
            };
            return Json(jsonData);
        }
        [HttpPost]
        public ActionResult SearchButtonUD(UserDetails userDetails)
        {
            TempData["UserDetails"] = JsonConvert.SerializeObject(userDetails);
            return Json(new { success = true });
        }
        [HttpPost]
        public IActionResult ResetButtonUD()
        {
            TempData["UserDetails"] = null;
            return Json(new { success = true });
        }
        public async Task<JsonResult> GetStatusUD(UserDetails userDetails)
        {
            var cs = await _userDetailsRepository.GetStatusUD(userDetails);
            return Json(cs);
        }
        public async Task<JsonResult> GetStatusLoc(LocationModel locationModel)
        {
            var cs = await _locationRepository.GetStatusLoc(locationModel);
            return Json(cs);
        }
        public async Task<JsonResult> ResetPasswordDetails(UserDetails userDetails)
        {
            var ResetPassword = await _userDetailsRepository.ResetUserDetails(userDetails);
            _ = ResetPassWordMail(ResetPassword);
            return Json(ResetPassword);
        }

        [HttpPost]
        public async Task<IActionResult> SaveUserDetails(UserDetails userDetails)
        {
            bool success = false;
            bool duplicate = false;
            UserDetails userData = new();

            if (userDetails.IDUser == 0)
            {
                var resposnse = await _userDetailsRepository.SaveUserDetails(userDetails);
                if (resposnse.Success)
                {
                    userData = await _userDetailsRepository.GetUserDetailsById(resposnse.ID);
                    userData.Location = userData.IDLocation.ToString();
                    userDetails.IDUser = resposnse.ID;
                    userDetails.Password = resposnse.Password;
                    if (userDetails.Role != "USER")
                    {
                        _ = MailSend(userDetails);
                    }
                    //if (userDetails.Role == "USER")
                    //{
                    //    _ = MailSendUserDetails(userDetails);
                    //}
                }
                success = resposnse.Success;
                duplicate = resposnse.Duplicate;
            }
            else
            {
                success = await _userDetailsRepository.UpdateUserDetails(userDetails);
            }
            return Json(new { success, userData, duplicate });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserDetails(int IDUser)
        {
            bool success = false;
            UserDetails userData = new();


            var response1 = await _userDetailsRepository.DeleteAssignAssetDetails(IDUser);
            var response = await _userDetailsRepository.DeleteUserDetails(IDUser);
            return Json(new { response1, response, userData });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteITAssetDetails(int IDAsset)
        {
            bool success = false;
            UserDetails userData = new();

            var response = await _ITAssetDetailsRepository.DeleteITAssetDetails(IDAsset);
            return Json(new { response, userData });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteInfra(int IDInfra)
        {
            bool success = false;
            InfrastructureModel InfraData = new();

            var response = await _infrastructureRepository.DeleteInfra(IDInfra);
            return Json(new { response, InfraData });
        }

        //public async Task<ActionResult>GeneratePassword(UserDetails userDetails)
        //{
        //    bool success = await _userDetailsRepository.GeneratePassword(userDetails);
        //    if(success) 
        //    {
        //        return Json(new { success = true });
        //    }
        //    else 
        //    {
        //        return Json(new { success = false });
        //    }
        //}

        public IActionResult MailSend(UserDetails userDetails)
        {
            try
            {
                string body = string.Empty;
                string requestSendBy = User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
                MailMessage mail = new();

                mail.To.Add(userDetails.EmailID ?? requestSendBy);
                // mail.CC.Add(Constant.)
                //mail.Bcc.Add(Constant.)
                mail.From = new MailAddress("infolegend@legendgloballogistics.com");
                mail.Subject = "New UserID created";
                body = string.Format("Dear {0},<br/><br/> Please find here with your login detail. <br/><br/> User ID: {0} <br/> Password: {1} <br/><br/> With regards, <br/> Legend IT Support<b> <br/> <font size=2><i><br/>This email message was auto-generated. Please do not respond. If you need additional help, please contact IT Support.</i></font>", userDetails.UserName, userDetails.Password);
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new()
                {
                    Host = "smtp.office365.com",
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("infolegend@legengloballogistics.com", "IL@legend456"), // Enter senders User name and password  
                    EnableSsl = true
                };
                smtp.Send(mail);
            }
            catch (Exception)
            {

            }

            return Json(new { success = true, msg = "Mail Request Send successfully" });

        }

        public async Task<IActionResult> MailSendUserDetails(UserDetails userDetails)
        {
            try
            {
                //var LocationName = ( await _userDetailsRepository.GetLocationfromID(userDetails.IDLocation));
                //var LocationDet = (await _userDetailsRepository.GetLocationfromID(item.IDLocation));
                //item.Location = LocationDet.Location;
                var LocationDet = (await _userDetailsRepository.GetLocationfromID(userDetails.IDLocation));



                string body = string.Empty;
                //string requestSendBy = User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
                MailMessage mail = new();

                var AdminEmailID = await _userDetailsRepository.GetAdminEmailID();

                foreach (var test in AdminEmailID)
                {
                    mail.To.Add(test.EmailID);
                }

                //mail.To.Add("vikesh.k@legendlogisticsltd.com");
                //mail.To.Add("rahul.kudale@legendlogisticsltd.com");
                //mail.To.Add("AdminEmailID");
                // mail.CC.Add(Constant.)
                //mail.Bcc.Add(Constant.)
                mail.From = new MailAddress("infolegend@legendgloballogistics.com");
                mail.Subject = "Newly Created User's UserDetails";
                body = string.Format("Dear Admin,<br/><br/> Please find User detail. <br/><br/> Full Name: {0} <br/> Role: {1} <br/> Department: {2} <br/> Designation: {3} <br/> UserName :{4} <br/> Unit :{5} <br/> Location :{6} <br/> Email ID: {7} <br/><br/>  With regards, <br/> Legend IT Support<b> <br/> <font size=2><i><br/>This email message was auto-generated. Please do not respond. If you need additional help, please contact IT Support.</i></font>", userDetails.FullName, userDetails.Role, userDetails.Department, userDetails.Designation, userDetails.UserName, userDetails.Unit, LocationDet.Location, userDetails.EmailID);
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

        public IActionResult ResetPassWordMail(ResponseModel responsemodel)
        {
            try
            {
                string body = string.Empty;
                string requestSendBy = User?.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
                MailMessage mail = new();

                mail.To.Add(responsemodel.EmailID ?? requestSendBy);
                // mail.CC.Add(Constant.)
                //mail.Bcc.Add(Constant.)
                mail.From = new MailAddress("infolegend@legendgloballogistics.com");
                mail.Subject = "Password Reset Successfully";
                body = string.Format("Dear {0},<br/><br/> Please find here with your login detail. <br/><br/> UserID: {0} <br/><br/> Password: {1}", responsemodel.UserName, responsemodel.Password);
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

        [HttpPost] //30/10
        public async Task<IActionResult> UploadFiles(UserDetails userDetails)
        {
            //UserDetails userDetails = new();
            List<Message> messages = new();
            List<string> ApprovedEXT = new() { ".pdf", ".doc", ".docx", ".txt", ".xls", ".xlsx", ".csv", ".pptx", ".png", ".jpeg", ".jpg", ".msg", ".ppt" };
            string UploadUserId = string.Empty;
            if (userDetails.IDUser > 0)
            {
                UploadUserId = userDetails.IDUser.ToString();
            }
            string UploadUsername = string.Empty;
            if (userDetails.UserName != null)
            {
                UploadUsername = userDetails.UserName.ToString();

            }
            //if (TempData.Peek("UniversalSerialNr") != null)
            //{
            //    universalSerialNr = TempData.Peek("UniversalSerialNr")?.ToString() ?? string.Empty;
            //}
            //string jobSerialNr = string.Empty;
            //if (TempData.Peek("JobSerialNr") != null)
            //{
            //    jobSerialNr = TempData.Peek("JobSerialNr")?.ToString() ?? string.Empty;
            //}
            string fileType = User.FindFirst(x => x.Type == "FileType")?.Value ?? string.Empty;
            string foldername = UploadUserId;
            // foldername = foldername.Replace("/", "");


            for (int i = 0; i < userDetails.File.Count; i++)
            {
                IFormFile file = userDetails.File[i];
                userDetails.DocName = file.FileName;
                if (userDetails.DocName.Contains(" "))
                {
                    userDetails.DocName = userDetails.DocName.Replace(" ", "");
                }
                string contentType = file.ContentType;
                string uploadPath = Constant.UploadDocFilePath(fileType);
                //string uploadPath = @"C:\\ITAsset\UserFiles";
                string folderpath = System.IO.Path.Combine(uploadPath, foldername);
                double fileSize = file.Length;
                fileSize /= 1048576;
                string fileExt = System.IO.Path.GetExtension(userDetails.DocName);
                uploadPath = System.IO.Path.Combine(folderpath, userDetails.DocName);
                userDetails.DocSize = fileSize;
                //    shipmentFileUpload.UniversalSerialNr = universalSerialNr;
                userDetails.ContentType = contentType;
                //if (ApprovedEXT.Contains(userDetails.DocType))
                //{
                //    if (userDetails.DocSize < 25)
                //    {
                if (Directory.Exists(System.IO.Path.GetFullPath(folderpath)))
                {
                    if (System.IO.File.Exists(System.IO.Path.GetFullPath(uploadPath)))
                    {
                        messages.Add(new Message { ProtocolVersion = 0, HostId = userDetails.DocName, MessageType = "File already Exits" });
                    }
                    else
                    {
                        using (FileStream stream = new(uploadPath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        };
                        _ = await _userDetailsRepository.SaveFile(userDetails);

                        messages.Add(new Message { ProtocolVersion = 1, HostId = userDetails.DocName, MessageType = "File Saved Successfully" });
                    }
                }
                else
                {
                    Directory.CreateDirectory(System.IO.Path.GetFullPath(folderpath));
                    using (FileStream stream = new(uploadPath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    };
                    _ = await _userDetailsRepository.SaveFile(userDetails);

                    messages.Add(new Message { ProtocolVersion = 1, HostId = userDetails.DocName, MessageType = "File Saved Successfully" });
                }
                //    }
                //    else
                //    {
                //        messages.Add(new Message { ProtocolVersion = 0, HostId = fileName, MessageType = "File size cannot be grater that 25MB" });
                //    }
                //}
                //else
                //{
                //    messages.Add(new Message { ProtocolVersion = 0, HostId = fileName, MessageType = "Invalid file" });
                //}
            }
            return Json(new { messages = messages });
        }

        public async Task<JsonResult> GetFileData(int page, int rows)
        {
            int IDUser = 0;

            if (TempData.Peek("IDUser") != null)
            {
                IDUser = (int)(TempData.Peek("IDUser") ?? "0");
            }
            //string universalSerialNr = string.Empty;
            //if (TempData.Peek("UniversalSerialNr") != null)
            //{
            //    universalSerialNr = TempData.Peek("UniversalSerialNr")?.ToString() ?? string.Empty;
            //}
            var FileDetails = ObjectTranslation.ConvertDocUploadFileDetails(await _userDetailsRepository.GetFiles(IDUser));

            int totalRecords = FileDetails.Count;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (from fileuploadGrid in FileDetails
                        select new
                        {
                            cell = new string[]
                            {
                                fileuploadGrid.IDDoc?? string.Empty,
                                fileuploadGrid.IDUser?? string.Empty,
                                fileuploadGrid.DocType?? string.Empty,
                                fileuploadGrid.DocName?? string.Empty,
                                fileuploadGrid.DocSize?? string.Empty,
                                fileuploadGrid.ContentType?? string.Empty,
                                fileuploadGrid.CreatedBy?? string.Empty,
                                fileuploadGrid.CreationTimeStamp?? string.Empty,
                                fileuploadGrid.ModifiedBy?? string.Empty,
                                fileuploadGrid.ModificationTimeStamp?? string.Empty,
                            }
                        }).ToArray()
            };
            return Json(jsonData);
        }

        public IActionResult SearchIDWisedocGrid(int IDUser)
        {
            TempData["IDUser"] = IDUser;
            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFiles(List<int> AllData, string userName, string IDUser)
        {

            string fileType = User.FindFirst(x => x.Type == "FileType")?.Value ?? string.Empty;
            var fileNames = await _userDetailsRepository.GetFileNameByID(AllData);
            //string foldername = IDUser.ToString();
            //string uploadPath = @"C:\\ITAsset\UserFiles";
            string uploadPath = Constant.UploadDocFilePath(fileType);
            foreach (var fileName in fileNames)
            {
                bool success = await _userDetailsRepository.DeleteFile(fileName);
                if (success)
                {
                    string filePath = System.IO.Path.Combine(uploadPath, IDUser, fileName.DocName);
                    if (System.IO.File.Exists(System.IO.Path.GetFullPath(filePath)))
                    {
                        System.IO.File.Delete(System.IO.Path.GetFullPath(filePath));
                    }
                }
            }
            return Json(new { success = true });
        }

        public async Task<IActionResult> DownloadDocFile(string IDuser, string DocName)
        {
            string fileType = User.FindFirst(x => x.Type == "FileType")?.Value ?? string.Empty;

            string msdsFilepath = Constant.UploadDocFilePath(fileType);
            string foldername = IDuser;
            string filePath = System.IO.Path.Combine(msdsFilepath, foldername, DocName);

            var contentType = await _userDetailsRepository.GetContentTypeByDocName(DocName);
            FileInfo fileInfo = new(filePath);

            if (fileInfo.Exists)
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                var contentDisposition = new ContentDisposition
                {
                    FileName = WebUtility.UrlEncode(DocName),
                    Inline = true
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(fileBytes, contentType);

            }
            else
            {
                return Json(new { message = "No data found for the given file name" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveDocType(IFormCollection postData)
        {
            bool success = false;

            UserDetails userDetails = new();
            {
                userDetails.IDDoc = Int16.Parse(postData["IDDoc"]);
                userDetails.DocType = postData["DocType"];
            }
            if (postData["oper"] == "edit")
            {

                success = await _userDetailsRepository.UpdateDocType(userDetails);
            }

            return Json(new { success });
        }

        public async Task<JsonResult> DestroyRenderDropdowns()
        {
            List<ITAssetDetailsModel> iTAssetDetails4 = await _ITAssetDetailsRepository.GetSerialNoAssign();

            var SerialNoList = (await _ITAssetDetailsRepository.GetSerialNoAssign()).OrderBy(x => x.SerialNumber).Where(x => !string.IsNullOrEmpty(x.SerialNumber))
                          .Select(x => new SelectListItem { Text = x.SerialNumber, Value = x.SerialNumber });

            return Json(new { SerialNoList });
        }

        public async Task<JsonResult> DestroyRenderUDDropdowns()
        {
            List<UserDetails> userDetails = await _userDetailsRepository.GetRoleFromUserDetails();

            var RoleList = (await _userDetailsRepository.GetRoleFromUserDetails()).OrderBy(x => x.Role).Where(x => !string.IsNullOrEmpty(x.Role))
                          .Select(x => new SelectListItem { Text = x.Role, Value = x.Role });

            List<UserDetails> userDetails1 = await _userDetailsRepository.GetDepartmentFromUserDetails();

            var DepartmentList = (await _userDetailsRepository.GetDepartmentFromUserDetails()).OrderBy(x => x.Department).Where(x => !string.IsNullOrEmpty(x.Department))
                          .Select(x => new SelectListItem { Text = x.Department, Value = x.Department });

            List<UserDetails> userDetails2 = await _userDetailsRepository.GetDesignationUserDetails();

            var DesignationList = (await _userDetailsRepository.GetDesignationUserDetails()).OrderBy(x => x.Designation).Where(x => !string.IsNullOrEmpty(x.Designation))
                          .Select(x => new SelectListItem { Text = x.Designation, Value = x.Designation });

            List<UserDetails> userDetails3 = await _userDetailsRepository.GetUserNameUserDetails();

            var UserNameList = (await _userDetailsRepository.GetUserNameUserDetails()).OrderBy(x => x.UserName).Where(x => !string.IsNullOrEmpty(x.UserName))
                          .Select(x => new SelectListItem { Text = x.UserName, Value = x.UserName });


            List<UserDetails> userDetails4 = await _userDetailsRepository.GetEmailIDUserDetails();

            var EmailIDList = (await _userDetailsRepository.GetEmailIDUserDetails()).OrderBy(x => x.EmailID).Where(x => !string.IsNullOrEmpty(x.EmailID))
                          .Select(x => new SelectListItem { Text = x.EmailID, Value = x.EmailID });


            return Json(new { RoleList, DepartmentList, DesignationList, UserNameList, EmailIDList });
        }


        //-------------------------------------------------------------------------------User List View Methods Ends
        //-------------------------------------------------------------------------------Location List View Methods Starts
        public async Task<JsonResult> GetLocationdata(string sidx, string sort, int page, int rows)
        {
            LocationModel locationModel = new();
            if (TempData["LocationModel"] != null)
            {
                var location = TempData["LocationModel"]?.ToString() ?? string.Empty;
                locationModel = JsonConvert.DeserializeObject<LocationModel>(location.ToString()) ?? new LocationModel();

            }

            var LocationList = ObjectTranslation.ConvertLocationList(await _locationRepository.GetLocationList(locationModel));
            int totalRecords = 5;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (from LocationGrid in LocationList
                        select new
                        {
                            LocationGrid.IDLocation,
                            cell = new string[]
                            {
                                LocationGrid.IDLocation ?? string.Empty,
                                string.Empty,
                                LocationGrid.IDLocationDis ?? string.Empty,
                                LocationGrid.Region ?? string.Empty,
                                LocationGrid.Country ?? string.Empty,
                                LocationGrid.Location ?? string.Empty,
                                LocationGrid.CreatedBy ?? string.Empty,
                                LocationGrid.CreationTimeStamp ?? string.Empty,
                                LocationGrid.ModifiedBy ?? string.Empty,
                                LocationGrid.ModificationTimeStamp ?? string.Empty,
                                LocationGrid.Status ?? string.Empty,
                            }
                        })
            };
            return Json(jsonData);
        }

        [HttpPost]
        public async Task<IActionResult> SaveLocationNew(LocationModel locationModel)
        {
            bool success = false;
            bool duplicate = false;

            if (locationModel.IDLocation == null)
            {
                var response = await _locationRepository.SaveLocation(locationModel);
                success = response.Success;
                duplicate = response.Duplicate;
            }
            else
            {
                success = await _locationRepository.UpdateLocation(locationModel);
            }
            return Json(new { success, duplicate });
        }

        [HttpPost]
        public ActionResult SearchButtonLocation(LocationModel locationModel)
        {
            TempData["LocationModel"] = JsonConvert.SerializeObject(locationModel);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult ResetButtonLocation()
        {
            TempData["LocationModel"] = null;
            return Json(new { success = true });
        }

        //public async Task<JsonResult> DestroyRenderLocationDropdowns()
        //{
        //    List<LocationModel> locationModels = await _locationRepository.GetRegionFromLocation();

        //    var RegionList = (await _locationRepository.GetRegionFromLocation()).OrderBy(x => x.Region).Where(x => !string.IsNullOrEmpty(x.Region))
        //                  .Select(x => new SelectListItem { Text = x.Region, Value = x.Region });

        //    List<LocationModel> locationModels1 = await _locationRepository.GetCountryFromLocation();

        //    var CountryList = (await _locationRepository.GetCountryFromLocation()).OrderBy(x => x.Country).Where(x => !string.IsNullOrEmpty(x.Country))
        //                  .Select(x => new SelectListItem { Text = x.Country, Value = x.Country });

        //    List<LocationModel> locationModels2 = await _locationRepository.GetLocationFromLocation1();

        //    var LocationList = (await _locationRepository.GetRegionFromLocation()).OrderBy(x => x.Location).Where(x => !string.IsNullOrEmpty(x.Location))
        //                  .Select(x => new SelectListItem { Text = x.Location, Value = x.Location });


        //    return Json(new { RegionList, CountryList, LocationList});
        //}


        //-------------------------------------------------------------------------------Location List View Methods Ends
        //-------------------------------------------------------------------------------ITAsset List View Methods Starts
        public async Task<JsonResult> GetITAssetdata(string sidx, string sort, int page, int rows)
        {
            string Region = string.Empty;
            string Country = string.Empty;
            string Location1 = string.Empty;

            ITAssetDetailsModel itAssetDetailsModel = new();

            if (TempData["ITAssetDetailsModel"] != null)
            {
                var ITAsset = TempData["ITAssetDetailsModel"]?.ToString() ?? string.Empty;
                itAssetDetailsModel = JsonConvert.DeserializeObject<ITAssetDetailsModel>(ITAsset) ?? new ITAssetDetailsModel();
            }
            if (TempData["Region"] != null)
            {
                Region = TempData["Region"]?.ToString() ?? string.Empty;
            }
            if (TempData["Country"] != null)
            {
                Country = TempData["Country"]?.ToString() ?? string.Empty;
            }
            if (TempData["Location1"] != null)
            {
                Location1 = TempData["Location1"]?.ToString() ?? string.Empty;
            }
            if (!string.IsNullOrEmpty(Region) || !string.IsNullOrEmpty(Country) || !string.IsNullOrEmpty(Location1))
            {
                var Data = await _locationRepository.GetLocationID(Region, Country, Location1);
                if (Data.Count > 0)
                {
                    int Lastindex = Data.Count - 1;
                    for (int i = 0; i < Data.Count; i++)
                    {
                        if (i == Lastindex)
                        {
                            itAssetDetailsModel.Remark += Data[i].IDLocation;
                        }
                        else
                        {
                            itAssetDetailsModel.Remark += Data[i].IDLocation + ",";
                        }
                    }
                }
            }

            var AssetList = await _ITAssetDetailsRepository.GetITAssetDetailsList(itAssetDetailsModel);
            foreach (var item in AssetList)
            {
                var LocationDet = (await _ITAssetDetailsRepository.GetLocationfromID(item.IDLocation));
                item.Location = LocationDet.Location;
                item.Region = LocationDet.Region;
            }
            //var ITAssetList = ObjectTranslation.ConvertITAssetList(await _ITAssetDetailsRepository.GetITAssetDetailsList(itAssetDetailsModel));
            var ITAssetList = ObjectTranslation.ConvertITAssetList(AssetList);
            int totalRecords = 5;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (from ITAssetGrid in ITAssetList
                        select new
                        {
                            ITAssetGrid.IDAsset,
                            cell = new string[]
                            {
                                ITAssetGrid.IDAsset ?? string.Empty,
                                string.Empty,
                                ITAssetGrid.IDAssetDis ?? string.Empty,
                                ITAssetGrid.UserID ?? string.Empty,
                                ITAssetGrid.IDLocation ?? string.Empty,
                                ITAssetGrid.HostName ?? string.Empty,
                                ITAssetGrid.AssetType ?? string.Empty,
                                ITAssetGrid.Brand ?? string.Empty,
                                ITAssetGrid.Model ?? string.Empty,
                                ITAssetGrid.SerialNumber ?? string.Empty,
                                ITAssetGrid.PurchaseYear ?? string.Empty,
                                ITAssetGrid.EmailID ?? string.Empty,
                                ITAssetGrid.Designation ?? string.Empty,
                                ITAssetGrid.FullName ?? string.Empty,
                                ITAssetGrid.LastUser ?? string.Empty,
                                ITAssetGrid.Location ?? string.Empty,
                                ITAssetGrid.Region ?? string.Empty,
                                ITAssetGrid.Country ?? string.Empty,
                                ITAssetGrid.Unit ?? string.Empty,
                                ITAssetGrid.CPU ?? string.Empty,
                                ITAssetGrid.Memory ?? string.Empty,
                                ITAssetGrid.HDD ?? string.Empty,
                                ITAssetGrid.OS ?? string.Empty,
                                ITAssetGrid.Software ?? string.Empty,
                                ITAssetGrid.Remark ?? string.Empty,
                                ITAssetGrid.Domain ?? string.Empty,
                                ITAssetGrid.Status ?? string.Empty,
                                ITAssetGrid.ActivityLog ?? string.Empty,
                                ITAssetGrid.CreatedBy ?? string.Empty,
                                ITAssetGrid.CreationTimeStamp ?? string.Empty,
                                ITAssetGrid.ModifiedBy ?? string.Empty,
                                ITAssetGrid.ModificationTimeStamp ?? string.Empty,
                                ITAssetGrid.Monitor ?? string.Empty,
                                ITAssetGrid.Keyboard ?? string.Empty,
                                ITAssetGrid.Mouse ?? string.Empty,
                                ITAssetGrid.MSOffice ?? string.Empty,
                                ITAssetGrid.HeadPhone ?? string.Empty,
                                ITAssetGrid.Department ?? string.Empty
                            }
                        })
            };
            return Json(jsonData);
        }
        public async Task<JsonResult> GetAssigndata(string sidx, string sort, int page, int rows)
        {
            ITAssetDetailsModel iTAssetDetailsModel = new();
            if (TempData.Peek("IdUser") != null)
            {
                iTAssetDetailsModel.UserID = (int)(TempData.Peek("IdUser") ?? 0);
            }
            var AssignAssetList = await _ITAssetDetailsRepository.GetAssignAssetList(iTAssetDetailsModel);
            //foreach (var item in AssignAssetList)
            //{
            //    var LocationDet = (await _userDetailsRepository.GetLocationfromID(item.IDLocation));
            //    item.Location = LocationDet.Location;
            //}

            //var UserList = ObjectTranslation.ConvertUserList(await _userDetailsRepository.GetUserList(userDetails));
            var userDetails1 = ObjectTranslation.ConvertITAssetList(AssignAssetList);
            int totalRecords = 5;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (from AssignGrid in userDetails1
                        select new
                        {
                            AssignGrid.IDAssign,
                            cell = new string[]
                            {
                                AssignGrid.IDAssign ?? string.Empty,
                                AssignGrid.UserID ?? string.Empty,
                                AssignGrid.LocationID ?? string.Empty,
                                AssignGrid.HostName ?? string.Empty,
                                AssignGrid.AssetType ?? string.Empty,
                                AssignGrid.Brand ?? string.Empty,
                                AssignGrid.Model ?? string.Empty,
                                AssignGrid.SerialNumber ?? string.Empty,
                                AssignGrid.CreatedBy ?? string.Empty,
                                AssignGrid.CreationTimeStamp ?? string.Empty,
                                AssignGrid.ModifiedBy ?? string.Empty,
                                AssignGrid.ModificationTimeStamp ?? string.Empty,
                            }
                        })
            };
            return Json(jsonData);
        }

        [HttpPost]
        public IActionResult SearchButtonITAsset(ITAssetDetailsModel itassetdetailmodel)
        {
            TempData["ITAssetDetailsModel"] = JsonConvert.SerializeObject(itassetdetailmodel);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult ResetButtonITAsset()
        {
            TempData["itassetdetailmodel"] = null;
            return Json(new { success = true });
        }

        public async Task<JsonResult> GetStatusITAsset(ITAssetDetailsModel iTAssetDetailsModel)
        {
            var cs = await _ITAssetDetailsRepository.GetStatusITAsset(iTAssetDetailsModel);
            return Json(cs);
        }

        [HttpPost]
        public async Task<IActionResult> SaveITAssetDetails1(ITAssetDetailsModel iTAssetDetailsModel)
        {
            bool success = false;
            bool duplicate = false;

            if (iTAssetDetailsModel.IDAsset == 0)
            {
                var response = await _ITAssetDetailsRepository.SaveITAssetDetails(iTAssetDetailsModel);
                success = response.Success;
                duplicate = response.Duplicate;
            }
            else
            {
                success = await _ITAssetDetailsRepository.UpdateITAssetDetails(iTAssetDetailsModel);
            }
            return Json(new { success, duplicate });
        }

        public async Task<JsonResult> DestroyRenderITAssetDropdowns()
        {
            List<ITAssetDetailsModel> iTAssetDetailsModels = await _ITAssetDetailsRepository.GetHostnameDropdownList();

            var HostNameList = (await _ITAssetDetailsRepository.GetHostnameDropdownList()).OrderBy(x => x.HostName).Where(x => !string.IsNullOrEmpty(x.HostName))
                          .Select(x => new SelectListItem { Text = x.HostName, Value = x.HostName });

            List<ITAssetDetailsModel> iTAssetDetailsModels1 = await _ITAssetDetailsRepository.GetAssetTypeDropdownList();

            var AssetTypeList = (await _ITAssetDetailsRepository.GetAssetTypeDropdownList()).OrderBy(x => x.AssetType).Where(x => !string.IsNullOrEmpty(x.AssetType))
                          .Select(x => new SelectListItem { Text = x.AssetType, Value = x.AssetType });

            List<ITAssetDetailsModel> iTAssetDetailsModels2 = await _ITAssetDetailsRepository.GetBrandDropdownList();

            var BrandList = (await _ITAssetDetailsRepository.GetBrandDropdownList()).OrderBy(x => x.Brand).Where(x => !string.IsNullOrEmpty(x.Brand))
                          .Select(x => new SelectListItem { Text = x.Brand, Value = x.Brand });

            List<ITAssetDetailsModel> iTAssetDetailsModels3 = await _ITAssetDetailsRepository.GetModelDropdownList();

            var ModelList = (await _ITAssetDetailsRepository.GetModelDropdownList()).OrderBy(x => x.Model).Where(x => !string.IsNullOrEmpty(x.Model))
                          .Select(x => new SelectListItem { Text = x.Model, Value = x.Model });

            List<ITAssetDetailsModel> iTAssetDetailsModels4 = await _ITAssetDetailsRepository.GetCountryFinal();

            var CountryList = (await _ITAssetDetailsRepository.GetCountryFinal()).OrderBy(x => x.Country).Where(x => !string.IsNullOrEmpty(x.Country))
                          .Select(x => new SelectListItem { Text = x.Country, Value = x.Country });

            List<ITAssetDetailsModel> iTAssetDetailsModels5 = await _ITAssetDetailsRepository.GetStatusDropdownList();

            var StatusList = (await _ITAssetDetailsRepository.GetStatusDropdownList()).OrderBy(x => x.Status).Where(x => !string.IsNullOrEmpty(x.Status))
                          .Select(x => new SelectListItem { Text = x.Status, Value = x.Status });

            List<ITAssetDetailsModel> iTAssetDetailsModels6 = await _ITAssetDetailsRepository.GetFullNameDropdownList();

            var FullNameList = (await _ITAssetDetailsRepository.GetFullNameDropdownList()).OrderBy(x => x.FullName).Where(x => !string.IsNullOrEmpty(x.FullName))
                          .Select(x => new SelectListItem { Text = x.FullName, Value = x.FullName });

            List<LocationModel> iTAssetDetailsModels7 = await _locationRepository.GetLocationFinal();

            var LocationList = (await _locationRepository.GetLocationFinal()).OrderBy(x => x.Location).Where(x => !string.IsNullOrEmpty(x.Location))
                          .Select(x => new SelectListItem { Text = x.Location, Value = x.Location });

            List<ITAssetDetailsModel> iTAssetDetailsModels8 = await _ITAssetDetailsRepository.GetSerialNrDropdownList();

            var SerialNrList = (await _ITAssetDetailsRepository.GetSerialNrDropdownList()).OrderBy(x => x.SerialNumber).Where(x => !string.IsNullOrEmpty(x.SerialNumber))
                          .Select(x => new SelectListItem { Text = x.SerialNumber, Value = x.SerialNumber });


            return Json(new { HostNameList, AssetTypeList, BrandList, ModelList, CountryList, StatusList, FullNameList, LocationList, SerialNrList });
        }
        //-------------------------------------------------------------------------------ITAsset List View Methods Ends
        //-------------------------------------------------------------------------------Infrastructure List View Methods Starts
        public async Task<JsonResult> GetInfrastructuredata(string sidx, string sort, int page, int rows)
        {
            string Region = string.Empty;
            string Country = string.Empty;
            string Location1 = string.Empty;

            InfrastructureModel infrastructureModel = new();
            if (TempData["InfrastructureModel"] != null)
            {
                var infrastructure = TempData["InfrastructureModel"]?.ToString() ?? string.Empty;
                infrastructureModel = JsonConvert.DeserializeObject<InfrastructureModel>(infrastructure) ?? new InfrastructureModel();
            }

            if (TempData["Region"] != null)
            {
                Region = TempData["Region"]?.ToString() ?? string.Empty;
            }
            if (TempData["Country"] != null)
            {
                Country = TempData["Country"]?.ToString() ?? string.Empty;
            }
            if (TempData["Location1"] != null)
            {
                Location1 = TempData["Location1"]?.ToString() ?? string.Empty;
            }
            if (!string.IsNullOrEmpty(Region) || !string.IsNullOrEmpty(Country) || !string.IsNullOrEmpty(Location1))
            {
                var Data = await _locationRepository.GetLocationID(Region, Country, Location1);
                if (Data.Count > 0)
                {
                    int Lastindex = Data.Count - 1;
                    for (int i = 0; i < Data.Count; i++)
                    {
                        if (i == Lastindex)
                        {
                            infrastructureModel.Remark += Data[i].IDLocation;
                        }
                        else
                        {
                            infrastructureModel.Remark += Data[i].IDLocation + ",";
                        }
                    }
                }
            }

            var InfraList = await _infrastructureRepository.GetInfrastructureList(infrastructureModel);
            foreach (var item in InfraList)
            {
                var LocationDet = (await _infrastructureRepository.GetLocationfromID(item.IDLocation));
                item.Location = LocationDet.Location;
            }

            var infrastructureList = ObjectTranslation.ConvertInfrastructureList(InfraList);
            int totalRecords = infrastructureList.Count;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (from InfrastructureGrid in infrastructureList
                        select new
                        {
                            InfrastructureGrid.IDLocation,
                            cell = new string[]
                            {
                                InfrastructureGrid.IDInfra?? string.Empty,
                                string.Empty,
                                InfrastructureGrid.IDInfraDis ?? string.Empty,
                                InfrastructureGrid.IDLocation ?? string.Empty,
                                InfrastructureGrid.AssetType ?? string.Empty,
                                InfrastructureGrid.Brand ?? string.Empty,
                                InfrastructureGrid.Model ?? string.Empty,
                                InfrastructureGrid.SerialNumber ?? string.Empty,
                                InfrastructureGrid.PurchaseYear ?? string.Empty,
                                InfrastructureGrid.Remark ?? string.Empty,
                                InfrastructureGrid.Unit ?? string.Empty,
                                InfrastructureGrid.Location ?? string.Empty,
                                InfrastructureGrid.Status ?? string.Empty,
                                InfrastructureGrid.CreatedBy ?? string.Empty,
                                InfrastructureGrid.CreationTimeStamp ?? string.Empty,
                                InfrastructureGrid.ModifiedBy ?? string.Empty,
                                InfrastructureGrid.ModificationTimeStamp ?? string.Empty,
                                InfrastructureGrid.ActivityLog?? string.Empty
                            }
                        })
            };
            return Json(jsonData);
        }

        public async Task<JsonResult> GetStatusInfra(InfrastructureModel infrastructureModel)
        {
            var cs = await _infrastructureRepository.GetStatusInfra(infrastructureModel);
            return Json(cs);
        }

        [HttpPost]
        public async Task<IActionResult> SaveInfraStructure(InfrastructureModel infrastructureModel)
        {
            bool success = false;
            bool duplicate = false;

            if (infrastructureModel.IDInfra == 0)
            {
                var response = await _infrastructureRepository.SaveInfrastructure(infrastructureModel);
                success = response.Success;
                duplicate = response.Duplicate;
            }
            else
            {
                success = await _infrastructureRepository.UpdateInfrastructure(infrastructureModel);
            }
            return Json(new { success, duplicate });
        }

        [HttpPost]
        public ActionResult SearchButtonInfrastructure(InfrastructureModel infrastructureModel)
        {
            TempData["InfrastructureModel"] = JsonConvert.SerializeObject(infrastructureModel);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult ResetButtonInfrastructure()
        {
            TempData["infrastructuremodel"] = null;
            return Json(new { success = true });
        }

        public async Task<JsonResult> DestroyRenderInfraDropdowns()
        {
            List<InfrastructureModel> infrastructureModels = await _infrastructureRepository.GetSerialnumberDropdownList();

            var SerialNoList = (await _infrastructureRepository.GetSerialnumberDropdownList()).OrderBy(x => x.SerialNumber).Where(x => !string.IsNullOrEmpty(x.SerialNumber))
                          .Select(x => new SelectListItem { Text = x.SerialNumber, Value = x.SerialNumber });

            List<InfrastructureModel> infrastructureModels1 = await _infrastructureRepository.GetModelDropdownList();

            var ModelList = (await _infrastructureRepository.GetModelDropdownList()).OrderBy(x => x.Model).Where(x => !string.IsNullOrEmpty(x.Model))
                          .Select(x => new SelectListItem { Text = x.Model, Value = x.Model });

            List<InfrastructureModel> infrastructureModels2 = await _infrastructureRepository.GetBrandDropdownList();

            var BrandList = (await _infrastructureRepository.GetBrandDropdownList()).OrderBy(x => x.Brand).Where(x => !string.IsNullOrEmpty(x.Brand))
                          .Select(x => new SelectListItem { Text = x.Brand, Value = x.Brand });

            List<InfrastructureModel> infrastructureModels3 = await _infrastructureRepository.GetAssetTypeDropdownList();

            var AssetTypeList = (await _infrastructureRepository.GetAssetTypeDropdownList()).OrderBy(x => x.AssetType).Where(x => !string.IsNullOrEmpty(x.AssetType))
                          .Select(x => new SelectListItem { Text = x.AssetType, Value = x.AssetType });





            return Json(new { SerialNoList, ModelList, BrandList, AssetTypeList });
        }
        //-------------------------------------------------------------------------------Infrastructure List View Methods Ends

        public async Task<JsonResult> GetCountriesData(string regionName)
        {
            var cs = await _locationRepository.GetCoutriesData(regionName);
            return Json(cs);
        }

        public async Task<JsonResult> GetLocationcontent(string countryName)
        {
            var cs = await _locationRepository.GetLocationData(countryName);
            return Json(cs);
        }

        public JsonResult GetManipulationITAssetGrid(string Region, string Country, string Location1)
        {
            TempData["Region"] = Region;
            TempData["Country"] = Country;
            TempData["Location1"] = Location1;
            return Json(new { success = true });
        }

        //----------------------------------------------------------------Export Data Methods--------------------------------------------//

        [HttpGet]
        public async Task<IActionResult> ExportUserData(UserDetails userDetails)
        {
            string filename = "";
            if (userDetails.Location == null)
            {
                filename = string.Format("LegendAsiaUserList-({0}).xlsx", DateTime.Now.ToString("ddMMyyyy"));
            }
            else
            {
                filename = string.Format("LegendAsiaUserList-({0})({1}).xlsx", userDetails.Location, DateTime.Now.ToString("ddMMyyyy"));
            }


            var weeklyLiftings = ObjectTranslation.ConvertUserList(await _userDetailsRepository.GetUserList(userDetails));

            if (weeklyLiftings.Any())
            {
                DataTable dataTable = CreateUserList(weeklyLiftings);
                using (XLWorkbook xLWorkbook = new())
                {
                    var workSheet = xLWorkbook.Worksheets.Add(dataTable, "User Data");
                    //for (int rowIndex = 2; rowIndex <= dataTable.Rows.Count + 1; rowIndex++)
                    //{
                    //    workSheet.Worksheet.Cell(rowIndex, 20).DataType = XLDataType.Number;
                    //    workSheet.Worksheet.Cell(rowIndex, 21).DataType = XLDataType.Number;
                    //    workSheet.Worksheet.Cell(rowIndex, 22).DataType = XLDataType.Number;
                    //    workSheet.Worksheet.Cell(rowIndex, 23).DataType = XLDataType.Number;
                    //    workSheet.Worksheet.Cell(rowIndex, 24).DataType = XLDataType.Number;
                    //    workSheet.Worksheet.Cell(rowIndex, 25).DataType = XLDataType.Number;
                    //    workSheet.Worksheet.Cell(rowIndex, 32).DataType = XLDataType.Number;
                    //}
                    using (MemoryStream stream = new())
                    {
                        xLWorkbook.SaveAs(stream);
                        byte[] byteStream = stream.ToArray();
                        string contentType = string.Empty;
                        var contentDisposition = new ContentDisposition
                        {
                            FileName = filename,
                            Inline = true
                        };
                        Response.Headers.Add("content-disposition", contentDisposition.ToString());
                        contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        return File(byteStream, contentType);
                    };
                };
            }
            else
            {
                return Json(new { error = "Unable to Export Document. Please contact IT Support" });
            }
        }

        private static DataTable CreateUserList(List<TranslatedUserDetails> UserRecords)
        {
            DataTable dataTable = new("User Data");
            dataTable.Columns.AddRange(new DataColumn[7]
                        {
                      //new DataColumn("IDUser"),
                      new DataColumn("FullName"),
                      //new DataColumn("Role"),
                      new DataColumn("Department"),
                      new DataColumn("Designation"),
                      new DataColumn("Unit"),
                      new DataColumn("EmailID"),
                      new DataColumn("Location"),
                      new DataColumn("Status")
                        });

            foreach (var item in UserRecords)
            {
                dataTable.Rows.Add(item.FullName, item.Department, item.Designation, item.Unit, item.EmailID, item.Location, item.Status);

            }
            return dataTable;
        }

        [HttpGet]
        public async Task<IActionResult> ExportITAssetData(ITAssetDetailsModel iTAssetDetailsModel)
        {
            string filename = "";

            if (iTAssetDetailsModel.Country != null)
            {
                filename = string.Format("LegendAsiaAssetList-({0})({1}).xlsx", iTAssetDetailsModel.Country, DateTime.Now.ToString("ddMMyyyy"));
            }
            else if ((iTAssetDetailsModel.Location != null))
            {
                filename = string.Format("LegendAsiaAssetList-({0})({1}).xlsx", iTAssetDetailsModel.Location, DateTime.Now.ToString("ddMMyyyy"));
            }
            else
            {
                filename = string.Format("LegendAsiaAssetList-({0}).xlsx", DateTime.Now.ToString("ddMMyyyy"));
            }

            var weeklyLiftings = ObjectTranslation.ConvertITAssetList(await _ITAssetDetailsRepository.GetITAssetDetailsList(iTAssetDetailsModel));

            if (weeklyLiftings.Any())
            {
                DataTable dataTable = CreateITAssetList(weeklyLiftings);
                using (XLWorkbook xLWorkbook = new())
                {
                    var workSheet = xLWorkbook.Worksheets.Add(dataTable, "Asset Data");
                    using (MemoryStream stream = new())
                    {
                        xLWorkbook.SaveAs(stream);
                        byte[] byteStream = stream.ToArray();
                        string contentType = string.Empty;
                        var contentDisposition = new ContentDisposition
                        {
                            FileName = filename,
                            Inline = true
                        };
                        Response.Headers.Add("content-disposition", contentDisposition.ToString());
                        contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        return File(byteStream, contentType);
                    };
                };

            }
            else
            {
                return Json(new { error = "Unable to Export Document. Please contact IT Support" });
            }
        }

        private static DataTable CreateITAssetList(List<TranslatedITAssetDetailsModel> ITAssetRecords)
        {
            DataTable dataTable = new("Asset Data");
            dataTable.Columns.AddRange(new DataColumn[22]
                        {
                      new DataColumn("HostName"),
                      new DataColumn("AssetType"),
                      new DataColumn("Brand"),
                      new DataColumn("Model"),
                      new DataColumn("SerialNumber"),
                      new DataColumn("PurchaseYear"),
                      new DataColumn("FullName"),
                      new DataColumn("EmailID"),
                      new DataColumn("Designation"),
                      new DataColumn("Department"),
                      new DataColumn("Location"),
                      new DataColumn("Unit"),
                      new DataColumn("CPU"),
                      new DataColumn("Memory"),
                      new DataColumn("HDD"),
                      new DataColumn("Monitor"),
                      new DataColumn("Keyboard"),
                      new DataColumn("Mouse"),
                      new DataColumn("OS"),
                      new DataColumn("MSOffice"),
                      new DataColumn("Software"),
                      new DataColumn("HeadPhone"),
                        });

            foreach (var item in ITAssetRecords)
            {
                dataTable.Rows.Add(item.HostName, item.AssetType, item.Brand, item.Model, item.SerialNumber, item.PurchaseYear,
                    item.FullName, item.EmailID, item.Designation, item.Department, item.Location, item.Unit, item.CPU, item.Memory, item.HDD, item.Monitor, item.Keyboard, item.Mouse, item.OS, item.MSOffice, item.Software, item.HeadPhone);

            }
            return dataTable;
        }

        [HttpGet]
        public async Task<IActionResult> ExportLocationData(LocationModel locationModel)
        {

            string filename = string.Format("LegendAsiaLocation.xlsx", DateTime.Now.ToString("yyyyMMddHHmmssfff"));

            var weeklyLiftings = ObjectTranslation.ConvertLocationList(await _locationRepository.GetLocationList(locationModel));

            if (weeklyLiftings.Any())
            {
                DataTable dataTable = CreateLocationList(weeklyLiftings);
                using (XLWorkbook xLWorkbook = new())
                {
                    var workSheet = xLWorkbook.Worksheets.Add(dataTable, "Location Data");
                    using (MemoryStream stream = new())
                    {
                        xLWorkbook.SaveAs(stream);
                        byte[] byteStream = stream.ToArray();
                        string contentType = string.Empty;
                        var contentDisposition = new ContentDisposition
                        {
                            FileName = filename,
                            Inline = true
                        };
                        Response.Headers.Add("content-disposition", contentDisposition.ToString());
                        contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        return File(byteStream, contentType);
                    };
                };

            }
            else
            {
                return Json(new { error = "Unable to print Document. Please contact IT Support" });
            }
        }

        private static DataTable CreateLocationList(List<TranslatedLocationModel> LocationRecords)
        {
            DataTable dataTable = new("Location Data");
            dataTable.Columns.AddRange(new DataColumn[4]
                        {
                      new DataColumn("Region"),
                      new DataColumn("Country"),
                      new DataColumn("Location"),
                      new DataColumn("ModifiedBy")
                        });

            foreach (var item in LocationRecords)
            {
                dataTable.Rows.Add(item.Region, item.Country, item.Location, item.ModifiedBy);

            }
            return dataTable;
        }

        [HttpGet]
        public async Task<IActionResult> ExportInfraData(InfrastructureModel infrastructureModel)
        {
            string filename = "";
            if (infrastructureModel.Location == null)
            {
                filename = string.Format("LegendAsiaInfrastructureList-({0}).xlsx", DateTime.Now.ToString("ddMMyyyy"));
            }
            else
            {
                filename = string.Format("LegendAsiaInfrastructureList-({0})({1}).xlsx", infrastructureModel.Location, DateTime.Now.ToString("ddMMyyyy"));
            }

            var weeklyLiftings = ObjectTranslation.ConvertInfrastructureList(await _infrastructureRepository.GetInfrastructureList(infrastructureModel));

            if (weeklyLiftings.Any())
            {
                DataTable dataTable = CreateInfraList(weeklyLiftings);
                using (XLWorkbook xLWorkbook = new())
                {
                    var workSheet = xLWorkbook.Worksheets.Add(dataTable, "ITAsset Data");
                    using (MemoryStream stream = new())
                    {
                        xLWorkbook.SaveAs(stream);
                        byte[] byteStream = stream.ToArray();
                        string contentType = string.Empty;
                        var contentDisposition = new ContentDisposition
                        {
                            FileName = filename,
                            Inline = true
                        };
                        Response.Headers.Add("content-disposition", contentDisposition.ToString());
                        contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        return File(byteStream, contentType);
                    };
                };

            }
            else
            {
                return Json(new { error = "Unable to Export Document. Please contact IT Support" });
            }
        }

        private static DataTable CreateInfraList(List<TranslatedInfrastrutureModel> InfraRecords)
        {
            DataTable dataTable = new("ITAsset Data");
            dataTable.Columns.AddRange(new DataColumn[8]
                        {
                      new DataColumn("AssetType"),
                      new DataColumn("Brand"),
                      new DataColumn("Model"),
                      new DataColumn("SerialNumber"),
                      new DataColumn("ModifiedBy"),
                      new DataColumn("PurchaseYear"),
                      new DataColumn("Location"),
                      new DataColumn("Status")
            });

            foreach (var item in InfraRecords)
            {
                dataTable.Rows.Add(item.AssetType, item.Brand, item.Model, item.SerialNumber, item.ModifiedBy, item.PurchaseYear, item.Location, item.Status);

            }
            return dataTable;
        }

        [HttpPost]
        public async Task<IActionResult> AssignITAsset(ITAssetDetailsModel iTAssetDetailsModel)
        {
            bool success = await _ITAssetDetailsRepository.AddAssignDetails(iTAssetDetailsModel);
            return Json(new { success });
        }

        [HttpGet]
        public async Task<IActionResult> GetUserDataByUserID(int id)
        {
            bool success = false;
            var cs = await _userDetailsRepository.GetUserDetailsById(id);
            return Json(new { success });
        }

        public IActionResult ReloadGridsByID(int UserID)
        {
            TempData["IdUser"] = UserID;
            return Json(new { success = true });
        }

        public async Task<IActionResult> UpdateAssetStatus(int UserID, string Status, string SerialNr)
        {
            bool Success = false;


            Success = await _ITAssetDetailsRepository.UpdateAssetStatus(SerialNr, Status, UserID);
            if (Success && Status != "ASSIGNED")
            {
                _ = await _ITAssetDetailsRepository.LastUserValue(UserID, SerialNr);
                _ = await _ITAssetDetailsRepository.DeleteAssignedAssetByUserID(UserID, SerialNr);
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> TransferITAssetDetails(ITAssetDetailsModel iTAssetDetailsModel)
        {
            bool success = false;

            var response = await _ITAssetDetailsRepository.TransferedToAnotherSystem(iTAssetDetailsModel);
            success = response.Success;
            success = await _ITAssetDetailsRepository.TransferedAndDeleted(iTAssetDetailsModel);


            return Json(new { success });
        }

        [HttpPost]
        public async Task<IActionResult> TransferUserDetails(UserDetails userDetails)
        {
            bool success = false;

            var response = await _userDetailsRepository.TransferUserDetails(userDetails);
            success = response.Success;
            success = await _userDetailsRepository.TransferedAndDeletedUser(userDetails);

            return Json(new { success });
        }

        [HttpPost]
        public async Task<IActionResult> TransferInfraDetails(InfrastructureModel infrastructureModel)
        {
            bool success = false;

            var response = await _infrastructureRepository.TransferInfraDetails(infrastructureModel);
            success = response.Success;
            success = await _infrastructureRepository.TransferedAndDeletedInfra(infrastructureModel);

            return Json(new { success });
        }
    }
}
