using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();
            Console.Clear();

            for(int i=9;i<=49;i++)
            {
                if(i%2==1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();
            Console.Clear();

            for (int i = 100;i> 50;i--)
            {
                if(i%2==0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
