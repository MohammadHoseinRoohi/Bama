using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities.CarAdvertisements
{
    public class Price : Thing
    {
        // نقد
        public double? Cash { get; set; }
        // اقساط
        public Installments? Installments { get; set; }

        // چطوری بگیم که یک آگهی میتواند قیمت نداشته باشد اما اگه داشت یا باید نقدی باشه یا اقساطی؟
    }
}