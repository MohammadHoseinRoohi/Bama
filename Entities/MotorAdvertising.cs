using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities.MotorAdvertisings
{
    public class MotorAdvertising : Thing
    {
        // کاربر
        public required User User { get; set; }
        // موتور
        public required Motor Motor { get; set; }
        // قیمت
        public Price? Price { get; set; }
        // آدرس عکس 
        public string? Picture { get; set; }
        // محل بازدید
        public required VisitLocation VisitLocation { get; set; }
        // توضیحات
        public string? Description { get; set; }
    }
}