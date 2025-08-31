using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;
using Practice4.Entities.CarAdvertisements;

namespace Practice4.Entities.HeavyVehicleAdvertisings
{
    public class HeavyVehicle : Thing
    {
        // نوع کاربری
        public string? UserYype { get; set; }
        // زیر دسته کاربری
        public string? UserSubcategory { get; set; }
        // برند 
        public required string Brand { get; set; }
        // مدل
        public string? Madel { get; set; }
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
        // گیربکس
        public string? Gearbox { get; set; }
        // سابقه تعمیر دارد یا ندارد
        public bool? RepairHistory { get; set; }
        // ساعت کارکرد
        public string? OperatingHours { get; set; }
    }
}