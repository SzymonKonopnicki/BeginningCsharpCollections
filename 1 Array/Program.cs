using System;

namespace _1_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] monthsOfYear =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            Console.WriteLine("Which month do you want to display?");
            Console.WriteLine("January = 1, February = 2, etc. : ");

            int month = int.Parse(Console.ReadLine());
            string chosenMonth = monthsOfYear[month - 1];

            Console.WriteLine($"That month is {chosenMonth}");

        }
    }
}
