using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{

    static class Program
    {
        
        public class Shared
        {
            public static TcpClient client = new TcpClient();
            public static NetworkStream stream;
            public static StreamWriter writer;
            public static StreamReader reader;
        }
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
            Shared.client.Connect(IPAddress.Parse("127.0.0.1"), 2048);
            Shared.stream = Shared.client.GetStream();
            Shared.writer = new StreamWriter(Shared.stream);
            Shared.writer.AutoFlush = true;
            Shared.reader = new StreamReader(Shared.stream);
            Application.Run(appC);
            
        }
    }
}
