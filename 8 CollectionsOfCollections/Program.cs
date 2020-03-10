using System;
using System.Collections.Generic;

namespace _8_CollectionsOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\8 CollectionsOfCollections\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> citys = csvReader.ReadAllCiyts();

            foreach (var city in citys)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
