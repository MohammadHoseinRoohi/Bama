using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.DTOs.Motors
{
    public class MotorUpdateDto
    {
        // برند 
        public string? Brand { get; set; }
        // مدل
        public string? Madel { get; set; }
        // سال
        public double? Year { get; set; }
        // نوع سوخت
        public string? FuelYype { get; set; }
        // گیربکس
        public string? Gearbox { get; set; }
        // کارکرد
        public string? Mileage { get; set; }
        // رنگ بدنه
        public string? BodyColor { get; set; }
    }
}