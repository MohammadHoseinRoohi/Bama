using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Exhibition : Thing
    {
        // نوع نمایشگاه
        public required string ExhibitionType { get; set; }
        //نام نمایشگاه
        public required string ExhibitionName { get; set; }
        // نام شما
        public required string YourName { get; set; }
        // نام مدیر
        public required string OwnerName { get; set; }
        // شماره تلفن
        public double PhoneNumber { get; set; }
        // استان 
        public required string Province { get; set; }
        // تلفن ثابت
        public double Landline { get; set; }
        // ایمیل
        public required string Email { get; set; }
        // آدرس
        public required string Address { get; set; }
        // توضیحات
        public string? Description { get; set; }
    }
}