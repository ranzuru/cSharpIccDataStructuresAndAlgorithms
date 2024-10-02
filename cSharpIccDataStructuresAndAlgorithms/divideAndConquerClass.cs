using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class divideAndConquerClass
    {
        static int max;
        static int min;
        public static void Main()
        {
            Console.WriteLine("Finding Minimum and Maximum Values (Unordered Array) Using Divide and Conquer Approach");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            Console.Write("\nArray: ");
            Console.WriteLine("[ " + string.Join(", ", rng.data) + " ]");

            Console.WriteLine("\nElements");
            Console.WriteLine("===========================================================");

            int max = DacMax(rng.data, 0, rng.data.Length - 1);
            Console.WriteLine("Maximum: " + max);

            int min = DacMin(rng.data, 0, rng.data.Length - 1);
            Console.WriteLine("Minimum: " + min);
        }

        static int DacMax(int[] arr, int low, int high)
        {
            // 1 element in array
            if (low == high) return arr[high];

            //  2 elements in array
            if (high == low + 1) return (arr[low] > arr[high]) ? arr[low] : arr[high];


            // 3+ elements in array
            int mid = (low + high) / 2;
            int leftMax = DacMax(arr, low, mid); // left hand max
            int rightMax = DacMax(arr, mid + 1, high); // right hand max

            return (leftMax > rightMax) ? leftMax : rightMax;
        }

        static int DacMin(int[] arr, int low, int high)
        {
            // 1 element in array
            if (low == high) return arr[low];

            //  2 elements in array
            if (high == low + 1) return (arr[low] < arr[high]) ? arr[low] : arr[high];


            // 3+ elements in array
            int mid = (low + high) / 2;
            int leftMin = DacMin(arr, low, mid); // left hand min
            int rightMin = DacMin(arr, mid + 1, high); // right hand min

            return (leftMin < rightMin) ? leftMin : rightMin;
        }
    }
}
