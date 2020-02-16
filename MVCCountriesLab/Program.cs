using System;

namespace MVCCountriesLab
{
    class Program
    { 
    
        static void Main(string[] args)
        {
            CountryController countryController = new CountryController();
            countryController.WelcomeAction();
        }
    }
}
