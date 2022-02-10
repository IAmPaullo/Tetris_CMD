using System;
using System.Text;

namespace Tetris_CMD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Game game = new Game();
            game.Awake();
        }
    }
}
