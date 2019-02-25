public class GFG {
    static public long GCD(long a, long b)
    {
        long rem = b%a;
        if (rem==0)
        {
            return a;
        }   
        return GCD(rem,a);
    }
    static public long GCDArray(long[] arr)
    {
        if(arr.Length == 1)
        {
            return arr[0];
        }
        long[] tempArr = new long[arr.Length - 1];
        tempArr[0] = GCD(arr[0], arr[1]);
        for(int i = 1;i<tempArr.Length;i++)
        {
            tempArr[i] = arr[i+1];
        }
        return GCDArray(tempArr);
    }
	static public void Main () {
	    int t = Convert.ToInt32(Console.ReadLine());
	    for(int tItr=0;tItr<t;tItr++)
	    {
	        long n = (long) Convert.ToDouble(Console.ReadLine());
	        string s = Console.ReadLine();
	        long[] arr = Array.ConvertAll(s.Trim().Split(' '), converter: Convert.ToInt64);
	        Array.Sort(arr);
	        Console.WriteLine(GCDArray(arr)); 
	    }
	}
}