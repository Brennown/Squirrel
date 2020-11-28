using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class GraphicController : Controller
    {
        public IActionResult LosserMonth()
        {
            return View();
        }
        public IActionResult InputsAndOutputsPerMonth()
        {
            return View();
        }
    }
}
