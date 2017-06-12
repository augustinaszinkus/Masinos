using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masinos
{
    class Automobiliai
    {
        public List<Automobilis> AutomobiliaiSarasas { get; private set; }
        public Automobiliai()
        {
            AutomobiliaiSarasas = new List<Automobilis>();
            AutomobiliaiSarasas.Add(new Automobilis(4200, 92, "Svedija", "Sedanas", "Priekiniai varomi", "Volvo", "S40", 2005));
            AutomobiliaiSarasas.Add(new Automobilis(1000, 85, "Italija", "Universalas", "Priekiniai varomi", "Fiat", "Multipla" , 2003));
            AutomobiliaiSarasas.Add(new Automobilis(4150, 85, "Japonija", "Visureigis", "Visi varomi", "Toyota" , "Land cruiser", 1999));
            AutomobiliaiSarasas.Add(new Automobilis(3850, 88, "Vokietija", "Kupe", "Priekiniai varomi", "Opel", "Astra", 2007));
            AutomobiliaiSarasas.Add(new Automobilis(3700, 144, "Anglija", "Sedanas", "Visi varomi", "Jaguar", "x-type", 2005));
            AutomobiliaiSarasas.Add(new Automobilis(4700, 160, "Amerika", "Universalas", "Galiniai varomi", "Chrysler", "300c", 2006));
            AutomobiliaiSarasas.Add(new Automobilis(4850, 120, "Svedija", "Visureigis", "Visi varomi", "Volvo", "XC90", 2004));
            AutomobiliaiSarasas.Add(new Automobilis(4975, 125, "Vokietija", "Kupe", "Galiniai varomi", "Mercedes-benz", "CLK270", 2005));
            AutomobiliaiSarasas.Add(new Automobilis(8900, 82, "Prancuzija", "Sedanas", "Priekiniai varomi", "Peugeot", "508", 2011));
            AutomobiliaiSarasas.Add(new Automobilis(7850, 85, "Amerika", "Universalas", "Priekiniai varomi", "Ford", "Focus", 2011));
            AutomobiliaiSarasas.Add(new Automobilis(8100, 81, "Japonija", "Visureigis", "Priekiniai varomi", "Nissan", "Qashqai", 2010));
            AutomobiliaiSarasas.Add(new Automobilis(7200, 84, "Svedija", "Kupe", "Priekiniai varomi", "Volvo", "C30", 2011));
            AutomobiliaiSarasas.Add(new Automobilis(9700, 147, "Vokietija", "Sedanas", "Priekiniai varomi", "Volkswagen", "Passat CC", 2009));
            AutomobiliaiSarasas.Add(new Automobilis(8750, 171, "Vokietija", "Universalas", "Visi varomi", "Audi", "A6", 2008));
            AutomobiliaiSarasas.Add(new Automobilis(7150, 130, "Anglija", "Visureigis", "Visi varomi", "Land Rover", "Range Rover", 2003));
            AutomobiliaiSarasas.Add(new Automobilis(7900, 132, "Prancuzija", "Kupe", "Priekiniai varomi", "Renault", "Megane", 2011));
            AutomobiliaiSarasas.Add(new Automobilis(17500, 88, "Cekija", "Sedanas", "Priekiniai varomi", "Skoda", "Superb", 2015));
            AutomobiliaiSarasas.Add(new Automobilis(12750, 96, "Vokietija", "Universalas", "Priekiniai varomi", "Opel", "Insignia", 2013));
            AutomobiliaiSarasas.Add(new Automobilis(13000, 81, "Cekija", "Visureigis", "Visi varomi", "Skoda", "Yeti", 2014));
            AutomobiliaiSarasas.Add(new Automobilis(10300, 90, "Vokietija", "Kupe", "Priekiniai varomi", "Volkswagen", "Scirocco", 2010));
            AutomobiliaiSarasas.Add(new Automobilis(19000, 190, "Vokietija", "Sedanas", "Galiniai varomi", "BMW", "530D", 2011));
            AutomobiliaiSarasas.Add(new Automobilis(13500, 120, "Svedija", "Universalas", "Priekiniai varomi", "Volvo", "V60", 2013));
            AutomobiliaiSarasas.Add(new Automobilis(19500, 177, "Amerika", "Visureigis", "Visi varomi", "Jeep", "Grand Cherokee", 2012));
            AutomobiliaiSarasas.Add(new Automobilis(18900, 147, "Japonija", "Kupe", "Galiniai varomi", "Toyota", "GT86", 2014));
        }
    }
}
