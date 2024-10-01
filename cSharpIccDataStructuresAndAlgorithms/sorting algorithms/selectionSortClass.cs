using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class selectionSortClass
    {
        public static void Main()
        {
            Console.WriteLine("Selection Sort with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            selectionSort ssArray = new selectionSort(rng.data);

            Console.Write("\nORIGINAL Order: ");
            ssArray.display();          

            ssArray.sort();

            Console.Write("\nSORTED Order  : ");
            ssArray.display();
        }
    }

    class selectionSort
    {
        public int[] data;
        public selectionSort(int[] inputData)
        {
            this.data = inputData;
        }
        public void sort()
        {
            Console.Write("\nSorting Process\n");
            Console.WriteLine("=============================================\n");

            int smallest;

            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                Console.WriteLine("Iteration: " + (i + 1));
                Console.WriteLine("--------------------------------------------");

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest]) smallest = index;
                }

                if (smallest != i)
                {
                    Console.WriteLine($"Swapped  : " + data[i] + " and " + data[smallest] + " (refer from the order above)");
                    posSwap(i, smallest);
                }
                else Console.WriteLine("As is    : " + data[i]);

                Console.Write("Order    : ");
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
