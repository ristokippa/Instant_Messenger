using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Application_Development.Classes
{
    // This is the class that holds the information about the event.
    // In this case it will hold only information available in the clock
    // class, but could hold additional state information.
    public class TimeInfoEventArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }

    // EVENT PUBLISHER CLASS.
    // The class that other classes will observe. This class publishes one delegate:
    // "SecondChanged".
    public class TimerClass
    {
        private int hour;
        private int minute;
        private int second;

        // The delegate the subscribers must implement
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);

        // An instance of the delegate with event keyword added
        public event SecondChangeHandler SecondChanged;

        // This function will raise an EVENT every one seconds
        public void RunClock()
        {
            // Endless loop
            for(;;)
            {
                Thread.Sleep(100);

                // Get the current time
                System.DateTime dt = System.DateTime.Now;

                // If the second has changed notify the subscribers
                if(dt.Second != second)
                {
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // If anyone has subscribed, notify them
                    if(SecondChanged != null)
                    {
                        SecondChanged(this, timeInformation);
                    }
                }

                // Update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
    }

    // SUBSCRIBER: DisplayClock subscribes to the clock's events. The job of
    // DisplayClock is to display the current time.
    public class DisplayClock
    {
        private TextBox _realTimeData;
        public DisplayClock(TextBox realTimeData)
        {
            this._realTimeData = realTimeData;
        }

        public void Subscribe(TimerClass theClock)
        {
            theClock.SecondChanged += new TimerClass.SecondChangeHandler(TimeHasChanged);
        }

        public void TimeHasChanged(object TimerClass, TimeInfoEventArgs ti)
        {
            string timerValue = ti.hour.ToString() + ":" + ti.minute.ToString() + ":" + ti.second.ToString();
            _realTimeData.Invoke((Action)delegate{
                _realTimeData.Text = timerValue;
            });
        }
    }
}
