using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.trees
{
    class BSTClass  // Binary Search Tree
    {
        public static void Main()
        {
            BSTFunction tree = new BSTFunction();

            /*
             * On a regular Binary Tree, nodes (including root) are set manually.
             * On BST, nodes are set depending on the value (left minimum, right maximum)
             * It will start on the root then to its referenced nodes.
             */

            tree.insert(50); // root
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);

            /*
             *         50
             *       /    \
             *     30      70
             *    /  \    /
             *   20  40  60
             */

            Console.Write("\nPre Order traversal    : ");
            tree.preOrder();    // Output: 50 30 20 40 70 60
            Console.WriteLine("\n");

            Console.Write("\nPost Order traversal   : ");
            tree.postOrder();   // Output: 20 40 30 60 70 50
            Console.WriteLine("\n");

            Console.Write("\nIn Order traversal     : ");
            tree.inorder();     // Output: 20 30 40 50 60 70
            Console.WriteLine("\n");

            // for Level Order Traversal: 50 30 70 20 40 60

            Console.Write("\nMinimum Value          : " + tree.minValue() + "\n");
            Console.Write("\nMaximum Value          : " + tree.maxValue() + "\n");
        }
    }

    class BSTNode
    {
        public int key { get; set; }
        public BSTNode left, right;
        public BSTNode(int key)
        {
            this.key = key;
            left = right = null;
        }
    }
}
