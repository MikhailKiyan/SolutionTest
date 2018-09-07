using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class ChatController : Controller
    {
        [Demo]
        public IActionResult Travel()
        {
            return View();
        }
    }
}