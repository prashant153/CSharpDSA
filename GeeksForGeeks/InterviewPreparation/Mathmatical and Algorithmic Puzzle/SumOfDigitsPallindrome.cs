public class GFG {
    private static int FindDigitSum(int n)
    {
        int q = n;
        int sum=0;
        while(q!=0)
        {
            sum += (q%10);
            q /= 10; 
        }
        return sum;
    }
    private static string CheckPallindrome(int num)
    {
        int rem, sum = 0, temp;  
        temp = num;
        while (num > 0) {  
            rem = num % 10; //for getting remainder by dividing with 10    
            num = num / 10; //for getting quotient by dividing with 10    
            sum = sum * 10 + rem;  
            /*multiplying the sum with 10 and adding  
            remainder*/  
        }  
        return (sum ==temp ? "YES" : "NO");
    }
	static public void Main () {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = FindDigitSum(n);
            Console.WriteLine(CheckPallindrome(sum));
        }
	}
}