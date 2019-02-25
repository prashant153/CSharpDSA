public class GFG {
    static public long KthValue(long n,long k)
    {
        for (long i =1;i<k;i++)
        {
            n = n/10;
        }
        return n%10;
    }
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
	    for(int tItr=0;tItr<t;tItr++)
	    {
	        string s = Console.ReadLine();
	        long[] arr = Array.ConvertAll(s.Trim().Split(' '), converter: Convert.ToInt64);
	        long a = arr[0];
	        long b = arr[1];
	        long k = arr[2];
    		Console.WriteLine(KthValue((long)Math.Pow(a,b),k));
	    }
        
	}
}