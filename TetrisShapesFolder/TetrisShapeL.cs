using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public static class TetrisShapeL
    {
        private const int rotAlternative = 4;
        private const ConsoleColor shapeColor = ConsoleColor.Yellow;


        public static Primitives[,] CreateShape(int rot)
        {
            rot %= rotAlternative;

            return rot switch
            {
                0 => TetrisShapeLForm_0(),
                1 => TetrisShapeLForm_1(),
                2 => TetrisShapeLForm_2(),
                3 => TetrisShapeLForm_3(),
                _ => null,
            };
        }

        private static Primitives[,] TetrisShapeLForm_0()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[0, 1] = new Primitives(shapeColor);
            result[1, 1] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeLForm_1()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 0] = new Primitives(shapeColor);
            result[1, 1] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);
            result[2, 0] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeLForm_2()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[0, 0] = new Primitives(shapeColor);
            result[0, 1] = new Primitives(shapeColor);
            result[1, 1] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);

            return result;
        }
        private static Primitives[,] TetrisShapeLForm_3()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[0, 2] = new Primitives(shapeColor);
            result[1, 0] = new Primitives(shapeColor);
            result[1, 1] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);

            return result;
        }

    }
}
