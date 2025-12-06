using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.DTOs.VisitLocations
{
    public class VisitLocationAddDto
    {
        // استان 
        public required string Province { get; set; }
        // شهر
        public required string City { get; set; }
        // منطقه 
        public string? Region { get; set; }
    }
}