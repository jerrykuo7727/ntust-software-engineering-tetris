using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public enum USERINPUT : int { LEFT = 0, RIGHT, DOWN, LAND, CW_ROTATE, CCW_ROTATE, RESTART };
    // We just regard timer calling OnPaint(e) as an user input because it is easier

    public class View : UserControl
    {
        public Controller controller;
        public Model model;
        public USERINPUT input;
        public event EventHandler GameOver;

        private Timer timer;

        protected Color controllerColor; // just for test
        protected int tileHeight = 16;
        protected int tileWidth = 16;

        public View()
        {
            model = new Model();
            controller = new Controller(model, this);
            controllerColor = Color.DarkCyan;
            input = USERINPUT.DOWN;

            timer = new Timer() { Interval = model.speed }; // 執行Tick事件的速度
            timer.Tick += delegate{
                input = USERINPUT.DOWN; // 在Tick發生之後要做{input = USERINPUT.DOWN;}
            };
            timer.Tick += (s, e) => Invalidate();// 然後再來要做{Invalidate();} Invalidate裡面會呼叫OnPaint
            timer.Start();
        }

        // just pretend to be controller for a while
        public void UserHasInput()
        {
            if (controllerColor == Color.DarkCyan)
                controllerColor = Color.DarkBlue;
            else
                controllerColor = Color.DarkCyan;
        }
        // just pretend OnPaint find GameOver for a while
        public void MakeGameOverEvent()
        {
            GameOver(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            controller.UserHasInput(); // 呼叫Controller遊戲要更新
            if (controller.currentState == "gameOverState") GameOver(this, EventArgs.Empty);
            timer.Interval = model.speed; // 隨時檢查速度有沒有變快
            GameDisplay(e); // 進入這個函式以畫出畫面，這是大家在自己的View裡要override的
            base.OnPaint(e); // 回去做它沒有被override時會做的事
        }

        protected virtual void GameDisplay(PaintEventArgs e)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)),
                                             new Rectangle(j * tileWidth, i * tileHeight, tileWidth - 1, tileHeight - 1));
                }
            }
        }
    }
}