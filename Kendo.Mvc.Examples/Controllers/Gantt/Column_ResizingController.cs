﻿using Kendo.Mvc.Examples.Models.Gantt;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class GanttController : Controller
    {
        [Demo]
        public ActionResult Column_Resizing()
        {
            return View();
        }
    }
}