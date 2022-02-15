using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tetris_CMD
{
    public class HighScoreScene
    {
        SaveHandler saveHandler = new();



        public void ShowHighScore()
        {


            SetUpScene();

        }


        public void SetUpScene()
        {
            if (saveHandler.GetFileExists())
            {
                Console.Clear();
                Console.WriteLine("Apertar Enter para voltar");
                saveHandler.LoadFromTxt();

            }
            else
            {
                Console.Clear();
                
                Console.WriteLine("Nenhum Score encontrado :( ");
                Thread.Sleep(2000);

            }





        }

    }
}
