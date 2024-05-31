using System;

namespace MyCSharpProject
{
    class Program4
    {
        // Function to perform binary search on a sorted array
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Target not found
        }

        // Function to perform bubble sort on an unsorted array
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 7;

            int result = BinarySearch(sortedArray, target);
            if (result != -1)
            {
                Console.WriteLine($"Element {target} found at index {result}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }

            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Unsorted Array:");
            Console.WriteLine(string.Join(", ", unsortedArray));

            BubbleSort(unsortedArray);
            Console.WriteLine("Sorted Array using Bubble Sort:");
            Console.WriteLine(string.Join(", ", unsortedArray));
        }
    }
}
