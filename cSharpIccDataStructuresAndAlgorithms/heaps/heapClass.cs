using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.heaps
{
    class heapClass
    {
        public static void Main()
        {
            Console.WriteLine("Max Heap utilizing Array and Heapify Down");
            Console.Write("\nArray Index/es: ");
            int arrayIndex = Convert.ToInt32(Console.ReadLine());
            double[] heapArray = new double[arrayIndex];
            Console.WriteLine("");
            for (int i = 0; i < arrayIndex; i++)
            {
                Console.Write("Index [" + i + "], Entry " + (i + 1) + ": ");
                double entry = Convert.ToDouble(Console.ReadLine());
                heapArray[i] = entry;
            }

            Console.Write("\nOriginal Array Elements: ");
            heapFunctions.printArray(heapArray);

            maxHeapClass.maxHeapSort(heapArray);
            Console.Write("\n\nMax Heap Array Elements: ");
            heapFunctions.printArray(heapArray);
            Console.WriteLine("\nExtracted Max (Root)   :  " + maxHeapClass.extractMax(heapArray));

            Console.WriteLine("\n");
        }
    }

    class heapFunctions
    {
        // heapify down position swap
        public static void positionSwap<T>(T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];  // pos0 - swapped out
            array[pos1] = tmpVal;       // pos1 - swapped in
        }

        // left (1) child index (from parent - 0)
        public static int leftChildPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        // right (2) child index (from parent - 0)
        public static int rightChildPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        public static void printArray<T>(T[] array)
        {
            foreach (T t in array)
            {
                Console.Write(' ' + t.ToString() + ' ');
            }
        }
    }
}
