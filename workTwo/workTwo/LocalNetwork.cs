using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// class foe local network
    /// </summary>
    public class LocalNetwork
    {
        private List<Computer> net;

        public LocalNetwork(List<Computer> newNet)
        {
            net = newNet;
        }

        /// <summary>
        /// each step infected some computers
        /// </summary>
        public void StepOfVirusInfection()
        {
            foreach (var comp in net)
            {
                foreach (var neib in comp.LinkComputers)
                {
                    Random rnd = new Random();
                    if (rnd.Next(10, 100) > 80)  
                        net[neib].Infected = true;
                }

            }
        }

        /// <summary>
        /// print on console network status
        /// </summary>
        public void Print()
        {
            foreach (var comp in net)
            {
                Console.WriteLine(" OS:" + comp.os + " " + "Infection:" + comp.Infected);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// checking all comtures are infected
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            int i = 0;
            foreach (var comp in net)
            {
                if (!comp.Infected)
                {
                    ++i;
                }
            }
            return i == 0;
        }

        /// <summary>
        /// start virus infection
        /// </summary>
        public void VirusInfection()
        {
            int i = 1;
            while (!Check())
            {

                StepOfVirusInfection();
                Console.WriteLine("Step " + i);
                Print();
                ++i;
            }
        }
    }
}
