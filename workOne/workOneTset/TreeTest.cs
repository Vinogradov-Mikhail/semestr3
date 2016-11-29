using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkOne.Test
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void ForeachTestInInt()
        {
            var tree = new Tree<int>();
            tree.AddValue(1);
            tree.AddValue(2);
            tree.AddValue(3);
            tree.AddValue(4);
            int i = 4;
            int count = 0;
            foreach (var value in tree)
            {
                if (value == i)
                {
                    ++count;
                }
                --i;
            }
           Assert.AreEqual(4, count);
        }
    }
}
