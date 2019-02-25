public class GFG {
    static public bool CheckPrime(int n)
    {
        if(n%2 == 0)
        {
            return false;
        }
        for(int i = 3; i<= Math.Sqrt(n);i=i+2)
        {
            if(n%i==0){
                return false;
            }
        }
        return true;
    }
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());		
            if(CheckPrime(n))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
	}
}