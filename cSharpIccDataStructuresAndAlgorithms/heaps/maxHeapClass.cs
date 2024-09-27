using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.heaps
{
    class maxHeapClass
    {
        // sort
        public static void maxHeapSort<heapArray>(heapArray[] array) where heapArray : IComparable<heapArray>
        {
            int heapSize = array.Length;
            buildMaxHeap(array);

            // extract element from array
            for (int i = heapSize - 1; i >= 1; i--)
            {
                heapFunctions.positionSwap(array, i, 0); // 1st last position swap
                heapSize--;
                heapifyDown(array, heapSize, 0);
            }

            Array.Reverse(array);
        }
        public static void buildMaxHeap<heapArray>(heapArray[] array) where heapArray : IComparable<heapArray>
        {
            int heapSize = array.Length;

            // heapify each elements
            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                heapifyDown(array, heapSize, i);
            }
        }

        // making root (last index) as the highest
        public static void heapifyDown<heapArray>(heapArray[] array, int heapSize, int heapifyDownPos) where heapArray : IComparable<heapArray>
        {
            int largestKidPos;
            int leftPos = heapFunctions.leftChildPos(heapifyDownPos);
            int rightPos = heapFunctions.rightChildPos(heapifyDownPos);

            // Determine the largest child
            if (leftPos < heapSize)
            {
                largestKidPos = leftPos;
                if (rightPos < heapSize && array[rightPos].CompareTo(array[leftPos]) > 0) largestKidPos = rightPos;

                // heapify down recursively
                if (array[largestKidPos].CompareTo(array[heapifyDownPos]) > 0)
                {
                    heapFunctions.positionSwap(array, heapifyDownPos, largestKidPos);
                    heapifyDown(array, heapSize, largestKidPos);
                }
            }
        }
        public static heapArray extractMax<heapArray>(heapArray[] array) where heapArray : IComparable<heapArray>
        {
            if (array.Length == 0) throw new InvalidOperationException("Heap is empty.");

            // root - max
            heapArray maxValue = array[0];

            array[0] = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            heapifyDown(array, array.Length, 0);

            return maxValue;
        }
    }
}
