public class GFG {
    static public long[] PrimeArr(long n)
    {
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
        long count = 0;
        for(long i = 2;i<=n;i++)
        {
            if(prime[i]==true)
            {
                count++;
            }
        }
        long[] retArr = new long[count];
        long tempCount = count;
        for(long i = 2;i<=n;i++)
        {
            if(prime[i]==true && tempCount >0)
            {
                retArr[count-tempCount]=i;
                tempCount--;
            }
        }
        return retArr;
    }
    static public void PrimePairs(long n)
    {
        long[] primeArr = PrimeArr(n/2);
        for(long i=0;i<primeArr.Length;i++)
        {
            for(long j=0;j<primeArr.Length;j++)
            {
                if(primeArr[i]*primeArr[j]<=n)
                {
                    Console.Write(primeArr[i]+" "+ primeArr[j]+" ");
                }
            }
        }
    }
	static public void Main () {
        long t = (long) Convert.ToDouble(Console.ReadLine());        
        for (int tItr = 0; tItr < t; tItr++) 
        {
            long n = (long) Convert.ToDouble(Console.ReadLine());            
            PrimePairs(n);
            Console.WriteLine();
        }	
    }
}