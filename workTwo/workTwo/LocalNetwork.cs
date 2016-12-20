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
        private List<Computer> listOfAllComputersInNet;
        private Random rand = new Random();
        private bool[,] matrixOfLink;

        public LocalNetwork(List<Computer> newNetOfComp, bool[,] mat)
        {
            this.listOfAllComputersInNet = newNetOfComp;
            this.matrixOfLink = mat;
        }

        /// <summary>
        /// each step infected some computers
        /// </summary>
        public void StepOfVirusInfection()
        {
            List<Computer> listOfComputersInfectedInThisStep = new List<Computer>();
            for( int i = 0; i < listOfAllComputersInNet.Count; ++i)
            {
                if(listOfAllComputersInNet[i].Infected)
                {
                    for ( int j = 0; j < listOfAllComputersInNet.Count; ++j)
                    {
                        if(matrixOfLink[i,j] && !listOfAllComputersInNet[j].Infected 
                            && !listOfComputersInfectedInThisStep.Contains(listOfAllComputersInNet[j]))
                        {
                            if(rand.Next(1, 100) <= listOfAllComputersInNet[j].GetProbability())
                            {
                                listOfAllComputersInNet[j].Infected = true;
                                listOfComputersInfectedInThisStep.Add(listOfAllComputersInNet[j]);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// print on console network status
        /// </summary>
        public void PrintStatusInStep()
        {
            foreach (var comp in listOfAllComputersInNet)
            {
                Console.WriteLine(" OS:" + comp.GetOsName() + " " + "Infection:" + comp.Infected);
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
            foreach (var comp in listOfAllComputersInNet)
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
                PrintStatusInStep();
                System.Threading.Thread.Sleep(800);
                ++i;
            }
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            Console.WriteLine("///////////////////ALL COMPUTERS INFECTED/////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////////////////");
        }
    }
}
