using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class Description : Thing
    {
        // منطقه آزاد
        public bool FreeZone { get; set; }
        // توضیحات ها 
        public required string Descriptions { get; set; }
    }
}