using System;
using System.Media;
using System.IO;
using System.Globalization;
using System.Dynamic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.Specialized;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.Windows.Forms.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.IO.Compression;
using System.Text.RegularExpressions;

using ScreenShot_Master;
namespace SreenShotClass
{
    public class SH
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        public Image LastImage;
        public string LastPath;

        public bool ScreenShotDoing { get; set; }
        /// <summary>
        /// Makes Fullscreen shot
        /// </summary>
        public void ScreenShot()
        {
            ScreenShotDoing = true;
            SH_Settings settings = new SH_Settings();
            Shot_Setting shotSet = new Shot_Setting();
            ScreenShot(settings, shotSet);
            ScreenShotDoing = false;
        }
        public void ScreenShot(SH_Settings settings, Shot_Setting shotSet)
        {
            ScreenShotDoing = true;
            if (shotSet.Size == Size.Empty)
                return;
            Bitmap printscreen = new Bitmap(shotSet.Size.Width, shotSet.Size.Height);   //создаём картинку сзаданным размером
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(shotSet.StartPoint, new Point(0, 0), shotSet.Size);
            if (!Directory.Exists(settings.FolderPath)) Directory.CreateDirectory(settings.FolderPath); //если папка ScreenShots не существует то создаём
            string fileName = String.Format("{0:MM.dd.yyyy}_{0:HH.mm.ss}", DateTime.Now);
            //string lpath = settings.FolderPath + fileName;
            string lpath = settings.FolderPath + fileName + '.' + settings.ImageFormat.ToString();
            LastPath = lpath;
            LastImage = printscreen as Image;
            printscreen.Save(lpath, settings.ImageFormat);  //сохраняем картинку
            //MainForm.ActiveForm.Visible = true;
            ScreenShotDoing = false;
        }
        public void ScreenShot(string filepath, ImageFormat imf, Size size, Point startPoint, Screen screen)
        {
            SH_Settings settings = new SH_Settings(filepath, imf);
            Shot_Setting shotSet = new Shot_Setting(screen, size, startPoint);
            ScreenShot(settings, shotSet);
        }
        public void ScreenShotCurrentWindow(SH_Settings settings)
        {
            IntPtr handle = GetForegroundWindow();
            RECT rect = new RECT();

            GetWindowRect(handle, ref rect);
            Size size = new Size(rect.Right - rect.Left,
                               rect.Bottom - rect.Top);
            Point p = new Point(rect.Left, rect.Top);
            Screen sc = Screen.FromPoint(p);
            Shot_Setting shotSet = new Shot_Setting(sc, size, p);
            ScreenShot(settings, shotSet);
        }
    }     
   
}
