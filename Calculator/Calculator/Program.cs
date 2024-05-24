using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo;
            double numberVerifier = 0.1;
            double userNum1 = 0;
            double userNum2 = 0;
            do
            {
                Console.WriteLine("What operation do you want to perform? (+/-)");
                string operationChoice = Console.ReadLine();

                Console.WriteLine("Enter first number: ");

                string inputString = Console.ReadLine();

                while (!(double.TryParse(inputString, out numberVerifier)))
                {
                    Console.WriteLine("Please input a number:");
                    inputString = Console.ReadLine();
                }
                userNum1 = double.Parse(inputString);
                Console.WriteLine("Enter second number: ");
                
                inputString = Console.ReadLine();
                while (!(double.TryParse(inputString, out numberVerifier)))
                {
                    Console.WriteLine("Please input a number:");
                    inputString = Console.ReadLine();
                }

                    userNum2 = double.Parse(inputString);

                if(operationChoice=="+")
                {
                    double userTotal = userNum1 + userNum2;
                    Console.Write("{0} + {1} = {2}", userNum1, userNum2, userTotal);
                }
                else if(operationChoice=="-")
                {
                    double userTotal = userNum1 - userNum2;
                    Console.Write("{0} - {1} = {2}", userNum1, userNum2, userTotal);
                }

                Console.Write("Do you want another go (y/n): ");
                yesNo = Console.ReadLine();
            } while (yesNo == "y");

        }
    }
}
