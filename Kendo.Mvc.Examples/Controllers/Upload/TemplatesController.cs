﻿using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
	public partial class UploadController : Controller
	{
        [Demo]
        public ActionResult Templates()
		{
			return View();
		}
	}
}
