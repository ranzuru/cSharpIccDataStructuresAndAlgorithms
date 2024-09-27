using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class selectionSortClass
    {
        public static void Main()
        {
            sortingFunction ssArray = new sortingFunction(10);

            Console.WriteLine("Order");
            Console.WriteLine("================================================");
            Console.WriteLine("Original");
            ssArray.display();

            ssArray.performSort();
        }
    }

    class sortingFunction
    {
        private int[] data;
        private static Random generator = new Random();

        public sortingFunction(int size)
        {
            data = new int[size];

            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(-99, 99);
            }
        }

        public void performSort()
        {
            Console.Write("\nSorted Array Elements :(Step by Step)\n\n");
            display();

            int smallest;

            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest]) smallest = index;
                }

                posSwap(i, smallest);
                display();
            }
        }

        public void posSwap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }

        public void display()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }
}
