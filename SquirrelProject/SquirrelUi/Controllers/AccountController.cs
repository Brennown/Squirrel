using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SquirrelUi.Models.Domain;
using SquirrelUi.Models.ViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SquirrelUi.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index(string message)
        {
            var viewmodel = new AccountViewModel
            {
                Message = message
            };

            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index));
            }

            var hasAny = (account.UserName == "Brenno" && account.Password == "dev3598");

            if (!hasAny)
            {
                return RedirectToAction(nameof(Index), new { message = "Username or password is incorret!!"});
            }

            await Authentication(account);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task Authentication(Account account)
        {
            ClaimsIdentity identity = new ClaimsIdentity("CookieAuth");
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, $"{account.UserName}"));
            identity.AddClaim(new Claim(ClaimTypes.Name,$"{account.UserName}"));

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }
    }
}
