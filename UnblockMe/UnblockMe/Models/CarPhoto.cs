using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnblockMe.Models
{
    public partial class CarPhoto
    {
        public string PhotoId { get; set; }

        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }

        public Car Car { get; set; }
    }
}
