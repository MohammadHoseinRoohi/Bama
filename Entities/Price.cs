using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Price : Thing
    {
        // فروش نقدی
        public double? CashSale { get; set; }
        // فروش اقساطی
        public InstallmentSales? InstallmentSales { get; set; }
    }
}