using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Network.Tests
{
    [TestClass]
    public class UnitTest
    {
        private bool[,] mat;
        private List<Computer> comp;
        private OperatingSystems os;

        [TestMethod]
        public void TestOfIncetionNet()
        {
            mat = new bool[3, 3] { { false, true, true }, { true, false, false }, { true, false, false } };
            comp = new List<Computer>
            {
                new Computer(new Windows(), false),
                new Computer(new Linux(), false),
                new Computer(new MacOS(), true)
            };
            var net = new LocalNetwork(comp, mat);
            net.VirusInfection();
            Assert.AreEqual(true, net.Check());
        }

        [TestMethod]
        public void OsProbabilityTest()
        {
            os = new MacOS();
            Assert.AreEqual(10, os.InfectionProbability);
            os = new Linux();
            Assert.AreEqual(40, os.InfectionProbability);
            os = new Windows();
            Assert.AreEqual(80, os.InfectionProbability);

        }
    }
}
