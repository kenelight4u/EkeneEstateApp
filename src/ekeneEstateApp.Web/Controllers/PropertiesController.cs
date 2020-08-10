using System;
using System.Threading.Tasks;
using ekeneEstateApp.Web.Interfaces;
using ekeneEstateApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ekeneEstateApp.Web.Controllers
{
    public class PropertiesController : Controller
    {   
        private readonly IPropertyService _propertyService;

        public PropertiesController( IPropertyService propertyService )
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

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