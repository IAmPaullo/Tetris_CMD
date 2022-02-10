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
        private Grid grid;
        private Grid boardGrid;
        public enum TetrisShape { I, J, L, O, S, T, Z };
        private TetrisShape type;



        public ObjectShape(Grid boardGrid, TetrisShape type)
        {
            this.boardGrid = boardGrid;
            this.type = type;
            //grid = new Grid(boardGrid.TopValue - 3, boardGrid.LeftValue + 3, NewObjectShape(type, rot));
            topPos = grid.TopValue;
        }

        public bool ReturnIsDestroyed { get { return isDestroyed; } }
        public Grid ReturnGrid { get { return grid; } }

        public void Draw()
        {
            grid.DrawArea();
        }
        public void Draw(int x, int y)
        {
            grid.DrawShape(x, y);
        }


        private Primitives[,] NewObjectShape(TetrisShape type, int rot)
        {
            switch (type)
            {
                default:
                    break;

                case TetrisShape.I:
                    return TetrisShapeI.CreateShape(rot);
                    
                case TetrisShape.J:
                    //
                    break;
                case TetrisShape.L:
                    //
                    break;
                case TetrisShape.O:
                    //
                    break;
                case TetrisShape.S:
                    //
                    break;
                case TetrisShape.T:
                    //
                    break;

                case TetrisShape.Z:
                    //
                    break;
            }
            return null;
        }


    }
}
