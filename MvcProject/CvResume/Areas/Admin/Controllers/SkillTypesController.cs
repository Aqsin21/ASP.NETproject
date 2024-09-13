using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class SkillTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
