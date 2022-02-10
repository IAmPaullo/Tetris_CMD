﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tetris_CMD
{
    class Game
    {
        private const string windowTitle = "Tetris CMD";
        private const int gameLoopTime = 60;
        private GameBoard gameBoard = new GameBoard();
        
        
        public void Awake()
        {
            Console.Title = windowTitle;

            gameBoard.DrawBoard();

            while (!gameBoard.GameHasFinished())
            {
                gameBoard.GetKeyInputAndMovePieces();
               
                Thread.Sleep(gameLoopTime);
            }
        }
        
    }


   
}
