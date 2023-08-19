using AutoPlacApp.Modeli;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Servisi
{
    public class SQLAutoSkladiste : IAutoSkladiste
    {
        private readonly AppDbContext context;

        public SQLAutoSkladiste(AppDbContext context)
        {
            this.context = context;
        }
        public Auto Dodaj(Auto noviAuto)
        {
            context.Database.ExecuteSqlRaw("spDodaj {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}",
                                        noviAuto.Marka,
                                        noviAuto.Model,
                                        noviAuto.GodinaProizvodnje,
                                        noviAuto.Karoserija,
                                        noviAuto.Gorivo,
                                        noviAuto.Stanje,
                                        noviAuto.Cena,
                                        noviAuto.Kilometraža,
                                        noviAuto.Kubikaža,
                                        noviAuto.SnagaMotora,
                                        noviAuto.Boja,
                                        noviAuto.StranaVolana,
                                        noviAuto.BrojVrata,
                                        noviAuto.BrojSedista,
                                        noviAuto.Klima,
                                        noviAuto.SlikaDir);
            return noviAuto;
        }

        public Auto Izbrisi(int id)
        {
            Auto auto = context.Automobili.Find(id);
            if (auto != null)
            {
                context.Automobili.Remove(auto);
                context.SaveChanges();
            }
            return auto;

        }

        public Auto Izmeni(Auto izmeniAuto)
        {
            var auto = context.Automobili.Attach(izmeniAuto);
            auto.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return izmeniAuto;
        }

        public IEnumerable<Auto> Pretraga(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return context.Automobili;
            }

            return context.Automobili.Where(e => e.Marka.ToString().ToUpper().StartsWith(searchTerm.ToUpper()) ||
                              e.Model.ToUpper().StartsWith(searchTerm.ToUpper()));
        }

        public Auto UzmiAuto(int id)
        {
            return context.Automobili
                    .FromSqlRaw<Auto>("spUzmiAuto {0}", id)
                    .ToList()
                    .FirstOrDefault();
        }

        public IEnumerable<Auto> UzmiSveAutomobile()
        {
            return context.Automobili
                    .FromSqlRaw<Auto>("SELECT * from Automobili order by Marka")
                    .ToList();
        }
    }
}
