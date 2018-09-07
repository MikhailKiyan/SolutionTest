using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class ListBoxController : BaseController
    {
        [Demo]
        public IActionResult Tag_Helper()
        {
            ViewBag.Attendees = new List<string>()
            {
                "Steven White",
                "Nancy King",
                "Nancy Davolio",
                "Robert Davolio",
                "Michael Leverling",
                "Andrew Callahan",
                "Michael Suyama"
            };

            return View();
        }
    }
}
