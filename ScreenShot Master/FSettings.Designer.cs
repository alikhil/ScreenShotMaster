namespace ScreenShot_Master
{
    partial class FSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.On2ClickNotifyCMbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionOnCloseCBox = new System.Windows.Forms.ComboBox();
            this.ShowNotificationsOnTrayCheckBox = new System.Windows.Forms.ComboBox();
            this.RunAppOnWindowsStartCHeckBox = new System.Windows.Forms.CheckBox();
            this.AppTopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScreenshotSavePathTBox = new System.Windows.Forms.TextBox();
            this.choseSavepathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageFormatCBox = new System.Windows.Forms.ComboBox();
            this.HideAppOnShotCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rectKey = new System.Windows.Forms.ComboBox();
            this.rectMod = new System.Windows.Forms.ComboBox();
            this.activeMod = new System.Windows.Forms.ComboBox();
            this.activeKey = new System.Windows.Forms.ComboBox();
            this.fullKey = new System.Windows.Forms.ComboBox();
            this.fullMod = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.CopyToClipboardAfterShotCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CopyToClipboardAfterShotCheckbox);
            this.groupBox2.Controls.Add(this.On2ClickNotifyCMbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ActionOnCloseCBox);
            this.groupBox2.Controls.Add(this.ShowNotificationsOnTrayCheckBox);
            this.groupBox2.Controls.Add(this.RunAppOnWindowsStartCHeckBox);
            this.groupBox2.Controls.Add(this.AppTopMostCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Программа";
            // 
            // On2ClickNotifyCMbox
            // 
            this.On2ClickNotifyCMbox.FormattingEnabled = true;
            this.On2ClickNotifyCMbox.Items.AddRange(new object[] {
            "Сделать скриншот",
            "Сделать скриншот и загрузить",
            "Выйти из приложения"});
            this.On2ClickNotifyCMbox.Location = new System.Drawing.Point(213, 95);
            this.On2ClickNotifyCMbox.Name = "On2ClickNotifyCMbox";
            this.On2ClickNotifyCMbox.Size = new System.Drawing.Size(181, 21);
            this.On2ClickNotifyCMbox.TabIndex = 7;
            this.On2ClickNotifyCMbox.SelectedIndexChanged += new System.EventHandler(this.On2ClickNotifyCMbox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "При двойном клике на иконку в трее";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "При закрытии программы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Показывать уведомления в трее";
            // 
            // doOnCloseComBox
            // 
            this.ActionOnCloseCBox.FormattingEnabled = true;
            this.ActionOnCloseCBox.Items.AddRange(new object[] {
            "закрыть",
            "свернуть"});
            this.ActionOnCloseCBox.Location = new System.Drawing.Point(213, 70);
            this.ActionOnCloseCBox.Name = "doOnCloseComBox";
            this.ActionOnCloseCBox.Size = new System.Drawing.Size(181, 21);
            this.ActionOnCloseCBox.TabIndex = 4;
            this.ActionOnCloseCBox.SelectedIndexChanged += new System.EventHandler(this.doOnCloseComBox_SelectedIndexChanged);
            // 
            // showNotifsInTrayComBox
            // 
            this.ShowNotificationsOnTrayCheckBox.Enabled = false;
            this.ShowNotificationsOnTrayCheckBox.FormattingEnabled = true;
            this.ShowNotificationsOnTrayCheckBox.Items.AddRange(new object[] {
            "всегда",
            "никогда",
            "когда главное окно свернуто"});
            this.ShowNotificationsOnTrayCheckBox.Location = new System.Drawing.Point(213, 43);
            this.ShowNotificationsOnTrayCheckBox.Name = "showNotifsInTrayComBox";
            this.ShowNotificationsOnTrayCheckBox.Size = new System.Drawing.Size(181, 21);
            this.ShowNotificationsOnTrayCheckBox.TabIndex = 4;
            this.ShowNotificationsOnTrayCheckBox.SelectedIndexChanged += new System.EventHandler(this.showNotifsInTrayComBox_SelectedIndexChanged);
            // 
            // runInWinLoadChBox
            // 
            this.RunAppOnWindowsStartCHeckBox.AutoSize = true;
            this.RunAppOnWindowsStartCHeckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunAppOnWindowsStartCHeckBox.Location = new System.Drawing.Point(198, 15);
            this.RunAppOnWindowsStartCHeckBox.Name = "runInWinLoadChBox";
            this.RunAppOnWindowsStartCHeckBox.Size = new System.Drawing.Size(196, 17);
            this.RunAppOnWindowsStartCHeckBox.TabIndex = 1;
            this.RunAppOnWindowsStartCHeckBox.Text = "Запускать при загрузке Windows";
            this.RunAppOnWindowsStartCHeckBox.UseVisualStyleBackColor = true;
            this.RunAppOnWindowsStartCHeckBox.CheckedChanged += new System.EventHandler(this.runInWinLoadChBox_CheckedChanged);
            // 
            // topMostChBox
            // 
            this.AppTopMostCheckBox.AutoSize = true;
            this.AppTopMostCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AppTopMostCheckBox.Location = new System.Drawing.Point(58, 15);
            this.AppTopMostCheckBox.Name = "topMostChBox";
            this.AppTopMostCheckBox.Size = new System.Drawing.Size(116, 17);
            this.AppTopMostCheckBox.TabIndex = 0;
            this.AppTopMostCheckBox.Text = "Поверх всех окон";
            this.AppTopMostCheckBox.UseVisualStyleBackColor = true;
            this.AppTopMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostChBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScreenshotSavePathTBox);
            this.groupBox1.Controls.Add(this.choseSavepathBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ImageFormatCBox);
            this.groupBox1.Controls.Add(this.HideAppOnShotCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скриншот";
            // 
            // savepathTbox
            // 
            this.ScreenshotSavePathTBox.Location = new System.Drawing.Point(6, 33);
            this.ScreenshotSavePathTBox.Name = "savepathTbox";
            this.ScreenshotSavePathTBox.Size = new System.Drawing.Size(371, 20);
            this.ScreenshotSavePathTBox.TabIndex = 1;
            // 
            // choseSavepathBtn
            // 
            this.choseSavepathBtn.Location = new System.Drawing.Point(381, 32);
            this.choseSavepathBtn.Name = "choseSavepathBtn";
            this.choseSavepathBtn.Size = new System.Drawing.Size(29, 21);
            this.choseSavepathBtn.TabIndex = 1;
            this.choseSavepathBtn.Text = "...";
            this.choseSavepathBtn.UseVisualStyleBackColor = true;
            this.choseSavepathBtn.Click += new System.EventHandler(this.choseSavepathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Формат изображения";
            // 
            // imageFormatComBox
            // 
            this.ImageFormatCBox.FormattingEnabled = true;
            this.ImageFormatCBox.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "BMP"});
            this.ImageFormatCBox.Location = new System.Drawing.Point(352, 62);
            this.ImageFormatCBox.Name = "imageFormatComBox";
            this.ImageFormatCBox.Size = new System.Drawing.Size(58, 21);
            this.ImageFormatCBox.TabIndex = 1;
            this.ImageFormatCBox.SelectedIndexChanged += new System.EventHandler(this.imageFormatComBox_SelectedIndexChanged);
            // 
            // hideAppInScreenShotChBox
            // 
            this.HideAppOnShotCheckBox.AutoSize = true;
            this.HideAppOnShotCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HideAppOnShotCheckBox.Location = new System.Drawing.Point(6, 62);
            this.HideAppOnShotCheckBox.Name = "hideAppInScreenShotChBox";
            this.HideAppOnShotCheckBox.Size = new System.Drawing.Size(208, 17);
            this.HideAppOnShotCheckBox.TabIndex = 0;
            this.HideAppOnShotCheckBox.Text = "Скрывать программу на скриншоте\r\n";
            this.HideAppOnShotCheckBox.UseVisualStyleBackColor = true;
            this.HideAppOnShotCheckBox.CheckedChanged += new System.EventHandler(this.hideAppInScreenShotChBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rectKey);
            this.tabPage2.Controls.Add(this.rectMod);
            this.tabPage2.Controls.Add(this.activeMod);
            this.tabPage2.Controls.Add(this.activeKey);
            this.tabPage2.Controls.Add(this.fullKey);
            this.tabPage2.Controls.Add(this.fullMod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(428, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Горячие клавиши";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Скриншот активного окна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Скришот выделенной области";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Скришот полного экрана";
            // 
            // rectKey
            // 
            this.rectKey.FormattingEnabled = true;
            this.rectKey.Location = new System.Drawing.Point(270, 120);
            this.rectKey.Name = "rectKey";
            this.rectKey.Size = new System.Drawing.Size(92, 21);
            this.rectKey.TabIndex = 0;
            this.rectKey.SelectedIndexChanged += new System.EventHandler(this.rectKey_SelectedIndexChanged);
            // 
            // rectMod
            // 
            this.rectMod.FormattingEnabled = true;
            this.rectMod.Location = new System.Drawing.Point(189, 120);
            this.rectMod.Name = "rectMod";
            this.rectMod.Size = new System.Drawing.Size(59, 21);
            this.rectMod.TabIndex = 0;
            this.rectMod.SelectedIndexChanged += new System.EventHandler(this.rectMod_SelectedIndexChanged);
            // 
            // activeMod
            // 
            this.activeMod.FormattingEnabled = true;
            this.activeMod.Location = new System.Drawing.Point(189, 77);
            this.activeMod.Name = "activeMod";
            this.activeMod.Size = new System.Drawing.Size(59, 21);
            this.activeMod.TabIndex = 0;
            this.activeMod.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // activeKey
            // 
            this.activeKey.FormattingEnabled = true;
            this.activeKey.Location = new System.Drawing.Point(270, 77);
            this.activeKey.Name = "activeKey";
            this.activeKey.Size = new System.Drawing.Size(92, 21);
            this.activeKey.TabIndex = 0;
            // 
            // fullKey
            // 
            this.fullKey.FormattingEnabled = true;
            this.fullKey.Location = new System.Drawing.Point(270, 38);
            this.fullKey.Name = "fullKey";
            this.fullKey.Size = new System.Drawing.Size(92, 21);
            this.fullKey.TabIndex = 0;
            // 
            // fullMod
            // 
            this.fullMod.FormattingEnabled = true;
            this.fullMod.Location = new System.Drawing.Point(189, 38);
            this.fullMod.Name = "fullMod";
            this.fullMod.Size = new System.Drawing.Size(59, 21);
            this.fullMod.TabIndex = 0;
            this.fullMod.SelectedIndexChanged += new System.EventHandler(this.fullMod_SelectedIndexChanged);
            // 
            // CopyToClipboardAfterShotCheckbox
            // 
            this.CopyToClipboardAfterShotCheckbox.AutoSize = true;
            this.CopyToClipboardAfterShotCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyToClipboardAfterShotCheckbox.Location = new System.Drawing.Point(62, 122);
            this.CopyToClipboardAfterShotCheckbox.Name = "CopyToClipboardAfterShotCheckbox";
            this.CopyToClipboardAfterShotCheckbox.Size = new System.Drawing.Size(332, 17);
            this.CopyToClipboardAfterShotCheckbox.TabIndex = 8;
            this.CopyToClipboardAfterShotCheckbox.Text = "Копировать изображение в буфер обмена после скриншота";
            this.CopyToClipboardAfterShotCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyToClipboardAfterShotCheckbox.UseVisualStyleBackColor = true;
            this.CopyToClipboardAfterShotCheckbox.CheckedChanged += new System.EventHandler(this.CopyToClipboardAfterShotCheckbox_CheckedChanged);
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 307);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox HideAppOnShotCheckBox;
        private System.Windows.Forms.ComboBox ImageFormatCBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ShowNotificationsOnTrayCheckBox;
        private System.Windows.Forms.CheckBox RunAppOnWindowsStartCHeckBox;
        private System.Windows.Forms.CheckBox AppTopMostCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScreenshotSavePathTBox;
        private System.Windows.Forms.Button choseSavepathBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ActionOnCloseCBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rectKey;
        private System.Windows.Forms.ComboBox rectMod;
        private System.Windows.Forms.ComboBox activeMod;
        private System.Windows.Forms.ComboBox activeKey;
        private System.Windows.Forms.ComboBox fullKey;
        private System.Windows.Forms.ComboBox fullMod;
        private System.Windows.Forms.ComboBox On2ClickNotifyCMbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CopyToClipboardAfterShotCheckbox;
    }
}