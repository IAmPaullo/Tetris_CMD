using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class GameOverHandler
    {
        private ScoreHandler scoreHandler = new();
        
        private Random randValue = new();
        private List<string> gameOverTextOptions = new();
        private string gameOverMsg;
        public void DefineGameOverScreen()
        {
            AddGameOverTextToList();
            SetUpGameOverGraphics();
            DisplayStats();
            ConsoleKeyInfo k = Console.ReadKey(true);
            if (k.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
        }

        private void SetUpGameOverGraphics()
        {
            int randTextValue = randValue.Next(0, gameOverTextOptions.Count);
            gameOverMsg = DefineRandomText(randTextValue);
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10,
                Console.WindowHeight / 2 + 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(gameOverMsg);
        }
        private void DisplayStats()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 ,
                Console.WindowHeight / 2 + 20);
            Console.WriteLine($"Score = {scoreHandler.GetScore()}");
            Console.WriteLine($"Level = {scoreHandler.GetLevel()}");
            Console.WriteLine($"Linhas Destruídas = {scoreHandler.GetLines()}");
        }

        private string DefineRandomText(int value) { return gameOverTextOptions[value]; }

        private void AddGameOverTextToList()
        {
            gameOverTextOptions.Add(@"
               _____            __  __  ______    ____ __      __ ______  _____  
              / ____|    /\    |  \/  ||  ____|  / __ \\ \    / /|  ____||  __ \ 
             | |  __    /  \   | \  / || |__    | |  | |\ \  / / | |__   | |__) |
             | | |_ |  / /\ \  | |\/| ||  __|   | |  | | \ \/ /  |  __|  |  _  / 
             | |__| | / ____ \ | |  | || |____  | |__| |  \  /   | |____ | | \ \ 
              \_____|/_/    \_\|_|  |_||______|  \____/    \/    |______||_|  \_\
                                                                     
                                                                     


");


            gameOverTextOptions.Add(@"
               ______ ___     __  ___ ______   ____  _    __ ______ ____ 
              / ____//   |   /  |/  // ____/  / __ \| |  / // ____// __ \
             / / __ / /| |  / /|_/ // __/    / / / /| | / // __/  / /_/ /
            / /_/ // ___ | / /  / // /___   / /_/ / | |/ // /___ / _, _/ 
            \____//_/  |_|/_/  /_//_____/   \____/  |___//_____//_/ |_|  
                                                                         
            

");

            gameOverTextOptions.Add(@"

         ________   ________   _____ ______    _______           ________   ___      ___  _______    ________     
        |\   ____\ |\   __  \ |\   _ \  _   \ |\  ___ \         |\   __  \ |\  \    /  /||\  ___ \  |\   __  \    
        \ \  \___| \ \  \|\  \\ \  \\\__\ \  \\ \   __/|        \ \  \|\  \\ \  \  /  / /\ \   __/| \ \  \|\  \   
         \ \  \  ___\ \   __  \\ \  \\|__| \  \\ \  \_|/__       \ \  \\\  \\ \  \/  / /  \ \  \_|/__\ \   _  _\  
          \ \  \|\  \\ \  \ \  \\ \  \    \ \  \\ \  \_|\ \       \ \  \\\  \\ \    / /    \ \  \_|\ \\ \  \\  \| 
           \ \_______\\ \__\ \__\\ \__\    \ \__\\ \_______\       \ \_______\\ \__/ /      \ \_______\\ \__\\ _\ 
            \|_______| \|__|\|__| \|__|     \|__| \|_______|        \|_______| \|__|/        \|_______| \|__|\|__|
                                                                                                          

");
            gameOverTextOptions.Add(@"
         ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ 
        ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗
        ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝
        ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗
        ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║
         ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝
                                                                                  
        mas ainda podem me contratar!!!


");
            gameOverTextOptions.Add(@"
         ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄       ▄▄  ▄▄▄▄▄▄▄▄▄▄▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄               ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
        ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌     ▐░░▌▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░▌             ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
        ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌   ▐░▐░▌▐░█▀▀▀▀▀▀▀▀▀      ▐░█▀▀▀▀▀▀▀█░▌ ▐░▌           ▐░▌ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌
        ▐░▌          ▐░▌       ▐░▌▐░▌▐░▌ ▐░▌▐░▌▐░▌               ▐░▌       ▐░▌  ▐░▌         ▐░▌  ▐░▌          ▐░▌       ▐░▌
        ▐░▌ ▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▐░▐░▌ ▐░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░▌       ▐░▌   ▐░▌       ▐░▌   ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌
        ▐░▌▐░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌     ▐░▌       ▐░▌    ▐░▌     ▐░▌    ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
        ▐░▌ ▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌   ▀   ▐░▌▐░█▀▀▀▀▀▀▀▀▀      ▐░▌       ▐░▌     ▐░▌   ▐░▌     ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀█░█▀▀ 
        ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌               ▐░▌       ▐░▌      ▐░▌ ▐░▌      ▐░▌          ▐░▌     ▐░▌  
        ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░█▄▄▄▄▄▄▄█░▌       ▐░▐░▌       ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌      ▐░▌ 
        ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌        ▐░▌        ▐░░░░░░░░░░░▌▐░▌       ▐░▌
         ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀▀▀▀▀▀▀▀▀▀▀          ▀          ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀ 

");
           


        }
    }
}
