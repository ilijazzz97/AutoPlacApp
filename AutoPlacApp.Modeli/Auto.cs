
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AutoPlacApp.Modeli
{
    public class Auto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Morate uneti marku!")]
        public Marka Marka { get; set; }
        [Required(ErrorMessage = "Morate uneti model!"), StringLength(15, ErrorMessage = "Maksimalna dužina imena modela je 15 karaktera!")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Morate uneti godinu proizvodnje!"), Range(1900, 2023, ErrorMessage = "Godina proizvodnje mora biti izmedju {1} i {2}!")]
        public int GodinaProizvodnje { get; set; }
        [Required(ErrorMessage = "Morate uneti karoseriju!")]
        public Karoserija Karoserija { get; set; }
        [Required(ErrorMessage = "Morate uneti gorivo!")]
        public Gorivo Gorivo { get; set; }
        [Required(ErrorMessage = "Morate uneti stanje automobila!")]
        public Stanje Stanje { get; set; }
        [Required(ErrorMessage = "Morate uneti cenu!"), Range(100, 1000000, ErrorMessage = "{0} mora biti izmedju {1} i {2}!")]
        public int Cena { get; set; }
        public string? SlikaDir { get; set; }
        [Range(0, 10000000, ErrorMessage = "{0} mora biti izmedju {1} i {2}!")]
        public int Kilometraža { get; set; }
        [Required(ErrorMessage = "Morate uneti kubikažu!"), Range(1, 10000, ErrorMessage = "{0} mora biti izmedju {1} i {2}!")]
        public int Kubikaža { get; set; }
        [Required(ErrorMessage = "Morate uneti cenu!"), Range(1, 1000, ErrorMessage = "{0} mora biti izmedju {1} i {2}!")]
        public int SnagaMotora { get; set; }
        public Boja Boja { get; set; }
        public StranaVolana StranaVolana { get; set; }

        public BrojVrata BrojVrata { get; set; }
        public BrojSedista BrojSedista { get; set; }
        public Klima Klima { get; set; }
    }
}
