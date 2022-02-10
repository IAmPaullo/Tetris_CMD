using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class GameBoard
    {
        public const int boardHeight = 40;
        public const int boardWidth = 20;

        private int linesPerLvlAmount = 10;
        private int shapeAmount = 7;
        private int lines = 0;
        private int score = 0;
        private int level = 0;
        private float dropSpeed;
        private bool isFinished = false;
        private Grid levelGrid;
        private ObjectShape currentShape, nextShape;


        public GameBoard()
        {

        }
        public bool GameHasFinished()
        {
            return isFinished;
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
                        //mover pra esquerda
                        //MoveLeft(); em algum momento
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

        public void DrawBoard()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            //levelGrid.Draw();

        }

        private void DrawBorder()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            //Desenhar uma caixa aqui?
        }

        public void UpdateGameLoop()
        {

        }

    }
}
