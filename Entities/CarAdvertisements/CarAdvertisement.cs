using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities.CarAdvertisements
{
    public class CarAdvertisement : Thing
    {
        // کاربر
        public required User User { get; set; }
        // ماشین
        public required Car Car { get; set; }
        // قیمت
        public Price? Price { get; set; }
        // آدرس عکس یا ویدیو
        public string? PictureOrVideo { get; set; }
        // محل بازدید
        public required VisitLocation VisitLocation { get; set; }
        // منطقه آزاد
        public bool FreeRegion { get; set; }
        // توضیحات
        public string? Description { get; set; }
    }
}