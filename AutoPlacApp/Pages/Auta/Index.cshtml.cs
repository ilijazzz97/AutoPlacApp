using AutoPlacApp.Modeli;
using AutoPlacApp.Servisi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace AutoPlacApp.Pages.Auta
{
    public class IndexModel : PageModel
    {
        private readonly IAutoSkladiste autoSkladiste;
        public IEnumerable<Auto> Automobili;

        public IndexModel(IAutoSkladiste autoSkladiste)
        {
            this.autoSkladiste = autoSkladiste;
        }
        public void OnGet()
        {
            Automobili = autoSkladiste.UzmiSveAutomobile();
        }
    }
}
