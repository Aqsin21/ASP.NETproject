using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
