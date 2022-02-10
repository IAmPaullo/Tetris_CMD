using System;

namespace Tetris_CMD
{
    public class Primitives
    {
        ConsoleColor color;

        public Primitives(ConsoleColor color)
        {
            this.color = color;
        }

        public void DrawPrimitive(int x, int y)
        {
            if (y >= Console.WindowHeight || y < 0) return;

            if (x >= Console.WindowWidth || x < 0) return;

            Console.ForegroundColor = color;
            Console.Write('ඞ');

        }

    }
}