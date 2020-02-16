using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCCountriesLab
{
    class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("Djbouti", "Africa", new List<ConsoleColor>(){ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.White}){},
            new Country("Japan", "Asia", new List<ConsoleColor>(){ConsoleColor.Red, ConsoleColor.White}){},
            new Country("The United Kingdom of Great Britain and Northern Ireland", "Europe", 
                new List<ConsoleColor>(){ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.White}){},
        };
        
        public void CountryAction(Country c)
        {
            CountryView countryview = new CountryView(c);
            countryview.Display();
        }
        public void WelcomeAction()
        {
            CountryListView countryList = new CountryListView(CountryDb);
            Console.Clear();
            Console.WriteLine("Hello, welcome to the country app. " +
                "Please select a country from the following list:");
            countryList.Display();
            CountryAction(SelectCountry(countryList));
            WelcomeSelect();
        }
        public void WelcomeSelect()
        {
            while (true)
            {
                Console.WriteLine("Would you like to select another country?");
                Console.WriteLine("1: Yes");
                Console.WriteLine("2: No");
                string decision = Console.ReadLine().Trim();
                if (decision == "1")
                {
                    WelcomeAction();
                    return;
                }
                else if (decision == "2")
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That was not a valid input");
                }
            }
        }
        public Country SelectCountry(CountryListView countryList)
        {
            int i;
            Console.WriteLine("Type the corresponding number of a country.");
            while(!Int32.TryParse(Console.ReadLine(), out i) ||  
                   i - 1 > countryList.Countries.Count() || i - 1 < 0)
            {
                Console.Clear();
                Console.WriteLine("That was not a valid input.");
                Console.WriteLine("Type the corresponding number of a country.");
                countryList.Display();
            }
            return countryList.Countries[i - 1];
        }
    }
}
