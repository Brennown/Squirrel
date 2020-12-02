using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SquirrelUi.Controllers
{
    public class RegistrationController : Controller
    {
        [Authorize]
        public IActionResult ProductGroup()
        {
            return View();
        }
        [Authorize]
        public IActionResult ProductBrand()
        {
            return View();
        }
        [Authorize]
        public IActionResult StorageLocation()
        {
            return View();
        }
        [Authorize]
        public IActionResult UnitMeasure()
        {
            return View();
        }
        [Authorize]
        public IActionResult Product()
        {
            return View();
        }
        [Authorize]
        public IActionResult Country()
        {
            return View();
        }
        [Authorize]
        public IActionResult State()
        {
            return View();
        }
        [Authorize]
        public IActionResult City()
        {
            return View();
        }
        [Authorize]
        public IActionResult Provider()
        {
            return View();
        }
        [Authorize]
        public IActionResult UserProfile()
        {
            return View();
        }
      
    }
}
