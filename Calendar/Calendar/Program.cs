using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            string inputString = Console.ReadLine();
            int numberVerifier = 0;

            while(!(int.TryParse(inputString, out numberVerifier)))
            {
                Console.WriteLine("Please input a valid number");
                inputString = Console.ReadLine();
            }

            while(int.Parse(inputString)<1 || int.Parse(inputString)>9999)
            {
                Console.WriteLine("Please input a valid number");
                inputString = Console.ReadLine();
            }

            int year = int.Parse(inputString);

            for(int i=1;i<=12;i++)
            {
                int numberDays = DateTime.DaysInMonth(year, i);
                Console.WriteLine("Month: {0}", i);
                Console.WriteLine("Days in month: {0}", numberDays);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
