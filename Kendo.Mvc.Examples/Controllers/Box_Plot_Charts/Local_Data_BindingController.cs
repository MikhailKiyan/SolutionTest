﻿using Kendo.Mvc.Examples.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class Box_Plot_ChartsController : Controller
    {
        [Demo]
        public IActionResult Local_Data_Binding()
        {
            return View(ChartDataRepository.OzoneConcentration());
        }
    }
}