using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public static class TetrisShapeS
    {
        private const int rotAlternative = 2;
        private const ConsoleColor shapeColor = ConsoleColor.White;


        public static Primitives[,] CreateShape(int rot)
        {
            rot %= rotAlternative;

            return rot switch
            {
                0 => TetrisShapeSForm_0(),
                1 => TetrisShapeSForm_1(),
                _ => null,
            };
        }

        private static Primitives[,] TetrisShapeSForm_0()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);
            result[2, 0] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeSForm_1()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);
            result[3, 2] = new Primitives(shapeColor);

            return result;
        }

    }
}
