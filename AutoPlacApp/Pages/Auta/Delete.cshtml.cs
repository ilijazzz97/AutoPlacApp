using AutoPlacApp.Modeli;
using AutoPlacApp.Servisi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoPlacApp.Pages.Auta
{
    public class DeleteModel : PageModel
    {
        private readonly IAutoSkladiste autoSkladiste;
        [BindProperty]
        public Auto Auto { get; set; }

        public DeleteModel(IAutoSkladiste autoSkladiste)
        {
            this.autoSkladiste = autoSkladiste;
        }
        public IActionResult OnGet(int id)
        {
            Auto = autoSkladiste.UzmiAuto(id);
            if(Auto == null)
            {
                RedirectToPage("/NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            Auto izbrisanAuto = autoSkladiste.Izbrisi(Auto.Id);
            if(izbrisanAuto == null)
            {
                RedirectToPage("/NotFound");
            }
            return RedirectToPage("/Auta/Index");
        }
    }
}
