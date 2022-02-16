using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public static class TetrisShapeT
    {
        private const int rotAlternative = 4;
        private const ConsoleColor shapeColor = ConsoleColor.DarkMagenta;


        public static Primitives[,] CreateShape(int rot)
        {
            rot %= rotAlternative;

            return rot switch
            {
                0 => TetrisShapeTForm_0(),
                1 => TetrisShapeTForm_1(),
                2 => TetrisShapeTForm_2(),
                3 => TetrisShapeTForm_3(),
                _ => null,
            };
        }

        private static Primitives[,] TetrisShapeTForm_0()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[2, 0] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeTForm_1()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);
            result[3, 1] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeTForm_2()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[2, 0] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);
            result[3, 1] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeTForm_3()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[2, 0] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[3, 1] = new Primitives(shapeColor);

            return result;
        }

    }
}
