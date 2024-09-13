using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class BlogPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
