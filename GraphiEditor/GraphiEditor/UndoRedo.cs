﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphiEditor
{
    /// <summary>
    /// class for undo and redo action
    /// </summary>
    public class UndoRedo
    {

        public Stack<Command> undo = new Stack<Command>();
        private Stack<Command> redo = new Stack<Command>();


        /// <summary>
        /// Add in history of command
        /// </summary>
        public void AddCommand(Command command, bool isCommandOver)
        {
            undo.Push(command);

            if (isCommandOver)
            {
                undo.Push(null);
            }

            if (redo.Count != 0)
            {
                redo = new Stack<Command>();
            }
        }

        /// <summary>
        /// Cancel last operation
        /// </summary>
        public void Undo(List<Line> lines)
        {
            if (undo.Count > 0)
            {
                undo.Pop();

                while (undo.Count > 0 && undo.Peek() != null)
                {
                    redo.Push(undo.Pop());
                    redo.Peek().UnExecute(lines);
                }

                redo.Push(null);
            }
        }

        /// <summary>
        /// do last operation which was cancel
        /// </summary>
        public void Redo(List<Line> lines)
        {
            if (redo.Count > 0)
            {
                redo.Pop();

                while (redo.Count > 0 && redo.Peek() != null)
                {
                    undo.Push(redo.Pop());
                    undo.Peek().Execute(lines);
                }

                undo.Push(null);
            }
        }
    }
}
