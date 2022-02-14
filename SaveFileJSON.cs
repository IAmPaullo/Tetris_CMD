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
    public class SaveFileJSON
    {
        //public string name { get; set; }
        public int Score { get; set; }
        public int HighScore { get; set; }

        public int Level { get; set; }

        public int Lines { get; set; }
    }

   
    

}
