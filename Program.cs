using System;

namespace FibonacciPrinter
{
    class Program
    {


        
        
        
        static void Fibonacci(int a,int b)
        {

            //compute the values only after checking if both values are Numbers and elements of the fibonacci sequence
            //the values are adjacent (i.e they appear one after the other on the fibonacci sequence
            //also you must ensure that if both entries are the same value then they must both be one 
            //else if the above conditions are not met throw an exception

            
            
            /*functions that are helpers to the fibonacci method*/

            //This function will test if a value is an element of the fibonacci sequence
            // true if x is perfect square after the mathematicsal expression has been applied to it
            static bool isFibonacci(int n)
            {
                // n is Fibonacci if one of 
                // 5*n*n + 4 or 5*n*n - 4 or  
                // both are a perfect square 
                return isPerfectSquare(5 * n * n + 4) ||
                       isPerfectSquare(5 * n * n - 4);
            }
            
            static bool isPerfectSquare(int n)
            {
                int s = (int)Math.Sqrt(n);
                return (s * s == n);
            }


            static bool isAdjacent(int a, int b)
            {
                //Compute the next value and check if it is the same as b
                double x = a * (1 + Math.Sqrt(5)) / 2.0;
                int next = (int)Math.Round(x);

                if(next == b)
                {
                    return true;
                }

                return false;
            }

            if (isFibonacci(a) && isFibonacci(b) && ((a==1 && b==1) || isAdjacent(a,b)) && ((a >= 0 && b > 0) || (b >= 0 && a > 0))) 
            {

                int count = 0;
                while (count < 5)
                {
                    count++;
                    int next = a + b;
                    Console.Write(next+" ");
                    a = b;
                    b = next;
                }
            }
            else
            {
                if (a < 0 || b < 0)
                    throw new Exception("Both values must be non-negative");

                if(!isFibonacci(a) || !isFibonacci(b))
                 throw new Exception("The number(s) entered is(are) not fibonacci ");

                if (!isAdjacent(a, b))
                    throw new Exception("The numbers entered are not adjacent");


            }

        }
        static void Main(string[] args)
        {
            //Test here 
            Fibonacci(1, 2);
        }
    }
}
