using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// class for windows os
    /// </summary>
    public class Windows : OperatingSystems
    {
        public Windows(int probability = 80)
        {
            InfectionProbability = probability;
            NameOfOs = "Windows";
        }
    }
}
