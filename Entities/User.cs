using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice4.Entities.Base;
using Practice4.Entities.CarAdvertisements;
using Practice4.Entities.HeavyVehicleAdvertisings;
using Practice4.Entities.MotorAdvertisings;

namespace Practice4.Entities
{
    public class User : Thing
    {
        // شماره تماس
        public double PhoneNumber { get; set; }
        // آگهی ماشین
        // public CarAdvertisement? CarAdvertisement { get; set; }
        // آگهی ماشین سنگین
        // public HeavyVehicleAdvertising? HeavyVehicleAdvertising { get; set; }
        // آگهی موتور
        // public MotorAdvertising? MotorAdvertising { get; set; }
    }
}