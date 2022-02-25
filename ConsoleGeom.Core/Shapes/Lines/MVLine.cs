using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Core.Shapes.Lines
{
    public class MVLine : VLine, IMovable
    {
        public void Move(Point position)
        {
            if (position == points[0]) return;
            Clear();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = points[i] with { X = position.X, Y = position.Y + i };
            }
            

            
        }
    }
}
