public class GFG {
    static public void PrintJumpingNumbers(long n)
    {
        //start from 10
        //Graph based question. To be implemented later.
    }
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
	    for(int tItr=0;tItr<t;tItr++)
	    {
	        long n = (long) Convert.ToDouble(Console.ReadLine());
	        if(n<=10)
	        {
	            for(long i=0;i<=n;i++)
	            {
	                Console.Write(i+" ");
	            }
	        }
	        else
	        {
	            for(int i=0;i<=10;i++)
	            {
	                Console.Write(i+" ");
	            }
	        }
	        PrintJumpingNumbers(n);
	        Console.WriteLine();
	    }
            
}
    
}