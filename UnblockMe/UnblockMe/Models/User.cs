using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class User : IdentityUser
    {
        public User()
        {
            Car = new HashSet<Car>();
        }
        [PersonalData]
        [Column(TypeName = "nvarchar(40)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(40)")]
        public string LastName { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}
