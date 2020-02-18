using System;
using System.Collections.Generic;

namespace _4_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            City slaskie = new City("Slaskie", "SLA", "Polska", 4524091, 2180662, 2343429);
            City malopolskie = new City("Malopolskie", "MLP", "Polska", 3404863, 1652663, 1752200);

            var citys = new Dictionary<string, City>();
            citys.Add(slaskie.CityCode, slaskie);
            citys.Add(malopolskie.CityCode, malopolskie);

            var searchedCity = citys.TryGetValue("WLK", out City city);
            
            if (searchedCity)
                Console.WriteLine(city.CityName);
            else
                Console.WriteLine("There is no city with this code");


            citys.Remove(malopolskie.CityCode);
            citys[slaskie.CityCode] = malopolskie;

            bool exist = citys.ContainsKey(slaskie.CityCode);
            Console.WriteLine(exist);

            foreach (var city2 in citys.Values)
            {
                Console.WriteLine(city2.CityName);
            }

        }
    }
}
