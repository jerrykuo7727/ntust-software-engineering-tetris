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

        protected Color controllerColor; // just for test
        protected int TileHeight = 16;
        protected int TileWidth = 16;

        public View()
        {
            //model = new Model();
            //controller = new Controller(model);
            controllerColor = Color.DarkCyan;

            timer = new Timer() { Interval = 1000 }; // 一秒執行一次Tick事件
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

        protected override void OnPaint(PaintEventArgs e)
        {
            // Controller.UserHasInput(); // 呼叫Controller遊戲要更新
            UserHasInput();
            GameDisplay(e); // 進入這個函式以畫出畫面，這是大家在自己的View裡要override的
            base.OnPaint(e); // 回去做它沒有被override時會做的事
        }

        protected virtual void GameDisplay(PaintEventArgs e)
        {
            for (int i = 19; i > 0; i++)
            {
                for (int j = 10; j > 0; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)),
                                             new Rectangle(j * TileWidth, i * TileHeight, TileWidth - 1, TileHeight - 1));
                }
            }
        }
    }
}