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
            View1.input = USERINPUT.DOWN;
            View1.Invalidate();
        }

        private void CWRotateButton_Click(object sender, EventArgs e)
        {
            View1.input = USERINPUT.CW_ROTATE;
            View1.Invalidate();
        }


        private void CCWRotateButton_Click(object sender, EventArgs e)
        {
            View1.input = USERINPUT.CCW_ROTATE;
            View1.Invalidate();
        }

        private void Left_Button_Click(object sender, EventArgs e)
        {
            View1.input = USERINPUT.LEFT;
            View1.Invalidate();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            View1.input = USERINPUT.RIGHT;
            View1.Invalidate();
        }

        private void LandButton_Click(object sender, EventArgs e)
        {
            View1.input = USERINPUT.LAND;
            View1.Invalidate();
        }

        private void View_GameOver(object sender, EventArgs e)
        {
            GameOverBox.Visible = true;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            GameOverBox.Visible = false;
            View1.input = USERINPUT.RESTART;
            View1.Invalidate();
        }

        private void NoBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void Button1_Click(object sender, EventArgs e)
        {
            View1.MakeGameOverEvent();
            View1.Invalidate();
        }
    }
}
