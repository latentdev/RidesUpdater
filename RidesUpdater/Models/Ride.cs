using System;
using System.Collections.Generic;
using System.Text;

namespace RidesUpdater.Models
{
    public class Ride
    {
        public object Links { get; set; }
        public object Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public WaitTime WaitTime { get; set; }
    }
}
