using System;
using System.Collections.Generic;
using System.Text;

namespace RidesUpdater.Models
{
    public class WaitTime
    {
        public Fastpass FastPass { get; set; }
        public string Status { get; set; }
        public bool SingleRider { get; set; }
        public int PostedWaitMinutes { get; set; }
        public string RollUpStatus { get; set; }
        public string RollUpWaitTimeMessage { get; set; }
    }
}
