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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastImgChBox = new System.Windows.Forms.CheckBox();
            this.pictureContexMenuStip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьВPaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьСсылкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rectangleShotBtn = new System.Windows.Forms.Button();
            this.screenShotBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьПоследнийСкриншотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRкодНаСсылкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.pictureContexMenuStip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.notifyContexMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(184, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "mainMenu";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.функцииToolStripMenuItem.Text = "Настройки";
            this.функцииToolStripMenuItem.Click += new System.EventHandler(this.функцииToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.помощьToolStripMenuItem.Text = "О программе";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // showLastImgChBox
            // 
            this.showLastImgChBox.AutoSize = true;
            this.showLastImgChBox.Location = new System.Drawing.Point(11, 75);
            this.showLastImgChBox.Name = "showLastImgChBox";
            this.showLastImgChBox.Size = new System.Drawing.Size(163, 17);
            this.showLastImgChBox.TabIndex = 5;
            this.showLastImgChBox.Text = "Показывать  изображение";
            this.showLastImgChBox.UseVisualStyleBackColor = true;
            this.showLastImgChBox.CheckedChanged += new System.EventHandler(this.showLastImgChBox_CheckedChanged);
            // 
            // pictureContexMenuStip
            // 
            this.pictureContexMenuStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВPaintToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.получитьСсылкуToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.qRкодНаСсылкуToolStripMenuItem});
            this.pictureContexMenuStip.Name = "pictureContexMenuStip";
            this.pictureContexMenuStip.Size = new System.Drawing.Size(174, 136);
            // 
            // открытьВPaintToolStripMenuItem
            // 
            this.открытьВPaintToolStripMenuItem.Name = "открытьВPaintToolStripMenuItem";
            this.открытьВPaintToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.открытьВPaintToolStripMenuItem.Text = "Открыть в Paint";
            this.открытьВPaintToolStripMenuItem.Click += new System.EventHandler(this.открытьВPaintToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // получитьСсылкуToolStripMenuItem
            // 
            this.получитьСсылкуToolStripMenuItem.Name = "получитьСсылкуToolStripMenuItem";
            this.получитьСсылкуToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.получитьСсылкуToolStripMenuItem.Text = "Получить ссылку";
            this.получитьСсылкуToolStripMenuItem.Click += new System.EventHandler(this.UploadImageTSMI_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изображениеToolStripMenuItem,
            this.путьКФайлуToolStripMenuItem});
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            this.изображениеToolStripMenuItem.Click += new System.EventHandler(this.изображениеToolStripMenuItem_Click);
            // 
            // путьКФайлуToolStripMenuItem
            // 
            this.путьКФайлуToolStripMenuItem.Name = "путьКФайлуToolStripMenuItem";
            this.путьКФайлуToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.путьКФайлуToolStripMenuItem.Text = "Путь к файлу";
            this.путьКФайлуToolStripMenuItem.Click += new System.EventHandler(this.путьКФайлуToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.pictureContexMenuStip;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(1, 93);
            this.pictureBox.MaximumSize = new System.Drawing.Size(294, 175);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(192, 104);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click_1);
            // 
            // rectangleShotBtn
            // 
            this.rectangleShotBtn.Image = global::ScreenShot_Master.Properties.Resources.genericapp51;
            this.rectangleShotBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangleShotBtn.Location = new System.Drawing.Point(92, 23);
            this.rectangleShotBtn.Name = "rectangleShotBtn";
            this.rectangleShotBtn.Size = new System.Drawing.Size(100, 52);
            this.rectangleShotBtn.TabIndex = 1;
            this.rectangleShotBtn.Text = "Выделить";
            this.rectangleShotBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangleShotBtn.UseVisualStyleBackColor = true;
            this.rectangleShotBtn.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // screenShotBtn
            // 
            this.screenShotBtn.Image = global::ScreenShot_Master.Properties.Resources.screen;
            this.screenShotBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.screenShotBtn.Location = new System.Drawing.Point(1, 23);
            this.screenShotBtn.Name = "screenShotBtn";
            this.screenShotBtn.Size = new System.Drawing.Size(87, 52);
            this.screenShotBtn.TabIndex = 1;
            this.screenShotBtn.Text = "Заскринить";
            this.screenShotBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.screenShotBtn.UseVisualStyleBackColor = true;
            this.screenShotBtn.Click += new System.EventHandler(this.screenShotBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.notifyContexMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ScreenShot Master";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyContexMenu
            // 
            this.notifyContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьПоследнийСкриншотToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem});
            this.notifyContexMenu.Name = "notifyContexMenu";
            this.notifyContexMenu.Size = new System.Drawing.Size(310, 92);
            // 
            // показатьПоследнийСкриншотToolStripMenuItem
            // 
            this.показатьПоследнийСкриншотToolStripMenuItem.Name = "показатьПоследнийСкриншотToolStripMenuItem";
            this.показатьПоследнийСкриншотToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.показатьПоследнийСкриншотToolStripMenuItem.Text = "Показать последний скриншот";
            this.показатьПоследнийСкриншотToolStripMenuItem.Click += new System.EventHandler(this.показатьПоследнийСкриншотToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // получитьСсылкуНаПоследнийСкриншотToolStripMenuItem
            // 
            this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem.Name = "получитьСсылкуНаПоследнийСкриншотToolStripMenuItem";
            this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem.Text = "Получить ссылку на последний скриншот";
            this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem.Click += new System.EventHandler(this.получитьСсылкуНаПоследнийСкриншотToolStripMenuItem_Click);
            // 
            // qRкодНаСсылкуToolStripMenuItem
            // 
            this.qRкодНаСсылкуToolStripMenuItem.Name = "qRкодНаСсылкуToolStripMenuItem";
            this.qRкодНаСсылкуToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.qRкодНаСсылкуToolStripMenuItem.Text = "QR-код на ссылку";
            this.qRкодНаСсылкуToolStripMenuItem.Click += new System.EventHandler(this.qRкодНаСсылкуToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 91);
            this.Controls.Add(this.showLastImgChBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.rectangleShotBtn);
            this.Controls.Add(this.screenShotBtn);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
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
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.pictureContexMenuStip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.notifyContexMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button screenShotBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button rectangleShotBtn;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.CheckBox showLastImgChBox;
        private System.Windows.Forms.ContextMenuStrip pictureContexMenuStip;
        private System.Windows.Forms.ToolStripMenuItem открытьВPaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьСсылкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКФайлуToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyContexMenu;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьПоследнийСкриншотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьСсылкуНаПоследнийСкриншотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRкодНаСсылкуToolStripMenuItem;
    }
}

