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
            bool[,] mat = new bool[3,3] { { false, true, true }, { true, false, false }, { true, false, false } };
            var comp = new List<Computer>
            {
                new Computer(new Windows(), false),
                new Computer(new Linux(), false),
                new Computer(new MacOS(), true)
            };
            var net = new LocalNetwork(comp, mat);
            net.VirusInfection();
        }

    }
}
