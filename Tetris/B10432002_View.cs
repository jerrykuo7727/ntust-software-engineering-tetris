using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class B10432002_View : Tetris.View
    {
        override protected void GameDisplay(PaintEventArgs e)
        {
            var fallingBlock = new SolidBrush(Color.Aqua);
            var pilingBlock = new SolidBrush(Color.Navy);

            if (controller.cp == 6)
            {
                fallingBlock = new SolidBrush(Color.Lime);
            }
            else if (controller.cp == 5)
            {
                fallingBlock = new SolidBrush(Color.SkyBlue);
            }
            else if (controller.cp == 4)
            {
                fallingBlock = new SolidBrush(Color.Gold);
            }
            else if (controller.cp == 3)
            {
                fallingBlock = new SolidBrush(Color.PeachPuff);
            }

            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (model.Board[i, j] == 1 || model.Board[i, j] == 2)
                        e.Graphics.FillRectangle(fallingBlock, new Rectangle((j - 1) * tileWidth, (i - 1) * tileHeight, tileWidth - 1, tileHeight - 1));
                    else if (model.Board[i, j] == 3)
                        e.Graphics.FillRectangle(pilingBlock, new Rectangle((j - 1) * tileWidth, (i - 1) * tileHeight, tileWidth - 1, tileHeight - 1));
                }
            }
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 1.0f),
                                             new Rectangle(j * tileWidth, i * tileHeight, tileWidth - 1, tileHeight - 1));
                }
            }
        }
    }
}
