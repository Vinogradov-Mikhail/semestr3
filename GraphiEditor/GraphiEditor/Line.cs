using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphiEditor
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        /// <summary>
        /// Constructs a line by 2 given points
        /// </summary>
        /// <param name="beginning"></param>
        /// <param name="end"></param>
        public Line(Point beginning, Point end)
        {
            this.Start = beginning;
            this.End = end;
        }

        /// <summary>
        /// Draw line on picture box
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Cyan, 2), Start, End);
        }

        /// <summary>
        /// get distatnce between two coordinates
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Distance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X)* (first.X - second.X) + (first.Y - second.Y)*(first.Y - second.Y));
        }
    }
}
