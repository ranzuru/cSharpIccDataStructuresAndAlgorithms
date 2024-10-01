using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class mergeSortClass
    {
        public static void Main()
        {
            Console.WriteLine("Merge Sort with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            mergeSort msArray = new mergeSort(rng.data);

            Console.Write("\nORIGINAL Order: ");
            msArray.display();
            Console.WriteLine("\n");

            msArray.SortArray(msArray.data, 0, msArray.data.Length - 1);

            Console.Write("\nSORTED Order  : ");
            msArray.display();
        }
    }

    class mergeSort
    {
        public int[] data;
        public mergeSort(int[] data)
        {
            this.data = data;
        }
        public int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
                Console.WriteLine("Merged Order          : " + string.Join(", ", array) + "\n");
            }
            return array;
        }

        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j, p = 1;

            Console.WriteLine("Pass                  : " + (p++));
            Console.WriteLine("==============================================================");
            Console.WriteLine("Index Value Comparison: From " + left + " (left) to " + right + " (right)");
 
            // iterate index comparison and compares each value from each hands
            for (i = 0; i < leftArrayLength; ++i)
            {
                leftTempArray[i] = array[left + i];
                Console.WriteLine("Left Hand Value       : " + leftTempArray[i]);
            }
                
            for (j = 0; j < rightArrayLength; ++j)
            {
                rightTempArray[j] = array[middle + 1 + j];
                Console.WriteLine("Right Hand Value      : " + rightTempArray[j]);
            }       

            i = 0;
            j = 0;
            int k = left;

            // Merging Arrays
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j]) array[k++] = leftTempArray[i++];
                else array[k++] = rightTempArray[j++];
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        public void display()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
