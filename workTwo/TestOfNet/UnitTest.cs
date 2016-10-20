using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Network.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestOfIncetionNet()
        {
            Computer comp1 = new Computer("Windows", false, new List<int> { 1, 2, 3 });
            Computer comp2 = new Computer("Windows", false, new List<int> { 0, 3 });
            Computer comp3 = new Computer("Windows", false, new List<int> { 1, 2 });
            Computer comp4 = new Computer("Windows", false, new List<int> { 1, 3 });
            List<Computer> computers = new List<Computer>();
            computers.Add(comp1);
            computers.Add(comp2);
            computers.Add(comp3);
            computers.Add(comp4);
            LocalNetwork net = new LocalNetwork(computers);
            net.VirusInfection();
        }
    }
}
