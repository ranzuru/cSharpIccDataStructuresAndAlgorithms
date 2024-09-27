using cSharpIccDataStructuresAndAlgorithms;
using cSharpIccDataStructuresAndAlgorithms.graph;
using cSharpIccDataStructuresAndAlgorithms.hashing;
using cSharpIccDataStructuresAndAlgorithms.heaps;
using cSharpIccDataStructuresAndAlgorithms.linked_list;
using cSharpIccDataStructuresAndAlgorithms.sorting_algorithms;
using cSharpIccDataStructuresAndAlgorithms.stack_and_queues;
using cSharpIccDataStructuresAndAlgorithms.trees;
using System.Linq.Expressions;
using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {
        //quicksort.Main();


        bool loop = false;  // off
        while (loop)
        {
            Console.WriteLine("C# DATA STRUCTURES AND ALGORITHMS");
            Console.WriteLine("==========================================================");
            Console.WriteLine("[2] Arrays");
            Console.WriteLine("[3.1] Linked List - Singly");
            Console.WriteLine("[3.2] Linked List - Doubly");
            Console.WriteLine("[3.4] Linked List - Doubly with Node");
            Console.WriteLine("[4.1] Stacks and Queues - Stacks");
            Console.WriteLine("[4.2] Stacks and Queues - Queues");
            Console.WriteLine("[5.1] Trees - Binary Search Tree");
            Console.WriteLine("[5.2] Trees - Red-Black Tree");
            Console.WriteLine("[6] Graphs");
            Console.WriteLine("[7] Hashing");
            Console.WriteLine("[8] Heaps");
            Console.WriteLine("[9.1] Sorting Algorithm - Quick Sort");
            Console.WriteLine("[9.2] Sorting Algorithm - Selection Sort");
            Console.WriteLine("[9.3] Sorting Algorithm - Bubble Sort");
            Console.WriteLine("[9.4] Sorting Algorithm - Insertion Sort");
            Console.WriteLine("[9.5] Sorting Algorithm - Merge Sort");
            Console.WriteLine("[10.1] Searching Algorithms - Binary Search");
            Console.WriteLine("[10.2] Searching Algorithms - Linear Search");
            Console.WriteLine("[11] Greedy Algorithms");
            Console.WriteLine("[12] Divide and Conquer");
            Console.WriteLine("[13] Backtracking");
            Console.WriteLine("[14] Space and Time Complexity Analysis");
            Console.WriteLine("[0] Exit");

            Console.Write("\nSelect a Lesson: ");
            double selection;

            if (double.TryParse(Console.ReadLine(), out selection))
            {
                Console.Clear();
                switch (selection)
                {
                    case 2:
                        ArrayClass.Main();
                        break;
                    // LINKED LIST
                    case 3.1:
                        LinkedList1.Main();
                        break;
                    case 3.2:
                        LinkedList2.Main();
                        break;
                    case 3.3:
                        LinkedListNode.Main();
                        break;
                    // STACKS AND QUEUES
                    case 4.1:
                        StackClass.Main();
                        break;
                    case 4.2:
                        QueueClass.Main();
                        break;
                    // TREE
                    case 5.1:
                        BSTClass.Main();
                        break;
                    case 5.2:
                        RedBlackTree.Main();
                        break;

                    case 6:
                        undirectedGraph.Main();
                        break;
                    case 7:
                        doubleHashing.Main();
                        break;
                    case 8:
                        heapClass.Main();
                        break;
                    case 0:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid lesson selected. Choose among the given selections.");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid input. Use numeric character indicated on each selections.\n");
            }

            if (selection != 0)
            {
                Console.WriteLine("\n\nPress Enter to return to the menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}