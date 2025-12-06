using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.DTOs.HeavyVehicles
{
    public class HeavyVehicleUpdateDto
    {
        // نوع کاربری
        public string? UserYype { get; set; }
        // زیر دسته کاربری
        public string? UserSubcategory { get; set; }
        // برند 
        public string? Brand { get; set; }
        // مدل
        public string? Madel { get; set; }
        // سال
        public double? Year { get; set; }
        // تیپ خودرو
        public string? VehicleType { get; set; }
        // کارکرد
        public required string Mileage { get; set; }
        // وضعیت بدنه
        public string? BodyCondition { get; set; }
        // رنگ بدنه
        public string? BodyColor { get; set; }
        // گیربکس
        public string? Gearbox { get; set; }
        // سابقه تعمیر دارد یا ندارد
        public bool RepairHistory { get; set; }
        // ساعت کارکرد
        public string? OperatingHours { get; set; }
    }
}