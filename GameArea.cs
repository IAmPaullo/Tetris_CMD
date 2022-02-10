using System;

namespace Tetris_CMD
{
    public class GameArea
    {
        ConsoleColor color;

        public GameArea(ConsoleColor color)
        {
            this.color = color;
        }

        public void DrawGameArea(int x, int y)
        {
            if (y >= Console.WindowHeight || y < 0) return;

            if (x >= Console.WindowWidth || x < 0) return;

            Console.ForegroundColor = color;
            Console.Write('ඞ');

        }

    }
}