using System;
using System.Linq;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int citiesCount = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 1; i <= citiesCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continentName = input[0];
                string countryName = input[1];
                string cityName = input[2];

                if (!continents.ContainsKey(continentName))
                    continents.Add(continentName, new Dictionary<string, List<string>>());

                if (!continents[continentName].ContainsKey(countryName))
                    continents[continentName].Add(countryName, new List<string>());

                continents[continentName][countryName].Add(cityName);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                    Console.WriteLine($" {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}
