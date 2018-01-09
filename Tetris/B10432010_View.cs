using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class B10432010_View : Tetris.View
    {
        override protected void GameDisplay(PaintEventArgs e)
        {
            var brush = new SolidBrush(controllerColor);
            for (int i = 1; i < 21 /* Model.BOARD_HEIGHT */; i++)
            {
                for (int j = 1; j < 11 /* Model.BOARD_WIDTH */; j++)
                {
                    e.Graphics.FillRectangle(brush, new Rectangle((j - 1) * TileWidth, (i - 1) * TileHeight, TileWidth - 1, TileHeight - 1));
                }
            }
        }
    }

}
