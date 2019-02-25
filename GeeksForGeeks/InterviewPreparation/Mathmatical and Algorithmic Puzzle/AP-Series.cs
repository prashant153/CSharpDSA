public class GFG {
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) {
            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(q[0] + (n-1)*(q[1]-q[0]));
        }  
        
	}
}
// Used simple AP formula