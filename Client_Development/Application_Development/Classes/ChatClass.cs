using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Application_Development.Classes
{
    class ChatClass
    {
        // Constructor
        public ChatClass()
        {

        }

        public void GetMachineIP()
        {
            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            string ExternalIP = IPHost.AddressList[0].ToString();
            string SecondIP = IPHost.AddressList[1].ToString();
            GlobalsSecond.IPAddress[0] = ExternalIP;
            GlobalsSecond.IPAddress[1] = SecondIP;
        }
    }
}
