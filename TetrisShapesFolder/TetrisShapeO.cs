using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public static class TetrisShapeO
    {
        private const int rotAlternative = 1;
        private const ConsoleColor shapeColor = ConsoleColor.White;


        public static Primitives[,] CreateShape(int rot)
        {
            rot = rot % rotAlternative;


            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);

            return result;

        }

       

    }
}
