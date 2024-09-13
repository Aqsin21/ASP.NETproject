using Microsoft.AspNetCore.Mvc;

namespace CvResume.Areas.Admin.Controllers
{
    public class PersonSkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
