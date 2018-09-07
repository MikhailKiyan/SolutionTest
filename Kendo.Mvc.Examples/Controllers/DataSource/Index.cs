using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.Examples.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class DataSourceController : Controller
    {

        [Demo]
        public ActionResult Index()
        {
            return View();
        }
    }
}