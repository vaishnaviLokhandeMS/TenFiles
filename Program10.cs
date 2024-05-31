using System;
using System.Collections.Generic;

namespace MyCSharpProject
{
    class Program10
    {
        // Function to find all prime numbers up to a given number using Sieve of Eratosthenes
        public static List<int> SieveOfEratosthenes(int n)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        // Function to perform basic arithmetic operations (+, -, *, /) on two numbers
        public static double BasicCalculator(char operation, double num1, double num2)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }

        static void Main(string[] args)
        {
            int n = 30;
            Console.WriteLine($"Prime numbers up to {n}:");
            List<int> primes = SieveOfEratosthenes(n);
            Console.WriteLine(string.Join(", ", primes));

            char operation = '+';
            double num1 = 10;
            double num2 = 5;
            Console.WriteLine($"{num1} {operation} {num2} = {BasicCalculator(operation, num1, num2)}");
        }
    }
}
