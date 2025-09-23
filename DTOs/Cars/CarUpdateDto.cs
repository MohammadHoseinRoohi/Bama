using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.DTOs.Cars
{
    public class CarUpdateDto
    {
        // کارکرد
        public  string? Mileage { get; set; }
        // وضعیت بدنه
        public  string? BodyCondition { get; set; }
    }
}