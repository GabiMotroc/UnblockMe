using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class UserActivity
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Data { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public DateTime ActivityTime { get; set; } = DateTime.UtcNow;
    }
}
