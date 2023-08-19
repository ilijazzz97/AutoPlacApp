using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Modeli
{
    public enum Klima
    {
        [Description("Nema klimu")] Nema,
        [Description("Manuelna klima")] Manuelna,
        [Description("Automatska klima")] Automatska
    }

    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class KlimaDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public KlimaDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
