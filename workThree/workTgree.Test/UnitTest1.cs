using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace workThree.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Graph graph;
        private bool[,] vertexMatrix;
        private bool[] roborsPosition;
        private Robots robots;

        [TestMethod]
        public void TestOfWorkForGraphOfThree()
        {
            vertexMatrix = new bool[,] { { true, true, false }, { true, true, true }, { false, true, true } };
            roborsPosition = new bool[] { true, false, true };
            graph = new Graph(vertexMatrix, roborsPosition.Length);
            robots = new Robots(graph, roborsPosition);
            Assert.IsTrue(robots.RobotsWarWithKillingAll());
        }

        [TestMethod]
        public void TestOfWorkForGraphOfFour()
        {
            vertexMatrix = new bool[,] { { true, true, true, false }, { true, true, false, true }, 
                { true, false, true, true }, { false, true, true, true } };
            roborsPosition = new bool[] { true, false, false, true };
            graph = new Graph(vertexMatrix, roborsPosition.Length);
            robots = new Robots(graph, roborsPosition);
            Assert.IsTrue(robots.RobotsWarWithKillingAll());
            roborsPosition[0] = false;
            Assert.IsFalse(robots.RobotsWarWithKillingAll());
        }

        [TestMethod]
        public void TestOfWorkForGraphOfFive()
        {
            vertexMatrix = new bool[,] { { true, false, true, false, false }, { false, true, false, true, true },
                { true, false, true, true, false }, { false, true, true, true, false }, 
                { false, true, false, false, true } };
            roborsPosition = new bool[] { true, true, true, true, true };
            graph = new Graph(vertexMatrix, roborsPosition.Length);
            robots = new Robots(graph, roborsPosition);
            Assert.IsTrue(robots.RobotsWarWithKillingAll());
            roborsPosition[1] = false;
            Assert.IsFalse(robots.RobotsWarWithKillingAll());
        }
    }
}
