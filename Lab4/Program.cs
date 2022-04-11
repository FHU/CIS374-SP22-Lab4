using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph1 = new UndirectedGraph("../../../graphs/graph5.txt");


            //Console.WriteLine(graph1);
            Console.WriteLine("Test 1: ConnectedComponents");
            Console.WriteLine(graph1.ConnectedComponents);
            Console.WriteLine();

            Console.WriteLine("Test 2: DFS");
            Dictionary<Node, Node> nodeDictionary = graph1.DFS(graph1.Nodes[0]);
            foreach (var nodes in nodeDictionary)
            {
                Console.Write(nodes.Key.Name);
                Console.Write(" is connected to ");
                Console.WriteLine(nodes.Value.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Test 3: DFS");
            var NodeDictionary2 = graph1.BFS(graph1.Nodes[0]);
            foreach (var nodes in NodeDictionary2)
            {
                Console.Write(nodes.Key.Name);
                if (nodes.Value.pred != null)
                {
                Console.Write(" is connected to ");
                Console.Write(nodes.Value.pred.Name);
                Console.Write(" and is ");
                Console.Write(nodes.Value.dist);
                Console.WriteLine(" spaces from the starting node");
                }
                else
                {
                Console.WriteLine(" has no predecessor");
                }
            }
            //Console.WriteLine(graph1.IsReachable("madison", "lauren"));

            //Console.WriteLine(graph1.DFS(graph1.Nodes[2]));


        }
    }
}

