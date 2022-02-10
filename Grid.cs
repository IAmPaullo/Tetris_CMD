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




    }
}
