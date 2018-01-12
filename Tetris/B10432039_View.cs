using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class B10432039_View : Tetris.View
    {
        override protected void GameDisplay(PaintEventArgs e)
        {
            var fallingBlock = new SolidBrush(Color.Brown);
            var pilingBlock = new SolidBrush(Color.Black);
            for (int i = 1; i < 21 ; i++)
            {
                for (int j = 1; j < 11 ; j++)
                {
                    if (model.Board[i,j] == 1 || model.Board[i, j] == 2)
                        e.Graphics.FillRectangle(fallingBlock, new Rectangle((j - 1) * tileWidth, (i - 1) * tileHeight, tileWidth - 1, tileHeight - 1));
                    else if (model.Board[i, j] == 3)
                        e.Graphics.FillRectangle(pilingBlock, new Rectangle((j - 1) * tileWidth, (i - 1) * tileHeight, tileWidth - 1, tileHeight - 1));
                }
            }
            base.GameDisplay(e);
        }
    }

}
