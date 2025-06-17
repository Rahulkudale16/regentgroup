using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;
using System.Reflection;
using System.Security.Claims;

namespace LegendAsiaAsset.Data
{
    public class Constant
    {
        public static readonly int sessionTimeout = 3600;
        //public static readonly int sessionTimeoutReminder = 100;
        public static readonly int sessionTimeoutReminder = 300;
        public const string LocationDuplicateMessage = "Duplicate Location {0} already exist!";
        //path added for upload 30/10
        public const string UploadDocumentsFilePathPROD = @"C:\\ITAsset\";
        public const string UploadDocumentsFilePathDEV = @"C:\\ITAsset\";
        public const string UploadDocumentsFilePathUAT = @"C:\\UAT\ITAsset\";
        public const string UploadDocumentsFilePathLOCAL = @"C:\\ITAsset\";
        //public const string ShipmetfilesServerFilePathUAT = @"\\172.16.10.28\Tank(UAT)\ShipmentFiles";
        //public const string ShipmetfilesServerFilePathLOCAL = @"C:\\Tank\ShipmentFiles";

        public static List<SelectListItem> GetRoleDropdown()
        {
            List<SelectListItem> role = new()
            {

                new SelectListItem
                {
                    Text = "SUPERUSER",
                    Value = "SUPERUSER"
                },
                 new SelectListItem()
                 {
                     Text = "ADMIN",
                     Value = "ADMIN"
                 },
                 new SelectListItem()
                 {
                     Text = "HR",
                     Value = "HR"
                 },
                 new SelectListItem
                {
                    Text = "USER",
                    Value = "USER"
                },

            };
            return role;
        }

        public static List<SelectListItem> GetDepartmentDropdown()
        {
            List<SelectListItem> department = new()
            {

                new SelectListItem
                {
                    Text = "ACCOUNTS",
                    Value = "ACCOUNTS"
                },
                 new SelectListItem
                {
                    Text = "ADMIN",
                    Value = "ADMIN"
                },
                 new SelectListItem()
                 {
                     Text = "AUTOMOTIVE LOGISTICS",
                     Value ="AUTOMOTIVE LOGISTICS"
                 },
                 new SelectListItem()
                 {
                     Text = "AUTOMOTIVE LOGISTICS",
                     Value ="AUTOMOTIVE LOGISTICS"
                 },
                 new SelectListItem()
                 {
                     Text = "BUSINESS INFORMATION OFFICE",
                     Value = "BUSINESS INFORMATION OFFICE"
                 },
                 new SelectListItem()
                 {
                     Text = "BUSS PERFORMANCE MGT",
                     Value = "BUSS PERFORMANCE MGT"
                 },
                 new SelectListItem()
                 {
                     Text = "CEO'S OFFICE",
                     Value = "CEO'S OFFICE"
                 },
                 new SelectListItem()
                 {
                     Text = "CONTAINER SHIPPING",
                     Value = "CONTAINER SHIPPING"
                 },
                 new SelectListItem()
                 {
                     Text = "FINANCE",
                     Value = "FINANCE"
                 },
                 new SelectListItem()
                 {
                     Text = "FINANCE SETTLEMENT TEAM",
                     Value = "FINANCE SETTLEMENT TEAM"
                 },
                 new SelectListItem()
                 {
                     Text = "GLOBAL FREIGHT MGT & AGENCY",
                     Value = "GLOBAL FREIGHT MGT & AGENCY"
                 },
                 new SelectListItem()
                 {
                     Text = "HR",
                     Value = "HR"
                 },
                 new SelectListItem()
                 {
                     Text = "INTEGRATED LOGISTICS",
                     Value = "INTEGRATED LOGISTICS"
                 },
                 new SelectListItem()
                 {
                     Text ="ISO TANK",
                     Value = "ISO TANK"
                 },
                 new SelectListItem()
                 {
                     Text = "IT/BUSINESS PROCESS",
                     Value = "IT/BUSINESS PROCESS"
                 },
                 new SelectListItem()
                 {
                     Text = "LAND LOGISTICS",
                     Value = "LAND LOGISTICS"
                 },
                 new SelectListItem()
                 {
                     Text = "IT",
                     Value = "IT"
                 },
                 new SelectListItem()
                 {
                     Text = "LEGAL",
                     Value = "LEGAL"
                 },
                 new SelectListItem()
                 {
                     Text = "LIL BGC",
                     Value = "LIL BGC"
                 },
                 new SelectListItem()
                 {
                     Text = "LOCAL TRANSPORTATION",
                     Value = "LOCAL TRANSPORTATION"
                 },
                 new SelectListItem()
                 {
                     Text = "MARINE LOGISTICS & BREAKBULK",
                     Value = "MARINE LOGISTICS & BREAKBULK"
                 },
                 new SelectListItem()
                 {
                     Text = "SENIOR MANAGEMENT",
                     Value = "SENIOR MANAGEMENT"
                 },
                 new SelectListItem()
                 {
                     Text = "TRADELOGIC",
                     Value = "TRADELOGIC"
                 },
                 new SelectListItem()
                 {
                     Text = "YACHT | PROJECTS",
                     Value = "YACHT | PROJECTS"
                 },
            };

            return department;
        }

