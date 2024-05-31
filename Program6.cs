using System;
using System.Collections.Generic;

namespace MyCSharpProject
{
    // Definition for graph node
    public class GraphNode
    {
        public int Val;
        public List<GraphNode> Neighbors;

        public GraphNode(int val = 0)
        {
            Val = val;
            Neighbors = new List<GraphNode>();
        }
    }

    class Program6
    {
        // Function to perform depth-first search (DFS) on a graph
        public static void DFS(GraphNode start, HashSet<GraphNode> visited)
        {
            if (start == null || visited.Contains(start))
                return;

            Console.Write(start.Val + " ");
            visited.Add(start);

            foreach (var neighbor in start.Neighbors)
            {
                DFS(neighbor, visited);
            }
        }

        // Function to perform breadth-first search (BFS) on a graph
        public static void BFS(GraphNode start)
        {
            if (start == null)
                return;

            Queue<GraphNode> queue = new Queue<GraphNode>();
            HashSet<GraphNode> visited = new HashSet<GraphNode>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                GraphNode current = queue.Dequeue();
                Console.Write(current.Val + " ");

                foreach (var neighbor in current.Neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating a sample graph
            GraphNode node1 = new GraphNode(1);
            GraphNode node2 = new GraphNode(2);
            GraphNode node3 = new GraphNode(3);
            GraphNode node4 = new GraphNode(4);
            GraphNode node5 = new GraphNode(5);

            node1.Neighbors.Add(node2);
            node1.Neighbors.Add(node3);
            node2.Neighbors.Add(node4);
            node3.Neighbors.Add(node4);
            node4.Neighbors.Add(node5);

            // Performing DFS on the graph
            HashSet<GraphNode> visitedDFS = new HashSet<GraphNode>();
            Console.WriteLine("Depth-First Search (DFS):");
            DFS(node1, visitedDFS);
            Console.WriteLine();

            // Performing BFS on the graph
            Console.WriteLine("Breadth-First Search (BFS):");
            BFS(node1);
            Console.WriteLine();
        }
    }
}
