using System;

namespace UnblockMe.Services
{
    public class Audit
    {

        //Audit Properties
        public Guid AuditID { get; set; }
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public string AreaAccessed { get; set; }
        public DateTime TimeAccessed { get; set; }

        //Default Constructor
        public Audit() { }
    }
}
