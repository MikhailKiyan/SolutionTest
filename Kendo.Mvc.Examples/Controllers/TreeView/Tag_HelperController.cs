using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class TreeViewController : BaseController
    {
        [Demo]
        public ActionResult Tag_Helper()
        {
            return View();
        }
    }
}