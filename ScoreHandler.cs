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


        private JSONFileSave saveFile = new();

        public void SetData(int score, int level, int line)
        {
            Score = score;
            Level = level;
            Lines = line;
            
        }

        public int StatsManager(int lines, int linesPerLvlAmount, out int score, int level)
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


        public int GetScore() { return Score; }

        public int GetLevel() { return Level; }

        public int GetLines() { return Lines; }

    }

    
    public class JSONFileSave
    {

        public static void SaveMain()
        {

            var saveFile = new SaveFileJSON
            {
                Score = new ScoreHandler().GetScore(),
                Level = new ScoreHandler().GetLevel(),
                Lines = new ScoreHandler().GetLines()

            };

            string fileName = "SaveGameFile.json";
            string jsonString = JsonSerializer.Serialize(saveFile);
            File.WriteAllText(fileName, jsonString);

            Console.SetCursorPosition(78, 10);
            Console.WriteLine("Jogo Salvo");
        }

    }




}
