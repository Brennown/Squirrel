using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class GraphicController : Controller
    {
        [Authorize]
        public IActionResult LosserMonth()
        {
            return View();
        }
        [Authorize]
        public IActionResult InputsAndOutputsPerMonth()
        {
            return View();
        }
    }
}
