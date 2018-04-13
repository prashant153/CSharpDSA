using System;

namespace PrimeNumOptimizedNaive
{
  /*  

   
   We can do following optimizations:
   1)   Instead of checking till n, we can check till √n because a larger factor 
        of n must be a multiple of smaller factor that has been already checked.
   2)   The algorithm can be improved further by observing that all primes are 
        of the form 6k ± 1, with the exception of 2 and 3.
        This is because all integers can be expressed as (6k + i) for some 
        integer k and for i = ?1, 0, 1, 2, 3, or 4; 2 divides(6k + 0), (6k + 2),
        (6k + 4); and 3 divides(6k + 3). So a more efficient method is to 
        test if n is divisible by 2 or 3, then to check through all the numbers
        of form 6k ± 1.


   */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a prime.");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (IsPrime(number)==true)
                {
                    Console.WriteLine("{0} is a Prime Number.",number);
                }
                else
                {
                    Console.WriteLine("{0} is not a Prime Number.",number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!! Please check if the" +
                                  " input was a number??");
                //throw ex;
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number %2 == 0 || number%3 == 0)
            {
                return false;
            }
            for (int i = 5; i*i < number; i=i+6)
            {
                if (number% i ==0 || number%(i+2)==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
