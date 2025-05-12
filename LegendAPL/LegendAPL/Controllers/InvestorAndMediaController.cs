using LegendALP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendALP.Models;
using System.Web.Management;

namespace LegendALP.Controllers
{
    public class InvestorAndMediaController : Controller
    {
        // GET: InvestorAndMedia
        public ActionResult InvestorRelations()
        {
            return View();
        }

        public ActionResult News2018()
        {
            return View();

        }
        public ActionResult News2019()
        {
            return View();
        }
        public ActionResult News2020()
        {
            return View();
        }
        public ActionResult News2021()
        {
            return View();
        }
        public ActionResult News2022()
        {
            return View();
        }
        public ActionResult AllNews()
        {
            return View();
        }
        public ActionResult News2023()
        {
            return View();
        }
        public ActionResult News2024()
        {
            return View();
        }
        public ActionResult News2025()
        {
            return View();
        }
        public ActionResult LegendWhistleBlowingChannels()
        {
            return View();
        }
        public ActionResult DetailNews(string idNews)
        {
            if (TempData["idNews"] != null)
            {
                idNews = TempData["idNews"].ToString();
            }
            //ViewBag.NewsContent = Constant.NewsList().Where(x => x.Value == idNews).Select(x => x.Text).FirstOrDefault()?? string.Empty;
            var contactDetails = Constant.NewsList(idNews);
            int j = 0;
            var news1 = (Constant.NewsList2()).Where(x => x.NewsYear == contactDetails.NewsYear);
            foreach (var item in news1)
            {
                if (item.IDNews != idNews && j <= 4)
                {
                    j++;
                    contactDetails.ContactDetails.Add(item);
                }

            }
            return View(contactDetails);
        }

        public ActionResult GoToNews(string idNews)
        {
            TempData["idNews"] = idNews;
            bool success = true;
            return Json(success);
        }
    }
}