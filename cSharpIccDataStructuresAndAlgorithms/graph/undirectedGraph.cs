using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.graph
{
    class undirectedGraph
    {
        public static void Main()
        {
            int vrt, edg;
            Console.WriteLine("Un-Directed (Zero Based Indexing) Graph using Matrix Adjacency");
            Console.Write("\nVertices (including 0): ");
            int.TryParse(Console.ReadLine(), out vrt);
            Console.WriteLine("\nNote: Valid indices are from 0 to " + (vrt - 1));
            Console.Write("\nEdge/s: ");
            int.TryParse(Console.ReadLine(), out edg);

            // graph structure (Adjacent Matrix using array)
            // for Adjacent List (use List<List>)
            int[,] edges = new int[vrt, vrt];
            bool[] visited = new bool[vrt];

            Console.WriteLine("\nEdge Positioning (0-1, start from 0)");
            int edgeCount = 0;

            while (edgeCount < edg)
            {
                Console.Write($"Enter edge {edgeCount + 1}: ");
                string[] input = Console.ReadLine().Split('-');

                // src - source, dst - destination
                if (input.Length == 2 && int.TryParse(input[0], out int src) && int.TryParse(input[1], out int dst))
                {
                    if (src < 0 || src >= vrt || dst < 0 || dst >= vrt)
                    {
                        Console.WriteLine("Out of Range: " + src + "-" + dst + ". Valid range is 0 to " + (vrt -1) + ".");
                        continue;
                    }

                    // valid undirected edge
                    edges[src, dst] = 1;
                    edges[dst, src] = 1;
                    edgeCount++;
                }
                else Console.WriteLine("Invalid input format. Please use the format 'x-y'.");
            }

            Console.Write("\nDepth First Search (DFS)     : ");
            for (int i = 0; i < vrt; i++)
            {
                if (!visited[i]) undirectedGraphFunction.DFS(edges, vrt, visited, i);
            }

            for (int i = 0; i < vrt; i++)
            {
                visited[i] = false; // visit reset for BFS
            }

            Console.Write("\n\nBreadth First Search (BFS)   : ");
            for (int i = 0; i < vrt; i++)
            {
                if (!visited[i]) undirectedGraphFunction.BFS(edges, vrt, visited, i);
            }

            undirectedGraphFunction.PrintMatrix(edges, vrt);
        }
    }
}
