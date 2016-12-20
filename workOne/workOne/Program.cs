using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.AddValue(5);
            tree.AddValue(2);
            tree.AddValue(3);
            tree.AddValue(4);
            tree.Remove(2);
            foreach (var value in tree)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(tree.SearchElement(2));
        }
    }
}
