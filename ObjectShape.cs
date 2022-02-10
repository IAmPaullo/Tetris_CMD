using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    class ObjectShape
    {
        private float topPos;
        private int rot;
        private bool isDestroyed = false;
        private Type type;
        private Grid grid;
        private Grid boardGrid;
        public enum Tetrominoes { I, J, L, O, S, T, Z };



        public ObjectShape(Grid boardGrid, Type type)
        {
            this.boardGrid = boardGrid;
            this.type = type;
            //grid = new Grid(boardGrid.TopValue - 3, boardGrid.LeftValue + 3, NewObjectShape(type, rot));
            topPos = grid.TopValue;
        }
    }
}
