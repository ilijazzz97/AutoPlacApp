using AutoPlacApp.Modeli;
using AutoPlacApp.Servisi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoPlacApp.Pages.Auta
{
    public class DetailsModel : PageModel
    {
        private readonly IAutoSkladiste autoSkladiste;
        public Auto Auto;
        [BindProperty(SupportsGet = true)]
        public string Poruka { get; set; }

        public DetailsModel(IAutoSkladiste autoSkladiste)
        {
            this.autoSkladiste = autoSkladiste;
        }
        public IActionResult OnGet(int id)
        {
            Auto = autoSkladiste.UzmiAuto(id);
            if (Auto == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
