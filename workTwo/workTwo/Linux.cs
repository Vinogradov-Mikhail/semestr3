using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// class for linux os
    /// </summary>
    public class Linux: OperatingSystems
    {
        public Linux(int probability = 40)
        {
            InfectionProbability = probability;
            NameOfOs = "Linux";
        }
    }
}
