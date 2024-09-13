using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class SkillGroupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
