using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class quickSortClass
    {
        public static void Main()
        {
            Console.WriteLine("Quick Sort with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            quickSort qsArray = new quickSort(rng.data);

            Console.Write("\nORIGINAL Order: ");
            qsArray.display();
            Console.WriteLine();

            qsArray.sort(0, qsArray.data.Length - 1);

            Console.WriteLine();
            Console.Write("\nSORTED Order  : ");
            qsArray.display();

            Console.WriteLine();
        }
    }

    class quickSort
    {
        public int[] data;
        public quickSort(int[] data)
        {
            this.data = data;
        }

        public void sort(int left, int right)
        {
            if (left < right)   // subarray has 1 or more element
            {
                // partitioned array (smallest (left) to biggest (right))
                int pivot = partitioning(data, left, right);
                Console.WriteLine("Partitioned Order: " + string.Join(", ", data));

                // recursive sort on both sides
                if (pivot > 1) sort(left, pivot - 1);

                if (pivot + 1 < right) sort(pivot + 1, right);
            }
        }

        private static int partitioning(int[] arr, int left, int right)
        {
            int pivot = arr[left]; // left most
            Console.WriteLine("\nPivot            : " + pivot);
            Console.WriteLine("============================================");

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

                Console.WriteLine("Left Hand Value  : " + arr[left]);
                Console.WriteLine("Right Hand Value : " + arr[right]);
                // left and right swap
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    Console.WriteLine("Hands            : Swap\n");
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    Console.WriteLine("Hands            : No Swap\n");
                    return right;
                }
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
