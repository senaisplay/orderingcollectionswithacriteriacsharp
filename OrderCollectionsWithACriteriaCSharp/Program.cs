using OrderCollectionsWithACriteriaCSharp.Models;
using System;
using System.Linq;

namespace OrderCollectionsWithACriteriaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = Country.Countries;
            var orderedCountries = countries.OrderBy(x => x.Name);
            foreach (var country in orderedCountries)
            {
                Console.WriteLine(country.Name);
            }
            // Wait for a key to be pressed while executing
            Console.ReadKey();
        }
    }
}
