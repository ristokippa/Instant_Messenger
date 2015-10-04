using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //for Mr. Marshal
using System.Threading;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {

            Classes.Server ServerSide = new Classes.Server(5, 4);
            Classes.TextEdit TextEdit = new Classes.TextEdit();
            Thread blinkThread = new Thread(TextEdit.BlinkText);

            string blinking_text = "Waiting for connections with ServerSide.";
            blinkThread.Start(blinking_text);
            ServerSide.PrintStuff("Server started.");
            // IpRequest returns local PC-s IPaddress
            string ip = ServerSide.IpRequest();
            string port = "10000";
            ServerSide.IsConnected(ip, Convert.ToInt32(port));

            //Console.WriteLine(Marshal.SizeOf(uus));   //Cannot use it. Solution: http://stackoverflow.com/questions/19408424/why-cant-i-do-marshal-sizeof-for-this-c-sharp-struct
            //ServerSide.PrintStuff("Waiting for (another) connection.");
            Console.Read();

        }
    }
}
