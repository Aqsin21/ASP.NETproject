using Microsoft.AspNetCore.Mvc;
using Services.Blogpost;

namespace CvResume.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogPostService blogPostService;

        public BlogController(IBlogPostService blogPostService)
        {
            this.blogPostService = blogPostService;
        }
        public IActionResult Index()
        {
            var response = blogPostService.GetAllAsync();
            return View(response);
        }
    }
}


