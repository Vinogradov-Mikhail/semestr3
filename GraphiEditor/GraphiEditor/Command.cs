using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphiEditor
{
    /// <summary>
    /// intreface for start and cancel command
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// start command
        /// </summary>
        public abstract void Execute(List<Line> shapes);

        /// <summary>
        /// cancel command
        /// </summary>
        public abstract void UnExecute(List<Line> shapes);
    }
}
