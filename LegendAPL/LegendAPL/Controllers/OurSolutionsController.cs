using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegendALP.Controllers
{
    public class OurSolutionsController : Controller
    {
        // GET: OurSolutions
        [Route("OurSolutions")]
        public ActionResult LocalCharges()
        {
            return View();
        }
        public ActionResult SailingSchedule()
        {
            return View();
        }

        public ActionResult HeavyHaulageandLineHaul()
        {
            return View();
        }

        public ActionResult SpecialisedLogistics()
        {
            return View();
        }

        public ActionResult MarineLogistics()
        {
            return View();
        }

        public ActionResult RegionalFeederServices()
        {
            return View();
        }

        public ActionResult OurSolutions()
        {
            return View();
        }
    }
}