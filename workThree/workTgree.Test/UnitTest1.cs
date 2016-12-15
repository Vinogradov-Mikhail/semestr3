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
        public void Test1()
        {
            vertexMatrix = new bool[3, 3] { { true, true, false }, { true, true, true }, { false, true, true } };
            roborsPosition = new bool[3] { true, false, true };
            graph = new Graph(vertexMatrix, roborsPosition.Length);
            robots = new Robots(graph, roborsPosition);
            Assert.AreEqual(true,robots.RobotsWarWithKillingAll());
        }
    }
}
