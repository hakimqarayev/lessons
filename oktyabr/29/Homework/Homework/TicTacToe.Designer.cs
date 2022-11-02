namespace Homework
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(130, 131);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn4.Location = new System.Drawing.Point(0, 132);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(130, 131);
            this.btn4.TabIndex = 0;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn7.Location = new System.Drawing.Point(0, 264);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(130, 131);
            this.btn7.TabIndex = 0;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn2.Location = new System.Drawing.Point(136, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(130, 131);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn3.Location = new System.Drawing.Point(272, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(130, 131);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn5.Location = new System.Drawing.Point(136, 132);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(130, 131);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn6.Location = new System.Drawing.Point(272, 132);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(130, 131);
            this.btn6.TabIndex = 0;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn8.Location = new System.Drawing.Point(136, 264);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(130, 131);
            this.btn8.TabIndex = 0;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn9.Location = new System.Drawing.Point(272, 264);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(130, 131);
            this.btn9.TabIndex = 0;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.ClickButton);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 396);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.Click += new System.EventHandler(this.ClickButton);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
    }
}

