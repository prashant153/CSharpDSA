using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N");
            try
            {
                int number =  int.Parse(Console.ReadLine());
                Console.WriteLine(Fact(number));
            }
            catch (Exception )
            {
                Console.WriteLine("Something went wrong!! Is your input a " +
                                  "proper number");
            }
        }

        private static int Fact(int number)
        {
            if (number==0)
            {
                return 1;
            }
            return number * Fact(number - 1);                
        }
    }
}
