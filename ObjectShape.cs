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
        //public Action ShapeMovement;



        public ObjectShape(Grid boardGrid, TetrisShape type)
        {
            //AssignAction();
            this.boardGrid = boardGrid;
            this.type = type;
            grid = new Grid(boardGrid.TopValue - 3, boardGrid.LeftValue + 3, NewObjectShape(type, rot));
            topPos = grid.TopValue;
        }

        //public void AssignAction()
        //{
        //    ShapeMovement += grid.MoveDown;
        //    ShapeMovement += grid.MoveDown;
        //    ShapeMovement += grid.MoveDown;

        //}

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
                default:
                    break;

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


        public void MovePieceLeft()
        {
            grid.MoveLeft();
        }

        public void MovePieceRight()
        {
            grid.MoveRight();
        }

        public void MovePieceDown()
        {
            grid.MoveDown();
        }

        public void MoveDownByTime(float speed)
        {
            topPos += speed;

            if ((int)(topPos + speed) > (int)topPos)
            {
                grid.MoveDown();
                
            }
        }


    }
}
