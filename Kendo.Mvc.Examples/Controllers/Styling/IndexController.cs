﻿using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class StylingController : Controller
    {
        [Demo]
        public IActionResult Index()
        {
            return View();
        }
    }
}
