using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class User
    {
        public User()
        {
            Car = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NoTelephone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}
