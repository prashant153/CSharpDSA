using System;
using System.Numerics;

namespace ProgramTest
{
    public class Program 
    {
        static public decimal CalcNr(long n,long r)
        {
            decimal prod = 1;
            for(long i=0;i<r;i++)
            {
                prod *= n;
                n--;
            }
            return prod;
        }
        static public decimal Factorial(long n)
        {
            decimal res = 1; 
            for (long i = 2; i <= n; i++) 
                res = res * i;

            return res; 
        }
        static public void Main () 
        {
            long t = 1;
            for(long tItr=0;tItr<t;tItr++)
            {	        
                long n = 778;
                long r = 116;
                if(n<r)
                {
                    Console.WriteLine(0);
                }
                else if((n==r)||(r==0))
                {
                    Console.WriteLine(1);
                }
                else if(((n-r)==1) || r==1)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    decimal Nr = 1;
                    if((n-r)>r)
                    {
                        Nr = CalcNr(n,r);
                    }
                    else
                    {
                        Nr = CalcNr(n,n-r);
                        r = n-r;
                    }
                    decimal rFact = Factorial(r);
                    if(rFact ==0)
                        rFact =1;
                        
                    Console.WriteLine(Nr/rFact);
                }
            }
	    }
    }    
}
