namespace WindowsFormsAppPart3
{
    partial class UsersInfo
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
            this.customerslist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // customerslist
            // 
            this.customerslist.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.customerslist.FormattingEnabled = true;
            this.customerslist.ItemHeight = 20;
            this.customerslist.Location = new System.Drawing.Point(75, 33);
            this.customerslist.Name = "customerslist";
            this.customerslist.Size = new System.Drawing.Size(622, 364);
            this.customerslist.TabIndex = 0;
            // 
            // UsersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerslist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsersInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersInfo";
            this.Load += new System.EventHandler(this.UsersInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox customerslist;
    }
}