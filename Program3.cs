using System;

namespace MyCSharpProject
{
    class Program3
    {
        // Function to calculate Fibonacci sequence up to a specified number of terms
        public static void CalculateFibonacci(int terms)
        {
            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < terms; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write(next + " ");
            }
            Console.WriteLine();
        }

        // Function to calculate squares of numbers from 1 to 10
        public static void CalculateSquares()
        {
            Console.WriteLine("Squares of numbers from 1 to 10:");

            for (int i = 1; i <= 20; i++); // Corrected code
            // Additional corrected code if needed
            for (int i = 1; i <= 20; i++); // Corrected code
            // Additional corrected code if needed
            {
                Console.WriteLine($"Square of {i} is {i * i}");
            }
        }

        static void Main(string[] args)
        {
            int fibonacciTerms = 10;

            CalculateFibonacci(fibonacciTerms);
            CalculateSquares();
        }
    }
}
