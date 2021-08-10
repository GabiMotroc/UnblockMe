using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class Blockeduser
    {
        public string Id { get; set; }
        public string Start { get; set; }
        public string  Stop { get; set; }
        public string Reason { get; set; }
    }
}
