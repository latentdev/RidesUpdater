using System;
using System.Timers;

namespace RidesUpdater
{
    public class Updater
    {
        private Timer _timer;
        private int _lastMinute;
        private string _debug;


        public Updater()
        {
            _timer = new Timer(1000);
            _lastMinute = DateTime.Now.Minute;
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _timer.Start();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            int currentTime = DateTime.Now.Minute;
            if (currentTime % 5 == 0)
            {
                if (_lastMinute < DateTime.Now.Minute)
                {
                    _lastMinute = DateTime.Now.Minute;
                    Console.WriteLine(DateTime.Now);
                    //YourImportantMethod(); // Call The method with your important staff..
                }
            }

        }
    }
}
