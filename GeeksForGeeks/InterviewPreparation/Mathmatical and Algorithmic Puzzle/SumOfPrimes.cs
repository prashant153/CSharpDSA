public class GFG {
    static public void SumOfPrimes(long n)
    {
        long sum =0;
        bool[] prime = new bool[n+1];
        for(long i =0;i<=n;i++)
        {
            prime[i] = true;
        }
        for(long p =2;p*p<=n;p++)
        {
            if(prime[p] == true)
            {
                for(long i = p*p; i<=n;i+=p){
                    prime[i] = false;
                }   
            }
        }
        for(long i = 2;i<=n;i++)
        {
            if(prime[i]==true)
            {
                sum+=i;
            }
        }        
        Console.WriteLine(sum);
    }
	static public void Main () {
	    long t = (long) Convert.ToDouble(Console.ReadLine());
	    for (int tItr = 0; tItr < t; tItr++) 
        {
            long n = (long) Convert.ToDouble(Console.ReadLine());  
            SumOfPrimes(n);
	    }
    }
}