using System;
using System.Text;

namespace MVCCountriesLab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country c)
        {
            DisplayCountry = c;
        }
        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"Country: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
            Console.Write("Flag Colors: ");
            foreach(ConsoleColor color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = color;
                Console.Write(color + " ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
