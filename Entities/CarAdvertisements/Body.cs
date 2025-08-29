using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;
using Practice4.Enums;

namespace Practice4.Entities
{
    public class Body : Thing
    {
        // رنگ بدنه
        public required BodyColor BodyColor { get; set; }
        // وضعیت بدنه
        public required BodyCondition BodyCondition { get; set; }
        // رنگ داخلی
        public required InteriorColor InteriorColor { get; set; }
    }
}