using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.linked_list
{
    class LinkedList1
    {
        public static void Main()
        {
            // singly linked list
            // should add/ remove nodes manually (making method)
            Node nodeA = new Node(6);
            Node nodeB = new Node(3);
            Node nodeC = new Node(4);
            Node nodeD = new Node(2);
            Node nodeE = new Node(1);

            // node a (head), depends which node will be set first
            // .next sets as which is the next node
            nodeA.next = nodeB;                             
            Console.WriteLine("Node                         : " + nodeA.data);      // output: 6
            Console.WriteLine("Node Next                    : " + nodeA.next.data); // output: 3
            // from node a to b
            int nodeCount = CountNodes(nodeA);
            Console.WriteLine("Node Count (start at a)      : " + nodeCount);       // output: 2
            nodeB.next = nodeC;
            nodeC.next = nodeD;
            // set the linked list into single (nodes from a to e)
            nodeD.next = nodeE;                                                     // next of node E is null
            // from node a to e
            nodeCount = CountNodes(nodeA);
            Console.WriteLine("Node Count (start at a)      : " + nodeCount);       // output: 5
            // .prev sets as which is the previous node
            // if it is set to node e to a, it would result to a doubly linked list
            nodeD.prev = nodeC;
            Console.WriteLine("Node Previous (start at d)   : " + nodeD.prev.data); // output: 4
        }

        public static int CountNodes(Node head)
        {
            int count = 1;
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
                count += 1;
            }
            return count;
        }
    }

    class Node
    {
        public int data;
        public Node next; // for next node
        public Node prev; // for previous node
        public Node(int data)
        {
            this.data = data;
        }
    }
}
