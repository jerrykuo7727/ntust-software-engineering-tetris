using System.Windows.Forms;

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
            this.RotateButton = new System.Windows.Forms.Button();
            this.view1 = new Tetris.B10432010_View();
            this.gameOverBox = new System.Windows.Forms.GroupBox();
            this.noBtn = new System.Windows.Forms.Button();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.gameOverBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Button
            // 
            this.Left_Button.Location = new System.Drawing.Point(276, 251);
            this.Left_Button.Name = "Left_Button";
            this.Left_Button.Size = new System.Drawing.Size(54, 60);
            this.Left_Button.TabIndex = 1;
            this.Left_Button.Text = "Left";
            this.Left_Button.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(390, 251);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(54, 60);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(330, 282);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(60, 40);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // LandButton
            // 
            this.LandButton.Location = new System.Drawing.Point(280, 328);
            this.LandButton.Name = "LandButton";
            this.LandButton.Size = new System.Drawing.Size(160, 30);
            this.LandButton.TabIndex = 4;
            this.LandButton.Text = "Land";
            this.LandButton.UseVisualStyleBackColor = true;
            this.LandButton.Click += new System.EventHandler(this.LandButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(330, 240);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(60, 40);
            this.RotateButton.TabIndex = 5;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // view1
            // 
            this.view1.Location = new System.Drawing.Point(12, 12);
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(250, 407);
            this.view1.TabIndex = 0;
            this.view1.GameOver += new System.EventHandler(this.View_GameOver);
            // 
            // gameOverBox
            // 
            this.gameOverBox.Controls.Add(this.noBtn);
            this.gameOverBox.Controls.Add(this.gameoverLabel);
            this.gameOverBox.Controls.Add(this.yesBtn);
            this.gameOverBox.Location = new System.Drawing.Point(258, 39);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Size = new System.Drawing.Size(186, 100);
            this.gameOverBox.TabIndex = 11;
            this.gameOverBox.TabStop = false;
            this.gameOverBox.Text = "Game Over";
            this.gameOverBox.Visible = false;
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(98, 39);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(80, 40);
            this.noBtn.TabIndex = 8;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
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
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(12, 39);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(80, 40);
            this.yesBtn.TabIndex = 6;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 431);
            this.Controls.Add(this.gameOverBox);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.LandButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.Left_Button);
            this.Controls.Add(this.view1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gameOverBox.ResumeLayout(false);
            this.gameOverBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Left_Button;
        private B10432010_View view1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LandButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.GroupBox gameOverBox;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Button yesBtn;
    }
}

