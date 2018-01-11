using System.Windows.Forms;

// 可更換成其他繼承了Tetris.View的View
using CustomView = Tetris.B10432010_View; 

namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Left_Button = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.LandButton = new System.Windows.Forms.Button();
            this.CWRotateButton = new System.Windows.Forms.Button();
            this.GameOverBox = new System.Windows.Forms.GroupBox();
            this.NoBtn = new System.Windows.Forms.Button();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.CCWRotateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.View1 = new CustomView();
            this.GameOverBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Button
            // 
            this.Left_Button.Location = new System.Drawing.Point(268, 282);
            this.Left_Button.Name = "Left_Button";
            this.Left_Button.Size = new System.Drawing.Size(70, 40);
            this.Left_Button.TabIndex = 1;
            this.Left_Button.Text = "Left";
            this.Left_Button.UseVisualStyleBackColor = true;
            this.Left_Button.Click += new System.EventHandler(this.Left_Button_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(400, 282);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(70, 40);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(339, 282);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(60, 40);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // LandButton
            // 
            this.LandButton.Location = new System.Drawing.Point(287, 328);
            this.LandButton.Name = "LandButton";
            this.LandButton.Size = new System.Drawing.Size(160, 36);
            this.LandButton.TabIndex = 4;
            this.LandButton.Text = "Land";
            this.LandButton.UseVisualStyleBackColor = true;
            this.LandButton.Click += new System.EventHandler(this.LandButton_Click);
            // 
            // CWRotateButton
            // 
            this.CWRotateButton.Location = new System.Drawing.Point(268, 236);
            this.CWRotateButton.Name = "CWRotateButton";
            this.CWRotateButton.Size = new System.Drawing.Size(100, 40);
            this.CWRotateButton.TabIndex = 5;
            this.CWRotateButton.Text = "Rotate Clockwise";
            this.CWRotateButton.UseVisualStyleBackColor = true;
            this.CWRotateButton.Click += new System.EventHandler(this.CWRotateButton_Click);
            // 
            // GameOverBox
            // 
            this.GameOverBox.Controls.Add(this.NoBtn);
            this.GameOverBox.Controls.Add(this.gameoverLabel);
            this.GameOverBox.Controls.Add(this.YesBtn);
            this.GameOverBox.Location = new System.Drawing.Point(268, 38);
            this.GameOverBox.Name = "GameOverBox";
            this.GameOverBox.Size = new System.Drawing.Size(186, 100);
            this.GameOverBox.TabIndex = 11;
            this.GameOverBox.TabStop = false;
            this.GameOverBox.Text = "Game Over";
            this.GameOverBox.Visible = false;
            // 
            // NoBtn
            // 
            this.NoBtn.Location = new System.Drawing.Point(98, 39);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(80, 40);
            this.NoBtn.TabIndex = 8;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameoverLabel.Location = new System.Drawing.Point(14, 21);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(72, 15);
            this.gameoverLabel.TabIndex = 7;
            this.gameoverLabel.Text = "Try Again?";
            // 
            // YesBtn
            // 
            this.YesBtn.Location = new System.Drawing.Point(12, 39);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(80, 40);
            this.YesBtn.TabIndex = 6;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // CCWRotateButton
            // 
            this.CCWRotateButton.Location = new System.Drawing.Point(370, 236);
            this.CCWRotateButton.Name = "CCWRotateButton";
            this.CCWRotateButton.Size = new System.Drawing.Size(100, 40);
            this.CCWRotateButton.TabIndex = 13;
            this.CCWRotateButton.Text = "Rotate Cntrclockwise";
            this.CCWRotateButton.UseVisualStyleBackColor = true;
            this.CCWRotateButton.Click += new System.EventHandler(this.CCWRotateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Differculty:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(333, 169);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(47, 15);
            this.SpeedLabel.TabIndex = 15;
            this.SpeedLabel.Text = "milisec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "1 Tick per";
            // 
            // View1
            // 
            this.View1.Location = new System.Drawing.Point(12, 12);
            this.View1.Name = "View1";
            this.View1.Size = new System.Drawing.Size(250, 407);
            this.View1.TabIndex = 0;
            this.View1.GameOver += new System.EventHandler(this.View_GameOver);
            this.View1.Paint += new System.Windows.Forms.PaintEventHandler(this.SpeedLabel_ChangeText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CCWRotateButton);
            this.Controls.Add(this.GameOverBox);
            this.Controls.Add(this.CWRotateButton);
            this.Controls.Add(this.LandButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.Left_Button);
            this.Controls.Add(this.View1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GameOverBox.ResumeLayout(false);
            this.GameOverBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Left_Button;
        private Tetris.View View1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LandButton;
        private System.Windows.Forms.Button CWRotateButton;
        private System.Windows.Forms.GroupBox GameOverBox;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button CCWRotateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label label2;
    }
}

