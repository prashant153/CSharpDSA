using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's Prime :");
            int number = int.Parse(Console.ReadLine());
            if (IsPrime(number)== true)
            {
                Console.WriteLine("{0} is a Prime Number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number.", number);
            }
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number%i==0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
