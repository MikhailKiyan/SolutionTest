﻿using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        [Demo]
        public IActionResult ClientFiltering()
        {
            return View();
        }
    }
}