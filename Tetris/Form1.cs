using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            view1.Invalidate();
            view1.input = USERINPUT.DOWN;
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            view1.Invalidate();
            view1.input = USERINPUT.ROTATE;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            view1.Invalidate();
            view1.input = USERINPUT.RIGHT;
        }

        private void LandButton_Click(object sender, EventArgs e)
        {
            view1.Invalidate();
            view1.input = USERINPUT.LAND;
            view1.MakeGameOverEvent();
        }

        private void View_GameOver(object sender, EventArgs e)
        {
            gameOverBox.Visible = true;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {

        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            // do nothing
        }
    }
}
