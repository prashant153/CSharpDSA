public class GFG {

	static public void Main () {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();
            long n =  (long)Convert.ToDouble(s);
            
            long dec = 0;
            for(long i = s.Length; i>0;i--)
            {
                long j = (long)s.Length - i;
                dec += ((long) Math.Pow(2,j)) * (n%10);
                n /=10;
            }
    
            Console.WriteLine(dec);
        }
	}
}