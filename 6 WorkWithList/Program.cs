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

            int maxToDisplay = userInput;

            for (int i = citys.Count -1; i >= 0; i--)
            {
                int displayIndex = citys.Count - 1 - i;
                if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quite: ");
                    if (Console.ReadLine() != "")
                        break;
                }

                City city = citys[i];
                Console.WriteLine($"{displayIndex + 1} - {city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
