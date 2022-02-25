using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Core.Shapes.Lines
{
    public abstract class Line: Shape
    {
        protected Line(Point start, int length) => points = new Point[length];
    }
}
