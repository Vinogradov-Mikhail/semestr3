using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] adjacencyMatrix = new bool[3, 3] { { true, true, false }, { true, true, true }, { false, true, true } };
            bool[] isRobotHere = new bool[3] { true, true, true};
            //bool[,] adjacencyMatrix = new bool[4, 4];
            //adjacencyMatrix[0, 0] = true;
            //adjacencyMatrix[0, 1] = true;
            //adjacencyMatrix[0, 2] = true;
            //adjacencyMatrix[0, 3] = false;

            //adjacencyMatrix[1, 0] = true;
            //adjacencyMatrix[1, 1] = true;
            //adjacencyMatrix[1, 2] = false;
            //adjacencyMatrix[1, 3] = true;

            //adjacencyMatrix[2, 0] = true;
            //adjacencyMatrix[2, 1] = false;
            //adjacencyMatrix[2, 2] = true;
            //adjacencyMatrix[2, 3] = true;

            //adjacencyMatrix[3, 0] = false;
            //adjacencyMatrix[3, 1] = true;
            //adjacencyMatrix[3, 2] = true;
            //adjacencyMatrix[3, 3] = true;

            //bool[] isRobotHere = new bool[4];
            //isRobotHere[0] = true;
            //isRobotHere[1] = true;
            //isRobotHere[2] = true;
            //isRobotHere[3] = true;
            Graph graph = new Graph(adjacencyMatrix, isRobotHere.Length);
            Robots robots = new Robots(graph, isRobotHere);
            Console.WriteLine(robots.RobotsWarWithKillingAll());
        }
    }
}
