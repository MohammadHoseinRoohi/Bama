using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Practice4.Entities;
using Practice4.Entities.CarAdvertisements;
using Practice4.Entities.HeavyVehicleAdvertisings;
using Practice4.Entities.MotorAdvertisings;

namespace Practice4.DbContextes
{
    public class BamaDB : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarAdvertisement> CarAdvertisements { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<HeavyVehicle> HeavyVehicles { get; set; }
        public DbSet<HeavyVehicleAdvertising> HeavyVehicleAdvertisings { get; set; }
        public DbSet<Motor> Motors { get; set; }
        public DbSet<MotorAdvertising> MotorAdvertisings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VisitLocation> VisitLocations { get; set; }
        public DbSet<Installments> Installments { get; set; }
        public DbSet<Price> Prices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data source = DBFiles\bamadb.sqlite");
        }
    }
}