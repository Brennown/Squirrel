using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class OperationController : Controller
    {
        [Authorize]
        public IActionResult ProductInput()
        {
            return View();
        }
        [Authorize]
        public IActionResult OutputProduct()
        {
            return View();
        }
        [Authorize]
        public IActionResult ProductRelease()
        {
            return View();
        }
        [Authorize]
        public IActionResult Invetory()
        {
            return View();
        }
    }
}
