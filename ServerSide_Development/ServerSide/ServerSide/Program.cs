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
            Classes.Server uus = new Classes.Server(5, 4);
            uus.PrintStuff("Server started.");
            //string ip = "127.0.0.1";
            //string ip = "192.168.43.183"; //dell
            string ip = "192.168.43.254";   //msi
            Console.WriteLine("Current server IP = " + ip);
            string port = "10000";
            Console.WriteLine("Current target port = " + port);

            uus.IsConnected(ip, Convert.ToInt32(port));
            //Console.WriteLine(Marshal.SizeOf(uus));   //Cannot use it. Solution: http://stackoverflow.com/questions/19408424/why-cant-i-do-marshal-sizeof-for-this-c-sharp-struct
            
            Console.WriteLine("The end");
            Console.Read();

        }
    }
}
