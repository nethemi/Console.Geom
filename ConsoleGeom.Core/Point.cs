using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Core
{
    public record Point(int X, int Y)
    {
        public void Draw(char dot = '*')
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(dot);
        }
    }
}
