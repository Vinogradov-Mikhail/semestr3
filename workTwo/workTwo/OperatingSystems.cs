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
        public string NameOfOs { get; set; }

        public int InfectionProbability { get; set; }
    }
}
