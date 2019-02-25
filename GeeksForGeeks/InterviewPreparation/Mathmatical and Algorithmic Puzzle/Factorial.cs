public class GFG {
    private static long Factorial(long n)
    {
        if(n==0)
        {
            return 1;
        }
        return n*Factorial(n-1);
    }
	static public void Main () {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) {
            long n =(long) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
	}
}