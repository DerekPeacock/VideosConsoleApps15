using ConsoleAppProject.App02;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BodyMassApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Feet { get; set; }

        [BindProperty]
        public int Inches { get; set; }

        [BindProperty]
        public int Stones { get; set; }

        [BindProperty]
        public int Pounds { get; set; }

        [BindProperty]
        public int Centimetres { get; set; }

        [BindProperty]
        public int Kilograms { get; set; }

        [BindProperty]
        public double BmiIndex { get; set; }


        private readonly ILogger<IndexModel> _logger;

        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            BMI bmi = new BMI();

            if(Feet > 0)
            {
                bmi.Inches = Feet * 12 + Inches;
                bmi.Pounds = Stones * 14 + Pounds;
                bmi.CalculateImperialBMI();
            }
            else if(Centimetres > 0)
            {
                bmi.Metres = (double)Centimetres / 100;
                bmi.Kilograms = Kilograms;
                bmi.CalculateMetricBMI();
            }
            
            BmiIndex = bmi.Index;

            return RedirectToPage("/HealthMessage", new { BmiIndex });
        }
    }
}
