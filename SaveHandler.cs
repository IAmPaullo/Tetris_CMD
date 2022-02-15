using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Tetris_CMD
{
    public class SaveHandler
    {
        string exePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"saveFile.txt");


        public void SaveToTxt(int score, int level, int lines)
        {

            if (GetScoreFromSave() < score)
            {

                try
                {

                    StreamWriter sw = new(exePath);
                    sw.WriteLine($"Score = {score}");
                    sw.WriteLine($"Level = {level}");
                    sw.WriteLine($"Linhas Destruídas = {lines}");
                    sw.WriteLine(@$"Player: {Environment.UserName}");

                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Jogo Salvo!");
                }
            }

        }


        public void LoadFromTxt()
        {
            if (File.Exists(exePath))
            {
                try
                {
                    StreamReader sr = new(exePath);
                    string content = sr.ReadLine();

                    while (content != null)
                    {
                        Console.WriteLine(content);

                        content = sr.ReadLine();
                    }



                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }

        public bool GetFileExists()
        {
            if (File.Exists(exePath))
                return true;
            else
                return false;
        }

        public int GetScoreFromSave()
        {
            int value;

            string content = File.ReadLines(exePath).First();

            string newContent = content.Substring(8);


            value = int.Parse(newContent);

            Console.WriteLine(newContent);



            return value;
        }


    }
}
