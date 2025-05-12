using LegendALP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegendALP.Controllers
{
    public class CareerController : Controller
    {
        // GET: Career
        public ActionResult HeadCommercialTank()
        {
            return View();
        }

        public ActionResult CargoTariff()
        {
            return View();
        }

        public ActionResult OperationsSharedServices()
        {
            return View();


        }

        public ActionResult Equipment()
        {
            return View();

        }
        public ActionResult ISOTankDivision()
        {
            return View();


        }

        public ActionResult LandLogisticsDivision()
        {
            return View();


        }

        public ActionResult TankContainerDivision()
        {
            return View();

        }
        public ActionResult GlobalFreight()
        {
            return View();

        }
        public ActionResult AccountingFinance()
        {
            return View();

        }
        public ActionResult InformationTechnology()
        {
            return View();

        }
        public ActionResult TankContainerDiv()
        {
            return View();
        }

        public ActionResult CareerDetails(string idCareer)
        {
            ViewBag.CareerContent = Constant.CareerList().Where(x => x.Value == idCareer).Select(x => x.Text).FirstOrDefault() ?? string.Empty;
            return View();
        }
    }
}