using System;
using System.Collections.Generic;

namespace MVCCountriesLab
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        public List<Country> Countries;
        public void Display()
        {
            foreach (Country country in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(country) + 1}: {country.Name}");
            }
        }
    }
}
