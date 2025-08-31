using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;

namespace Practice4.Entities
{
    public class VisitLocation : Thing
    {
        // استان 
        public required string Province { get; set; }
        // شهر
        public required string City { get; set; }
        // منطقه 
        public string? Region { get; set; }
    }
}