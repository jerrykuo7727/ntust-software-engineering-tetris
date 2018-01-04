using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class B10432010_View : Tetris.View
    {
        override protected void OnPaint(PaintEventArgs e)
        {
            ControllerUpdate();
            var brush = new SolidBrush(controllerColor);
            for (int i = 0; i < 21 /* Model.BOARD_HEIGHT */; i++)
            {
                for (int j = 0; j < 11 /* Model.BOARD_WIDTH */; j++)
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(j * TileWidth, i * TileHeight, TileWidth - 1, TileHeight - 1));
                }
            }
            base.OnPaint(e);
        }
    }

}
