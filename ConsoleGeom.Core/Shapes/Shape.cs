using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Core.Shapes
{
    public abstract class Shape
    {
        public Point[] points { get; init; } = null!;
        public void Draw(char dot = '*')
        {
            for(int i = 0; i < points.Length; i++)
            {
                points[i].Draw(dot);
            }
        }

        public void Clear() => Draw(' ');
    }
}
