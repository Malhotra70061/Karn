using System.Diagnostics;
using Karn.Modals;
using Karn.Service;
using Microsoft.AspNetCore.Mvc;

namespace Karn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBasicTaxCalculationService _Service;
        private readonly ICalculationService _Service2;

        public HomeController(ILogger<HomeController> logger, IBasicTaxCalculationService Service, ICalculationService service2)
        {
            _logger = logger;
            _Service = Service;
            _Service2 = service2;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _Service.GetAsync();
            return View(data);
        }


        public async Task<IActionResult> Add()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Add(BasicTaxCalculation basicTaxCalculation)
        {
            if (ModelState.IsValid)
            {
                await _Service.PostAsync(basicTaxCalculation).ConfigureAwait(false); 
                return RedirectToAction("Index");
            }
             
            return View(basicTaxCalculation);
        }





        //---------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> CalculationIndex()
        {
            var data = await _Service2.GetAsync();
            return View(data);
        }

        public async Task<IActionResult> CalculationAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CalculationAdd(Calculation calculation)
        {
            if (ModelState.IsValid)
            {
                await _Service2.PostAsync(calculation).ConfigureAwait(false);                 
                return RedirectToAction("CalculationIndex");
            }
             
            return View(calculation);
        }
         
    }
}
