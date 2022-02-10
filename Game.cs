using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tetris_CMD
{
    class Game
    {
        private const string windowTitle = "Tetris CMD";
        private const int gameLoopTime = 1000;
        private GameBoard gameBoard = new GameBoard(2, Console.WindowWidth / 2 - 5);
        
        
        public void Awake()
        {
            Console.Title = windowTitle;

            gameBoard.DrawBoard();

            while (!gameBoard.GameHasFinished())
            {
                gameBoard.GetKeyInputAndMovePieces();
                gameBoard.DrawBoard();

                Console.ReadKey();

                //Thread.Sleep(gameLoopTime);
            }
        }
        
    }


   
}
