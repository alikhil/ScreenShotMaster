using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.IO;
using System.Windows.Forms;
using SreenShotClass;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Xml;
namespace ScreenShot_Master
{
    public partial class MainForm : Form
    {
        public  CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
        Point pos;
        bool moved;
        public MainForm()
        {
            
            InitializeComponent();
            InitSettings();

        }
        private void CheckUpdate()
        {
            string  link = "https://www.dropbox.com/s/s37r34pisokdbyb/version.xml?dl=1";
            
            WebClient web = new WebClient();
            web.DownloadStringCompleted += client_DownloadFileCompleted;
            web.DownloadStringAsync(new Uri(link));
            
        }


         void client_DownloadFileCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
             string ver = null, hash = null, uri = null;

            XmlDocument doc = new XmlDocument();
            string s = e.Result;
            doc.LoadXml(s);
            XmlElement el = doc.DocumentElement;
            foreach (XmlElement elem in el.ChildNodes)
            {
                if (elem.Name == "version") ver = elem.InnerText;
                if (elem.Name == "hash") hash = elem.InnerText;
                if (elem.Name == "link") uri = elem.InnerText;
            }
            if (ver != null && hash != null && uri != null)
            {
                Version fVer = new Version(Application.ProductVersion);
                Version newVer = new Version(ver);
                if (newVer.CompareTo(fVer) == 1)
                {
                    DialogResult dr = MessageBox.Show("Обнаружена новая версия программы.\nУстановить?","Обновление",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
#if !DEBUG
                        ExtractResource("Updater", "updater.exe");
#endif
                        Process proc = new Process();
                        proc.StartInfo.FileName = "updater.exe";
#if !DEBUG
                        proc.StartInfo.CreateNoWindow = true;
#endif
                        proc.StartInfo.UseShellExecute = false;
                        string d = "Work#" + Application.ExecutablePath + '#' + uri + '#' + hash;
                        d = d.Replace(" ", "^^");
                        d = d.Replace("#", " ");
                        proc.StartInfo.Arguments = d;
                        proc.Start();
                    }
                }
            }


        }
        private void InitSettings()
        {
            if (!Settings.KeyExist("FolderPath"))
            {
                Settings.AddSettings("FolderPath", Directory.GetCurrentDirectory() + "\\ScreenShots"); //Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\ScreenShots");
                if(!Directory.Exists("ScreenShots"))
                Directory.CreateDirectory("ScreenShots");
            }
            if (!Settings.KeyExist("ImageFormat"))
                Settings.AddSettings("ImageFormat", "png");
            Settings.Refresh();
            if(!Settings.KeyExist("On2ClickNotify"))
            {
                Settings.AddSettings("On2ClickNotify", "MakeSS");
            }
            bool check = Settings.GetValue("FormSize", "Minimum") == "Maximum";
            showLastImgChBox.Checked = check;
            if (check)
                this.Size = this.MaximumSize;
            else
                this.Size = this.MinimumSize;

            TopMost = Settings.GetValue("TopMost","true") == "true";
            #region InitHotKeys

            InitHotkeys();

            #endregion

        }

