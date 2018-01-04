using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class View : UserControl
    {
        // Controller controller;
        Timer timer;
        protected Color controllerColor;
        protected int TileHeight = 16;
        protected int TileWidth = 16;

        public View()
        {
            controllerColor = Color.DarkCyan;
            timer = new Timer() { Interval = 1000 };
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
            base.OnPaint(e);
        }

    }
}