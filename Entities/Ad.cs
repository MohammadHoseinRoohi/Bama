using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Ad : Thing
    {
        // ماشین
        public required Car Car { get; set; }
        // قیمت
        public required Price Price { get; set; }
        // توضیحات
        public required Description Description { get; set; }
        // محل بازدید
        public required string PlaceOfVisit { get; set; }

        // عملیات بارگزاری عکس با فرانت است با بک و اینکه چطور باید در دیتابیس ذخیره شود؟
    }
}