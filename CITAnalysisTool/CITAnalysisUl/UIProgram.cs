// author: shivavandana

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dev1;

namespace Dev1Forms
{
    static class UIProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CIT_UI());
        }
    }
}
