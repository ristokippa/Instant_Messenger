using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;


namespace ServerSide.Classes
{
    class Server
    {
        private int x = 1;
        private int y = 3;

        //Constructor
        public Server(int k, int l)
        {
            x = k;
            y = l;
        }

        public void PrintStuff(string text)
        {
            Console.WriteLine(text);

        }

        public string IpRequest()
        {
            // Getting IP address from local PC
            String strHostName = string.Empty;
            // First get host name from local machine
            strHostName = Dns.GetHostName();
            // Then using host name, get IP address from a list
            Console.WriteLine("[{0}] Local PC's host name: " + strHostName, DateTime.Now);

            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            // Put together the desired IP address
            //for (int i = 0; i < addr.Length; i++)
            //{
            //    //Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            //    //Console.WriteLine("====>" + addr[1]);
            //}
            return addr[1].ToString();
        }

        public bool IsConnected(string server_ip, int client_socket)
        {
            try
            {
                Console.WriteLine("Waiting for connection with device (IP: " + server_ip + ", Port: " + client_socket + ")");

                // Uses the GetStream public method to return the NetworkStream.
                System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(server_ip);
                TcpListener serverSocket = new TcpListener(ipaddress, client_socket);
                serverSocket.Start(); //Initializes TcpListner

                /*default keyword is just setting the object clientSocket to null or default value of a reference type, 
                 * since TcpClient is a class, (a reference type).*/
                TcpClient clientSocket = default(TcpClient);
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Connection with client accepted.");
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////\n");
                Console.WriteLine("EXCEPTION: ");
                Console.WriteLine(ex.ToString() + "\n");
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////");
                return false;
            }

        }

        public void PortListener()
        {
            //Write code for incoming messages
        }


        public void GlobalVariables()
        {
            string IPAddr = "IpReq result";
        }
    }
}