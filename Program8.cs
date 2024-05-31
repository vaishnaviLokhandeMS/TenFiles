using System;

namespace MyCSharpProject
{
    class Program8
    {
        // Function to find the nth Fibonacci number using recursion
        public static int FibonacciRecursive(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Input must be a positive integer.");
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Function to find the nth Fibonacci number using dynamic programming
        public static int FibonacciDP(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Input must be a positive integer.");
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

        static void Main(string[] args)
        {
            int n = 10;

            Console.WriteLine($"Recursive Fibonacci of {n}th number is: {FibonacciRecursive(n)}");
            Console.WriteLine($"Dynamic Programming Fibonacci of {n}th number is: {FibonacciDP(n)}");
        }
    }
}
