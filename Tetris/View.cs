using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    enum USERINPUT : int { LEFT = 0, RIGHT, DOWN, LAND, ROTATE };
    // We just regard timer calling OnPaint(e) as an user input because it is easier

    class View : UserControl
    {
        //public Controller controller;
        //public Model model
        Timer timer;
        public USERINPUT input;

        protected Color controllerColor;
        protected int TileHeight = 16;
        protected int TileWidth = 16;

        public View()
        {
            //model = new Model();
            //controller = new Controller(model);
            controllerColor = Color.DarkCyan;
            timer = new Timer() { Interval = 1000 };
            timer.Tick += delegate{
                input = USERINPUT.DOWN;
            };
            timer.Tick += (s, e) => Invalidate();
            timer.Start();
        }

        // pretend to be controller for a while
        public void ControllerUpdate()
        {
            if (controllerColor == Color.DarkCyan)
                controllerColor = Color.DarkBlue;
            else
                controllerColor = Color.DarkCyan;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Controller.UserHasInput();
            ControllerUpdate();
            GameDisplay(e);
            base.OnPaint(e);
        }

        protected virtual void GameDisplay(PaintEventArgs e)
        {
            for (int i = 1; i < 21 /* Model.BOARD_HEIGHT */; i++)
            {
                for (int j = 1; j < 11 /* Model.BOARD_WIDTH */; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)),
                                             new Rectangle(j * TileWidth, i * TileHeight, TileWidth - 1, TileHeight - 1));
                }
            }
        }
    }
}