using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Mileage : Thing
    {
        // کارکرد = 0
        public bool Zero { get; set; }
        // x = کارکرد
        public bool Mileaged { get; set; }
        // حواله یا پیش فروش
        public bool PreSale { get; set; }

        // چگونه به فروشنده بگیم اگه ماشین کارکرده بود از کیلومتر ماشین رو وارد کن؟ 
    }
}