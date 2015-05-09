namespace ScreenShot_Master
{
    partial class TakeAreaWindows
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
            this.SuspendLayout();
            // 
            // TakeAreaWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeAreaWindows";
            this.Opacity = 0.3D;
            this.Text = "TakeAreaWindows";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TakeAreaWindows_Load);
            this.Click += new System.EventHandler(this.TakeAreaWindows_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TakeAreaWindows_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TakeAreaWindows_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TakeAreaWindows_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}