using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.searching_algorithms
{
    class linearSearchClass
    {
        public static void Main()
        {
            Console.WriteLine("Linear Search with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            Console.Write("\nArray: ");
            Console.WriteLine("[ " + string.Join(", ", rng.data) + " ]");
            Console.Write("\nTarget: ");
            int target = Convert.ToInt32(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result =linearSearch(rng.data, target);
            double time = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("\n\nResult");
            Console.WriteLine("=============================================");
            if (result != -100) Console.WriteLine("Target: Found [" + result + "] " + rng.data[result]);
            else Console.WriteLine("Target: Not Found");
            Console.WriteLine("Time  : " + time + "ms");

        }

        private static int linearSearch(int[] array , int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return i;
            }
            return -100;
        }
    }
}
