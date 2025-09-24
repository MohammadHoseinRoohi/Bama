using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.DTOs.Exhibitions
{
    public class ExhibitionUpdateDto
    {
        // نام مدیر
        public  string? OwnerName { get; set; }
        // شماره تلفن
        public double PhoneNumber { get; set; }
        // ایمیل
        public  string? Email { get; set; }
        // آدرس
        public  string? Address { get; set; }
        // توضیحات
        public string? Description { get; set; }
    }
}