using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class Car
    {
        private string _licencePlate;
        private string _blockedBy;
        private string _blocks;
        public string LicencePlate 
        {
            get => _licencePlate;
            set
            {
                this._licencePlate = value.Replace(" ", "").ToLower(); 
            }  
        }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string BockedBy 
        {
            get => _blockedBy;
            set
            {
                if(value != null)
                    this._blockedBy = value.Replace(" ", "").ToLower();
            }
        }
        public string Blocks 
        {
            get => _blocks;
            set
            {
                if (value != null)  
                    this._blocks = value.Replace(" ", "").ToLower();
            }
        }
        public int OwnerId { get; set; }

        public virtual User Owner { get; set; }
    }
}
