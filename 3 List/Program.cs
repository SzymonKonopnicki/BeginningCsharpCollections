﻿using System;
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

            City cityTest = new City("Test", "TES", "Polska", 3000000, 1600000, 1400000);

            int index;
            citys.Insert(index, cityTest);

            foreach (var city in citys)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }

            Console.WriteLine($"{citys.Count} citys");

        }
    }
}
