using System;
using System.Threading.Tasks;
using ekeneEstateApp.Web.Interfaces;
using ekeneEstateApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ekeneEstateApp.Web.Controllers
{
    [Authorize]
    public class PropertiesController : Controller
    {   
        private readonly IPropertyService _propertyService;

        public PropertiesController( IPropertyService propertyService )
        {
            _propertyService = propertyService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var properties = _propertyService.GetAllProperties();
            return View(properties);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PropertyModel model)
        {
            try
            {
                await _propertyService.AddProperty(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
               ModelState.AddModelError("", e.Message);
                return View();
            }
        }
    }
}