using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class GameBoard
    {
        public const int boardHeight = 20;
        public const int boardWidth = 20;

        private int linesPerLvlAmount = 10;
        private int shapeAmount = 7;
        private int lines = 0;
        private int score = 0;
        private int level = 0;
        private float speed;
        private bool isFinished = false;
        private Grid levelGrid;
        private ObjectShape currentShape, nextShape;


        public GameBoard(int top, int left)
        {
            levelGrid = new Grid(top, left, boardHeight, boardWidth);
        }
        public bool GameHasFinished()
        {
            return isFinished;
        }
        public void DrawBoard()
        {
            Console.Clear();
            DrawBorder();
            levelGrid.DrawArea();

        }


        private static void DrawGameBox(int x, int y, int width, int height, bool isDoubleLine)
        {
            string singleLine = "////\\\\";
            string doubleLine = "*ඞ*" + "\u0D9E" +"****";
            string setString = isDoubleLine ? doubleLine : singleLine;


            Console.SetCursorPosition(x, y);
            Console.Write(setString[0]);

            for (int column = 0; column < width; column++)
            {
                Console.Write(setString[1]);
            }

            Console.Write(setString[2]);

            int xSize = x + width - 1;
            int ySize = y + 1;

            for (int row = 0; row < height - 2; row++, ySize++)
            {
                Console.SetCursorPosition(x, ySize);
                Console.Write(setString[3]);

                Console.SetCursorPosition(xSize, ySize);
                Console.Write(setString[3]);
            }

            ySize = y + height - 1;

            Console.SetCursorPosition(x, ySize);
            Console.Write(setString[4]);


            for (int column = 0; column < width - 2; column++)
            {
                Console.Write(setString[1]);
            }

            Console.Write(setString[5]);

        }



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
                        currentShape.ShapeMovement?.Invoke();
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine(Console.KeyAvailable);
                        break;

                    case ConsoleKey.DownArrow:

                        break;

                    case ConsoleKey.Spacebar:

                        break;
                }
            }

        }


        private void DrawBorder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            DrawGameBox(levelGrid.LeftValue - 1, levelGrid.TopValue - 1,
                boardWidth + 2, boardHeight + 2, true);

            //DrawGameBox(levelGrid.LeftValue + levelGrid.ColumnsValue + 2,
            //    levelGrid.TopValue + levelGrid.RowValue / 2 - 3, 10, 10, false);
        }


    }
}
