using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.DTOs.Motors
{
    public class MotorAddDto
    {
        // برند 
        public required string Brand { get; set; }
        // مدل
        public required string Madel { get; set; }
        // سال
        public double Year { get; set; }
        // نوع سوخت
        public required string FuelYype { get; set; }
        // گیربکس
        public required string Gearbox { get; set; }
        // کارکرد
        public required string Mileage { get; set; }
        // رنگ بدنه
        public required string BodyColor { get; set; }
    }
}