using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Tetris_CMD
{
    class SaveHandler
    {
        private ScoreHandler scoreHandler;
        public void SaveToTxt(int score, int level, int lines)
        {
            try
            {
                string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                StreamWriter sw = new(exePath);
                sw.WriteLine($"Score = {scoreHandler.GetScore()}");
                sw.WriteLine($"Level = {scoreHandler.GetLevel()}");
                sw.WriteLine($"Linhas Destruídas = {scoreHandler.GetLines()}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro no save");
            }
            finally
            {
                Console.WriteLine("Jogo Salvo!");
            }


        }


    }
}
