using System;

namespace _2_ArrayPracticalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\2 ArrayPracticalExample\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            City[] citys = csvReader.ReadFirstNCiyts(7);

            foreach (var city in citys)
            {
                Console.WriteLine($"{city.TotalPopulation} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
