using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.Entities
{
    // استعلام خلافی خودرو؟؟؟
    public class VehicleViolationInquiry
    {
        // پلاک ماشین
        public required string LicensePlate { get; set; }
        // کد ملی
        public double NationalCode { get; set; }
        // شماره تماس
        public double PhoneNumber { get; set; }
    }
}