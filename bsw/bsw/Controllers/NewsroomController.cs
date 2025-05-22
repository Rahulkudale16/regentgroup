using Microsoft.AspNetCore.Mvc;

namespace bsw.Controllers
{
    public class NewsroomController : Controller
    {
        public IActionResult Newsroom()
        {
            return View();
        }
    }
}
