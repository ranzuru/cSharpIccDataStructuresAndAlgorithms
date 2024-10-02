using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class backtrackingClass
    {
        public static void Main()
        {
            int permCount = 0;

            Console.WriteLine("Array (Unordered) Element/s Permutation/s using Backtracking");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            Console.Write("\nArray: ");
            Console.WriteLine("[ " + string.Join(", ", rng.data) + " ]");

            Console.WriteLine("\nPermutation/s");
            Console.WriteLine("===========================================================");
            Permute(rng.data, 0, rng.data.Length - 1, ref permCount);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Count: " + permCount);
        }

       private static void Permute(int[] arr, int l, int r, ref int count)
        {
            if (l == r)
            {
                Console.WriteLine("Order " + (count + 1) + ": " + string.Join(", ", arr));
                count++; // permutation count

                bool isAscending, isDescending;
                (isAscending, isDescending) = IsSorted(arr);

                if (isAscending)
                {
                    Console.WriteLine("Order " + (count + 1) + ": " + string.Join(", ", arr) + " (Ascending Order)");
                }

                if (isDescending)
                {
                    Console.WriteLine("Order " + (count + 1) + ": " + string.Join(", ", arr) + " (Descending Order)");
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    Swap(ref arr[l], ref arr[i]);   // explore new permutations
                    Permute(arr, l + 1, r, ref count); // permutation recursion on remaining elements
                    Swap(ref arr[l], ref arr[i]);   // backtrack
                }
            }
        }

        private static (bool, bool) IsSorted(int[] arr)
        {
            bool isAscending = true;
            bool isDescending = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) isAscending = false;   // ascending order validation

                if (arr[i] < arr[i + 1]) isDescending = false;  // descending order validation
            }
            return (isAscending, isDescending);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
