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
        public double PhoneNumber { get; set; }
        public CarAdvertisement? CarAdvertisement { get; set; }
        public HeavyVehicleAdvertising? HeavyVehicleAdvertising { get; set; }
        public MotorAdvertising? MotorAdvertising { get; set; }
    }
}