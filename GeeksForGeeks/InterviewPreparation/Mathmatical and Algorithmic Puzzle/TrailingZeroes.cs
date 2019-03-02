public class GFG {
    static public void TrailingZeroes(long n)
    {
        long twosCount =0;
        long fivesCount =0;
        for(long i = 2;i<=n;i++)
        {
            long j = i;
            while(j%2==0)
            {
                twosCount++; 
                j /= 2;
            }
            while(j%5==0)
            {
                fivesCount++; 
                j /= 5;
            }
        }
        Console.WriteLine(Math.Min(twosCount,fivesCount));
    }
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
	    for(int tItr=0;tItr<t;tItr++)
	    {
	        long n = (long) Convert.ToDouble(Console.ReadLine());
	        TrailingZeroes(n);
	    }
	}
}