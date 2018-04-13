using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int number = int.Parse(Console.ReadLine());
            try
            {
                int a = 0;
                int b = 1;
                int c = 1;
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(a);
                    a = b;
                    b = c;
                    c = b + a;

                }
            }
            catch (Exception )
            {
                Console.WriteLine("Something went wrong!! Please check if a " +
                                  "proper number is provided.");
            }
        }
    }
}
