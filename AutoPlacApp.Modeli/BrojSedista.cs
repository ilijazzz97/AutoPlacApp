using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Modeli
{
    public enum BrojSedista
    {
        [Description("Nije uneto")] Nema,
        [Description("2 sedišta")] Dva,
        [Description("3 sedišta")] Tri,
        [Description("4 sedišta")] Četiri,
        [Description("5 sedišta")] Pet,
        [Description("6 sedišta")] Šest,
        [Description("7 sedišta")] Sedam,
        [Description("8 sedišta")] Osam,
        [Description("9 sedišta")] Devet
    }

    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class SedistaDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public SedistaDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
