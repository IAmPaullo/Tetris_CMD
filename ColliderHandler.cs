using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    class ColliderHandler
    {
        public static bool isColliding(Grid board, Grid obj, int topBuffer, int leftBuffer)
        {
            for (int row = 0; row < obj.RowValue; row++)
            {
                for (int col = 0; col < obj.ColumnsValue; col++)
                {
                    if (obj.GetPieceCellArea()[row, col] != null)
                    {
                        if (col + obj.LeftValue - board.LeftValue + leftBuffer < 0) return true;
                        if (col + obj.LeftValue - board.LeftValue + leftBuffer > board.ColumnsValue) return true;
                        if (row + obj.TopValue - board.TopValue + topBuffer > board.RowValue - 1) return true;


                        if (row + obj.TopValue - board.TopValue + topBuffer < 0) continue;

                        if (board.GetPieceCellArea()[row + obj.TopValue  - board.TopValue + topBuffer ,
                            col + obj.LeftValue - board.LeftValue + leftBuffer] != null) return true;
                    }


                }
            }
            return false;
        }


    }
}
