using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public static class TetrisShapeJ
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
                    return TetrisShapeJForm_0();

                case 1:
                    return TetrisShapeJForm_1();

                case 2:
                    return TetrisShapeJForm_2();

                case 3:
                    return TetrisShapeJForm_3();
            }

            return null;

        }

        private static Primitives[,] TetrisShapeJForm_0()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[0, 1] = new Primitives(shapeColor);
            result[1, 1] = new Primitives(shapeColor);
            result[2, 1] = new Primitives(shapeColor);
            result[3, 1] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeJForm_1()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 0] = new Primitives(shapeColor);
            result[1, 1] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);
            result[1, 3] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeJForm_2()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[0, 2] = new Primitives(shapeColor);
            result[0, 3] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);
            result[2, 2] = new Primitives(shapeColor);

            return result;
        }

        private static Primitives[,] TetrisShapeJForm_3()
        {
            Primitives[,] result = new Primitives[4, 4];
            result[1, 1] = new Primitives(shapeColor);
            result[1, 2] = new Primitives(shapeColor);
            result[1, 3] = new Primitives(shapeColor);
            result[2, 3] = new Primitives(shapeColor);

            return result;
        }

    }
}
