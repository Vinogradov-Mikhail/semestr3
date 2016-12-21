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
        private OperatingSystems os;

        /// <summary>
        /// is computer infected
        /// </summary>
        public bool Infected { get; set; }

        /// <summary>
        /// get os probability
        /// </summary>
        /// <returns></returns>
        public int GetProbability()
        {
            return os.InfectionProbability;
        }

        /// <summary>
        /// get os name
        /// </summary>
        /// <returns></returns>
        public string GetOsName()
        {
            return os.NameOfOs;
        }

        public int GetProbability() => os.InfectionProbability;
    }
}
