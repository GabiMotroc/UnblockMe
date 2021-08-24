using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.ViewModels
{
    public class BlockUserViewModel
    {

        public BlockUserViewModel()
        {
            Bans = new List<BlockedUsers>();
        }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Duration { get; set; }
        public List<BlockedUsers> Bans { get; set; }
    }
}
