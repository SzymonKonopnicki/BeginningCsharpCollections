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

            //List<City> citys = new List<City>();
            //citys.Add(slaskie);
            //citys.Add(slaskie);

            //foreach (City city in citys)
            //{
            //    Console.WriteLine(city.CityName);
            //}

            var citys = new Dictionary<string, City>();
            citys.Add(slaskie.CityCode, slaskie);
            citys.Add(slaskie.CityCode, slaskie);

            foreach (var city in citys.Values)
            {
                Console.WriteLine(city);
            }

        }
    }
}
