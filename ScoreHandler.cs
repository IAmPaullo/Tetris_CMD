using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class ScoreHandler
    {

        public int ScoreManager(int lines, int linesPerLvlAmount, out int score, int level)
        {
            score = 50 * level / 2;
            if (lines % linesPerLvlAmount == 0)
            {
                level++;
            }

            return level;
        }

        public void UpdateTitle(int score, int level, int line)
        {


            Console.Title = "          Tetris CMD " + "               PONTUAÇÃO: " + score;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(72, 2); // 72, 2 topo direito
            Console.Write("Linhas Concluidas:" + line);
            Console.SetCursorPosition(72, 4);
            Console.Write("Level: " + level);
        }


    }
}
