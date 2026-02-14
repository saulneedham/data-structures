using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Graph<string> graph = new Graph<string>();

            while (true)
            {

                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add Loot node");
                Console.WriteLine("2. Add Edge");
                Console.WriteLine("3. Get graph node count");
                Console.WriteLine("4. Get graph edge count");
                Console.WriteLine("5. Add weighted Edge");
                Console.WriteLine("6. Get a nodes adjacencies");
                Console.WriteLine("7. Get average outbounds");
                Console.WriteLine("8. Get average edge weight");
                Console.WriteLine("9. Conduct BFS");
                Console.WriteLine("10. Conduct DFS");
                Console.WriteLine("11. Find safest route");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        graph.AddNode(Convert.ToString(graph.NumNodes()));
                        Console.WriteLine("Node "+ Convert.ToString(graph.NumNodes()-1) + " added!");

                        break;

                    case "2":
                        Console.Write("Enter from node ID: ");
                        string from = Console.ReadLine();
                        Console.Write("Enter to node ID: ");
                        string to = Console.ReadLine();

                        graph.AddEdge(from, to);
                        Console.WriteLine("Edge added between nodes " + from + " and " + to + "!");

                        break;

                    case "3":
                        Console.WriteLine(graph.NumNodes());

                        break;

                    case "4":
                        Console.WriteLine(graph.NumEdges());

                        break;

                    case "5":
                        Console.Write("Enter from node ID: ");
                        string fromW = Console.ReadLine();
                        Console.Write("Enter to node ID: ");
                        string toW = Console.ReadLine();
                        Console.Write("Enter edge weight: ");
                        int weight = Convert.ToInt32(Console.ReadLine());

                        graph.AddWeightedEdge(fromW, toW, weight);
                        Console.WriteLine("Weighted edge added between nodes " + fromW + " and " + toW + "!");

                        break;

                    case "6":
                        Console.Write("Enter node ID: ");
                        string nodeID = Console.ReadLine();

                        List<string> adjacencies = graph.GetAllAdjacencies(nodeID);

                        if (adjacencies.Count == 0)
                        {
                            Console.WriteLine("Node has no adjacencies");
                        }
                        else
                        {
                            Console.WriteLine("Adjacent nodes: ");
                            foreach (var adj in adjacencies)
                            {
                                Console.WriteLine(adj);
                            }
                        }

                        break;

                    case "7":
                        double avgOutbound = graph.AverageOutbound();
                        Console.WriteLine("Average outbound edges: " + avgOutbound);

                        break;

                    case "8":
                        double avgWeight = graph.AverageWeight();
                        Console.WriteLine("Average edge weight: " + avgWeight);

                        break;

                    case "9":

                        break;

                    case "10":

                        break;

                    case "11":

                        break;


                }

            }

        }
    }
}
