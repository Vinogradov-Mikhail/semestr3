using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.AddValue(5);
            Console.WriteLine(tree.head.Value);
            tree.AddValue(2);

            tree.AddValue(3);
            Console.WriteLine(tree.head.Value);
            tree.AddValue(4);
            Console.WriteLine(tree.head.Value + "-----");
            foreach (var value in tree)
            {
                Console.WriteLine(value);
            }
        }
    }
}
