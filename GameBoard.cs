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
        private float speed = 10f;
        private bool isFinished = false;
        private Grid levelGrid;
        private ObjectShape currentShape, nextShape;


        private Random randValue = new Random();

        public GameBoard(int top, int left)
        {
            levelGrid = new Grid(top, left, boardHeight, boardWidth);
            currentShape = new ObjectShape(levelGrid,
                (ObjectShape.TetrisShape)(randValue.Next(0, shapeAmount)));

            nextShape = new ObjectShape(levelGrid,
                (ObjectShape.TetrisShape)(randValue.Next(0, shapeAmount)));
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
            currentShape.Draw(levelGrid);

        }

        public void UpdateGameLoop()
        {

            if (currentShape.ReturnIsDestroyed)
            {
                levelGrid.AssignPieceAndGrid(currentShape.ReturnGrid);
                currentShape = nextShape;
                nextShape = new ObjectShape(levelGrid,
                    (ObjectShape.TetrisShape)(randValue.Next(0, shapeAmount)));
            }
            currentShape.MoveDownByTime(speed);
        }

        private static void DrawGameBox(int x, int y, int width, int height)
        {
            
            string stringCharToUse = "┌━┐│└┘";
            string setString = stringCharToUse;


            Console.SetCursorPosition(x, y);
            Console.Write(setString[0]);

            for (int column = 0; column < width - 2; column++)
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


        private void DrawBorder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            DrawGameBox(levelGrid.LeftValue - 1, levelGrid.TopValue - 1,
                boardWidth + 2, boardHeight + 2);

            //DrawGameBox(levelGrid.LeftValue + levelGrid.ColumnsValue + 2,
            //    levelGrid.TopValue + levelGrid.RowValue / 2 - 3, 10, 10, false);
        }


    }
}
