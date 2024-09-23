using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class LinkedList
    {
        public static void Main()
        {
            Node nodeA = new Node(6);
            Node nodeB = new Node(3);
            Node nodeC = new Node(4);
            Node nodeD = new Node(2);
            Node nodeE = new Node(1);
            
            nodeA.next = nodeB;
            Console.WriteLine("Node: " + nodeA.data);       // output: 6
            Console.WriteLine("Node: " + nodeA.next.data);  // output: 3
            Console.WriteLine("Node: " + nodeA.head.data);  // output: 3
        }

        public static int CountNodes(Node head)
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
