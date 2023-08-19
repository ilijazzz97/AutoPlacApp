using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPlacApp.Modeli
{
    public enum Marka
    {
        [Description("Audi")] Audi,
        [Description("Alfa Romeo")] AlfaRomeo,
        [Description("Austin")] Austin,
        [Description("BMW")] BMW,
        [Description("Bentley")] Bentley,
        [Description("Cadillac")] Cadillac,
        [Description("Chevrolet")] Chevrolet,
        [Description("Citroen")] Citroen,
        [Description("Dacia")] Dacia,
        [Description("Dodge")] Dodge,
        [Description("Ferrari")] Ferrari,
        [Description("Fiat")] Fiat,
        [Description("Ford")] Ford,
        [Description("Jaguar")] Jaguar,
        [Description("Jeep")] Jeep,
        [Description("Kia")] Kia,
        [Description("Lada")] Lada,
        [Description("Lamborghini")] Lamborghini,
        [Description("Lancia")] Lancia,
        [Description("Land Rover")] LandRover,
        [Description("Maserati")] Maserati,
        [Description("Mazda")] Mazda,
        [Description("Mercedes Benz")] MercedesBenz,
        [Description("Mitsubishi")] Mitsubishi,
        [Description("Nissan")] Nissan,
        [Description("Opel")] Opel,
        [Description("Peugeot")] Peugeot,
        [Description("Porsche")] Porsche,
        [Description("Renault")] Renault,
        [Description("Rolls Royce")] RollsRoyce,
        [Description("Tesla")] Tesla,
        [Description("Toyota")] Toyota,
        [Description("Volkswagen")] Volkswagen,
        [Description("Škoda")] Škoda
    }

    // Uzimanje Description
    [AttributeUsage(AttributeTargets.Field)]
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }

}