        private void InitHotkeys()
        {
            string fullModKey = "0", cutModKey = "2", windModKey = "1";
            string fullKey = Keys.PrintScreen.GetHashCode().ToString();
            string cutKey = fullKey, windKey = fullKey;
            fullModKey = Settings.GetValue("FullModKey", fullModKey);
            cutModKey = Settings.GetValue("CutModKey", cutModKey);
            windModKey = Settings.GetValue("WindModKey", windModKey);

            windKey = Settings.GetValue("WindKey", windKey);
            cutKey = Settings.GetValue("CutKey", cutKey);
            fullKey = Settings.GetValue("FullKey", fullKey);

            int fullModKeyI = toint(fullModKey);
            int cutModKeyI = toint(cutModKey);
            int windModKeyI = toint(windModKey);

            int cutKeyI = toint(cutKey);
            int fullKeyI = toint(fullKey);
            int windKeyI = toint(windKey);

            HotKeyS.Init();
            HotKeyS.Handle = this.Handle;

            HotKeyS.RegstrerHotkey((HotKeyS.KeyModifer)fullModKeyI, (Keys)fullKeyI, FullScreenShotPressed);
            HotKeyS.RegstrerHotkey((HotKeyS.KeyModifer)cutModKeyI, (Keys)cutKeyI, CutScreenShotPressed);
            HotKeyS.RegstrerHotkey((HotKeyS.KeyModifer)windModKeyI, (Keys)windKeyI, WindScreenShotPressed);
        }
        int toint(string s)
        {
            return Convert.ToInt32(s);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TakeAreaWindows s = new TakeAreaWindows();
            s.ShowDialog();
            Rectangle r = s.ReturnRectangle;
            this.Text = String.Format("x = {0},y = {1},width = {2},height{3}", r.X, r.Y, r.Width, r.Height); 
            SH.ScreenShot();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // SH_Settings shh = new SH_Settings();
           // sh.ScreenShotCurrentWindow(shh);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitHotkeys();
        }

        private void screenShotBtn_Click(object sender, EventArgs e)
        {
            FormOut();
            SH.ScreenShot(Settings.GetSH_Settings(), new Shot_Setting());
            pictureBox.Image = SH.LastImage;
            FormIn();
        }

