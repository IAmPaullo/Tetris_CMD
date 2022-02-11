using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class ObjectShape
    {
        private float topPos;
        private int rot = 0;
        private bool isDestroyed = false;
        private Grid grid;
        private Grid boardGrid;
        public enum TetrisShape { I, J, L, O, S, T, Z };
        private TetrisShape type;
        //public Action ShapeMovement;



        public ObjectShape(Grid boardGrid, TetrisShape type)
        {
            //AssignAction();
            this.boardGrid = boardGrid;
            this.type = type;
            grid = new Grid(boardGrid.TopValue - 3, boardGrid.LeftValue + 7, NewObjectShape(type, rot));
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

        public void Draw(Grid rect)
        {
            grid.DrawArea(rect);
        }


        private Primitives[,] NewObjectShape(TetrisShape type, int rot)
        {
            switch (type)
            {

                case TetrisShape.I:
                    return TetrisShapeI.CreateShape(rot);

                case TetrisShape.J:
                    return TetrisShapeJ.CreateShape(rot);


                case TetrisShape.L:
                    return TetrisShapeL.CreateShape(rot);


                case TetrisShape.O:
                    return TetrisShapeO.CreateShape(rot);


                case TetrisShape.S:
                    return TetrisShapeS.CreateShape(rot);


                case TetrisShape.T:
                    return TetrisShapeT.CreateShape(rot);


                case TetrisShape.Z:
                    return TetrisShapeZ.CreateShape(rot);

            }
            return null;
        }


        public void RotatePiece()
        {
            Primitives[,] rotPieceCell = NewObjectShape(type, rot);
            Grid gridRotated = new Grid(grid, rotPieceCell);

            if (!ColliderHandler.isColliding(boardGrid, gridRotated))
            {
                grid = gridRotated;
                rot++;
            }
        }

        public void MovePieceLeft()
        {
            if (!ColliderHandler.isColliding(boardGrid, grid, -1, 0))
                grid.MoveLeft();
        }

        public void MovePieceRight()
        {
            if (!ColliderHandler.isColliding(boardGrid, grid, 1, 0))
                grid.MoveRight();
        }

        public void MoveDownByTime(float speed = 1f)
        {
            topPos += speed;

            if ((int)(topPos + speed) > (int)topPos)
            {
                if (!ColliderHandler.isColliding(boardGrid, grid, 0, 1))
                {
                    grid.MoveDown();
                }
                else
                {
                    isDestroyed = true;
                }
            }
        }


    }
}
