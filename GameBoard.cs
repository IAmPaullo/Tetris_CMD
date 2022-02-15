using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class GameBoard
    {
        public const int boardHeight = 25;
        public const int boardWidth = 15;

        private int linesPerLvlAmount = 15;
        private int shapeAmount = 7;
        private int lines = 0;
        private int score = 0;
        private int level = 1;
        private int maxPiecesInRow = 15;
        private float speed = 0.5f;
        private bool isFinished = false;
        public bool isHardMode;
        private Grid levelGrid;
        private ScoreHandler scoreHandler;
        public ObjectShape currentShape, nextShape;

        private SceneHandler sceneHandler = new();
        private Random randValue = new();

        public GameBoard(int top =0, int left = 0)
        {
            scoreHandler = new ScoreHandler();
            levelGrid = new Grid(top, left, boardHeight, boardWidth);
            currentShape = new ObjectShape(levelGrid,
                (ObjectShape.TetrisShape)(randValue.Next(0, shapeAmount)));

            nextShape = new ObjectShape(levelGrid,
                (ObjectShape.TetrisShape)(randValue.Next(0, shapeAmount)));


        }

        
        public void UpdateGameLoop()
        {
            RemoveEntireLine();
            if (currentShape.ReturnIsDestroyed)
            {
                if (CurrentShapePosIsOutOfBoard())
                {
                    isFinished = true;
                    return;
                }
                levelGrid.AssignPieceAndGrid(currentShape.ReturnGrid);
                scoreHandler.SetData(score, level, lines);
                currentShape = nextShape;
                nextShape = new ObjectShape(levelGrid,
                    (ObjectShape.TetrisShape)(randValue.Next(0, shapeAmount)));
            }
            currentShape.MoveDownByTime(1);
        }

        public void DrawBoard()
        {
            Console.Clear();
            DrawBorder();
            scoreHandler.UpdateTitle(score, level, lines);
            levelGrid.DrawArea();
            currentShape.Draw(levelGrid);
            if (isHardMode == true) return;
            DrawNextShape();


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

        }
        public void GetKeyInputAndMovePieces()
        {
            ConsoleKey consoleKey;

            if (Console.KeyAvailable)
            {
                consoleKey = Console.ReadKey().Key;




                switch (consoleKey)
                {

                    case ConsoleKey.LeftArrow:
                        currentShape.MovePieceLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        currentShape.MovePieceRight();
                        break;

                    case ConsoleKey.DownArrow:
                        currentShape.MoveDownByTime();
                        break;

                    case ConsoleKey.Z:
                        currentShape.RotatePiece();
                        break;
                }
            }

        }

        private void DrawNextShape()
        {

            Console.SetCursorPosition(72, 8);
            Console.Write("Proximo Tetraminó: ");
            nextShape.Draw(levelGrid.LeftValue + levelGrid.ColumnsValue + 3,
                levelGrid.TopValue + levelGrid.RowValue / 3);

        }

        public bool GameHasFinished()
        {
            return isFinished;
        }
        private bool CurrentShapePosIsOutOfBoard()
        {
            for (int row = 0; row < currentShape.ReturnGrid.RowValue; row++)
            {
                for (int columns = 0; columns < currentShape.ReturnGrid.ColumnsValue; columns++)
                {
                    if (currentShape.ReturnGrid.GetPieceCellArea()[row, columns] != null)
                    {
                        if (row + currentShape.ReturnGrid.TopValue - levelGrid.TopValue < 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        private void RemoveEntireLine()
        {
            int piecesInRow = 0;

            for (int row = 0; row < levelGrid.RowValue; row++)
            {
                for (int columns = 0; columns < levelGrid.ColumnsValue; columns++)
                {
                    if (levelGrid.GetPieceCellArea()[row, columns] != null)
                    {
                        piecesInRow++;
                    }

                    if (piecesInRow == maxPiecesInRow)
                    {
                        levelGrid.DefineGameArea(ClearLineFormatGrid(row, levelGrid.GetPieceCellArea()));
                        lines++;
                        level = scoreHandler.StatsManager(lines, linesPerLvlAmount, out score, level);
                    }

                }

                piecesInRow = 0;
            }
        }

        private Primitives[,] ClearLineFormatGrid(int row, Primitives[,] p)
        {
            Primitives[,] result = new Primitives[p.GetLength(0), p.GetLength(1)];


            for (int i = row; i > 0; i--)
            {
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    result[i, j] = p[i - 1, j];
                }
            }

            for (int i = row + 1; i < p.GetLength(0); i++)
            {
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    result[i, j] = p[i, j];
                }
            }

            return result;

        }
    }
}
