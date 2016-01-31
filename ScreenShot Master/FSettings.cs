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
            ScreenshotSavePathTBox.Text = Settings.GetValue(AppConsts.SaveFolderPath);
            ImageFormatCBox.Text = ImageFormatCBox.Items[ImageFormatCBox.Items.IndexOf(Settings.GetValue(AppConsts.ImageFormat, AppConsts.PNG).ToUpper())].ToString().ToUpper();

            HideAppOnShotCheckBox.Checked = Settings.GetValue(AppConsts.HideInShot, true);
            AppTopMostCheckBox.Checked = Settings.GetValue(AppConsts.TopMost, true);

            this.TopMost = AppTopMostCheckBox.Checked;

            ShowNotificationsOnTrayCheckBox.Text = Convert.ToString(ShowNotificationsOnTrayCheckBox.Items[Convert.ToInt32(Settings.GetValue(AppConsts.ShowNotifsInTray,"0"))]);
            ActionOnCloseCBox.Text = Convert.ToString(ActionOnCloseCBox.Items[Convert.ToInt32(Settings.GetValue(AppConsts.DoOnClose,"1"))]);
            RunAppOnWindowsStartCHeckBox.Checked = getFromReg();

            CopyToClipboardAfterShotCheckbox.Checked = Settings.GetValue(AppConsts.CopyToClipboardAfterShot, false);

            string on2click = Settings.GetValue(AppConsts.OnNotifyDoubleClick, AppConsts.MakeScreenShot);

            switch(on2click)
            {
                case AppConsts.MakeScreenShot:
                    On2ClickNotifyCMbox.Text = Convert.ToString(On2ClickNotifyCMbox.Items[0]);
                    break;
                case AppConsts.Exit:
                    On2ClickNotifyCMbox.Text = Convert.ToString(On2ClickNotifyCMbox.Items[2]);
                    break;
                case AppConsts.MakeSSAndUpload:
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

            string fullModKey = "0", cutModKey = "2", windModKey = "1", copyLastUrlModKey = "1";
            string fullKKey = Keys.PrintScreen.GetHashCode().ToString();
            string cutKey = fullKKey, windKey = fullKKey, copyLastUrlKey = Keys.F3.GetHashCode().ToString(); ;

            fullModKey = Settings.GetValue(AppConsts.FullScreenShotModKey, fullModKey);
            cutModKey = Settings.GetValue(AppConsts.CutScreenShotModKey, cutModKey);
            windModKey = Settings.GetValue(AppConsts.WindScreenShotModKey, windModKey);

            windKey = Settings.GetValue(AppConsts.WindScreenShotKey, windKey);
            cutKey = Settings.GetValue(AppConsts.CutScreenShotKey, cutKey);
            fullKKey = Settings.GetValue(AppConsts.FullScreenShotKey, fullKKey);

            int copyLastUrlModKey_ = toint(Settings.GetValue(AppConsts.CopyLastImageUrlModKey, copyLastUrlModKey));
            int copyLastUrlKey_ = toint(Settings.GetValue(AppConsts.CopyLastImageUrlKey, copyLastUrlKey));

            HotKeyS.KeyModifer fullModKeyI = (HotKeyS.KeyModifer)toint(fullModKey);
            HotKeyS.KeyModifer cutModKeyI = (HotKeyS.KeyModifer)toint(cutModKey);
            HotKeyS.KeyModifer windModKeyI = (HotKeyS.KeyModifer)toint(windModKey);
            HotKeyS.KeyModifer copyImageUrlModKeyI = (HotKeyS.KeyModifer)copyLastUrlModKey_;

            Keys cutKeyI = (Keys)toint(cutKey);
            Keys fullKeyI = (Keys)toint(fullKKey);
            Keys windKeyI = (Keys)toint(windKey);
            Keys lastUrlKeyI = (Keys)copyLastUrlKey_;

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
                Settings.EditKey(AppConsts.SaveFolderPath, folderBrowserDialog1.SelectedPath);
                ScreenshotSavePathTBox.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void topMostChBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = AppTopMostCheckBox.Checked;
            Settings.EditKey(AppConsts.TopMost, TopMost.ToString());
        }

        private void hideAppInScreenShotChBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.EditKey(AppConsts.HideInShot, HideAppOnShotCheckBox.Checked.ToString());
        }

        private void imageFormatComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ImageFormatCBox.SelectedIndex;
            Settings.EditKey(AppConsts.ImageFormat, ImageFormatCBox.Items[index].ToString());
        }

        private void showNotifsInTrayComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ShowNotificationsOnTrayCheckBox.SelectedIndex;
            Settings.EditKey(AppConsts.ShowNotifsInTray, index.ToString());
        }

        private void doOnCloseComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ActionOnCloseCBox.SelectedIndex;
            Settings.EditKey(AppConsts.DoOnClose, index.ToString());
        }
        private bool getFromReg()
        {
            bool ans = true;
            string key = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", AppConsts.AppName, "not exist").ToString();
            if (key == "not exist") ans = false;
            return ans;
        }
        private void runInWinLoadChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RunAppOnWindowsStartCHeckBox.Checked)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", AppConsts.AppName, Application.ExecutablePath);
            }

            else
            {
                string keyName = @"Software\Microsoft\Windows\CurrentVersion\Run";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (key != null)
                        key.DeleteValue(AppConsts.AppName);
                    
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            HotKeyS.KeyModifer modif;
            Enum.TryParse<HotKeyS.KeyModifer>(activeMod.SelectedValue.ToString(), out modif);
            Settings.EditKey(AppConsts.WindScreenShotModKey, tostr((int)modif));
        }

        private void fullMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            HotKeyS.KeyModifer modif;
            Enum.TryParse<HotKeyS.KeyModifer>(fullMod.SelectedValue.ToString(), out modif);
            Settings.EditKey(AppConsts.FullScreenShotModKey, tostr((int)modif));
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
            Settings.EditKey(AppConsts.WindScreenShotKey, tostr(key.GetHashCode()));
        }

        private void rectKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            Keys key;
            Enum.TryParse<Keys>(rectKey.SelectedValue.ToString(), out key);
            Settings.EditKey(AppConsts.CutScreenShotKey, tostr(key.GetHashCode()));
        }

        private void rectMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
                return;
            HotKeyS.KeyModifer modif;
            Enum.TryParse<HotKeyS.KeyModifer>(rectMod.SelectedValue.ToString(), out modif);
            Settings.EditKey(AppConsts.CutScreenShotModKey, tostr((int)modif));
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
            Settings.EditKey(AppConsts.FullScreenShotKey, tostr(key.GetHashCode()));
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
                    Settings.EditKey(AppConsts.OnNotifyDoubleClick, AppConsts.MakeScreenShot);
                    break;
                case 2:
                    Settings.EditKey(AppConsts.OnNotifyDoubleClick, AppConsts.Exit);
                    break;
                case 1:
                    Settings.EditKey(AppConsts.OnNotifyDoubleClick, AppConsts.MakeSSAndUpload);
                    break;
            }
        }

        private void CopyToClipboardAfterShotCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.EditKey(AppConsts.CopyToClipboardAfterShot, CopyToClipboardAfterShotCheckbox.Checked.ToString());
        }
    }
}
