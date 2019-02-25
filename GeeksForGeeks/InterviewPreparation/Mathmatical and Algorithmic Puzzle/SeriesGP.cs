public class GFG {
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
	    for(int tItr=0;tItr<t;tItr++)
	    {   string s = Console.ReadLine();
	        int[] arr = Array.ConvertAll(s.Trim().Split(' '), converter: Convert.ToInt32);
	        int n = Convert.ToInt32(Console.ReadLine());
	        double a1 = arr[0];
	        double a2 = arr[1];
	        double tempr = a2/a1;
	        double r = tempr;
	        Console.WriteLine(Math.Floor(a1*(Math.Pow(r,n-1))));
	    }
	}
}