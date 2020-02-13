using System;
using System.Collections.Generic;

namespace _3_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\2 ArrayPracticalExample\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> citys = csvReader.ReadAllCiyts();

            foreach (var city in citys)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
