using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
