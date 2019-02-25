public class GFG {
	static public void Main () {
		int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arm = new int[3];
            int q = n;
            for(int i = 0;i<3;i++){
                arm[i] = q%10;
                q /= 10;
            }
            if(n == (Math.Pow(arm[0],3)+Math.Pow(arm[1],3)+Math.Pow(arm[2],3)))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
	}
}