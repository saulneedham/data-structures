using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{

    class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            foreach(GraphNode<T> current in nodes)
            {
                if(current.ID.CompareTo(id) == 0)
                {
                    return current;
                }
            }
            return null;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);
            Console.WriteLine(n1.ID);
            Console.WriteLine(n2.ID);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
        }

        public int NumNodes()
        {
            return nodes.Count;
        }

        public int NumEdges()
        {
            int count = 0;

            foreach (GraphNode<T> current in nodes)
            {
                count += current.GetAdjList().Count;
            }

            return count;
        }

        public void AddWeightedEdge(T from, T to, int weight)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);
            Console.WriteLine(n1.ID);
            Console.WriteLine(n2.ID);

            if (n1 != null && n2 != null)
            {
                n1.AddEdgeWithWeight(n2, weight);
            }
        }

        public double AverageOutbound()
        {

            int totalEdges = 0;

            foreach (GraphNode<T> node in nodes)
            {
                totalEdges += node.GetAdjList().Count;
            }

            return (double)totalEdges / NumNodes();
        }

        public double AverageWeight()
        {
            int totalEdges = 0;
            int totalWeight = 0;

            foreach (GraphNode<T> node in nodes)
            {
                totalEdges += node.GetAdjList().Count;
                foreach (int weight in node.GetWeightsList())
                {
                    totalWeight += weight;
                }
            }

            return (double)totalWeight / totalEdges;
        }

        public List<T> GetAllAdjacencies(T id)
        {
        
            GraphNode<T> node = GetNodeByID(id);

            if (node.GetAdjList().Count() == 0)
            {
                return new List<T>();
            }

            return node.GetAdjList().ToList();
        }

        public void BFS(T startID, ref List<T> visited)
        {
            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            GraphNode<T> startNode = GetNodeByID(startID);

            queue.Enqueue(startNode);
            visited.Add(startID);

            while (queue.Count > 0)
            {
                GraphNode<T> currentNode = queue.Peek();
                LinkedList<T> currentAdjacencies = currentNode.GetAdjList();

                if (currentAdjacencies.Count() != 0)
                {
                    //GraphNode<T> nextNode = currentAdjacencies;
                    queue.Enqueue(nextNode);
                    currentNode = nextNode;
                }
            }
        }

        public void DFS(T startID, ref List<T> visited)
        {
            Stack<T> stack = new Stack<T>();
            GraphNode<T> startNode = GetNodeByID(startID);

            stack.Push(startNode);
            visited.Add(startID);

            while (stack.Count > 0)
            {
                GraphNode<T> currentNode = stack.Peek();
                LinkedList<T> currentAdjacencies = currentNode.GetAdjList();

                if (currentAdjacencies.Count() != 0)
                {
                    T nextNode = currentAdjacencies.First();
                    stack.Push(nextNode);
                    currentNode = nextNode;
                }
            }
        }

        public void SafestRoute(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }


    }
}
