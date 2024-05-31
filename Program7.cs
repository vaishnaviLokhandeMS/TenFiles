using System;

namespace MyCSharpProject
{
    class Program7
    {
        // Function to find the factorial of a number
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Function to check if a number is prime
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int number1 = 5;
            Console.WriteLine($"Factorial of {number1} is: {Factorial(number1)}");

            int number2 = 17;
            Console.WriteLine($"{number2} is {(IsPrime(number2) ? "prime" : "not prime")}");
        }
    }
}
