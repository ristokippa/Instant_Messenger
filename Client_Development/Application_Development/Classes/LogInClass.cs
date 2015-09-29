using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development
{

    class LogInClass
    {
        private string passCode = "";
        private string userName = "";

        // Accessor functions
        public string PassCode
        {
            set { passCode = value; }
        }

        public string UserName
        {
            set { userName = value; }
        }

        private string masterPassCode = "risto";
        private string masterUserName = "david";

        // Constructor
        public LogInClass() 
        { 
        
        }

        // Returns "TRUE" if user enters correct username and passcode
        public bool ValidateUser()
        {
            bool isValidated = (masterUserName.Equals(userName) &&
                masterPassCode.Equals(passCode));
            return isValidated;
        }

        public void RegisterNewUser()
        {
            // To Be Added
        }

        public void RecoverPassCode()
        {
            // To Be Added
        }

    }
}
