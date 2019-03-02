public class GFG {
    static public void TriangularNumber(long n)
    {
        long sum =0;
        for(long i = 1;i<=n;i++)
        {
            sum = (i*(i+1));
            if(sum%2 ==0)
            {
                sum /= 2;
                if(sum == n)
                {
                    Console.WriteLine(1);
                    return;
                }
            }
        }
        Console.WriteLine(0);
    }
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
	    for(int tItr=0;tItr<t;tItr++)
	    {
	        long n = (long) Convert.ToDouble(Console.ReadLine());
	        TriangularNumber(n);
	    }
	}
}