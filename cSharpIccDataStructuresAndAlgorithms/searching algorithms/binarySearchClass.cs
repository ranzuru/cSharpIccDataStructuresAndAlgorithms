using cSharpIccDataStructuresAndAlgorithms.sorting_algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.searching_algorithms
{
    class binarySearchClass
    {
        public static void Main()
        {
            Console.WriteLine("Binary Search with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            Array.Sort(rng.data);   // sort ascending (required)

            Console.Write("\nArray: ");
            Console.WriteLine("[ " + string.Join(", ", rng.data) + " ]");
            Console.Write("\nTarget: ");
            int target = Convert.ToInt32(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var bsiResult = binarySearch.bsIterative(rng.data, target);
            stopwatch.Stop();
            double iterativeTime = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("\nITERATING Binary Search");
            Console.WriteLine("=============================================");
            if (bsiResult is int bsiPosition) Console.WriteLine("Target: Found [" + bsiPosition + "] " + target);
            else Console.WriteLine("Target: Not Found");
            Console.WriteLine("Time  : " + iterativeTime + "ms");

            Console.WriteLine("\nRECURSIVE Binary Search");
            Console.WriteLine("=============================================");

            stopwatch.Restart();
            var bsrResult = binarySearch.bsRecursive(rng.data, target, 0, rng.data.Length - 1);
            stopwatch.Stop();
            double recursiveTime = stopwatch.Elapsed.TotalMilliseconds;

            if (bsrResult is int bsrPosition) Console.WriteLine("Target: Found [" + bsrPosition + "] " + target);
            else Console.WriteLine("Target: Not Found");
            Console.WriteLine("Time  : " + recursiveTime + "ms");
        }
    }
    
    class binarySearch
    {
        public static object bsIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid]) return ++mid;
                else if (key < inputArray[mid]) max = mid - 1;
                else min = mid + 1;
            }
            return "Nil";
        }

        public static object bsRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max) return "Nil";
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid]) return ++mid;
                else if (key < inputArray[mid]) return bsRecursive(inputArray, key, min, mid - 1);
                else return bsRecursive(inputArray, key, mid + 1, max);
            }
        }
    }
}
