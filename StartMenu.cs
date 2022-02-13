using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class StartMenu
    {
        private int selectedOption;
        private string[] options;
        private string mainMenuText;
        private Random randValue = new();
        
        private List<string> menuTextRandom = new();

        public StartMenu(string prompt, string[] options)
        {

            this.mainMenuText = prompt;
            this.options = options;
            selectedOption = 0;
            
        }

        public int Start()
        {
            AddMenuTitleList();

            return ReturnSelectedOptionInput();
        }

        private void DrawOptions()
        {
            int randText = randValue.Next(0, menuTextRandom.Count);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10,
                Console.WindowHeight / 2 - 10);
            mainMenuText = DefineRandomText(randText);

            Console.WriteLine(mainMenuText);
            for (int i = 0; i < options.Length; i++)
            {
                string currentOption = options[i];
                string prefix;

                if (i == selectedOption)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(Console.WindowWidth / 2 - 10,
                Console.WindowHeight / 2 + 2 + i);
                Console.WriteLine($"{prefix}<<{currentOption}>>");
            }
            Console.ResetColor();

        }

        public int ReturnSelectedOptionInput()
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                DrawOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    if (selectedOption == -1)
                        selectedOption = options.Length - 1;

                    selectedOption--;

                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (selectedOption == options.Length)
                        selectedOption = 0;

                    selectedOption++;
                }

            } while (key != ConsoleKey.Enter);

            return selectedOption;
        }



        private string DefineRandomText(int value) { return menuTextRandom[value]; }
     


        private void AddMenuTitleList()
        {
            menuTextRandom.Add(@"
                 _______ ______ _______ _____  _____  _____ 
                |__   __|  ____|__   __|  __ \|_   _|/ ____|
                   | |  | |__     | |  | |__) | | | | (___  
                   | |  |  __|    | |  |  _  /  | |  \___ \ 
                   | |  | |____   | |  | | \ \ _| |_ ____) |
                   |_|  |______|  |_|  |_|  \_\_____|_____/ 
                                                            
                                             

");
            menuTextRandom.Add(@"
                  ______________________  _________
                 /_  __/ ____/_  __/ __ \/  _/ ___/
                  / / / __/   / / / /_/ // / \__ \ 
                 / / / /___  / / / _, _// / ___/ / 
                /_/ /_____/ /_/ /_/ |_/___//____/  
                                   



");
            menuTextRandom.Add(@"
                
                 _______ _______ _______ ______  _  ______ 
                (_______|_______|_______|_____ \| |/ _____)
                    _    _____      _    _____) ) ( (____  
                   | |  |  ___)    | |  |  __  /| |\____ \ 
                   | |  | |_____   | |  | |  \ \| |_____) )
                   |_|  |_______)  |_|  |_|   |_|_(______/ 
                                                           


                              

");
            menuTextRandom.Add(@"
                 ______  ______  ______  ______  __  ______    
                /\__  _\/\  ___\/\__  _\/\  == \/\ \/\  ___\   
                \/_/\ \/\ \  __\\/_/\ \/\ \  __<\ \ \ \___  \  
                   \ \_\ \ \_____\ \ \_\ \ \_\ \_\ \_\/\_____\ 
                    \/_/  \/_____/  \/_/  \/_/ /_/\/_/\/_____/ 
                                                               
                
                


");
            menuTextRandom.Add(@"
                 _______ _______ _______ ______ _______ _______ 
                |_     _|    ___|_     _|   __ \_     _|     __|
                  |   | |    ___| |   | |      <_|   |_|__     |
                  |___| |_______| |___| |___|__|_______|_______|
                                                                

");
            menuTextRandom.Add(@"

                ░░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░
                ░░░░░░░▒▒▒░░░░░░░░▒▒▒░░░░░░░░░░░
                ░░░░░░▒▒░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░
                ░░░▒▒▒▒░░░░░▒░░░░░░░░░░▒░░░░░░░░
                ░░░▒░░▒░░░░░▒░░░░░░░░░░▒░░░░░░░░
                ░░░▒░░▒░░░░░▒░░░░░░░░░░▒░░░░░░░░
                ░░░▒░░▒░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░ TETRIS!!!!
                ░░░▒░░▒░░░░░░░░░░░░░░▒░░░░░░░░░░
                ░░░▒░░▒░░░░░░░░░░░░░░▒░░░░░░░░░░
                ░░░▒▒▒▒░░░░░░░░░░░░░░▒░░░░░░░░░░
                ░░░░░░▒░░░░░░░░░░░░░░▒░░░░░░░░░░
                ░░░░░░▒░░░░▒▒▒▒▒▒░░░░▒░░░░░░░░░░
                ░░░░░░▒░░░░▒░░░░▒░░░░▒░░░░░░░░░░
                ░░░░░░▒░░░░▒░░░░▒░░░░▒░░░░░░░░░░
                ░░░░░░▒▒▒▒▒▒░░░░▒▒▒▒▒▒░░░░░░░░░░

");
            menuTextRandom.Add(@"
                 _____ _____ _____ ____  ___ ____  
                |_   _| ____|_   _|  _ \|_ _/ ___| 
                  | | |  _|   | | | |_) || |\___ \ 
                  | | | |___  | | |  _ < | | ___) |
                  |_| |_____| |_| |_| \_\___|____/ 
                                    


");
            menuTextRandom.Add(@"010101001000101010101001010010100100101010011");


        }

    }
}
