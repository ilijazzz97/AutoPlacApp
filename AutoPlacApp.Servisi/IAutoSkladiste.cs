using AutoPlacApp.Modeli;

namespace AutoPlacApp.Servisi
{
    public interface IAutoSkladiste
    {
        IEnumerable<Auto> Pretraga(string searchTerm);
        IEnumerable<Auto> UzmiSveAutomobile();
        Auto UzmiAuto(int id);
        Auto Izmeni(Auto izmeniAuto);
        Auto Dodaj(Auto noviAuto);
        Auto Izbrisi(int id);
    }
}