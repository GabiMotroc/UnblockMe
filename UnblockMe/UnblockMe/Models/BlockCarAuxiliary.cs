using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class BlockCarAuxiliary
    {
        public BlockCarAuxiliary(List<string> OwnCars, string OtherCar)
        {
            this.OwnCars = OwnCars;
            this.OtherCar = OtherCar;
        }
        public List<string> OwnCars { get; set; }
        public string OtherCar { get; set; } 
    }
}
