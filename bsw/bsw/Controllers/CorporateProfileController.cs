using Microsoft.AspNetCore.Mvc;

namespace bsw.Controllers
{
    public class CorporateProfileController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
        public IActionResult CorporateMilestones()
        {
            return View();
        }
        public IActionResult OurGlobalNetwork()
        {
            return View();

        }
        public IActionResult SafetyAndSecurity()
        {
            return View();
        }
        public IActionResult AwardsAndAccolades()
        {
            return View();
        }
    }
}
