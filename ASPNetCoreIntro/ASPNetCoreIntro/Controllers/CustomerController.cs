using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreIntro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private ILoggerr _logger;

        public CustomerController(ILoggerr logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult SaveCustomer()
        {
            _logger.Log("");
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text="Ankara",Value="06"},
                    new SelectListItem {Text="İstanbul",Value="34"},
                    new SelectListItem {Text="İzmir",Value="35"}

                }
            });
        }

        [HttpPost]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}
