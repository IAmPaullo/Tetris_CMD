using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class Movement
    {
        public void GetKeyInputAndMovePieces()
        {
            ConsoleKey consoleKey;

            if (Console.KeyAvailable)
            {
                consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    default:
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(Console.KeyAvailable);
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine(Console.KeyAvailable);
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine(Console.KeyAvailable);
                        break;

                    case ConsoleKey.Spacebar:
                        Console.WriteLine(Console.KeyAvailable);
                        break;
                }
            }

        }
    }
}
