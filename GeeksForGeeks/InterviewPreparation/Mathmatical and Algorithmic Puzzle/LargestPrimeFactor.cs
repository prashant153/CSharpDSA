public class GFG {
    static public void LargestPrime(long n)
    {
        long maxPrime = -1; 
        // Print the number of 2s 
        // that divide n 
        while (n % 2 == 0) { 
            maxPrime = 2; 
            // equivalent to n /= 2 
            n >>= 1; 
        } 
  
        // n must be odd at this point, 
        // thus skip the even numbers 
        // and iterate only for odd 
        // integers 
        for (int i = 3; i <= Math.Sqrt(n); i += 2) { 
            while (n % i == 0) { 
                maxPrime = i; 
                n = n / i; 
            } 
        } 
        // This condition is to handle 
        // the case when n is a prime 
        // number greater than 2 
        if (n > 2) 
            maxPrime = n; 
  
        Console.WriteLine(maxPrime);
    }
	static public void Main () {
	    long t = (long) Convert.ToDouble(Console.ReadLine());
	    for (int tItr = 0; tItr < t; tItr++) 
        {
            long n = (long) Convert.ToDouble(Console.ReadLine());  
            LargestPrime(n);
	    }
    }
}