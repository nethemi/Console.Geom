using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Core.Shapes.Lines
{
    public class VLine : Line
    { 
        public VLine(Point start, int length) : base(start, length)
        {
            for (int i = 0; i < length; i++)
            {
                points[i] = new Point(start.X, start.Y + i);
            }
        }
    }
}
