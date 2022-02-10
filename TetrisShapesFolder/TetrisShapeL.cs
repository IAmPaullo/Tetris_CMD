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
        private const ConsoleColor shapeColor = ConsoleColor.White;


        public static Primitives[,] CreateShape(int rot)
        {
            rot = rot % rotAlternative;

            switch (rot)
            {
                default:
                    break;

                case 0:
                    return TetrisShapeLForm_0();

                case 1:
                    return TetrisShapeLForm_1();

                case 2:
                    return TetrisShapeLForm_2();

                case 3:
                    return TetrisShapeLForm_3();
            }

            return null;

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
