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
        private string[] options = { "Normal", "Dificil","Score", "Sair" };
        private int selectedOption;

        private GameBoard gameBoard = new GameBoard(2, Console.WindowWidth / 2 - 5);
        private Movement movement = new Movement();
        private SceneHandler sceneHandler = new();
        private GameOverHandler gameOver = new();
        
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
            
            sceneHandler.DefineSceneByIndex(selectedOption);

            if(selectedOption == 2)
            {
                selectedOption = startMenu.Start();
                
            }

            
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

            gameBoard.isHardMode = sceneHandler.isHardMode;

            gameBoard.DrawBoard();
            while (!gameBoard.GameHasFinished())
            {

                gameBoard.GetKeyInputAndMovePieces();
                gameBoard.UpdateGameLoop();
                gameBoard.DrawBoard();

                

                Thread.Sleep(gameLoopTime);


            }
            gameOver.DefineGameOverScreen();
        }
    }

}


    



