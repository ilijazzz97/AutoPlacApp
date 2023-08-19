
using System.ComponentModel;

namespace AutoPlacApp.Modeli
{
    public enum Stanje
    {
        [Description("Polovno vozilo")] Polovno,
        [Description("Novo vozilo")] Novo
    }

    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class StanjeDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public StanjeDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
