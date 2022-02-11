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
        private Primitives[,] pieceCellArea;


        public int TopValue { get { return top; } }
        public int LeftValue { get { return left; } }
        public int ColumnsValue { get { return columns; } }
        public int RowValue { get { return rows; } }

        public void MoveLeft() { left--; }
        public void MoveRight() { left++; }
        public void MoveDown() { top++; }



        public Grid(int top, int left, int columns, int rows)
        {
            this.columns = columns;
            this.rows = rows;
            this.top = top;
            this.left = left;
            pieceCellArea = new Primitives[rows, columns];
        }

        public Grid(int top, int left, Primitives[,] pieceCellArea)
        {
            columns = pieceCellArea.GetLength(0);
            rows = pieceCellArea.GetLength(1);
            this.top = top;
            this.left = left;
            this.pieceCellArea = pieceCellArea;
        }

        public Grid(Grid grid, Primitives[,] pieceCellArea)
        {
            rows = grid.RowValue;
            columns = grid.ColumnsValue;
            top = grid.TopValue;
            left = grid.LeftValue;
            this.pieceCellArea = pieceCellArea;
        }


        public void DefineGameArea(Primitives[,] pieceCellArea)
        {
            this.pieceCellArea = pieceCellArea;
        }

        public Primitives[,] GetPieceCellArea()
        {
            return pieceCellArea;
        }
        public void DrawArea()
        {
            for (int row = 0; row < RowValue; row++)
            {
                for (int column = 0; column < ColumnsValue; column++)
                {
                    if (pieceCellArea[row, column] != null)
                    {
                        pieceCellArea[row, column].DrawPrimitive(column + LeftValue, row + TopValue);
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
                    if (pieceCellArea[row, column] != null)
                    {
                        if (row + TopValue - grid.TopValue >= 0)
                            pieceCellArea[row, column].DrawPrimitive(column + LeftValue,
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
                    if (pieceCellArea[row, column] != null)
                    {
                        pieceCellArea[row, column].DrawPrimitive(column + x, row + y);
                    }
                }
            }
        }

        public void AssignPieceAndGrid(Grid g)
        {
            if (g.RowValue > RowValue || g.ColumnsValue > ColumnsValue) return;

            for (int row = 0; row < g.RowValue; row++)
            {
                for (int col = 0; col < g.ColumnsValue; col++)
                {
                    if (g.pieceCellArea[row, col] != null)
                    {
                        pieceCellArea[row + g.TopValue - TopValue, col + g.LeftValue - LeftValue] =
                            g.pieceCellArea[row, col];

                    }
                }
            }


        }

    }
}
