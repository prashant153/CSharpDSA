public class GFG {
    
    private static long Factorial(int n)
    {
        if(n == 0){
            return 1;
        }
        return n*Factorial(n-1);
    }
    
	static public void Main () {
		int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int[] arr = new int[2];
            arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int n = arr[0];
            int r = arr[1];
            long nFact = Factorial(n);
            long nrFact = Factorial(n-r);
            long nPr = nFact / nrFact;
            Console.WriteLine(nPr);
        }
    }
}