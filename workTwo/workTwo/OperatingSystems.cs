using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// abstract class for OS
    /// </summary>
    public abstract class OperatingSystems
    {
        /// <summary>
        /// name of os
        /// </summary>
        public string NameOfOs { get; set; }

        /// <summary>
        /// probability of infection
        /// </summary>
        public int InfectionProbability { get; set; }
    }
}
