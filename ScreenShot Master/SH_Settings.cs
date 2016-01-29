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
using System.Windows;
using System.Diagnostics;
using System.Windows.Forms.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.IO.Compression;

using System.Threading.Tasks;
namespace SreenShotClass
{
    public class SH_Settings
    {
        public string FolderPath;
        public ImageFormat ImageFormat;
        /// <summary>
        /// Default settings
        /// </summary>
        public SH_Settings()
        {
            FolderPath  = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\ScreenShots";
            Directory.CreateDirectory(FolderPath);
            FolderPath += '\\';
            ImageFormat = ImageFormat.Png;
        }
        /// <summary>
        /// Set settings
        /// </summary>
        /// <param name="path">Screens saving folder name</param>
        /// <param name="imf">Screens saving Image Format</param>
        public SH_Settings(string folderPath,ImageFormat imf)
        {
            FolderPath = folderPath;
            if (!Directory.Exists(FolderPath))
            {
                //throw new InvalidFolderPathException();
                Directory.CreateDirectory(folderPath);
            }
            ImageFormat = imf;
            FolderPath += '\\';

        }
    }
    public class Shot_Setting
    {
        public Size Size;
        public Screen Screen;
        public Point StartPoint;
        public Shot_Setting()
        {
            Screen = Screen.PrimaryScreen;
            Size = Screen.Bounds.Size;
            StartPoint = new Point(0, 0);
        }
        public Shot_Setting(Screen scr,Size size,Point point)
        {
            StartPoint = point;
            Screen = scr;
            Size = size;
        }
    }
}
