using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Modeli
{
    public enum StranaVolana
    {
        [Description("Nije uneto")] Nema,
        [Description("Levi volan")] LeviVolan,
        [Description("Desni volan")] DesniVolan
    }

    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class VolanDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public VolanDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
