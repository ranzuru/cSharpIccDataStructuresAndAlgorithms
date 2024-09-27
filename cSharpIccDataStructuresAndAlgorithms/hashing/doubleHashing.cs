using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.hashing
{
    class doubleHashing
    {
        public static void Main()
        {
            Hashtable hashTbl = new Hashtable();

            Console.WriteLine("Double Hashing with Key Converter (ASCII)");

            Console.Write("\nIndex/es: ");
            int indexStorage = Convert.ToInt32(Console.ReadLine());
            string[] hashArray = new string[indexStorage];

            Console.WriteLine("\nNote: String of characters is preferred on the key input. ");
            for (indexStorage = 0; indexStorage < hashArray.Length; indexStorage++)
            {
                Console.WriteLine("\n==============================================");
                Console.WriteLine("Entry " + (indexStorage + 1));
                Console.Write("Key  : ");
                string key = Console.ReadLine();
                Console.Write("Value: ");
                string value = Console.ReadLine();
                hashFunction.doubleHashing(key, value, hashArray);
            }

            Console.WriteLine("\nStored Data:");
            for (int i = 0; i < hashArray.Length; i++)
            {
                if (hashArray[i] != null) Console.WriteLine("Index {0}: {1}", i, hashArray[i]);
            }
        }
    }
}