        public void FormOut()
        {
            if (Settings.GetValue("HideInShot", "true") == "false")
                return;
            if (WindowState == FormWindowState.Minimized)
                return;
            pos = (this.Location.X == -500.0 && this.Location.Y == -500.0) ? pos : this.Location;
            this.Location = new Point(-500, -500);
            moved = true;
        }
        public void FormIn()
        {
            if (!moved)
                return;
            this.Location = pos;
            moved = false;
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (!SH.ScreenShotDoing)
            {
                FormOut();
                TakeAreaWindows t = new TakeAreaWindows();
                SH.ScreenShotDoing = true;
                t.ShowDialog();
                SH.ScreenShot(Settings.GetSH_Settings(), new Shot_Setting(Screen.PrimaryScreen, t.ReturnRectangle.Size, t.ReturnRectangle.Location));
                pictureBox.Image = (SH.LastImage != null) ? SH.LastImage : pictureBox.Image;
                this.Visible = true;
                FormIn();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
     
        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExtractResource(string resName, string fName)
        {
            object ob = Properties.Resources.ResourceManager.GetObject(resName, originalCulture);
            byte[] myResBytes = (byte[])ob;
            using (FileStream fsDst = new FileStream(fName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] bytes = myResBytes;
                fsDst.Write(bytes, 0, bytes.Length);
                fsDst.Close();
                fsDst.Dispose();
            }
        }
        
        private void showLastImgChBox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showLastImgChBox.Checked;
            if (check)
                this.Size = this.MaximumSize;
            else
                this.Size = this.MinimumSize;
            Settings.AddSettings("FormSize", ((check) ? "Maximum" : "Minimum"));
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (Size == MinimumSize)
                return;
            if (WindowState == FormWindowState.Minimized)
                return;
            Point p = Location;
            Size screen = Screen.PrimaryScreen.Bounds.Size;
            if (Size.Height + Location.Y > screen.Height)
                p.Y = Screen.PrimaryScreen.Bounds.Height - Size.Height;
            if((Size.Width + Location.X > screen.Width))
                p.X = screen.Width - Size.Width;
            if(Location.X < 0)
                p.X = 0;
            Location = p;
        }

        private void pictureBox_Click_1(object sender, EventArgs e)
        {
            if (SH.LastImage == null)
                return;
            FImage fim = new FImage(pictureBox.Image);
            fim.ShowDialog();
            
        }

        private void showProp_Click(object sender, EventArgs e)
        {
            AppProperties.ShowProperties(SH.LastPath);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            HotKeyS.Update(m);
        }

        private void FullScreenShotPressed(object sender,EventArgs e)
        {
            screenShotBtn_Click(sender, e);
        }
        private void CutScreenShotPressed(object sender, EventArgs e)
        {
            pictureBox_Click(sender,e);
        }
        private void WindScreenShotPressed(object sender, EventArgs e)
        {
            if(Handle != SH.GetForegroundWindow())
                FormOut();
            SH.ScreenShotCurrentWindow(Settings.GetSH_Settings());
            pictureBox.Image = (SH.LastImage != null) ? SH.LastImage : pictureBox.Image;
            FormIn();
        }

        private void открытьВPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SH.LastPath == null)
                return;
            try
            {
                System.Diagnostics.ProcessStartInfo procInfo = new System.Diagnostics.ProcessStartInfo();
                procInfo.FileName = ("mspaint.exe");
                procInfo.Arguments = SH.LastPath; // Полный путь к изображению
                System.Diagnostics.Process.Start(procInfo);
            }
            catch { }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SH.LastPath == null)
                return;
            try
            {
                System.Diagnostics.Process.Start(SH.LastPath);
            }
            catch { }
        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SH.LastImage == null)
                return;
            Clipboard.SetImage(SH.LastImage);
        }

        private void путьКФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SH.LastPath == null)
                return;
            Clipboard.SetText(SH.LastPath);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SH.LastPath == null)
                return;
            StringCollection col = new StringCollection();
            col.Add(SH.LastPath);
            Clipboard.SetFileDropList(col);
        }

        private void UploadImageTSMI_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(delegate() { Helper.PostToImgur(new Bitmap(SH.LastImage)); });
            t.ApartmentState = ApartmentState.STA;
            t.Start();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void settingsMenu_Click(object sender, EventArgs e)
        {
            FSettings set = new FSettings();
            set.FormClosing += set_FormClosing;
            set.ShowDialog();
        }

        void set_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitSettings();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.GetValue("DoOnClose", "1") == "1" && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                ExitApp();
            }
        }

        private  void ExitApp(bool exit = false)
        {
            HotKeyS.UnregisterAll();
            notifyIcon.Dispose();
            if (exit)
                Application.Exit();
        }

        private void показатьПоследнийСкриншотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SH.LastImage == null)
                return;

            FImage fim = new FImage(SH.LastImage);
            fim.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            settingsMenu_Click(sender, e);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp(true);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            оПрограммеToolStripMenuItem_Click(sender, e);
        }

        private void функцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsMenu_Click(sender, e);
        }


        private void MainForm_Move(object sender, EventArgs e)
        {
            //  прилипало
            if (!SH.ScreenShotDoing && moved)
            {
                int leapdist = 15;
                if (this.Left < leapdist)
                {
                    this.Left = 0;
                }
                if (this.Top < leapdist)
                {
                    this.Top = 0;
                }
                Size scr = Screen.PrimaryScreen.Bounds.Size;
                if (scr.Width - this.Location.X < leapdist + this.Width)
                {
                    this.Location = new Point(scr.Width - this.Width, this.Location.Y);
                }
                if (scr.Height - this.Location.Y < leapdist + this.Height)
                {
                    this.Location = new Point(this.Location.X, scr.Height - this.Height);

                }
            }

        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            string on2click = Settings.GetValue("On2ClickNotify", "MakeSS");
            switch(on2click)
            {
                case "MakeSS":
                    screenShotBtn_Click(null, null);
                    break;
                case "Exit":
                    ExitApp(true);
                    break;
                case "MakeSSAndUpload":
                    screenShotBtn_Click(null, null);
                    UploadImageTSMI_Click(null, null);
                    break;
            }
        }

        private void получитьСсылкуНаПоследнийСкриншотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SH.LastImage != null)
            UploadImageTSMI_Click(null, null);
        }

        private void qRкодНаСсылкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SH.LastImageUrl))
            {
                QRCodeGenerator qrCodeGen = new QRCodeGenerator();
                var code = qrCodeGen.CreateQrCode(SH.LastImageUrl, QRCodeGenerator.ECCLevel.Q);

                var img = code.GetGraphic(20, Color.Black, Color.White);
                FImage fim = new FImage(img);
                fim.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ссылка на изображение еще не получена. ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
   
}
