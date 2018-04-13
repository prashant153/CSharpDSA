using System;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibonacci(number));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!! Did you input a " +
                                  "proper number??");
            }
        }

        private static int Fibonacci(int number)
        {
            if (number<=1)
            {
                return number;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
