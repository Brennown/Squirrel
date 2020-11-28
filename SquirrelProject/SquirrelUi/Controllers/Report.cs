using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class Report : Controller
    {
        public IActionResult StockPosition()
        {
            return View();
        }
        public IActionResult Resupply()
        {
            return View();
        }
    }
}
