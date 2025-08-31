using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities.CarAdvertisements
{
    public class Installments : Thing
    {
        // مبلغ اقساط 
        public double InstallmentAmount { get; set; }
        // پیش پرداخت
        public double DownPayment { get; set; }
        // پیش پرداخت دوم (اختیاری)
        public double? SecondDownPayment { get; set; }
        //تعداد اقساط
        public required string NumberOfInstallments { get; set; }
        // زمان تحویل
        public required string DeliveryTime { get; set; }
        // موعد پرداخت
        public required string PaymentDate { get; set; }
    }
}