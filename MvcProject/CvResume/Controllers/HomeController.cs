using Microsoft.AspNetCore.Mvc;

namespace CvResume.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
