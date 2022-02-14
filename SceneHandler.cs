using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class SceneHandler
    {

        public bool isHardMode;
        public void DefineSceneByIndex(int selectedOption)
        {


            switch (selectedOption)
            {

                case 0:
                    isHardMode = false;
                    break;

                case 1:
                    isHardMode = true;
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
