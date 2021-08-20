﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class BlockedUsers
    {
        //public BlockedUsers()
        //{
        //    Id = new Guid();
        //}
        public Guid Id { get; set; }
        public string BlockedId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public string Reason { get; set; }

        public virtual User User { get; set; }
    }
}