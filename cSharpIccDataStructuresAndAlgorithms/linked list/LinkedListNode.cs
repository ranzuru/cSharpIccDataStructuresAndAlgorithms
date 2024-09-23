using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.linked_list
{
    class LinkedListNode
    {
        public static void Main()
        {
            // represents a node in the linked list
            // each node belongs to a 1 list at a time
            LinkedListNode<Int32> node = new LinkedListNode<Int32>(11); // list node: 11
            
            // can have multiple nodes at a time
            LinkedList<int> list = new LinkedList<int>();
            
            Console.WriteLine("Current Node : " + node.Value);
            
            // adding nodes to the linked list
            list.AddFirst(node); // 11 added to the linked list, adding the node to the linked list
            list.AddLast(55); // list: 11, 55 (nodes 11 and 55)
            list.AddFirst(99);// list: 99, 11, 55 (nodes 99, 11, and 55)
            
            Console.WriteLine("Added 55 at the last and 99 at the first");
            Console.WriteLine("Previous Node: " + node.Previous.Value); // output 99
            Console.WriteLine("Current Node : " + node.Value); // output 11
            Console.WriteLine("Next Node    : " + node.Next.Value); // output 55
            
            Console.WriteLine("Number List:");
            foreach (var num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