        public static List<SelectListItem> GetDesignationDropdown()
        {
            List<SelectListItem> designation = new()
            {

                new SelectListItem
                {
                    Text = "ACCOUNTS EXECUTIVE",
                    Value = "ACCOUNTS EXECUTIVE"
                },
                 new SelectListItem
                {
                    Text = "FINANCIAL CONTROLLER",
                    Value = "FINANCIAL CONTROLLER"
                },

                 new SelectListItem()
                 {
                     Text = "CHIEF FINANCIAL OFFICER",
                     Value = "CHIEF FINANCIAL OFFICER"
                 },
                 new SelectListItem()
                 {
                     Text = "FINANCE MANAGER",
                     Value = "FINANCE MANAGER"
                 },
                 new SelectListItem()
                 {
                     Text = "OFFICE CLEANER",
                     Value = "OFFICE CLEANER"
                 },
                 new SelectListItem()
                 {
                     Text = "ADMIN MANAGER",
                     Value = "ADMIN MANAGER"
                 },
                 new SelectListItem()
                 {
                     Text = "ADMIN EXECUTIVE",
                     Value = "ADMIN EXECUTIVE"
                 },
                 new SelectListItem()
                 {
                     Text = "EXECUTIVE DIRECTOR, ADMIN & PR",
                     Value = "EXECUTIVE DIRECTOR, ADMIN & PR"
                 },
                 new SelectListItem()
                 {
                     Text = "SUPPORT ASSISTANT",
                     Value = "SUPPORT ASSISTANT"
                 },
                 new SelectListItem()
                 {
                     Text = "SENIOR OPERATIONS MANAGER",
                     Value = "SENIOR OPERATIONS MANAGER"
                 },
                 new SelectListItem()
                 {
                     Text = "SYSTEM ADMINISTRATOR",
                     Value = "SYSTEM ADMINISTRATOR"
                 },
                 new SelectListItem()
                 {
                     Text = "BUSS PERFORMANCE CONTROLLER",
                     Value = "BUSS PERFORMANCE CONTROLLER"
                 },
                 new SelectListItem()
                 {
                     Text = "DIRECTOR",
                     Value = "DIRECTOR"
                 },
                 new SelectListItem()
                 {
                     Text = "EXECUTIVE",
                     Value = "EXECUTIVE"
                 },
                 new SelectListItem()
                 {
                     Text = "DEPUTY GROUP CEO",
                     Value = "DEPUTY GROUP CEO"
                 },
                 new SelectListItem()
                 {
                     Text = "SENIOR TRADE MANAGER",
                     Value = "SENIOR TRADE MANAGER"
                 },
                 new SelectListItem()
                 {
                     Text = "EQUIPMENT CONTROLLER",
                     Value = "EQUIPMENT CONTROLLER"
                 },
                 new SelectListItem()
                 {
                     Text = "TRADE EXECUTIVE",
                     Value = "TRADE EXECUTIVE"
                 },
                 new SelectListItem()
                 {
                     Text = "ASSISTANT MANAGER",
                     Value = "ASSISTANT MANAGER"
                 },
                 new SelectListItem()
                 {
                     Text = "GENERAL MANAGER",
                     Value = "GENERAL MANAGER"
                 },
                 new SelectListItem()
                 {
                     Text = "SENIOR EXECUTIVE",
                     Value = "SENIOR EXECUTIVE"
                 },
                 new SelectListItem()
                 {
                     Text = "OPERATIONS EXECUTIVE",
                     Value = "OPERATIONS EXECUTIVE"
                 },
                 new SelectListItem()
                 {
                     Text = "SALES EXECUTIVE",
                     Value = "SALES EXECUTIVE"
                 },
                 new SelectListItem()
                 {
                     Text = "TEAM LEAD (SOFTWARE DEVELPOER)",
                     Value = "TEAM LEAD (SOFTWARE DEVELPOER)"
                 },
                 new SelectListItem()
                 {
                     Text = "SOFTWARE DEVELPOER",
                     Value = "SOFTWARE DEVELPOER"
                 },
            };
            return designation;
        }

