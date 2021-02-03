using BodyMassMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using ConsoleAppProject.App02;

namespace BodyMassMVC.Controllers
{
    public class HomeController : Controller
    {
        public double BmiIndex;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(BmiViewModel model)
        {
            BMI bmi = new BMI();

            if (model.Feet > 0)
            {
                bmi.Inches = model.Feet * 12 + model.Inches;
                bmi.Pounds = model.Stones * 14 + model.Pounds;
                bmi.CalculateImperialBMI();
            }
            else if (model.Centimetres > 0)
            {
                bmi.Metres = (double)model.Centimetres / 100;
                bmi.Kilograms = model.Kilograms;
                bmi.CalculateMetricBMI();
            }

            BmiIndex = bmi.Index;

            return RedirectToAction("HealthMessage", new { BmiIndex });

        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult HealthMessage(double BmiIndex)
        {
            return View(BmiIndex);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
