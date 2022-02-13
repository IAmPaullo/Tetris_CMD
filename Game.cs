using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tetris_CMD
{
    class Game
    {
        private string windowTitle = "          Tetris CMD " + "               PONTUAÇÃO: ";
        private const int gameLoopTime = 120;
        private GameBoard gameBoard = new GameBoard(2, Console.WindowWidth / 2 - 5);
        private Movement movement = new Movement();
        
        
        public void Awake()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = windowTitle;
            Console.BufferHeight = Console.WindowHeight + 50;
            Console.BufferWidth = Console.WindowWidth + 50;

            gameBoard.DrawBoard();

            while (!gameBoard.GameHasFinished())
            {

                gameBoard.GetKeyInputAndMovePieces();
                gameBoard.UpdateGameLoop();
                gameBoard.DrawBoard();

                //Console.ReadKey();

                Thread.Sleep(gameLoopTime);

                
            }
        }
        
    }


   
}
