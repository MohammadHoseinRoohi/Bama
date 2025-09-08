using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.Entities
{
    public class BamaCalculator
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
        // قیمت
        public double? Price { get; set; }
    }
}