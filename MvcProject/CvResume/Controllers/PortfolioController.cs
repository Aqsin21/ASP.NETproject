﻿using Microsoft.AspNetCore.Mvc;

namespace CvResume.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
