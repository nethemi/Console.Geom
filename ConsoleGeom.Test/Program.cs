using System;

namespace ConsoleGeom.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable move = new MVLine(new Point(5, 6), 6);
            if(move is Shape shape)
            {
                shape.Draw();
                Console.ReadKey();
                move.Move(new Point(3, 4));
                shape.Draw('$');
            }
        }
    }
}
