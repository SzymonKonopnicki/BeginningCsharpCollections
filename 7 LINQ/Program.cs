using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\2 ArrayPracticalExample\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> citys = csvReader.ReadAllCiyts();

            //foreach (var city in citys.Where(c => !c.CityName.Contains("Test")).Take(10))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //for (int i = 3; i <= 8; i++)
            //    Console.WriteLine(citys[i].CityName);


            Console.WriteLine($"{citys.Max(c => c.MenPopulation):### ### ###} - The city with the largest male population");
            Console.WriteLine($"{citys.Min(c => c.WomenPopulation):### ### ###} - The city with the smallest female population");
            Console.WriteLine($"{citys.Sum(c => c.TotalPopulation):### ### ###} - Total population of all cities");

            Console.WriteLine($"{citys.Average(c => c.MenPopulation):### ### ###} - Average male population");

            Console.WriteLine(citys.All(c => c.TotalPopulation > 200000));
            Console.WriteLine(citys.Any(c => c.TotalPopulation > 20000000));
        }
    }
}
