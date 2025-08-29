using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Car : Thing
    {
        // برند
        public required string Brand { get; set; }
        // مدل
        public required string Madel { get; set; }
        // سال
        public required DateTime Year { get; set; }
        // تبپ خودرو
        public required string VehicleType { get; set; }
        // کارکرد
        public required Mileage Mileage { get; set; }
        // بدنه
        public required Body Body { get; set; }
    }
}