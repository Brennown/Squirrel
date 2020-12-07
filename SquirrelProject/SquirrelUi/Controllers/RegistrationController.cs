using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SquirrelDomain.Entities;
using SquirrelService.Interfaces;
using SquirrelUi.Models.ViewModels;
using System.Threading.Tasks;

namespace SquirrelUi.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IProductGroupService _productGroupService;
        public RegistrationController(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ProductGroup()
        {
            var productGroups = await _productGroupService.GetAllProductGroup();
            var viewModel = new ProductGroupViewModel
            { 
                ProductGroups = productGroups 
            };
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertProductGroup(ProductGroup produdGroup)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ProductGroup));
            }
            await _productGroupService.InsertNewProductGroup(produdGroup);
            return RedirectToAction(nameof(ProductGroup));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> UpdateProductGroup(int? id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ProductGroup));
            }
            var productGropup = await _productGroupService.GetProductGroupById(id.Value);
            return View(productGropup);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProductGroup(ProductGroup produdGroup)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ProductGroup));
            }
            await _productGroupService.UpdateProductGroup(produdGroup);
            return RedirectToAction(nameof(ProductGroup));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> DeleteProductGroup(int? id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ProductGroup));
            }
            var productGropup = await _productGroupService.GetProductGroupById(id.Value);
            return View(productGropup);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProductGroup(int productGroupId)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ProductGroup));
            }
            await _productGroupService.DeleteProductGroup(productGroupId);
            return RedirectToAction(nameof(ProductGroup));
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
