using System;
using System.Collections.Generic;

namespace _6_WorkWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\2 ArrayPracticalExample\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> citys = csvReader.ReadAllCiyts();

            Console.Write("Enter how many cities you want to diplay: ");

            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must enter a positive integer!");
                return;
            }

            int maxToDisplay = Math.Min(userInput, citys.Count);

            for (int i = 0; i < maxToDisplay; i++)
            {
                City city = citys[i];
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
