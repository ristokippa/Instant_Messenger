using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerSide.Classes
{

    public class TextEdit
    {
        private volatile bool _blinkStop;
        // This method will be called through threading. 
        public void BlinkText(object blinking_text)
        {
            int i = 0;
            while (!_blinkStop)
            {
                //Console.WriteLine("lol");
                if (i % 2 == 0)
                {
                    Console.Write("[{0}]\t\t\t\t\t\t\t\r", DateTime.Now);
                    Thread.Sleep(500); 
                    i = i + 1;
                }

                else
                {
                    Console.Write("[{0}]\t" + blinking_text + "\r", DateTime.Now);
                    Thread.Sleep(500); 
                    i = i + 1;
                }
            }
        }


        public void BlinkStop()
        {
            _blinkStop = true;
        }
        // Volatile is used as hint to the compiler that this data 
        // member will be accessed by multiple threads. 
    }
}
