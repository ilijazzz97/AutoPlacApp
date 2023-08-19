using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Modeli
{
    public enum BrojVrata
    {
        [Description("Nije uneto")] Nema,
        [Description("2/3 vrata")] DvaTri,
        [Description("4/5 vrata")] ČetiriPet
    }

    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class VrataDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public VrataDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
