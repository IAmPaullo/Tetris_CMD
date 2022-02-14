using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tetris_CMD
{
    public class Game
    {
        private string windowTitle = "          Tetris CMD " + "               PONTUAÇÃO: ";
        private const int gameLoopTime = 120;

        private string msg;
        private string[] options = { "Normal", "Dificil", "Sair" };
        private int selectedOption;

        private GameBoard gameBoard = new GameBoard(2, Console.WindowWidth / 2 - 5);
        private Movement movement = new Movement();
        
        public bool isHardMode;

        public void Start()
        {

            SetupConsoleConfig();
            SetupMainMenu();
            GameLoop();

        }

        private void SetupMainMenu()
        {

            StartMenu startMenu = new StartMenu(msg, options);
            selectedOption = startMenu.Start();
            SceneHandler();

            //msg = $@"{startMenu}";
        }

        private void SetupConsoleConfig()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = windowTitle;
            Console.BufferHeight = Console.WindowHeight + 50;
            Console.BufferWidth = Console.WindowWidth + 50;
        }

        private void GameLoop()
        {

            
            //if (selectedOption == 1)
            //{
            //    gameBoard.isHardMode = true;
            //}
            //else
            //{
            //    gameBoard.isHardMode = false;
            //}


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


        private void SceneHandler()
        {


            switch (selectedOption)
            {

                case 0:
                    gameBoard.isHardMode = false;
                    break;

                case 1:
                    gameBoard.isHardMode = true;
                    break;

                case 2:

                    Console.WriteLine("Aperte Enter pra sair.");
                    ConsoleKeyInfo k = Console.ReadKey(true);
                    if (k.Key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                    break;


            }

        }
    }

}


    



