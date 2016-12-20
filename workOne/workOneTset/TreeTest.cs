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

        [TestMethod]
        public void RemoveAndSearchTestTest()
        {
            var tree = new Tree<int>();
            tree.AddValue(1);
            tree.AddValue(5);
            tree.AddValue(3);
            tree.AddValue(4);
            Assert.IsTrue(tree.SearchElement(5));
            tree.Remove(5);
            Assert.IsFalse(tree.SearchElement(5));

            tree = new Tree<int>();
            tree.AddValue(1);
            tree.AddValue(5);
            tree.AddValue(3);
            tree.AddValue(4);
            tree.Remove(1);
            Assert.IsFalse(tree.SearchElement(1));

            tree = new Tree<int>();
            tree.AddValue(1);
            tree.AddValue(5);
            tree.AddValue(3);
            tree.AddValue(4);
            tree.Remove(3);
            Assert.IsFalse(tree.SearchElement(3));

            tree = new Tree<int>();
            tree.AddValue(1);
            tree.AddValue(5);
            tree.AddValue(3);
            tree.AddValue(4);
            tree.Remove(4);
            Assert.IsFalse(tree.SearchElement(4));
        }
    }
}
