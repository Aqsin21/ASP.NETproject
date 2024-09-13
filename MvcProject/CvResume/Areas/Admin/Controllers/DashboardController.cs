using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
