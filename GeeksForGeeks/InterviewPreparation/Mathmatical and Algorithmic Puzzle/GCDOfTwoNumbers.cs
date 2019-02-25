public class GFG {
    private static long GCD(long a,long b)
    {
        long rem;
        rem = a % b;
        if(rem==0)
        {
            return b;
        }
        return GCD(b,rem);
    }
	static public void Main () {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) 
        {
            string s =Console.ReadLine();
            long[] arr =  Array.ConvertAll(s.Trim().Split(' '), converter: Convert.ToInt64);
            Array.Sort(arr);
            Array.Reverse(arr);
            long a = arr[0];
            long b = arr[1];
            Console.WriteLine(GCD(a,b));
            
        }
	}
}