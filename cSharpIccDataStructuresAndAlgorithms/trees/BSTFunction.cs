using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.trees
{
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
