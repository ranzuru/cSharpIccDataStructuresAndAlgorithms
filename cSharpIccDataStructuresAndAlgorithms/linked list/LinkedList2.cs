using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.linked_list
{
    class LinkedList2
    {
        public static void Main()
        {
            string[] ships = { "Nakhimov" };
            LinkedList<string> list = new LinkedList<string>(ships); // doubly linked list, can traverse at any direction
            list.AddFirst("Sovetsky");  // list: Sovetsky, Nakhimov
            list.AddLast("Soyuz");      // list: Sovetsky, Nakhimov, Soyuz
            list.AddFirst("Kremlin");   // list: Kremlin, Sovetsky, Nakhimov, Soyuz
            Console.WriteLine("Ship List");
            foreach (var ship in list)
            {
                Console.WriteLine(ship);
            }
            Console.WriteLine("Found Ship: " + list.Find("Soyuz").Value); // output: Found Ship: Soyuz, if not, it fails because of null
            // can remove at any nodes since its a doubly linked list
            list.Remove("Sovetsky");       // list: Kremlin, Nakhimov, Soyuz
            Console.WriteLine("Removed: Sovetsky");
            Console.WriteLine("Ship List");
            foreach (var ship in list)
            {
                Console.WriteLine(ship);
            }
            list.Clear();               // list empty
            Console.WriteLine("List Cleared");
            Console.WriteLine("Ship List");
            foreach (var ship in list)
            {
                Console.WriteLine(ship);
            }
        }
    }
}
