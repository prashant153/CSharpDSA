public class GFG {
    private static long ReverseDigits(long n)
    {
        long rev=0,rem,q;
        while(n>0)
        {
            rem = n % 10;
            n = n/10;
            rev = rev * 10 + rem;
        }
        return rev;
    }
	static public void Main () {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) 
        {
            long n = (long)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ReverseDigits(n));
        }
	}
}