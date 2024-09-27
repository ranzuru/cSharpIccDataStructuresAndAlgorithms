using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class quicksort
    {
        public static void Main()
        {
            
            Console.WriteLine("Quicksort using Array");

            Console.Write("\nNumber of Index/es: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNote: Use numeric characters (Integers: Positive/ Negative)\n");
            int[] qsArray = new int[indexCount];

            for (int i = 0; i < indexCount; i++)
            {
                Console.Write("Entry " + (i + 1) + ": ");
                int entry = Convert.ToInt32(Console.ReadLine());
                qsArray[i] = entry;
            }

            Console.WriteLine();
            Console.WriteLine("Order");
            Console.WriteLine("====================================");
            Console.Write("Original           : ");
            foreach (var item in qsArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            quickSort(qsArray, 0, qsArray.Length - 1);

            Console.WriteLine();
            Console.Write("Sorted (Ascending) : ");

            foreach (var item in qsArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void quickSort(int[] arr, int left, int right)
        {
            if (left < right)   // subarray has 1 or more element
            {
                // partitioned array (smallest (left) to biggest (right))
                int pivot = partitioning(arr, left, right);

                // recursive sort on both sides
                if (pivot > 1) quickSort(arr, left, pivot - 1);

                if (pivot + 1 < right) quickSort(arr, pivot + 1, right);
            }
        }

        private static int partitioning(int[] arr, int left, int right)
        {
            int pivot = arr[left]; // left most

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }   // left pivot condition

                while (arr[right] > pivot)
                {
                    right--;
                }   // right pivot condition

                // left and right swap
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else return right;
            }
        }
    }
}
