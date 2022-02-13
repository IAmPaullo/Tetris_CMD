using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_CMD
{
    public class SceneHandler
    {


        public void DefineSituationByIndex(int index)
        {

            switch (index)
            {

                case 0:
                    NormalMode();
                    break;

                case 1:
                    HardMode();
                    break;

                case 2:
                    Exit();
                    break;


            }

        }


        private void NormalMode()
        {

        }

        private void HardMode()
        {

        }
        private void Exit()
        {

        }


    }
}
