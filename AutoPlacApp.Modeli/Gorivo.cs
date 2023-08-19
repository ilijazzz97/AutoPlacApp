using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Modeli
{
    public enum Gorivo
    {
        [Description("Benzin")] Benzin,
        [Description("Dizel")] Dizel,
        [Description("Benzin + Gas")] BenzinGas,
        [Description("Benzin + Metan")] BenzinMetan,
        [Description("Električni pogon")] Električni,
        [Description("Hibridni pogon")] Hibridni,
    }


    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class GorivoDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public GorivoDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
