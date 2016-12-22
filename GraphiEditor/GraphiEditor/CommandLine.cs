using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphiEditor
{
    /// <summary>
    /// concrete command for line
    /// </summary>
    public class CommandLine : Command
    {
        private string name;
        private Line line;

        public CommandLine(Line line, string nameOfCommand)
        {
            this.line = line;
            this.name = nameOfCommand;
        }

        public override void UnExecute(List<Line> lines)
        {
            if (name != "Add")
            {
                lines.Add(line);
            }
            else
            {
                lines.Remove(line);
            }
        }

        public override void Execute(List<Line> lines)
        {
            if (name == "Add")
            {
                lines.Add(line);
            }
            else
            {
                lines.Remove(line);
            }
        }
    }
}
