using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] mat = new bool[,] { { false, true, true, false }, { true, false, false, true }, { true, false, false, true }, { false, true, true, false } };
            var comp = new List<Computer>
            {
                new Computer(new Windows(), false),
                new Computer(new Linux(), false),
                new Computer(new MacOS(), true),
                new Computer(new MacOS(), true)
            };
            //var net = new LocalNetwork(comp, mat);
            var net = new LocalNetwork(comp, mat);
            net.VirusInfection();
        }

    }
}
