namespace ScreenShot_Master
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLastShotImageCheckBox = new System.Windows.Forms.CheckBox();
            this.ImageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenInPaintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWithWindowsViewerMenuIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.GetUrlToImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyDropDownMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathToImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetQRCodeForLastShotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastScreenShotImageBox = new System.Windows.Forms.PictureBox();
            this.ShotRectangleButton = new System.Windows.Forms.Button();
            this.ShotFullScreenButton = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLastScreenShotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetUrlForLastShotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.ImageContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastScreenShotImageBox)).BeginInit();
            this.TrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.HelpMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(184, 24);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "mainMenu";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsStripMenuItemClick);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(94, 20);
            this.HelpMenuItem.Text = "О программе";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpClick);
            // 
            // ShowLastShotImageCheckBox
            // 
            this.ShowLastShotImageCheckBox.AutoSize = true;
            this.ShowLastShotImageCheckBox.Location = new System.Drawing.Point(11, 75);
            this.ShowLastShotImageCheckBox.Name = "ShowLastShotImageCheckBox";
            this.ShowLastShotImageCheckBox.Size = new System.Drawing.Size(163, 17);
            this.ShowLastShotImageCheckBox.TabIndex = 5;
            this.ShowLastShotImageCheckBox.Text = "Показывать  изображение";
            this.ShowLastShotImageCheckBox.UseVisualStyleBackColor = true;
            this.ShowLastShotImageCheckBox.CheckedChanged += new System.EventHandler(this.showLastImgChBox_CheckedChanged);
            // 
            // ImageContextMenu
            // 
            this.ImageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenInPaintMenuItem,
            this.OpenWithWindowsViewerMenuIcon,
            this.GetUrlToImageMenuItem,
            this.CopyDropDownMenu,
            this.GetQRCodeForLastShotMenuItem});
            this.ImageContextMenu.Name = "ImageContextMenu";
            this.ImageContextMenu.Size = new System.Drawing.Size(174, 114);
            // 
            // OpenInPaintMenuItem
            // 
            this.OpenInPaintMenuItem.Name = "OpenInPaintMenuItem";
            this.OpenInPaintMenuItem.Size = new System.Drawing.Size(173, 22);
            this.OpenInPaintMenuItem.Text = "Открыть в Paint";
            this.OpenInPaintMenuItem.Click += new System.EventHandler(this.OpenImageInPaintClick);
            // 
            // OpenWithWindowsViewerMenuIcon
            // 
            this.OpenWithWindowsViewerMenuIcon.Name = "OpenWithWindowsViewerMenuIcon";
            this.OpenWithWindowsViewerMenuIcon.Size = new System.Drawing.Size(173, 22);
            this.OpenWithWindowsViewerMenuIcon.Text = "Открыть";
            this.OpenWithWindowsViewerMenuIcon.Click += new System.EventHandler(this.OpenWithWindowsImageViewerClick);
            // 
            // GetUrlToImageMenuItem
            // 
            this.GetUrlToImageMenuItem.Name = "GetUrlToImageMenuItem";
            this.GetUrlToImageMenuItem.Size = new System.Drawing.Size(173, 22);
            this.GetUrlToImageMenuItem.Text = "Получить ссылку";
            this.GetUrlToImageMenuItem.Click += new System.EventHandler(this.UploadImageTSMI_Click);
            // 
            // CopyDropDownMenu
            // 
            this.CopyDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyFileMenuItem,
            this.CopyImageMenuItem,
            this.CopyPathToImageMenuItem});
            this.CopyDropDownMenu.Name = "CopyDropDownMenu";
            this.CopyDropDownMenu.Size = new System.Drawing.Size(173, 22);
            this.CopyDropDownMenu.Text = "Копировать";
            // 
            // CopyFileMenuItem
            // 
            this.CopyFileMenuItem.Name = "CopyFileMenuItem";
            this.CopyFileMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CopyFileMenuItem.Text = "Файл";
            this.CopyFileMenuItem.Click += new System.EventHandler(this.CopyImageFileToClipboard);
            // 
            // CopyImageMenuItem
            // 
            this.CopyImageMenuItem.Name = "CopyImageMenuItem";
            this.CopyImageMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CopyImageMenuItem.Text = "Изображение";
            this.CopyImageMenuItem.Click += new System.EventHandler(this.CopyImageToClipboardClick);
            // 
            // CopyPathToImageMenuItem
            // 
            this.CopyPathToImageMenuItem.Name = "CopyPathToImageMenuItem";
            this.CopyPathToImageMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CopyPathToImageMenuItem.Text = "Путь к файлу";
            this.CopyPathToImageMenuItem.Click += new System.EventHandler(this.CopyImagePathToClipboardClick);
            // 
            // GetQRCodeForLastShotMenuItem
            // 
            this.GetQRCodeForLastShotMenuItem.Name = "GetQRCodeForLastShotMenuItem";
            this.GetQRCodeForLastShotMenuItem.Size = new System.Drawing.Size(173, 22);
            this.GetQRCodeForLastShotMenuItem.Text = "QR-код на ссылку";
            this.GetQRCodeForLastShotMenuItem.Click += new System.EventHandler(this.getQRCodeToolStripMenuItem_Click);
            // 
            // LastScreenShotImageBox
            // 
            this.LastScreenShotImageBox.ContextMenuStrip = this.ImageContextMenu;
            this.LastScreenShotImageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastScreenShotImageBox.ErrorImage = null;
            this.LastScreenShotImageBox.Image = ((System.Drawing.Image)(resources.GetObject("LastScreenShotImageBox.Image")));
            this.LastScreenShotImageBox.Location = new System.Drawing.Point(1, 93);
            this.LastScreenShotImageBox.MaximumSize = new System.Drawing.Size(294, 175);
            this.LastScreenShotImageBox.Name = "LastScreenShotImageBox";
            this.LastScreenShotImageBox.Size = new System.Drawing.Size(192, 104);
            this.LastScreenShotImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LastScreenShotImageBox.TabIndex = 2;
            this.LastScreenShotImageBox.TabStop = false;
            this.LastScreenShotImageBox.Click += new System.EventHandler(this.pictureBox_Click_1);
            // 
            // ShotRectangleButton
            // 
            this.ShotRectangleButton.Image = global::ScreenShot_Master.Properties.Resources.genericapp51;
            this.ShotRectangleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShotRectangleButton.Location = new System.Drawing.Point(92, 23);
            this.ShotRectangleButton.Name = "ShotRectangleButton";
            this.ShotRectangleButton.Size = new System.Drawing.Size(100, 52);
            this.ShotRectangleButton.TabIndex = 1;
            this.ShotRectangleButton.Text = "Выделить";
            this.ShotRectangleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShotRectangleButton.UseVisualStyleBackColor = true;
            this.ShotRectangleButton.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // ShotFullScreenButton
            // 
            this.ShotFullScreenButton.Image = global::ScreenShot_Master.Properties.Resources.screen;
            this.ShotFullScreenButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShotFullScreenButton.Location = new System.Drawing.Point(1, 23);
            this.ShotFullScreenButton.Name = "ShotFullScreenButton";
            this.ShotFullScreenButton.Size = new System.Drawing.Size(87, 52);
            this.ShotFullScreenButton.TabIndex = 1;
            this.ShotFullScreenButton.Text = "Заскринить";
            this.ShotFullScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShotFullScreenButton.UseVisualStyleBackColor = true;
            this.ShotFullScreenButton.Click += new System.EventHandler(this.screenShotBtn_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "ScreenShot Master";
            this.TrayIcon.Visible = true;
            this.TrayIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.TrayIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLastScreenShotMenuItem,
            this.SettingsMenuItem,
            this.ExitMenuItem,
            this.GetUrlForLastShotMenuItem});
            this.TrayContextMenu.Name = "TrayContextMeny";
            this.TrayContextMenu.Size = new System.Drawing.Size(310, 92);
            // 
            // ShowLastScreenShotMenuItem
            // 
            this.ShowLastScreenShotMenuItem.Name = "ShowLastScreenShotMenuItem";
            this.ShowLastScreenShotMenuItem.Size = new System.Drawing.Size(309, 22);
            this.ShowLastScreenShotMenuItem.Text = "Показать последний скриншот";
            this.ShowLastScreenShotMenuItem.Click += new System.EventHandler(this.ShowLastScreenShotClick);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(309, 22);
            this.SettingsMenuItem.Text = "Настройки";
            this.SettingsMenuItem.Click += new System.EventHandler(this.ShowSettingClick);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(309, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // GetUrlForLastShotMenuItem
            // 
            this.GetUrlForLastShotMenuItem.Name = "GetUrlForLastShotMenuItem";
            this.GetUrlForLastShotMenuItem.Size = new System.Drawing.Size(309, 22);
            this.GetUrlForLastShotMenuItem.Text = "Получить ссылку на последний скриншот";
            this.GetUrlForLastShotMenuItem.Click += new System.EventHandler(this.getLastImageUrlToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 91);
            this.Controls.Add(this.ShowLastShotImageCheckBox);
            this.Controls.Add(this.LastScreenShotImageBox);
            this.Controls.Add(this.ShotRectangleButton);
            this.Controls.Add(this.ShotFullScreenButton);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 226);
            this.MinimumSize = new System.Drawing.Size(200, 119);
            this.Name = "MainForm";
            this.Text = "SSMaster";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ImageContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LastScreenShotImageBox)).EndInit();
            this.TrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ShotFullScreenButton;
        private System.Windows.Forms.PictureBox LastScreenShotImageBox;
        private System.Windows.Forms.Button ShotRectangleButton;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.CheckBox ShowLastShotImageCheckBox;
        private System.Windows.Forms.ContextMenuStrip ImageContextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenInPaintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenWithWindowsViewerMenuIcon;
        private System.Windows.Forms.ToolStripMenuItem GetUrlToImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyPathToImageMenuItem;
        public System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLastScreenShotMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetUrlForLastShotMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetQRCodeForLastShotMenuItem;
    }
}

