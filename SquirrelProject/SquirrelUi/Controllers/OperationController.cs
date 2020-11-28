using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult ProductInput()
        {
            return View();
        }
        public IActionResult OutputProduct()
        {
            return View();
        }
        public IActionResult ProductRelease()
        {
            return View();
        }
        public IActionResult Invetory()
        {
            return View();
        }
    }
}
