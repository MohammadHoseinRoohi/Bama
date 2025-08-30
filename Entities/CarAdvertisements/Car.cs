using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities.CarAdvertisements
{
    public class Car : Thing
    {
        // برند 
        public required string Brand { get; set; }
        // مدل
        public required string Madel { get; set; }
        // سال
        public double Year { get; set; }
        // تیپ خودرو
        public required string VehicleType { get; set; }
        // کارکرد
        public required string Mileage { get; set; }
        // وضعیت بدنه
        public required string BodyCondition { get; set; }
        // رنگ بدنه
        public required string BodyColor { get; set; }
        // رنگ داخلی
        public required string InteriorColor { get; set; }
    }
}