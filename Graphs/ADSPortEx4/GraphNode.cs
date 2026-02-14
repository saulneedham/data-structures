using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{

    class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;
        private LinkedList<int> weightsList;
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
            weightsList = new LinkedList<int>();
        }

        public T ID
        {
            get { return id; }
            set { id = value; }
        }

        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.id);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }

        public void AddEdgeWithWeight(GraphNode<T> to, int weight)
        {
            adjList.AddLast(to.id);
            weightsList.AddLast(weight);
        }

        public LinkedList<int> GetWeightsList()
        {
            return weightsList;
        }


    }
}
