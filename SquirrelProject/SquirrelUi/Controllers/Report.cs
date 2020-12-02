using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class Report : Controller
    {
        [Authorize]
        public IActionResult StockPosition()
        {
            return View();
        }
        [Authorize]
        public IActionResult Resupply()
        {
            return View();
        }
    }
}
