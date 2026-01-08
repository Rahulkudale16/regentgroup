using Dapper;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using LegendAsiaAsset.Models;
using LegendAsiaAsset.TranslatedModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LegendAsiaAsset.Data
{
    public class ObjectTranslation
    {
        // To convert Datetime Values
        public static string? ConvertDate(DateTime? dateTime)
        {
            if (dateTime == null || dateTime == DateTime.MinValue)
            {
                return string.Empty;
            }
            else
            {
                return dateTime?.ToString("dd-MM-yyyy");
            }
        }

        // Location List View
        public static List<TranslatedLocationModel> ConvertLocationList(List<LocationModel> locationModel)
        {
            List<TranslatedLocationModel> translatedLocationModel = new();
            foreach (var item in locationModel)
            {
                translatedLocationModel.Add(new TranslatedLocationModel
                {
                    IDLocation = item.IDLocation.ToString(),
                    Region = item.Region ?? string.Empty,
                    Country = item.Country ?? string.Empty,
                    Location = item.Location ?? string.Empty,
                    CreatedBy = item.CreatedBy ?? string.Empty,
                    CreationTimeStamp = item.CreationTimeStamp.ToString() ?? string.Empty,
                    ModifiedBy = item.ModifiedBy?? string.Empty,
                    ModificationTimeStamp = item.ModificationTimeStamp.ToString() ?? string.Empty,
                    Status = item.Status ?? string.Empty,
                    IDLocationDis = item.IDLocationDis ?? string.Empty,
                });
            }
            return translatedLocationModel;
        }

        // User List View
        public static List<TranslatedUserDetails> ConvertUserList(List<UserDetails> userDetails)
        {
            List<TranslatedUserDetails> translatedUserDetails = new();
            foreach (var item in userDetails)
            {
                translatedUserDetails.Add(new TranslatedUserDetails
                {
                    IDUser = item.IDUser.ToString(),
                    IDLocation = item.IDLocation.ToString(),
                    FullName = item.FullName ?? string.Empty,
                    Role = item.Role ?? string.Empty,
                    Department = item.Department ?? string.Empty,
                    Designation = item.Designation ?? string.Empty,
                    UserName = item.UserName ?? string.Empty,
                    Password = item.Password ?? string.Empty,
                    Unit = item.Unit ?? string.Empty,
                    EmailID = item.EmailID ?? string.Empty,
                    Domain = item.Domain ?? string.Empty,
                    Status = item.Status ?? string.Empty,
                    CreatedBy = item.CreatedBy ?? string.Empty,
                    CreationTimeStamp = item.CreationTimeStamp.ToString() ?? string.Empty,
                    ModifiedBy = item.ModifiedBy ?? string.Empty,
                    Location = item.Location ?? string.Empty,
                    ModificationTimeStamp = item.ModificationTimeStamp.ToString() ?? string.Empty,
                    IDUserDis = item.IDUserDis ?? string.Empty,
                });
            }
            return translatedUserDetails;
        }

        // Infrastructure List View
        public static List<TranslatedInfrastrutureModel> ConvertInfrastructureList(List<InfrastructureModel> infrastructureModel)
        {
            List<TranslatedInfrastrutureModel> translatedInfrastrutureModel = new();
            foreach (var item in infrastructureModel)
            {
                translatedInfrastrutureModel.Add(new TranslatedInfrastrutureModel
                {
                    IDInfra = item.IDInfra.ToString(),
                    IDLocation = item.IDLocation.ToString(),
                    AssetType = item.AssetType ?? string.Empty,
                    Brand = item.Brand ?? string.Empty,
                    Model = item.Model ?? string.Empty,
                    SerialNumber = item.SerialNumber ?? string.Empty,
                    PurchaseYear = ConvertDate(item.PurchaseYear),
                    Remark = item.Remark ?? string.Empty,
                    InvoiceNo = item.InvoiceNo ?? string.Empty,
                    PaidBy = item.PaidBy ?? string.Empty,
                    Unit = item.Unit ?? string.Empty,
                    Location = item.Location ?? string.Empty,
                    Status = item.Status ?? string.Empty,
                    CreatedBy = item.CreatedBy ?? string.Empty,
                    CreationTimeStamp = item.CreationTimeStamp.ToString() ?? string.Empty,
                    ModifiedBy = item.ModifiedBy ?? string.Empty,
                    ModificationTimeStamp = item.ModificationTimeStamp.ToString() ?? string.Empty,
                    IDInfraDis = item.IDInfraDis ?? string.Empty,
                });
            }
            return translatedInfrastrutureModel;
        }
        
        // ITAsset Details List View
        public static List<TranslatedITAssetDetailsModel> ConvertITAssetList(List<ITAssetDetailsModel> itAssetDetailsModel)
        {
            List<TranslatedITAssetDetailsModel> translatedAssetDetailsModel = new();
            foreach (var item in itAssetDetailsModel)
            {
                translatedAssetDetailsModel.Add(new TranslatedITAssetDetailsModel
                {
                    AssetID = item.AssetID ?? string.Empty,
                    IDAsset = item.IDAsset.ToString(),
                    IDAssign = item.IDAssign.ToString(),
                    UserID = item.UserID.ToString(),
                    IDLocation = item.IDLocation.ToString(),
                    HostName= item.HostName ?? string.Empty,
                    AssetType= item.AssetType ?? string.Empty,
                    Brand = item.Brand ?? string.Empty,
                    Model = item.Model ?? string.Empty,
                    SerialNumber = item.SerialNumber ?? string.Empty,
                    PurchaseYear = ConvertDate(item.PurchaseYear),
                    FullName = item.FullName ?? string.Empty,
                    LastUser = item.LastUser ?? string.Empty,
                    Location = item.Location ?? string.Empty,
                    Region = item.Region ?? string.Empty,
                    Country = item.Country ?? string.Empty,
                    Unit = item.Unit ?? string.Empty,
                    CPU = item.CPU ?? string.Empty,
                    Memory = item.Memory ?? string.Empty,
                    HDD = item.HDD ?? string.Empty,
                    OS = item.OS ?? string.Empty,
                    Software = item.Software ?? string.Empty,
                    Remark = item.Remark ?? string.Empty,
                    Domain = item.Domain ?? string.Empty,
                    Status = item.Status ?? string.Empty,
                    CreatedBy = item.CreatedBy ?? string.Empty,
                    CreationTimeStamp = item.CreationTimeStamp.ToString() ?? string.Empty,
                    ModifiedBy = item.ModifiedBy ?? string.Empty,
                    ModificationTimeStamp = item.ModificationTimeStamp.ToString() ?? string.Empty,
                    IDAssetDis = item.IDAssetDis ?? string.Empty,
                    Monitor = item.Monitor ?? string.Empty,
                    Mouse = item.Mouse ?? string.Empty,
                    Keyboard = item.Keyboard ?? string.Empty,
                    MSOffice = item.MSOffice.ToString(),
                    EmailID = item.EmailID ?? string.Empty,
                    Designation = item.Designation ?? string.Empty,
                    HeadPhone = item.HeadPhone ?? string.Empty,
                    Department = item.Department ?? string.Empty,
                    LastAssetLocation = item.LastAssetLocation ?? string.Empty,
                    InvoiceNo = item.InvoiceNo ?? string.Empty,
                    PaidBy = item.PaidBy ?? string.Empty,
                    ActivityLog = item.ActivityLog ?? string.Empty
                });
            }
            return translatedAssetDetailsModel;
        }

        //public static int GenerateRandomPassword()
        //{
        //    Random random = new();
        //    int number = random.Next(100000, 999999);
        //    return number;
        //}

        //public static string ToPascalCase(string original)
        //{
        //    // replace white spaces with undescore, then replace all invalid chars with empty string
        //    var pascalcase = invalidcharsrgx().replace(whitespace().replace(original, "_"), string.empty)
        //        // split by underscores
        //        .split(new char[] { '_' }, stringsplitoptions.removeemptyentries)
        //        // set first letter to uppercase
        //        .select(w => startswithlowercasechar().replace(w, m => m.value.toupper()))
        //        // replace second and all following upper case letters to lower if there is no next lower (abc -> abc)
        //        .select(w => firstcharfollowedbyuppercasesonly().replace(w, m => m.value.tolower()))
        //        // set upper case the first lower case following a number (ab9cd -> ab9cd)
        //        .select(w => lowercasenexttonumber().replace(w, m => m.value.toupper()))
        //        // lower second and next upper case letters except the last if it follows by any lower (abcdef -> abcdef)
        //        .select(w => uppercaseinside().replace(w, m => m.value.tolower()));

        //    return string.concat(pascalcase);
        //}

        public static List<TranslatedUserDetails> ConvertDocUploadFileDetails(List<UserDetails> userDetails)
        {
                List<TranslatedUserDetails> translatedFileUploads = new();
            foreach (var item in userDetails)
            {
                translatedFileUploads.Add(new TranslatedUserDetails
                {
                    IDDoc = item.IDDoc.ToString(),
                    IDUser = item.IDUser.ToString(),
                    DocType = item.DocType,
                    DocName = item.DocName,
                    DocSize = item.DocSize.ToString("0.00") + "MB",
                    CreatedBy = item.CreatedBy,
                    CreationTimeStamp = item.CreationTimeStamp.ToString(),
                    ModifiedBy = item.ModifiedBy,
                    //ModificationTimeStamp = item.ModificationTimeStamp,
                    //CreationTimestamp = ConvertDate(item.CreationTimestamp),
                    //WebModifiedBy = item.WebModifiedBy,
                    //ModificationTimestamp = ConvertDate(item.ModificationTimestamp),
                    ContentType = item.ContentType,
                    //UniversalSerialNr = item.UniversalSerialNr,
                    //DocumentName = item.DocumentName,
                });
            }
            return translatedFileUploads;
        }
    }
}
