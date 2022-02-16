using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class ScoreHandler
    {
        public int Score { get; set; }
        public int HighScore { get; set; }

        public int Level { get; set; }

        public int Lines { get; set; }

        private SaveHandler saveHandler = new();
        
        
        public void SetData(int score, int level, int line)
        {
            Score = score;
            Level = level;
            Lines = line;
            
        }

        public int StatsManager(int lines, int linesPerLvlAmount, out int score, int level)
        {
            score = 50 * level;
            if (lines % linesPerLvlAmount == 0)
            {
                level++;
            }

            saveHandler.SaveToTxt(score, level, lines);

            return level;
        }

        public void UpdateTitle(int score, int level, int line)
        {

            Console.Title = $" Tetris CMD                  PONTUAÇÃO:   {score}                Level: {level} ";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(72, 2); // 72, 2 topo direito nessa ordem de janela
            Console.Write("Linhas Concluidas:" + line);
            Console.SetCursorPosition(72, 4);
            Console.Write("Level: " + level);
        }


    }

   

}
