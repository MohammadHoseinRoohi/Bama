using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;
using Practice4.Enums;

namespace Practice4.Entities
{
    public class InstallmentSales : Thing
    {
        // مبلغ اقساط
        public double AmountInstallments { get; set; }
        // پیش پرداخت
        public double AdvancePayment { get; set; }
        // پیش پرداخت دوم
        // public double? SecondDownPayment { get; set; }
        public double SecondDownPayment { get; set; }
        // تعداد اقساط
        public required NumberOfInstallments NumberOfInstallments { get; set; }
        // زمان تحویل
        public required DeliveryTime DeliveryTime { get; set; }
        // موعد پرداخت
        public required PaymentDue PaymentDue { get; set; }
    }
}