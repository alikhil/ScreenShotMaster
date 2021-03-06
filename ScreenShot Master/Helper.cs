﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Resources;
using System.IO;
using System.Drawing;
using System.Net;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using SreenShotClass;
namespace ScreenShot_Master
{
    public static class ResourceExtensions
    {
        public static MemoryStream GetMemoryStream(this ResourceManager resourceManager, String name)
        {
            object resource = resourceManager.GetObject(name);

            if (resource is byte[])
            {
                return new MemoryStream((byte[])resource);
            }
            else
            {
                throw new System.InvalidCastException("The specified resource is not a binary resource.");
            }
        }
    }
    static class Helper
    {
        public static bool IsNotNullOrEmpty(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }
        public  const string IMGUR_API_KEY = "3d5907509d22a3130787a91bbb3c9189";
        public static ImageFormat ConvertStringToImageFormat(string img)
        {
            switch(img.ToLower())
            {
                case AppConsts.PNG :
                    return ImageFormat.Png;
                case "jpg" :
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "bmp" :
                    return ImageFormat.Bmp;
                default :
                    return ImageFormat.Png;
            }
        }
        public static bool PostToImgur(Bitmap bitmap)
        {
            if (bitmap == null)
                return false;
            try
            {
                MemoryStream memoryStream = new MemoryStream();

                using (var w = new WebClient())
                {
                    bitmap.Save(memoryStream, Settings.GetSH_Settings().ImageFormat);

                    var values = new NameValueCollection
				{
					{ "key", IMGUR_API_KEY },
					{ "image", Convert.ToBase64String(memoryStream.ToArray()) }
				};
                    string debug = values.ToString();
                    byte[] response = w.UploadValues("http://imgur.com/api/upload.xml", values);
                    XDocument xDocument = XDocument.Load(new MemoryStream(response));

                    string ans = (string)xDocument.Root.Element("original_image");
                   
                    Clipboard.SetText(ans);
                    SH.LastImageUrl = ans;
                    return true;
                }
            }
            catch
            {
                return false;
            }



        }
    }

    public static class AppProperties
    {
        [StructLayout(LayoutKind.Sequential)]
        public  class SHELLEXECUTEINFO
        {
            public int cbSize;
            public int fMask;
            public int hwnd;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpDirectory;
            public int nShow;
            public int hInstApp;
            public int lpIDList;
            public string lpClass;
            public int hkeyClass;
            public int dwHotKey;
            public int hIcon;
            public int hProcess;
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Auto)]
        public static extern int ShellExecuteEx(SHELLEXECUTEINFO shinfo);
        private const int SW_SHOW = 5;
        private const int SEE_MASK_INVOKEIDLIST = 0x0C;

        public static void ShowProperties(string path)
        {
            SHELLEXECUTEINFO shInfo = new SHELLEXECUTEINFO();
            shInfo.cbSize = Marshal.SizeOf(typeof(SHELLEXECUTEINFO));
            shInfo.lpFile = path;
            shInfo.nShow = SW_SHOW;
            shInfo.fMask = SEE_MASK_INVOKEIDLIST;
            shInfo.lpVerb = "properties";
            ShellExecuteEx(shInfo);

        }
    }

    public static class AppConsts
    {
        public static string AppName = "ScreenShot Master";

        public static string FullScreenShotModKey = "FullModKey";
        public static string CutScreenShotModKey = "CutModKey";
        public static string WindScreenShotModKey = "WindModKey";

        public static string FullScreenShotKey = "FullKey";
        public static string CutScreenShotKey = "CutKey";
        public static string WindScreenShotKey = "WindKey";

        public static string CopyLastImageUrlModKey = "CopyUrlModKey";
        public static string CopyLastImageUrlKey = "CopyUrlKey";

        public static string SaveFolderPath = "FolderPath";
        public static string ImageFormat = "ImgFormat";

        public static string OnNotifyDoubleClick = "On2ClickNotify";
        public static string FormSize = "FormSize";
        public static string DoOnClose = "DoOnClose";

        public static string TopMost = "TopMost";
        public static string HideInShot = "HideInShot";

        public static string ShowNotifsInTray = "ShowNotifsInTray";
        public static string CopyToClipboardAfterShot = "CopyToClipboardAfterShow";

        public const string PNG = "png";

        public const string MakeScreenShot = "MakeSS";
        public const string Exit = "Exit";
        public const string MakeSSAndUpload = "MakeSSAndUpload";

    }
}
