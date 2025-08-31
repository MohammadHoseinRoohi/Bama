using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;
using Practice4.Entities.CarAdvertisements;

namespace Practice4.Entities.HeavyVehicleAdvertisings
{
    public class HeavyVehicleAdvertising : Thing
    {
        // کاربر
        public required User User { get; set; }
        // ماشین سنگین
        public required HeavyVehicle HeavyVehicle { get; set; }
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