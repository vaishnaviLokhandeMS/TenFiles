using System;

namespace MyCSharpProject
{
    class Program2
    {
        // Function to calculate the square of a number
        public static int CalculateSquare(int number)
        {
            return number * number;
        }

        // Function to calculate the cube of a number
        public static int CalculateCube(int number)
        {
            return number * number * number;
        }

        static void Main(string[] args)
        {
            int num = 5;

            int square = CalculateSquare(num);
            int cube = CalculateCube(num);

            Console.WriteLine($"The square of {num} is: {square}");
            Console.WriteLine($"The cube of {num} is: {cube}");
        }
    }
}
