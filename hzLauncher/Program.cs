using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hzLauncher
{
    static class Program
    {
        public static Launcher launcher;
        public static Form monitor_instance;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            monitor_instance = new monitor();
            Application.Run(monitor_instance);
        }
    }
}
