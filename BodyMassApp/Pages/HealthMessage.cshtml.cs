using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BodyMassApp.Pages
{
    public class HealthMessageModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public double BmiIndex { get; set; }

        public void OnGet()
        {

        }
    }
}
