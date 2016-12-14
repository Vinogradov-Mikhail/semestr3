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
        /// <summary>
        /// OperatingSystem of this PC
        /// </summary>
        public OperatingSystems os;

        public bool Infected { get; set; }

        public Computer(OperatingSystems thisOs, bool poison)
        {
            os = thisOs;
            Infected = poison;
        }
    }
}
