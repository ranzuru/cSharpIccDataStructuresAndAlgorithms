using System;
using System.Collections.Generic;

namespace cSharpIccDataStructuresAndAlgorithms.trees
{
    class RedBlackTree
    {
        public static void Main()
        {
            RBTFunction tree = new RBTFunction();
            tree.Insertion(5);
            tree.Insertion(3);
            tree.Insertion(7);
            tree.Insertion(1);
            tree.Insertion(9);
            tree.Insertion(-1);
            tree.Insertion(11);
            tree.Insertion(6);
            tree.DisplayTree();
            tree.Deletion(-1);
            tree.DisplayTree();
            tree.Deletion(9);
            tree.DisplayTree();
            tree.Deletion(5);
            tree.DisplayTree();
            Console.ReadLine();
        }
    }
    public enum ColorSelection
    {
        Red, Black
    }

    public class RBTNode
    {
        public ColorSelection color;
        public RBTNode left;
        public RBTNode right;
        public RBTNode parent;
        public int data;

        public RBTNode(int data) { this.data = data; }
        public RBTNode(ColorSelection colour) { this.color = colour; }
        public RBTNode(int data, ColorSelection colour) { this.data = data; this.color = colour; }
    }
}
