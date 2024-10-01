using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class insertionSortClass
    {
        public static void Main()
        {
            Console.WriteLine("Insertion Sort with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            Console.Write("\nORIGINAL Order : ");
            insertionSort.PrintIntegerArray(rng.data);
            Console.WriteLine("\n");

            int[] sortedArray = insertionSort.sort(rng.data);

            Console.Write("\n\nSORTED Order   : ");
            insertionSort.PrintIntegerArray(sortedArray);
            Console.WriteLine("\n");
        }
    }

    class insertionSort
    {
        public static int[] sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                Console.WriteLine("\nPass                : " + (i + 1));
                Console.WriteLine("=================================================");
                int comparisonIteration = 1;
                for (int j = i + 1; j > 0; j--)
                {
                    Console.WriteLine("Comparison Iteration: " + (comparisonIteration++));
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                        Console.WriteLine("Left Hand Value     : " + inputArray[j - 1]);
                        Console.WriteLine("Right Hand Value    : " + inputArray[j]);
                        Console.WriteLine("Hands               : Swap");
                    }
                    else
                    {
                        Console.WriteLine("Hands               : No Swap");
                    }
                    Console.WriteLine("Order : " + string.Join(", ", inputArray) + "\n");
                }
            }
            return inputArray;
        }

        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}
