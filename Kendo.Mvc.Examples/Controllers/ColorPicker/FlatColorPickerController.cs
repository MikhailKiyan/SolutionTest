﻿using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
	public partial class ColorPickerController : Controller
	{
        [Demo]
        public IActionResult FlatColorPicker()
		{
			return View();
		}
	}
}
