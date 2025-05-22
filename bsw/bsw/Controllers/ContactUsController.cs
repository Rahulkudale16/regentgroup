using Microsoft.AspNetCore.Mvc;

namespace bsw.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
