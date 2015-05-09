using System.IO;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
namespace ScreenShot_Master
{
    public partial class FSettings : Form
    {
        private bool init = false;
        public FSettings()
        {
            InitializeComponent();
            #region InitHotKeys
            InitHotkeys();
            #endregion
            init = true;
        }

        private void FSettings_Load(object sender, EventArgs e)
        {
            savepathTbox.Text = Settings.GetValue("FolderPath");
            imageFormatComBox.Text = imageFormatComBox.Items[imageFormatComBox.Items.IndexOf(Settings.GetValue("ImageFormat", "PNG").ToUpper())].ToString().ToUpper();
            hideAppInScreenShotChBox.Checked = Convert.ToBoolean(Settings.GetValue("HideInShot", "true"));
            topMostChBox.Checked = Convert.ToBoolean(Settings.GetValue("TopMost","true"));
            this.TopMost = topMostChBox.Checked;
            showNotifsInTrayComBox.Text = Convert.ToString(showNotifsInTrayComBox.Items[Convert.ToInt32(Settings.GetValue("ShowNotifsInTray","0"))]);
            doOnCloseComBox.Text = Convert.ToString(doOnCloseComBox.Items[Convert.ToInt32(Settings.GetValue("DoOnClose","1"))]);
            runInWinLoadChBox.Checked = getFromReg();
            string on2click = Settings.GetValue("On2ClickNotify","MakeSS");

            switch(on2click)
            {
                case "MakeSS":
                    On2ClickNotifyCMbox.Text = Convert.ToString(On2ClickNotifyCMbox.Items[0]);
                    break;
                case "Exit":
                    On2ClickNotifyCMbox.Text = Convert.ToString(On2ClickNotifyCMbox.Items[2]);
                    break;
                case "MakeSSAndUpload":
                    On2ClickNotifyCMbox.Text = Convert.ToString(On2ClickNotifyCMbox.Items[1]);
                    break;

            }
        }

        private void InitHotkeys()
        {

            fullMod.DataSource = Enum.GetValues(typeof(HotKeyS.KeyModifer));
            rectMod.DataSource = Enum.GetValues(typeof(HotKeyS.KeyModifer));
            activeMod.DataSource = Enum.GetValues(typeof(HotKeyS.KeyModifer));
            fullKey.DataSource = Enum.GetValues(typeof(Keys));
            rectKey.DataSource = Enum.GetValues(typeof(Keys));
            activeKey.DataSource = Enum.GetValues(typeof(Keys));

            string fullModKey = "0", cutModKey = "2", windModKey = "1";
            string fullKKey = Keys.PrintScreen.GetHashCode().ToString();
            string cutKey = fullKKey, windKey = fullKKey;

            fullModKey = Settings.GetValue("FullModKey", fullModKey);
            cutModKey = Settings.GetValue("CutModKey", cutModKey);
            windModKey = Settings.GetValue("WindModKey", windModKey);

            windKey = Settings.GetValue("WindKey", windKey);
            cutKey = Settings.GetValue("CutKey", cutKey);
            fullKKey = Settings.GetValue("FullKey", fullKKey);

            HotKeyS.KeyModifer fullModKeyI = (HotKeyS.KeyModifer)toint(fullModKey);
            HotKeyS.KeyModifer cutModKeyI = (HotKeyS.KeyModifer)toint(cutModKey);
            HotKeyS.KeyModifer windModKeyI = (HotKeyS.KeyModifer)toint(windModKey);

            Keys cutKeyI = (Keys)toint(cutKey);
            Keys fullKeyI = (Keys)toint(fullKKey);
            Keys windKeyI = (Keys)toint(windKey);

            fullKey.SelectedItem = fullKeyI;
            rectKey.SelectedItem = cutKeyI;
            activeKey.SelectedItem = windKeyI;
            fullMod.SelectedItem = fullModKeyI;
            rectMod.SelectedItem = cutModKeyI;
            activeMod.SelectedItem = windModKeyI;
        }
        private int toint(string s)
        {
            return Convert.ToInt32(s);
        }
        private void choseSavepathBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if(folderBrowserDialog1.SelectedPath != null && Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                Settings.EditKey("FolderPath", folderBrowserDialog1.SelectedPath);
                savepathTbox.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void topMostChBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topMostChBox.Checked;
            Settings.EditKey("TopMost", TopMost.ToString());
        }

        private void hideAppInScreenShotChBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.EditKey("HideInShot", hideAppInScreenShotChBox.Checked.ToString());
        }

        private void imageFormatComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = imageFormatComBox.SelectedIndex;
            Settings.EditKey("ImageFormat", imageFormatComBox.Items[index].ToString());
        }

        private void showNotifsInTrayComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = showNotifsInTrayComBox.SelectedIndex;
            Settings.EditKey("ShowNotifsInTray", index.ToString());
        }

        private void doOnCloseComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = doOnCloseComBox.SelectedIndex;
            Settings.EditKey("DoOnClose", index.ToString());
        }
        private bool getFromReg()
        {
            bool ans = true;
            string key = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "ScreenShot Master", "not exist").ToString();
            if (key == "not exist") ans = false;
            return ans;
        }
        private void runInWinLoadChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (runInWinLoadChBox.Checked)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "ScreenShot Master", Application.ExecutablePath);
            }

            else
            {
                string keyName = @"Software\Microsoft\Windows\CurrentVersion\Run";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (key != null)
                        key.DeleteValue("ScreenShot Master");
                    
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            HotKeyS.KeyModifer modif;
            Enum.TryParse<HotKeyS.KeyModifer>(activeMod.SelectedValue.ToString(), out modif);
            Settings.EditKey("WindModKey", tostr((int)modif));
        }

        private void fullMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            HotKeyS.KeyModifer modif;
            Enum.TryParse<HotKeyS.KeyModifer>(fullMod.SelectedValue.ToString(), out modif);
            Settings.EditKey("FullModKey", tostr((int)modif));
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void activeKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            Keys key;
            Enum.TryParse<Keys>(activeKey.SelectedValue.ToString(), out key);
            Settings.EditKey("WindKey", tostr(key.GetHashCode()));
        }

        private void rectKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            Keys key;
            Enum.TryParse<Keys>(rectKey.SelectedValue.ToString(), out key);
            Settings.EditKey("CutKey", tostr(key.GetHashCode()));
        }

        private void rectMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            HotKeyS.KeyModifer modif;
            Enum.TryParse<HotKeyS.KeyModifer>(rectMod.SelectedValue.ToString(), out modif);
            Settings.EditKey("CutModKey", tostr((int)modif));
        }
        private string tostr(int y)
        {
            return Convert.ToString(y);
        }

        private void fullKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            Keys key;
            Enum.TryParse<Keys>(fullKey.SelectedValue.ToString(), out key);
            Settings.EditKey("FullKey", tostr(key.GetHashCode()));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void On2ClickNotifyCMbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int on2click = On2ClickNotifyCMbox.SelectedIndex;
            
            switch (on2click)
            {
                case 0:
                    Settings.EditKey("On2ClickNotify", "MakeSS");
                    break;
                case 2:
                    Settings.EditKey("On2ClickNotify", "Exit");
                    break;
                case 1:
                    Settings.EditKey("On2ClickNotify", "MakeSSAndUpload");
                    break;
            }
        }
       
    }
}
