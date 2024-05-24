using System;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you sure you want to delete the record?(y/n)");
            string inputString = Console.ReadLine();
            while(inputString!="y" && inputString!="n")
            {
                Console.WriteLine("Sorry, you must answer y or n");
                inputString = Console.ReadLine();
            }
            if (inputString == "y" || inputString == "Y")
            {
                Console.WriteLine("The record was deleted");
            }
            else if (inputString == "n" || inputString == "N")
            {
                Console.WriteLine("The record was not deleted");
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What year were you born?");
            inputString = Console.ReadLine();
            int yearBorn = 0;
            bool validYear = int.TryParse(Console.ReadLine(), out yearBorn);

            if (validYear)
            {

                while (int.Parse(inputString) < 1900 && int.Parse(inputString) > 2011)
                {
                    Console.WriteLine("Sorry, please enter a valid year.");
                    inputString = Console.ReadLine();
                    validYear = int.TryParse(Console.ReadLine(), out yearBorn);
                }
            }
            else
            {
                Console.WriteLine("Sorry,please enter a valid year.");
                inputString = Console.ReadLine();
                validYear = int.TryParse(Console.ReadLine(), out yearBorn);
            }
            yearBorn = int.Parse(inputString);
            int age = 2018 - yearBorn;
            Console.WriteLine("You are about {0} years old", age);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
