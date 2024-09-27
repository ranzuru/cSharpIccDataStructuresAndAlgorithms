using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.hashing
{
    class hashFunction
    {
        public static int keyHashing(string keyInput, string[] array)
        {
            long total = 0; 
            char[] c = keyInput.ToCharArray(); // integer will be treated as string

            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {
                total += 11 * total + (int)c[i];    // polynomial hash function
            }      

            total = total % array.Length;   // hash index

            if (total < 0) total += array.Length;   // ensure index is a positive

            return (int)total;  // computed hash value
        }

        public static int stepSizeHash(string keyInput, int arraySize)
        {
            long total = 0;
            char[] c = keyInput.ToCharArray();

            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {
                total = 7 * total + (int)c[i];
            }    

            total = (total % (arraySize - 1)) + 1; // calculate step size

            if (total < 0) total += arraySize;

            return (int)total;  // computed step size
        }

        public static void doubleHashing(string key, string value, string[] array)
        {
            int primaryIndex = keyHashing(key, array); // Initial index
            int stepSize = stepSizeHash(key, array.Length); // Step size

            int newIndex = primaryIndex;
            bool collision = false;

            for (int i = 0; i < array.Length; i++)
            {
                // calculate new index for hash collision resolution
                newIndex = (primaryIndex + i * stepSize) % array.Length;

                if (array[newIndex] == null)
                {
                    array[newIndex] = value;    // calculated index
                    Console.WriteLine("\nStored");
                    Console.WriteLine("Index: " + newIndex);
                    Console.WriteLine("Value: " + value);
                    return;
                } 
   
                if (primaryIndex == newIndex)
                {
                    Console.WriteLine("\nHash Collision");
                    Console.WriteLine("Entry Index   : " + newIndex);
                    Console.WriteLine("Existing Index: " + key);
                } else Console.WriteLine("\nChecking Index: " + newIndex);
            }

            Console.WriteLine("\nArray Full/ No Suitable Index Slot");
        }
    }
}
