using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// class for MacOS
    /// </summary>
    public class MacOS: OperatingSystems
    {
        public MacOS(int probability = 10)
        {
            InfectionProbability = 10;
            NameOfOs = "MacOs";
        }
    }
}
