using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieHub
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        internal static loginForm main;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new loginForm();
            Application.Run(main);
        }
    }
}
