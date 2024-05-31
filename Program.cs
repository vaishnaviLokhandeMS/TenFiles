using System;

namespace MyCSharpProject
{
    class Program1
    {
        // Function to calculate GCD of two numbers
        public static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Function to calculate LCM of two numbers
        public static int CalculateLCM(int a, int b)
        {
            return (a * b) / CalculateGCD(a, b);
        }

        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 20;

            int gcd = CalculateGCD(num1, num2);
            int lcm = CalculateLCM(num1, num2);

            Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
            Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
        }
    }
}
