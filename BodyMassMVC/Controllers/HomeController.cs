﻿using BodyMassMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ConsoleAppProject.App02;

namespace BodyMassMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(BmiCalculator bmi)
        {
            if (bmi.Centimetres > 140)
            {
                bmi.CalculateMetricBMI();
            }
            else if (bmi.Feet > 4 && bmi.Stones > 6)
            {
                bmi.CalculateImperialBMI();
            }
            else
            {
                ViewBag.Error = "You have entered values too small for any adult!";
                return View();
            }

            double bmiIndex = bmi.Index;

            return RedirectToAction("HealthMessage", new { bmiIndex });

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
