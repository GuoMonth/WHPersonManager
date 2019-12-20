using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WPMClient.SysModule;

namespace WPMClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartUp startUp = new StartUp();
            startUp.Run();
        }
    }
}
