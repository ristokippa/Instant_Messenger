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

        public bool IsConnected(string client_ip, int client_socket)
        {
            try
            {
                Console.WriteLine("Waiting for connection with device (IP: " + client_ip + ", Port: " + client_socket + ")");

                // Uses the GetStream public method to return the NetworkStream.
                System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(client_ip);
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
                Console.WriteLine("WOOT JUST HAPPND?!");
                Console.WriteLine(ex.ToString());
                return false;
            }

        }
        public void PortListener()
        {
            
        }
    }
}

