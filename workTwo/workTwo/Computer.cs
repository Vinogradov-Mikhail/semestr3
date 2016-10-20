using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// class for comuter
    /// </summary>
    public class Computer
    {
        public string os;

        public bool Infected { get; set; }

        /// <summary>
        /// list of comuters which link with this computer
        /// </summary>
        public List<int> LinkComputers { get; set; }

        public Computer(string thisOs, bool poison, List<int> thisLinkComputers)
        {
            os = thisOs;
            LinkComputers = thisLinkComputers;
            Infected = poison;
        }
    }
}
