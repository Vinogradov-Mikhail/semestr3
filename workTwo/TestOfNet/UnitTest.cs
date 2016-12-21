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
            mat = new bool[,] { { false, true, true }, { true, false, false }, { true, false, false } };
            comp = new List<Computer>
            {
                new Computer(new Windows(), false),
                new Computer(new Linux(), false),
                new Computer(new MacOS(), true)
            };
            var net = new LocalNetwork(comp, mat);
            net.VirusInfection();
            Assert.IsTrue(net.Check());
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

        [TestMethod]
        public void StepOfVirusTest()
        {
            mat = new bool[,] { { false, true, false }, { true, false, true }, { true, true, false } };
            comp = new List<Computer>
            {
                new Computer(new Windows(), true),
                new Computer(new Linux(), false),
                new Computer(new MacOS(), false)
            };
            var net = new LocalNetwork(comp, mat);
            net.StepOfVirusInfection();
            Assert.IsFalse(net.Check());
        }

        [TestMethod]
        public void NetworkTest()
        {
            mat = new bool[,] { { false, true, true, false}, { true, false, false, true}, { true, false, false, true }, { false, true, true, false } };
            comp = new List<Computer>
            {
                new Computer(new Windows(), false),
                new Computer(new Linux(), false),
                new Computer(new MacOS(), true),
                new Computer(new MacOS(), true)
            };
            var net = new LocalNetwork(comp, mat);
            net.VirusInfection();
            Assert.IsTrue(net.Check());
        }
    }
}
