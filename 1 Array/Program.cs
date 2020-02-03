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

            int[] arrayInt = { 4, 77, 65, 34 };

            char[] arrayChar = { 'h', 'e', 'y', '6' };

            System.Drawing.Rectangle[] arrayRectangle =
            {
                new System.Drawing.Rectangle(10, 10, 50, 50),
                new System.Drawing.Rectangle(30, 30, 50, 50),
                new System.Drawing.Rectangle(20, 100, 100, 50)
            };

            foreach (var month in monthsOfYear)
            {
                Console.WriteLine(month);
            }

        }
    }
}
