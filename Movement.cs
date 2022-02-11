using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class Movement
    {
        private GameBoard gameBoard = new GameBoard(2, Console.WindowWidth / 2 - 5);
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
                        gameBoard.currentShape.MovePieceLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        gameBoard.currentShape.MovePieceRight();
                        break;

                    case ConsoleKey.DownArrow:
                       // gameBoard.currentShape.MovePieceDown();
                        break;

                    case ConsoleKey.Spacebar:
                        Console.WriteLine(Console.KeyAvailable);
                        break;
                }
            }

        }
    }
}
