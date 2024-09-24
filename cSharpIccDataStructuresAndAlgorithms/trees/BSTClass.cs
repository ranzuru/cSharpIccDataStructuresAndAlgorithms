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

    class BSTFunction
    {
        BSTNode root;

        public BSTFunction()
        {
            root = null;
        }

        public void insert(int key) 
        { 
            root = insertRec(root, key); 
        }
        BSTNode insertRec(BSTNode root, int key)
        {
            if (root == null)
            {
                root = new BSTNode(key);
                return root;
            }
            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);
            return root;
        }

        public int minValue()
        {
            return minValueRec(root);
        }
        public int minValueRec(BSTNode root)
        {
            int minValue = root.key;
            while (root.left != null)
            {
                minValue = root.left.key;
                root = root.left;
            }
            return minValue;
        }

        public int maxValue()
        {
            return maxValueRec(root);
        }
        public int maxValueRec(BSTNode root)
        {
            int maxValue = root.key;
            while (root.right != null)
            {
                maxValue = root.right.key;
                root = root.right;
            }
            return maxValue;
        }

        public void preOrder() 
        { 
            preOrderRec(root); // Depth First Search/Traversal (start at bottom of the heirarchy)
        }   
        void preOrderRec(BSTNode root)
        {
            if (root != null)
            {
                Console.Write(root.key + " ");  // Root
                preOrderRec(root.left);         // Traverse Left Tree
                preOrderRec(root.right);        // Traverse Right Tree
            }
        }

        public void postOrder() 
        { 
            postOrderRec(root); // Depth First Search/Traversal
        } 
        void postOrderRec(BSTNode root)
        {
            if (root != null)
            {
                postOrderRec(root.left);        // Traverse Left Tree
                postOrderRec(root.right);       // Traverse Right Tree
                Console.Write(root.key + " ");  // Root
            }
        }

        public void inorder() 
        { 
            inorderRec(root); // Depth First Search/Traversal
        }     
        void inorderRec(BSTNode root)
        {
            if (root != null)
            {
                inorderRec(root.left);          // Traverse Left Tree
                Console.Write(root.key + " ");  // Root
                inorderRec(root.right);         // Traverse Right Tree
            }
        }

        /*
         * Level Order Traverse (Breadth-First Search/Traversa):
         * (start at top of the heirarchy)
         * Root
         * 1st Order (left to right)
         * 2nd Order (left to right)
         * and so on
         */
    }
}
