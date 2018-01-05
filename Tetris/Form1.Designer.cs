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
            this.view1 = new Tetris.B10432010_View();
            this.DownButton = new System.Windows.Forms.Button();
            this.LandButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Left_Button
            // 
            this.Left_Button.Location = new System.Drawing.Point(300, 24);
            this.Left_Button.Name = "Left_Button";
            this.Left_Button.Size = new System.Drawing.Size(48, 48);
            this.Left_Button.TabIndex = 1;
            this.Left_Button.Text = "Left";
            this.Left_Button.UseVisualStyleBackColor = true;
            this.Left_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(412, 24);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(48, 48);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // view1
            // 
            this.view1.Location = new System.Drawing.Point(12, 12);
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(240, 400);
            this.view1.TabIndex = 0;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(352, 50);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(56, 36);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // LandButton
            // 
            this.LandButton.Location = new System.Drawing.Point(300, 90);
            this.LandButton.Name = "LandButton";
            this.LandButton.Size = new System.Drawing.Size(160, 30);
            this.LandButton.TabIndex = 4;
            this.LandButton.Text = "Land";
            this.LandButton.UseVisualStyleBackColor = true;
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(352, 10);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(56, 36);
            this.RotateButton.TabIndex = 5;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 433);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.LandButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.Left_Button);
            this.Controls.Add(this.view1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Left_Button;
        private B10432010_View view1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LandButton;
        private System.Windows.Forms.Button RotateButton;
    }
}