        public static List<SelectListItem> GetRegion()
        {
            List<SelectListItem> Region = new()
            {

                new SelectListItem
                {
                    Text = "ASIA",
                    Value = "ASIA",

                },
                new SelectListItem
                {
                    Text = "EUROPE",
                    Value = "EUROPE",

                },
                new SelectListItem
                {
                    Text = "NORTH AMERICA",
                    Value = "NORTH AMERICA",

                },
                new SelectListItem
                {
                    Text = "SOUTH AMERICA",
                    Value = "SOUTH AMERICA",

                },
                new SelectListItem
                {
                    Text = "OCEANIA",
                    Value = "OCEANIA",
                },
            };

            return Region;
        }

        public static List<SelectListItem> GetCountry(string region)
        {
            List<SelectListItem> Country = new();

            if (region == "ASIA" || string.IsNullOrEmpty(region))
            {
                Country.Add(new SelectListItem
                {
                    Text = "CHINA",
                    Value = "CHINA",

                });
                Country.Add(new SelectListItem
                {
                    Text = "INDIA",
                    Value = "INDIA",

                });
                Country.Add(new SelectListItem
                {
                    Text = "INDONESIA",
                    Value = "INDONESIA",

                });
                Country.Add(new SelectListItem
                {
                    Text = "UAE",
                    Value = "UAE",

                });
                Country.Add(new SelectListItem
                {
                    Text = "UAE",
                    Value = "UAE",

                });
                Country.Add(new SelectListItem
                {
                    Text = "MALAYSIA",
                    Value = "MALAYSIA",

                });
                Country.Add(new SelectListItem
                {
                    Text = "SOUTH KOREA",
                    Value = "SOUTH KOREA",

                });
                Country.Add(new SelectListItem
                {
                    Text = "SINGAPORE",
                    Value = "SINGAPORE",

                });
                Country.Add(new SelectListItem
                {
                    Text = "THAILAND",
                    Value = "THAILAND",

                });
            }
            if (region == "OCEANIA" || string.IsNullOrEmpty(region))
            {
                Country.Add(new SelectListItem
                {
                    Text = "AUSTRALIA",
                    Value = "AUSTRALIA",

                });
            }
            if (region == "SOUTH AMERICA" || string.IsNullOrEmpty(region))
            {
                Country.Add(new SelectListItem
                {
                    Text = "BRAZIL",
                    Value = "BRAZIL",

                });
            }
            if (region == "EUROPE" || string.IsNullOrEmpty(region))
            {
                Country.Add(new SelectListItem
                {
                    Text = "NETHERLANDS",
                    Value = "NETHERLANDS",

                });
            }
            if (region == "NORTH AMERICA" || string.IsNullOrEmpty(region))
            {
                Country.Add(new SelectListItem
                {
                    Text = "USA",
                    Value = "USA",

                });
            }
            return Country;
        }

        public static List<SelectListItem> GetAssetType()
        {
            List<SelectListItem> AssetType = new()
            {
                new SelectListItem
                {
                    Text = "DESKTOP",
                    Value = "DESKTOP",
                },
                new SelectListItem
                {
                    Text = "LAPTOP",
                    Value = "LAPTOP",
                },
                new SelectListItem
                {
                    Text = "PC",
                    Value = "PC",
                },
                new SelectListItem
                {
                    Text = "MONITOR",
                    Value = "MONITOR",
                },
            };
            return AssetType;
        }

        public static List<SelectListItem> GetBrand()
        {
            List<SelectListItem> Brand = new()
            {
                new SelectListItem
                {
                    Text = "ASUS",
                    Value = "ASUS",
                },
                new SelectListItem
                {
                    Text = "HP",
                    Value = "HP",
                },
                new SelectListItem
                {
                    Text = "LENOVO",
                    Value = "LENOVO",
                },
            };
            return Brand;
        }

        public static List<SelectListItem> GetStatus()
        {
            List<SelectListItem> Status = new()
            {
                new SelectListItem
                {
                    Text = "ACTIVE",
                    Value = "ACTIVE"
                },
                new SelectListItem
                {
                    Text = "DEACTIVE",
                    Value = "DEACTIVE"
                },
            };
            return Status;
        }

        public static List<SelectListItem> GetStatusInfra()
        {
            List<SelectListItem> Status = new()
            {
                new SelectListItem
                {
                    Text = "AVAILABLE",
                    Value = "AVAILABLE"
                },
                new SelectListItem
                {
                    Text = "UNAVAILABLE",
                    Value = "UNAVAILABLE"
                },
            };
            return Status;
        }

        public static string UploadDocFilePath(string fileType)
        {
            string filePath = string.Empty;
            if (fileType == "PROD")
            {
                filePath = UploadDocumentsFilePathPROD;
            }
            else if (fileType == "DEV")
            {
                filePath = UploadDocumentsFilePathDEV;
            }
            else if (fileType == "UAT")
            {
                filePath = UploadDocumentsFilePathUAT;
            }
            else if (fileType == "LOCAL")
            {
                filePath = UploadDocumentsFilePathLOCAL;
            }
            return filePath;
        }
    }
}
