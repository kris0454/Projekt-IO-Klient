using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    static class Program
    {
        internal static ApplicationContext appC;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            appC = new ApplicationContext(new Form1()); 
            Application.Run(appC);
        }
    }
}
