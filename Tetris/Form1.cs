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
        Timer timer1;
        public Form1()
        {
            InitializeComponent();
            initial_timer1();
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
            View1.model.grade = 0;
            View1.input = USERINPUT.RESTART;
            View1.timer.Start();
            View1.Invalidate();
        }

        private void NoBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void SpeedLabel_ChangeText(object sender, PaintEventArgs e)
        {
            SpeedLabel.Text = View1.timer.Interval.ToString() + " milisec";
        }
        private void initial_timer1()
        {
            timer1 = new Timer { Interval = 100 };
            timer1.Tick += new EventHandler (timer_tick);
            timer1.Start();
;        }
        private void timer_tick(object Sender, EventArgs e)//讓分數變化
        {
            label3.Text = View1.model.grade.ToString();
        }
    }
}
