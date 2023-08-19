using AutoPlacApp.Modeli;
using AutoPlacApp.Servisi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AutoPlacApp.Pages.Auta
{
    public class EditModel : PageModel
    {
        private readonly IAutoSkladiste autoSkladiste;
        private readonly IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public Auto Auto { get; set; }

        [BindProperty]
        public IFormFile? Slika { get; set; }

        public EditModel(IAutoSkladiste autoSkladiste,
                         IWebHostEnvironment webHostEnvironment)
        {
            this.autoSkladiste = autoSkladiste;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Auto = autoSkladiste.UzmiAuto(id.Value);
            }
            else
            {
                Auto = new Auto();
                Auto.SlikaDir = "noimage.jpg";
            }

            if (Auto == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Slika != null)
                {
                    if (Auto.SlikaDir != null)
                    {
                        if(Auto.SlikaDir != "noimage.jpg")
                        {
                            string slikaPath = Path.Combine(webHostEnvironment.WebRootPath, "images/cars", Auto.SlikaDir);
                            System.IO.File.Delete(slikaPath);
                        }
                        Auto.SlikaDir = ProcesAploadSlika();
                    }
                    else if (Auto.SlikaDir == null)
                    {
                        Auto.SlikaDir = ProcesAploadSlika();
                    }
                }
                else if(Slika == null)
                {
                    if (Auto.SlikaDir == null)
                    {
                        Auto.SlikaDir = "noimage.jpg";
                    }
                    else
                    {
                        Auto.SlikaDir = Auto.SlikaDir;
                    }

                }
                if (Auto.Id > 0)
                {
                    Auto = autoSkladiste.Izmeni(Auto);
                }
                else
                {
                    Auto = autoSkladiste.Dodaj(Auto);
                }
                return RedirectToPage("Index");
            }
            return Page();

        }
        private string ProcesAploadSlika()
        {
            string unikatnoImeSlike = null;

            if (Slika != null)
            {
                string slikeFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/cars");
                unikatnoImeSlike = Guid.NewGuid().ToString() + "_" + Slika.FileName;
                string slikaPath = Path.Combine(slikeFolder, unikatnoImeSlike);
                using (var fileStream = new FileStream(slikaPath, FileMode.Create))
                {
                    Slika.CopyTo(fileStream);
                }
            }
            return unikatnoImeSlike;
        }
    }
}