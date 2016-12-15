using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workThree
{
    public class Graph
    {
        private int numberOfVertices;
        private bool[,] graph;

        public Graph(bool[,] adjacencyMatrix, int countVertex)
        {
            this.graph = adjacencyMatrix;
            this.numberOfVertices = countVertex;           
        }

        /// <summary>
        /// check is vertex way
        /// </summary>
        public bool HasWay(int i, int j)
        {
            return graph[i, j];
        }

        /// <summary>
        /// return count of vertex
        /// </summary>
        public int ReturnSize()
        {
            return numberOfVertices;
        }
    }
}
