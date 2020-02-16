using System;
using System.Collections.Generic;

namespace MVCCountriesLab
{
    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<ConsoleColor> Colors { get; set; }
        public Country(string name, string continent, List<ConsoleColor> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}
