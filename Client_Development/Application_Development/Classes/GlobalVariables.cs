using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development.Classes
{
    // "Global variable class". Use a public static class and access it from anywhere:
    public static class GlobalVariables
    {
        public static string[] IPAddress;
    }

    // 1) Wrap all such Global Variables into a single class (for manageability)
    // 2) Have properties insted of fields (variables). This way you have some mechanisms to
    // address any issues with concurrent writes to Globals in the future.
    public class GlobalsSecond
    {
        private static string[] _IPAddress = new string[5];
        public static string[] IPAddress
        {
            get { return _IPAddress; }
            // You can add logic here for race conditions or other measurements
            set { _IPAddress = value; }
        }
    }
}
