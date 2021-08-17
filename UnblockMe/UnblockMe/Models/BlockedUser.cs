using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class BlockedUser
    {
        public string Id { get; set; }
        public string StartTime { get; set; }
        public Int64 Penalty { get; set; }
        public string Reason { get; set; }

        public virtual User User { get; set; }
    }
}
