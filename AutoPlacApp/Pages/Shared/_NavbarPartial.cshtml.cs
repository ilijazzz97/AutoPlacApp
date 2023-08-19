using AutoPlacApp.Modeli;
using AutoPlacApp.Servisi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoPlacApp.Pages.Shared
{
    public class _NavbarPartialModel : PageModel
    {
        private readonly IAutoSkladiste autoSkladiste;
        public IEnumerable<Auto> Automobili { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public _NavbarPartialModel(IAutoSkladiste autoSkladiste)
        {
            this.autoSkladiste = autoSkladiste;
        }
        public void OnGet()
        {
            Automobili = autoSkladiste.Pretraga(SearchTerm);
        }
    }
}
