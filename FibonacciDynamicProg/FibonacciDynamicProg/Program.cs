using System;

namespace FibonacciDynamicProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of N:");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibonacci(number));
            }
            catch (Exception )
            {
                Console.WriteLine("Something went wrong!! Please check if the " +
                                  "input is a proper number");
            }
        }

        private static int Fibonacci(int number)
        {
            int[] f = new int[number + 2];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[number];
        }
    }
}
