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
        private GameArea[,] gameArea;


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
            gameArea = new GameArea[rows, columns];
        }

        public void DefineGameArea(GameArea[,] gameArea)
        {
            this.gameArea = gameArea;
        }

        public GameArea[,] GetGameArea()
        {
            return gameArea;
        }
        public void DrawGA()
        {
            for (int row = 0; row < RowValue; row++)
            {
                for (int column = 0; column < ColumnsValue; column++)
                {
                    if (gameArea[row, column] != null)
                    {
                        gameArea[row, column].DrawGameArea(column + LeftValue, row + TopValue);
                    }
                }
            }
        }

        public void DrawGA(Grid grid)
        {
            for (int row = 0; row < RowValue; row++)
            {
                for (int column = 0; column < ColumnsValue; column++)
                {
                    if (gameArea[row, column] != null)
                    {
                        if (row + TopValue - grid.TopValue >= 0)
                            gameArea[row, column].DrawGameArea(column + LeftValue,
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
                        gameArea[row, column].DrawGameArea(column + x, row + y);
                    }
                }
            }
        }
    }
}
