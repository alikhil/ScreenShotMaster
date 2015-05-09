using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
namespace ScreenShot_Master
{
    static class Program
    {
        private static Mutex mut;
        private static Mutex maker;

        /// <summary>
        /// 
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length == 1 && args[0] == "delete")
            {
                Process[] pl = Process.GetProcessesByName("Updater");

                foreach(Process p in pl)
                {
                    p.Kill();
                    p.WaitForExit(1500);
                }
                try
                {
                    File.Delete("Updater.exe");
                }
                catch { }
            }
            bool created = false,makerr;
            mut = new Mutex(true, "SHM",out created);
            maker = new Mutex(true, "NameOfMyApp", out makerr);
            if(!makerr)
            {

                MessageBox.Show("Для правильной работы ScreenShot Master`а закройте ScreenShot Maker!", "Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (created)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
                MessageBox.Show("Приложение ScreenShot Master уже было запущено", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
