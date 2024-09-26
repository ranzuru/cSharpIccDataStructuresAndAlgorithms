using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms.graph
{
    class undirectedGraphFunction
    {
        public static void BFS(int[,] edges, int vrt, bool[] visited, int indexStart)
        {
            Queue<int> queue = new Queue<int>(); // facilitate BFS traversal
            queue.Enqueue(indexStart);
            visited[indexStart] = true;
            while (queue.Count != 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write(currentVertex + " ");
                // explore adjacent vertices
                for (int i = 0; i < vrt; i++)
                {
                    if (i == currentVertex) continue;
                    // check of unvisited adjacent vertices
                    if (!visited[i] && edges[currentVertex, i] == 1)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }

            }
        }

        public static void DFS(int[,] edges, int vrt, bool[] visited, int indexStart)
        {
            // pre order traversal, processing current vertex after before the recursive call/s
            visited[indexStart] = true;
            Console.Write(indexStart + " ");
            // explore adjacent vertices
            for (int i = 0; i < vrt; i++)
            {
                if (i == indexStart) continue;
                // recursive DFS call
                if (!visited[i] && edges[indexStart, i] == 1) DFS(edges, vrt, visited, i);
            }
        }

        public static void PrintMatrix(int[,] edges, int size)
        {
            Console.WriteLine("\n\nAdjacency Matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(edges[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
