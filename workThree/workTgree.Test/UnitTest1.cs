using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace workThree.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOfWorkForGraphOfThree()
        {
            bool[,] vertexMatrix = new bool[,] { { true, true, false }, { true, true, true }, { false, true, true } };
            bool[] roborsPosition = new bool[] { true, false, true };
            Graph graph = new Graph(vertexMatrix, roborsPosition.Length);
            Robots robots = new Robots(graph, roborsPosition);
            Assert.IsTrue(robots.RobotsWarWithKillingAll());
        }

        [TestMethod]
        public void TestOfWorkForGraphOfFour()
        {
            bool[,] vertexMatrix = new bool[,] { { true, true, true, false }, { true, true, false, true }, 
                { true, false, true, true }, { false, true, true, true } };
            roborsPosition = new bool[] { true, false, false, true };
            Graph graph = new Graph(vertexMatrix, roborsPosition.Length);
            Robots robots = new Robots(graph, roborsPosition);
            Assert.IsTrue(robots.RobotsWarWithKillingAll());
            roborsPosition[0] = false;
            Assert.IsFalse(robots.RobotsWarWithKillingAll());
        }

        [TestMethod]
        public void TestOfWorkForGraphOfFive()
        {
            bool[,] vertexMatrix = new bool[,] { { true, false, true, false, false }, { false, true, false, true, true },
                { true, false, true, true, false }, { false, true, true, true, false }, 
                { false, true, false, false, true } };
            bool[] roborsPosition = new bool[] { true, true, true, true, true };
            Graph graph = new Graph(vertexMatrix, roborsPosition.Length);
            Robots robots = new Robots(graph, roborsPosition);
            Assert.IsTrue(robots.RobotsWarWithKillingAll());
            roborsPosition[1] = false;
            Assert.IsFalse(robots.RobotsWarWithKillingAll());
        }
    }
}
