using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //for Mr. Marshal

namespace ServerSide // miks on vaja classes folderit_?
{
    class Program
    {
        static void Main(string[] args)
        {

            Classes.Server ServerSide = new Classes.Server(5, 4);
            // Just for practise

            ServerSide.PrintStuff("\tServer started.");
            // IpRequest returns local PC-s IPaddress
            string ip = ServerSide.IpRequest();
            string port = "10000";
            ServerSide.IsConnected(ip, Convert.ToInt32(port));
            //Console.WriteLine(Marshal.SizeOf(uus));   //Cannot use it. Solution: http://stackoverflow.com/questions/19408424/why-cant-i-do-marshal-sizeof-for-this-c-sharp-struct
            Console.WriteLine("[{0}] Main program finished.", DateTime.Now);
            Console.Read();

        }
    }
}
