using System;

namespace MyCSharpProject
{
    class Program9
    {
        // Function to perform linear search on an array
        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Return the index of the target element if found
                }
            }
            return -1; // Return -1 if target element is not found
        }

        // Function to perform selection sort on an array
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap array[i] and array[minIndex]
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 64, 25, 12, 22, 11 };
            int target = 12;

            // Performing linear search
            int linearSearchResult = LinearSearch(array, target);
            if (linearSearchResult != -1)
            {
                Console.WriteLine($"Linear Search: Element {target} found at index {linearSearchResult}.");
            }
            else
            {
                Console.WriteLine($"Linear Search: Element {target} not found in the array.");
            }

            // Performing selection sort
            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            SelectionSort(array);

            Console.WriteLine("Array after Selection Sort:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
