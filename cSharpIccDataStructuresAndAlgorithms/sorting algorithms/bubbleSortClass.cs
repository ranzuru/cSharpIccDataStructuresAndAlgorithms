using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.sorting_algorithms
{
    class bubbleSortClass
    {
        public static void Main()
        {
            Console.WriteLine("Bubble Sort with Random Value/s");

            Console.Write("\nHow many random number/s: ");
            int indexCount = Convert.ToInt32(Console.ReadLine());

            randomNumberGenerator rng = new randomNumberGenerator(indexCount);

            bubbleSort bsArray = new bubbleSort(rng.data);

            Console.Write("\nORIGINAL Order: ");
            bsArray.display();
            Console.WriteLine("\n");

            bsArray.sort();

            Console.Write("\nSORTED Order  : ");
            bsArray.display();
        }
    }

    class bubbleSort
    {
        public int[] data;
        public bubbleSort(int[] data)
        {
            this.data = data;
        }

        public int[] sort()
        {
            var n = data.Length;
            bool swapRequired;
            for (int i = 0; i < n - 1; i++)
            {
                swapRequired = false;
                for (int j = 0; j < n - i - 1; j++)
                    if (data[j] > data[j + 1])
                    {
                        var tempVar = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tempVar;
                        swapRequired = true;
                        Console.WriteLine("Pass : " + i);
                        Console.WriteLine("==================================================================");
                        Console.WriteLine("Swap : " + data[j + 1] + " (left) and " + data[j] + " (right)");
                        Console.WriteLine("Order: " + string.Join(", ", data) + "\n");
                    }
                
                if (swapRequired == false) break;
            }
            return data;
        }

        public void display()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }
    }
}
