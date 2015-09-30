using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

            // 192.168.43.254/183
            //System.Net.IPAddress address = System.Net.IPAddress.Parse("");

            /*System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse("217.71.44.163");
            System.Net.IPEndPoint ipEndPoint = new System.Net.IPEndPoint(ipAddress, 10000);
            clientSocket.Connect(ipEndPoint);*/
            Application.Run(new Form1());

        } 
    }
}
