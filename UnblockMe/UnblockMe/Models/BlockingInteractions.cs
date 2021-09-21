using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class BlockingInteractions
    {
        public string Id { get; set; }
        public string Stuck { get; set; }
        public string BlockedBy { get; set; }
        public DateTime InteractionTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
