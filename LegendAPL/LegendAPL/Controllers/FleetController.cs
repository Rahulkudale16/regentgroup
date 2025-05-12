using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegendALP.Controllers
{
    public class FleetController : Controller
    {
        // GET: Fleet
        public ActionResult LandingCraft()
        {
            return View();
        }
        public ActionResult TugBoat()
        {
            return View();
        }
        public ActionResult Barge()
        {
            return View();
        }
    }
}