using Kendo.Mvc.Examples.Models.Scheduler;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class SchedulerController
    {
        [Demo]
        public IActionResult Tag_Helper()
        {
            return View();
        }
    }
}
