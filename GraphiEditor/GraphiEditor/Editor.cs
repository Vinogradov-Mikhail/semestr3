using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GraphiEditor
{
    public partial class Editor : Form
    {
        private UndoRedo unre = new UndoRedo();
        private List<Line> lines = new List<Line>();
        private bool canPaintLine = false;
        private bool isStartCoordinate = false;
        private bool manipulationFlag = false;
        private bool isReDrawLineHasEnd = false;
        private Point redrowingLineEnd;
        private Point lastClickCoordinate;
        private Point currentMousePosition;
        
        public Editor()
        {
            InitializeComponent();
            undoButton.Enabled = false;
            redoButton.Enabled = false;
        }

        private void PictureBoxPaintHandler(object sender, PaintEventArgs e)
        {
            ReDrawAll(e);
            if (canPaintLine && isStartCoordinate)
            {
                e.Graphics.DrawLine(new Pen(Color.Cyan, 2), lastClickCoordinate, currentMousePosition);
            }
            else if (manipulationFlag && isReDrawLineHasEnd)
            {
                e.Graphics.DrawLine(new Pen(Color.Cyan, 2), redrowingLineEnd, currentMousePosition);
            }
        }

        private void PictureBoxMouseMoveHandler(object sender, MouseEventArgs e)
        {
            currentMousePosition.X = e.X;
            currentMousePosition.Y = e.Y;
            if (canPaintLine && isStartCoordinate || (manipulationFlag && isReDrawLineHasEnd))
            {
                pictureBox.Invalidate();
            }
        }

        private void PictureBoxMouseClickHandler(object sender, MouseEventArgs e)
        {
            var beforeClic = lastClickCoordinate;
            lastClickCoordinate.X = e.X;
            lastClickCoordinate.Y = e.Y;
            if (canPaintLine && isStartCoordinate)
            {
                lines.Add(new Line(beforeClic, lastClickCoordinate));
                unre.AddCommand(new CommandLine(lines[lines.Count - 1], "Add"), true);
                CheckStackUnRe();
                canPaintLine = false;
                isStartCoordinate = false;
            }
            else if (!canPaintLine && !isStartCoordinate)
            {
                canPaintLine = true;
                isStartCoordinate = true;
            }
            else if(manipulationFlag && !isReDrawLineHasEnd)
            {
                ActionForLineReDrawing(lastClickCoordinate);
            }
            else if (manipulationFlag && isReDrawLineHasEnd)
            {
                manipulationFlag = false;
                isReDrawLineHasEnd = false;
                isStartCoordinate = false;
                lines.Add(new Line(redrowingLineEnd, lastClickCoordinate));
                unre.AddCommand(new CommandLine(lines[lines.Count - 1], "Add"), true);
                CheckStackUnRe();
            }
        }

        /// <summary>
        /// funcion for find near line with last click coordinate and delete this line 
        /// </summary>
        /// <param name="lastClick"></param>
        private void ActionForLineReDrawing(Point lastClick)
        {
            var temp = new Line(lastClick, lastClick);
            foreach (var line in lines)
            {
                if (line.Distance(line.Start, lastClick) < 8)
                {
                    redrowingLineEnd = line.End;
                    temp = line;
                }
                else if (line.Distance(line.End, lastClick) < 8)
                {
                    redrowingLineEnd = line.Start;
                    temp = line;
                }
            }
            
            if (!redrowingLineEnd.IsEmpty)
            {               
                unre.AddCommand(new CommandLine(temp, "Remove"), true);
                lines.Remove(temp);
                isReDrawLineHasEnd = true;
            }
        }

        /// <summary>
        /// redraw all lines
        /// </summary>
        /// <param name="e"></param>
        private void ReDrawAll(PaintEventArgs e)
        {
            foreach (var line in lines)
            {
                line.Draw(e);
            }
        }

        /// <summary>
        /// remove last Line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remove_Click(object sender, EventArgs e)
        {
            if (lines.Count != 0)
            {
                unre.AddCommand(new CommandLine(lines[lines.Count - 1], "Remove"), true);
                CheckStackUnRe();
                lines.RemoveAt(lines.Count - 1);
            }
            pictureBox.Invalidate();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            lines = new List<Line>();
            pictureBox.Invalidate();
        }

        /// <summary>
        /// change line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePosition_Click(object sender, EventArgs e)
        {
            manipulationFlag = true;
            canPaintLine = false;
            isStartCoordinate = true;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            unre.Undo(lines);
            CheckStackUnRe();
            pictureBox.Invalidate();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            unre.Redo(lines);
            CheckStackUnRe();
            pictureBox.Invalidate();
        }
        
        /// <summary>
        /// make enable or disable undo and redo button
        /// </summary>
        private void CheckStackUnRe()
        {
            undoButton.Enabled = !unre.UndoStakIsEmpty(); 
            redoButton.Enabled = !unre.RedoStakIsEmpty();
        }
    }
}
