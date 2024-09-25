using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.trees
{
    class RBTFunction
    {
        private RBTNode root;

        // INSERTION AND FIX =============================================================
        public void Insertion(int item)
        {
            RBTNode newItem = new RBTNode(item);

            if (root == null)
            {
                root = newItem;
                root.color = ColorSelection.Black;
                return;
            }

            RBTNode Y = null;
            RBTNode X = root;

            while (X != null)
            {
                Y = X;
                if (newItem.data < X.data) X = X.left;
                else X = X.right;
            }

            newItem.parent = Y;
            if (Y == null) root = newItem;
            else if (newItem.data < Y.data) Y.left = newItem;
            else Y.right = newItem;

            newItem.left = null;
            newItem.right = null;
            newItem.color = ColorSelection.Red;
            InsertionFix(newItem);
        }
        private void InsertionFix(RBTNode item)
        {
            while (item != root && item.parent.color == ColorSelection.Red)
            {
                if (item.parent == item.parent.parent.left)
                {
                    RBTNode Y = item.parent.parent.right;

                    if (Y != null && Y.color == ColorSelection.Red)
                    {
                        item.parent.color = ColorSelection.Black;
                        Y.color = ColorSelection.Black;
                        item.parent.parent.color = ColorSelection.Red;
                        item = item.parent.parent;
                    }
                    else
                    {
                        if (item == item.parent.right)
                        {
                            item = item.parent;
                            LeftRotation(item);
                        }
                        item.parent.color = ColorSelection.Black;
                        item.parent.parent.color = ColorSelection.Red;
                        RightRotation(item.parent.parent);
                    }
                }
                else
                {
                    RBTNode X = null;

                    X = item.parent.parent.left;
                    if (X != null && X.color == ColorSelection.Black)
                    {
                        item.parent.color = ColorSelection.Red;
                        X.color = ColorSelection.Red;
                        item.parent.parent.color = ColorSelection.Black;
                        item = item.parent.parent;
                    }
                    else
                    {
                        if (item == item.parent.left)
                        {
                            item = item.parent;
                            RightRotation(item);
                        }
                        item.parent.color = ColorSelection.Black;
                        item.parent.parent.color = ColorSelection.Red;
                        LeftRotation(item.parent.parent);
                    }
                }
                root.color = ColorSelection.Black;
            }
        }
        // DELETION AND FIX =====================================================
        public void Deletion(int key)
        {
            RBTNode item = Find(key);
            RBTNode X = null;
            RBTNode Y = null;

            if (item == null)
            {
                Console.WriteLine("Nothing to delete!");
                return;
            }

            if (item.left == null || item.right == null) Y = item;
            else Y = TreeSuccessor(item);

            if (Y.left != null) X = Y.left;
            else X = Y.right;

            if (X != null) X.parent = Y;

            if (Y.parent == null) root = X;
            else if (Y == Y.parent.left) Y.parent.left = X;
            else Y.parent.left = X;

            if (Y != item) item.data = Y.data;

            if (Y.color == ColorSelection.Black) DeletionFix(X);
        }

        private void DeletionFix(RBTNode X)
        {
            while (X != null && X != root && X.color == ColorSelection.Black)
            {
                if (X == X.parent.left)
                {
                    RBTNode W = X.parent.right;

                    if (W.color == ColorSelection.Red)
                    {
                        W.color = ColorSelection.Black;
                        X.parent.color = ColorSelection.Red;
                        LeftRotation(X.parent);
                        W = X.parent.right;
                    }
                    if (W.left.color == ColorSelection.Black && W.right.color == ColorSelection.Black)
                    {
                        W.color = ColorSelection.Red;
                        X = X.parent;
                    }
                    else if (W.right.color == ColorSelection.Black)
                    {
                        W.left.color = ColorSelection.Black;
                        W.color = ColorSelection.Red;
                        RightRotation(W);
                        W = X.parent.right;
                    }

                    W.color = X.parent.color;
                    X.parent.color = ColorSelection.Black;
                    W.right.color = ColorSelection.Black;
                    LeftRotation(X.parent);
                    X = root;
                }
                else
                {
                    RBTNode W = X.parent.left;

                    if (W.color == ColorSelection.Red)
                    {
                        W.color = ColorSelection.Black;
                        X.parent.color = ColorSelection.Red;
                        RightRotation(X.parent);
                        W = X.parent.left;
                    }
                    if (W.right.color == ColorSelection.Black && W.left.color == ColorSelection.Black)
                    {
                        W.color = ColorSelection.Black;
                        X = X.parent;
                    }
                    else if (W.left.color == ColorSelection.Black)
                    {
                        W.right.color = ColorSelection.Black;
                        W.color = ColorSelection.Red;
                        LeftRotation(W);
                        W = X.parent.left;
                    }

                    W.color = X.parent.color;
                    X.parent.color = ColorSelection.Black;
                    W.left.color = ColorSelection.Black;
                    RightRotation(X.parent);
                    X = root;
                }
            }
            if (X != null) X.color = ColorSelection.Black;
        }
        // ROTATIONS ========================================================
        private void LeftRotation(RBTNode X)
        {
            // identifies y as x right children, x is root
            RBTNode Y = X.right;
            
            // left child of y is moved to become the right child of x
            X.right = Y.left; 
            if (Y.left != null) Y.left.parent = X;  // sets y to become x (if y has left child)

            if (Y != null) Y.parent = X.parent; // sets y parent to be the same as x

            if (X.parent == null) root = Y; // sets y as the root, if the x is the root

            // checks if x is left/ right child, updates parent's child pointer
            if (X == X.parent.left) X.parent.left = Y; 
            else X.parent.right = Y;

            Y.left = X; // making the x to be the left child of y
            if (X != null) X.parent = Y;    // set x's parent to y
        }

        private void RightRotation(RBTNode Y)
        {
            RBTNode X = Y.left;

            Y.left = X.right;
            if (X.right != null) X.right.parent = Y;

            if (X != null) X.parent = Y.parent;

            if (Y.parent == null) root = X;

            if (Y == Y.parent.right) Y.parent.right = X;

            if (Y == Y.parent.left) Y.parent.left = X;

            X.right = Y;
            if (Y != null) Y.parent = X;
        }
        // DISPLAY ==============================================================
        public void DisplayTree()
        {
            if (root == null)
            {
                Console.WriteLine("Nothing in the tree!");
                return;
            }

            if (root != null) InOrderDisplay(root);
        }
        private void InOrderDisplay(RBTNode current)
        {
            if (current != null)
            {
                InOrderDisplay(current.left);
                Console.Write("({0}) ", current.data);
                InOrderDisplay(current.right);
            }
        }

        public RBTNode Find(int key)
        {
            bool isFound = false;
            RBTNode temp = root;
            RBTNode item = null;

            while (!isFound)
            {
                if (temp == null) break;

                if (key < temp.data) temp = temp.left;

                if (key > temp.data) temp = temp.right;

                if (key == temp.data)
                {
                    isFound = true;
                    item = temp;
                }
            }
            
            if (isFound)
            {
                Console.WriteLine("{0} was found", key);
                return temp;
            }
            else
            {
                Console.WriteLine("{0} not found", key);
                return null;
            }
        }
        private RBTNode Minimum(RBTNode X)
        {
            while (X.left.left != null) X = X.left;
            if (X.left.right != null) X = X.left.right;
            return X;
        }
        private RBTNode TreeSuccessor(RBTNode X)
        {
            if (X.left != null) return Minimum(X);
            else
            {
                RBTNode Y = X.parent;
                while (Y != null && X == Y.right)
                {
                    X = Y;
                    Y = Y.parent;
                }
                return Y;
            }
        }
    }
}
