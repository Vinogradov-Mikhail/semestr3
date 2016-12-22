﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workThree
{
    /// <summary>
    /// class for realization robots with graph where robots can be destroed all
    /// </summary>
    public class Robots
    {
        private Graph graph;
        private int countVertex;
        private bool[] withRobots; //shows in which the vertex are robots

        public Robots(Graph graph, bool[] positionAdd)
        {
            this.graph = graph;
            this.countVertex = graph.ReturnSize();
            this.withRobots = positionAdd;
        }

        /// <summary>
        /// checking can robot be destroyed
        /// </summary>
        private bool CanDestroy(int thisRobot, bool[] robotIsDestroyed)
        {
            Stack<int> StackOfVertex = new Stack<int>();
            StackOfVertex.Push(thisRobot);
            bool[] visited = new bool[countVertex];
            visited[thisRobot] = true;
            while (StackOfVertex.Count != 0)
            {
                int thisVertex = StackOfVertex.Pop();
                if (thisVertex != thisRobot && withRobots[thisVertex])
                {
                    robotIsDestroyed[thisRobot] = true;
                    robotIsDestroyed[thisVertex] = true;
                    return true;
                }
                for (int i = 0; i < countVertex; ++i)
                {
                    for (int j = 0; j < countVertex && i != thisVertex && graph.HasWay(i, thisVertex); ++j)
                    {
                        if (graph.HasWay(i, j) && i != j && !visited[j])
                        {
                            visited[j] = true;
                            StackOfVertex.Push(j);
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// return can all robots will destroyed
        /// </summary>
        public bool RobotsWarWithKillingAll()
        {
            bool[] isRobotDestroyed = new bool[countVertex];

            for (int i = 0; i < countVertex; ++i)
            {
                if (withRobots[i])
                {
                    if (!CanDestroy(i, isRobotDestroyed))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}