using AutoPlacApp.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Servisi
{
    public class MetodeAutoSkladiste : IAutoSkladiste
    {
        private List<Auto> _autoLista;
        public MetodeAutoSkladiste()
        {
            _autoLista = new List<Auto>()
            {
                new Auto() { Id = 1, Marka = Marka.Audi, Model = "A4", GodinaProizvodnje = 2013, Karoserija = Karoserija.Limuzina,
                             Gorivo = Gorivo.Dizel, Stanje = Stanje.Polovno, SlikaDir = "audia4.jpg", Cena = 12250 },
                new Auto() { Id = 2, Marka = Marka.BMW, Model = "520", GodinaProizvodnje = 2017, Karoserija = Karoserija.Limuzina,
                             Gorivo = Gorivo.Dizel, Stanje = Stanje.Polovno, Cena = 32900, SlikaDir = "bmw520.jpg", Kubikaža = 1995, Boja = Boja.Teget,
                             SnagaMotora = 190, Kilometraža = 183000, BrojVrata = BrojVrata.ČetiriPet, BrojSedista = BrojSedista.Pet,
                             StranaVolana = StranaVolana.LeviVolan, Klima = Klima.Automatska },
                new Auto() { Id = 3, Marka = Marka.Bentley, Model = "Continental", GodinaProizvodnje = 2013, Karoserija = Karoserija.Limuzina,
                             Gorivo = Gorivo.Hibridni, Stanje = Stanje.Polovno, SlikaDir = "bentleycontinental.jpg", Cena = 50000 },
                new Auto() { Id = 4, Marka = Marka.Audi, Model = "A7", GodinaProizvodnje = 2018, Karoserija = Karoserija.Kupe,
                             Gorivo = Gorivo.Dizel, Stanje = Stanje.Polovno, SlikaDir = "audia7.jpg", Cena = 62500, Boja = Boja.Crvena, Kubikaža = 2967,
                             SnagaMotora = 286, Kilometraža = 81000, BrojVrata = BrojVrata.ČetiriPet, BrojSedista = BrojSedista.Pet,
                             StranaVolana = StranaVolana.LeviVolan, Klima = Klima.Automatska },
                new Auto() { Id = 5, Marka = Marka.Jaguar, Model = "F-Type", GodinaProizvodnje = 2022, Karoserija = Karoserija.Kabriolet,
                             Gorivo = Gorivo.BenzinMetan, Stanje = Stanje.Novo, SlikaDir = "noimage.jpg", Cena = 114990, BrojSedista = BrojSedista.Dva }

            };
            _autoLista = _autoLista.OrderBy(x => x.Marka).ToList();
        }


        // Za multi line enum vrednosti, metoda za dobavljanje description enum vrednosti
        public static class EnumHelper
        {
            public static string GetEnumDescription(Enum value)
            {
                FieldInfo field = value.GetType().GetField(value.ToString());
                DescriptionAttribute[] attr1 = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                GorivoDescriptionAttribute[] attr2 = (GorivoDescriptionAttribute[])field.GetCustomAttributes(typeof(GorivoDescriptionAttribute), false);
                VolanDescriptionAttribute[] attr3 = (VolanDescriptionAttribute[])field.GetCustomAttributes(typeof(VolanDescriptionAttribute), false);
                SedistaDescriptionAttribute[] attr4 = (SedistaDescriptionAttribute[])field.GetCustomAttributes(typeof(SedistaDescriptionAttribute), false);
                VrataDescriptionAttribute[] attr5 = (VrataDescriptionAttribute[])field.GetCustomAttributes(typeof(VrataDescriptionAttribute), false);
                KlimaDescriptionAttribute[] attr6 = (KlimaDescriptionAttribute[])field.GetCustomAttributes(typeof(KlimaDescriptionAttribute), false);
                StanjeDescriptionAttribute[] attr7 = (StanjeDescriptionAttribute[])field.GetCustomAttributes(typeof(StanjeDescriptionAttribute), false);

                if (attr1 != null && attr1.Length > 0)
                    return attr1[0].Description;
                if (attr2 != null && attr2.Length > 0)
                    return attr2[0].Description;
                if (attr3 != null && attr3.Length > 0)
                    return attr3[0].Description;
                if (attr4 != null && attr4.Length > 0)
                    return attr4[0].Description;
                if (attr5 != null && attr5.Length > 0)
                    return attr5[0].Description;
                if (attr6 != null && attr6.Length > 0)
                    return attr6[0].Description;
                if (attr7 != null && attr7.Length > 0)
                    return attr7[0].Description;

                return value.ToString();
            }
        }

        // Metoda za uzimanje svih automobila
        public IEnumerable<Auto> UzmiSveAutomobile()
        {
            return _autoLista;
        }

        public Auto UzmiAuto(int id)
        {
            return _autoLista.FirstOrDefault(x => x.Id == id);
        }

        public Auto Izmeni(Auto izmeniAuto)
        {
            Auto auto = _autoLista.FirstOrDefault(e => e.Id == izmeniAuto.Id);
            if (auto != null)
            {
                auto.Marka = izmeniAuto.Marka;
                auto.Model = izmeniAuto.Model;
                auto.GodinaProizvodnje = izmeniAuto.GodinaProizvodnje;
                auto.Karoserija = izmeniAuto.Karoserija;
                auto.Gorivo = izmeniAuto.Gorivo;
                auto.Stanje = izmeniAuto.Stanje;
                auto.Cena = izmeniAuto.Cena;
                auto.Kilometraža = izmeniAuto.Kilometraža;
                auto.Kubikaža = izmeniAuto.Kubikaža;
                auto.SnagaMotora = izmeniAuto.SnagaMotora;
                auto.Boja = izmeniAuto.Boja;
                auto.StranaVolana = izmeniAuto.StranaVolana;
                auto.BrojVrata = izmeniAuto.BrojVrata;
                auto.BrojSedista = izmeniAuto.BrojSedista;
                auto.Klima = izmeniAuto.Klima;
                auto.SlikaDir = izmeniAuto.SlikaDir;
            }

            return auto;
        }

        public Auto Dodaj(Auto noviAuto)
        {
            noviAuto.Id = _autoLista.Max(e => e.Id) + 1;
            _autoLista.Add(noviAuto);
            return noviAuto;
        }

        public Auto Izbrisi(int id)
        {
            Auto autoZaBrisanje = _autoLista.FirstOrDefault(e => e.Id == id);
            if (autoZaBrisanje != null)
            {
                _autoLista.Remove(autoZaBrisanje);
            }
            return autoZaBrisanje;
        }

        public IEnumerable<Auto> Pretraga(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return _autoLista;
            }

            return _autoLista.Where(e => e.Marka.ToString().ToUpper().StartsWith(searchTerm.ToUpper()) ||
                              e.Model.ToUpper().StartsWith(searchTerm.ToUpper()));
        }
    }
}
