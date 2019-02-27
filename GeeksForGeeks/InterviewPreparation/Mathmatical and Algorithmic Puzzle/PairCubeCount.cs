public class GFG {
    public static void PairCubeCount(long n)
    {
        long count =0 ;
        //crn = cuberoot of n
        var num = Math.Pow(n,(double)(1.0/3.0));
        long crn = (long) Math.Round(num);
        //iterate through the crn and find the cube
        for(long i=1;i<=crn;i++)
        {
            for(long j=0;j<=crn;j++)
            {
                // if given condition true then count++
                if((i*i*i + j*j*j) == n)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
	static public void Main () {
	    long t = (long) Convert.ToDouble(Console.ReadLine());
	    for (int tItr = 0; tItr < t; tItr++) 
        {
            long n = (long) Convert.ToDouble(Console.ReadLine());  
            PairCubeCount(n);
	    }
    }
}