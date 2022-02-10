using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    class Grid
    {
        private int columns, rows;
        private int top, left;
        private Primitives[,] gameArea;


        public int TopValue { get { return top; } }
        public int LeftValue { get { return left; } }
        public int ColumnsValue { get { return columns; } }
        public int RowValue { get { return rows; } }


        public Grid(int top, int left, int columns, int rows)
        {
            this.columns = columns;
            this.rows = rows;
            this.top = top;
            this.left = left;
            gameArea = new Primitives[rows, columns];
        }

        public void DefineGameArea(Primitives[,] gameArea)
        {
            this.gameArea = gameArea;
        }

        public Primitives[,] GetGameArea()
        {
            return gameArea;
        }
        public void DrawArea()
        {
            for (int row = 0; row < RowValue; row++)
            {
                for (int column = 0; column < ColumnsValue; column++)
                {
                    if (gameArea[row, column] != null)
                    {
                        gameArea[row, column].DrawPrimitive(column + LeftValue, row + TopValue);
                    }
                }
            }
        }

        public void DrawArea(Grid grid)
        {
            for (int row = 0; row < RowValue; row++)
            {
                for (int column = 0; column < ColumnsValue; column++)
                {
                    if (gameArea[row, column] != null)
                    {
                        if (row + TopValue - grid.TopValue >= 0)
                            gameArea[row, column].DrawPrimitive(column + LeftValue,
                                row + TopValue);
                    }
                }
            }
        }

        public void DrawShape(int x, int y)
        {
            for (int row = 0; row < RowValue; row++)
            {
                for (int column = 0; column < ColumnsValue; column++)
                {
                    if (gameArea[row,column] != null)
                    {
                        gameArea[row, column].DrawPrimitive(column + x, row + y);
                    }
                }
            }
        }
    }
}
