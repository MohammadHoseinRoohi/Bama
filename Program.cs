using Microsoft.AspNetCore.Mvc;
using Practice4.DbContextes;
using Practice4.DTOs.Cars;
using Practice4.DTOs.Common;
using Practice4.DTOs.Exhibitions;
using Practice4.Entities;
using Practice4.Entities.CarAdvertisements;
using Practice4.Entities.HeavyVehicleAdvertisings;
using Practice4.Entities.MotorAdvertisings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<BamaDB>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("api/v1/cars/creat", (Car car) =>
{
    var db = new BamaDB();
    db.Cars.Add(car);
    db.SaveChanges();
    return "Car Created!";
});
app.MapGet("api/v1/cars/list", () =>
{
    var db = new BamaDB();
    return db.Cars.ToList();
});
app.MapPut("api/v1/cars/update/{id}", (int id, Car car) =>
{
    var db = new BamaDB();
    var newCar = db.Cars.Find(id);
    if (newCar == null)
    {
        return "Not Found!";
    }
    newCar.BodyColor = car.BodyColor;
    newCar.BodyCondition = car.BodyCondition;
    newCar.Brand = car.Brand;
    newCar.InteriorColor = car.InteriorColor;
    newCar.Madel = car.Madel;
    newCar.Mileage = car.Mileage;
    newCar.VehicleType = car.VehicleType;
    newCar.Year = car.Year;
    db.SaveChanges();
    return "Car Updated!";
});
app.MapDelete("api/v1/cars/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var car = db.Cars.Find(id);
    if (car == null)
    {
        return "Not Found!";
    }
    db.Cars.Remove(car);
    db.SaveChanges();
    return "Car Removed!";
});
app.MapPost("api/v2/cars/creat", (
    [FromBody] Car car,
    [FromServices] BamaDB db) =>
{
    db.Cars.Add(car);
    db.SaveChanges();
    return "Car Created!";
});
app.MapGet("api/v2/cars/list", ([FromServices] BamaDB db) =>
{
    return db.Cars.ToList();
});
app.MapPut("api/v2/cars/update/{id}", (
    [FromRoute] int id,
    [FromBody] Car car,
    [FromServices] BamaDB db) =>
{
    var newCar = db.Cars.Find(id);
    if (newCar == null)
    {
        return "Not Found!";
    }
    newCar.BodyColor = car.BodyColor;
    newCar.BodyCondition = car.BodyCondition;
    newCar.Brand = car.Brand;
    newCar.InteriorColor = car.InteriorColor;
    newCar.Madel = car.Madel;
    newCar.Mileage = car.Mileage;
    newCar.VehicleType = car.VehicleType;
    newCar.Year = car.Year;
    db.SaveChanges();
    return "Car Updated!";
});
app.MapDelete("api/v2/cars/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var car = db.Cars.Find(id);
    if (car == null)
    {
        return "Not Found!";
    }
    db.Cars.Remove(car);
    db.SaveChanges();
    return "Car Removed!";
});
app.MapPost("api/v3/cars/creat", (
    [FromBody] CarAddDto carAddDto,
    [FromServices] BamaDB db) =>
{
    var car = new Car
    {
        Brand = carAddDto.Brand,
        Madel = carAddDto.Madel,
        Year = carAddDto.Year,
        VehicleType = carAddDto.VehicleType,
        Mileage = carAddDto.Mileage,
        BodyColor = carAddDto.BodyColor,
        BodyCondition = carAddDto.BodyCondition,
        InteriorColor = carAddDto.InteriorColor
    };
    db.Cars.Add(car);
    db.SaveChanges();
    return new CommandResultDto
    {
        Successfull = true,
        Message = "Car Created!"
    };
});
app.MapGet("api/v3/cars/list", ([FromServices] BamaDB db) =>
{
    return db.Cars.Select(c => new CarListDto
    {
        Id = c.Guid,
        Brand = c.Brand,
        Madel = c.Madel,
        Year = c.Year,
        VehicleType = c.VehicleType,
        Mileage = c.Mileage,
        BodyColor = c.BodyColor,
        BodyCondition = c.BodyCondition,
        InteriorColor = c.InteriorColor
    }).ToList();
});
app.MapPut("api/v3/cars/update/{guid}", (
    [FromServices] BamaDB db,
    [FromRoute] string guid,
    [FromBody] CarUpdateDto carUpdateDto) =>
{
    var c = db.Cars.FirstOrDefault(m => m.Guid == guid);
    if (c == null)
    {
        return new CommandResultDto
        {
            Successfull = false,
            Message = "Not Found!!!!"
        };
    }
    c.BodyCondition = !string.IsNullOrEmpty(carUpdateDto.BodyCondition) ? carUpdateDto.BodyCondition : c.BodyCondition;
    c.Mileage = !string.IsNullOrEmpty(carUpdateDto.Mileage) ? carUpdateDto.Mileage : c.Mileage;
    db.SaveChanges();
    return new CommandResultDto
    {
        Successfull = true,
        Message = "Car Updated!"
    };
});
app.MapDelete("api/v3/cars/remove/{guid}", (
    [FromRoute] string guid,
    [FromServices] BamaDB db) =>
{
    var car = db.Cars.FirstOrDefault(m => m.Guid == guid);
    if (car == null)
    {
        return new CommandResultDto
        {
            Successfull = false,
            Message = "Not Found!!!"
        };
    }
    db.Cars.Remove(car);
    db.SaveChanges();
    return new CommandResultDto
    {
        Successfull = true,
        Message = "Car Removed!"
    };
});
app.MapPost("api/v1/exhibitions/creat", (Exhibition exhibition) =>
{
    var db = new BamaDB();
    db.Exhibitions.Add(exhibition);
    db.SaveChanges();
    return "Exhibition Created";
});
app.MapGet("api/v1/exhibitions/list", () =>
{
    var db = new BamaDB();
    return db.Exhibitions.ToList();
});
app.MapPut("api/v1/exhibitions/update/{id}", (int id, Exhibition exhibition) =>
{
    var db = new BamaDB();
    var newExhibition = db.Exhibitions.Find(id);
    if (newExhibition == null)
    {
        return "Not Found!";
    }
    newExhibition.Address = exhibition.Address;
    newExhibition.Description = exhibition.Description;
    newExhibition.Email = exhibition.Email;
    newExhibition.ExhibitionName = exhibition.ExhibitionName;
    newExhibition.ExhibitionType = exhibition.ExhibitionType;
    newExhibition.Landline = exhibition.Landline;
    newExhibition.OwnerName = exhibition.OwnerName;
    newExhibition.PhoneNumber = exhibition.PhoneNumber;
    newExhibition.YourName = exhibition.YourName;
    newExhibition.Province = exhibition.Province;
    db.SaveChanges();
    return "Exhibition Updated!";
});
app.MapDelete("api/v1/exhibitions/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var exhibition = db.Exhibitions.Find(id);
    if (exhibition == null)
    {
        return "Not Found!";
    }
    db.Exhibitions.Remove(exhibition);
    db.SaveChanges();
    return "Exhibition Removed!";
});
app.MapPost("api/v2/exhibitions/creat", (
    [FromBody] Exhibition exhibition,
    [FromServices] BamaDB db) =>
{
    db.Exhibitions.Add(exhibition);
    db.SaveChanges();
    return "Exhibition Created";
});
app.MapGet("api/v2/exhibitions/list", ([FromServices] BamaDB db) =>
{
    return db.Exhibitions.ToList();
});
app.MapPut("api/v2/exhibitions/update/{id}", (
    [FromRoute] int id,
    [FromBody] Exhibition exhibition,
    [FromServices] BamaDB db) =>
{
    var newExhibition = db.Exhibitions.Find(id);
    if (newExhibition == null)
    {
        return "Not Found!";
    }
    newExhibition.Address = exhibition.Address;
    newExhibition.Description = exhibition.Description;
    newExhibition.Email = exhibition.Email;
    newExhibition.ExhibitionName = exhibition.ExhibitionName;
    newExhibition.ExhibitionType = exhibition.ExhibitionType;
    newExhibition.Landline = exhibition.Landline;
    newExhibition.OwnerName = exhibition.OwnerName;
    newExhibition.PhoneNumber = exhibition.PhoneNumber;
    newExhibition.YourName = exhibition.YourName;
    newExhibition.Province = exhibition.Province;
    db.SaveChanges();
    return "Exhibition Updated!";
});
app.MapDelete("api/v2/exhibitions/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var exhibition = db.Exhibitions.Find(id);
    if (exhibition == null)
    {
        return "Not Found!";
    }
    db.Exhibitions.Remove(exhibition);
    db.SaveChanges();
    return "Exhibition Removed!";
});
app.MapPost("api/v3/exhibitions/creat", (
    [FromBody] ExhibitionAddDto exhibitionAddDto,
    [FromServices] BamaDB db) =>
{
    var exhibition = new Exhibition
    {
        ExhibitionType = exhibitionAddDto.ExhibitionType,
        ExhibitionName = exhibitionAddDto.ExhibitionName,
        YourName = exhibitionAddDto.YourName,
        OwnerName = exhibitionAddDto.OwnerName,
        PhoneNumber = exhibitionAddDto.PhoneNumber,
        Province = exhibitionAddDto.Province,
        Landline = exhibitionAddDto.Landline,
        Email = exhibitionAddDto.Email,
        Address = exhibitionAddDto.Address,
        Description = exhibitionAddDto.Description
    };
    db.Exhibitions.Add(exhibition);
    db.SaveChanges();
    return new CommandResultDto
    {
        Successfull = true,
        Message = "Exhibition Created!"
    };
});
app.MapGet("api/v3/exhibitions/list", ([FromServices] BamaDB db) =>
{
    return db.Exhibitions.Select(e => new ExhibitionListDto
    {
        Id = e.Guid,
        ExhibitionType = e.ExhibitionType,
        ExhibitionName = e.ExhibitionName,
        YourName = e.YourName,
        OwnerName = e.OwnerName,
        PhoneNumber = e.PhoneNumber,
        Province = e.Province,
        Landline = e.Landline,
        Email = e.Email,
        Address = e.Address,
        Description = e.Description
    }).ToList();
});
app.MapPut("api/v3/exhibitions/update/{guid}", (
    [FromRoute] string guid,
    [FromBody] ExhibitionUpdateDto exhibitionUpdateDto,
    [FromServices] BamaDB db) =>
{
    var exhibition = db.Exhibitions.FirstOrDefault(m => m.Guid == guid);
    if (exhibition == null)
    {
        return new CommandResultDto
        {
            Successfull = false,
            Message = "Not Found!!!"
        };
    }
    exhibition.OwnerName = !string.IsNullOrEmpty(exhibitionUpdateDto.OwnerName) ? exhibitionUpdateDto.OwnerName : exhibition.OwnerName;
    exhibition.PhoneNumber = exhibitionUpdateDto.PhoneNumber;
    exhibition.Email = !string.IsNullOrEmpty(exhibitionUpdateDto.Email) ? exhibitionUpdateDto.Email : exhibition.Email;
    exhibition.Address = !string.IsNullOrEmpty(exhibitionUpdateDto.Address) ? exhibitionUpdateDto.Address : exhibition.Address;
    exhibition.Description = !string.IsNullOrEmpty(exhibitionUpdateDto.Description) ? exhibitionUpdateDto.Description : exhibition.Description;
    db.SaveChanges();
    return new CommandResultDto
    {
        Successfull = true,
        Message = "Exhibition Updated!"
    };
});
app.MapDelete("api/v3/exhibitions/remove/{guid}", (
    [FromRoute] string guid ,
    [FromServices] BamaDB db) =>
{
    var exhibition = db.Exhibitions.FirstOrDefault(m => m.Guid == guid);
    if (exhibition == null)
    {
        return new CommandResultDto
        {
            Successfull = false,
            Message = "Not Found!!!"
        };
    }
    db.Exhibitions.Remove(exhibition);
    db.SaveChanges();
    return new CommandResultDto
    {
        Successfull = true,
        Message = "Exhibition Removed!"
    };
});
app.MapPost("api/v1/heavyVehicles/creat", (HeavyVehicle heavyVehicle) =>
{
    var db = new BamaDB();
    db.HeavyVehicles.Add(heavyVehicle);
    db.SaveChanges();
    return "HeavyVehicle Created!";
});
app.MapGet("api/v1/heavyVehicles/list", () =>
{
    var db = new BamaDB();
    return db.HeavyVehicles.ToList();
});
app.MapPut("api/v1/heavyVehicles/update/{id}", (int id, HeavyVehicle heavyVehicle) =>
{
    var db = new BamaDB();
    var newHeavyVehicle = db.HeavyVehicles.Find(id);
    if (newHeavyVehicle == null)
    {
        return "Not Found!";
    }
    newHeavyVehicle.BodyColor = heavyVehicle.BodyColor;
    newHeavyVehicle.BodyCondition = heavyVehicle.BodyCondition;
    newHeavyVehicle.Brand = heavyVehicle.Brand;
    newHeavyVehicle.Gearbox = heavyVehicle.Gearbox;
    newHeavyVehicle.Madel = heavyVehicle.Madel;
    newHeavyVehicle.Mileage = heavyVehicle.Mileage;
    newHeavyVehicle.OperatingHours = heavyVehicle.OperatingHours;
    newHeavyVehicle.RepairHistory = heavyVehicle.RepairHistory;
    newHeavyVehicle.UserSubcategory = heavyVehicle.UserSubcategory;
    newHeavyVehicle.UserYype = heavyVehicle.UserYype;
    newHeavyVehicle.VehicleType = heavyVehicle.VehicleType;
    newHeavyVehicle.Year = heavyVehicle.Year;
    db.SaveChanges();
    return "HeavyVehicle Updated!";
});
app.MapDelete("api/v1/heavyVehicles/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var heavyVehicles = db.HeavyVehicles.Find(id);
    if (heavyVehicles == null)
    {
        return "Not Found!";
    }
    db.HeavyVehicles.Remove(heavyVehicles);
    db.SaveChanges();
    return "HeavyVehicles Removed!";
});
app.MapPost("api/v2/heavyVehicles/creat", (
    [FromBody] HeavyVehicle heavyVehicle,
    [FromServices] BamaDB db) =>
{
    db.HeavyVehicles.Add(heavyVehicle);
    db.SaveChanges();
    return "HeavyVehicle Created!";
});
app.MapGet("api/v2/heavyVehicles/list", ([FromServices] BamaDB db) =>
{
    return db.HeavyVehicles.ToList();
});
app.MapPut("api/v2/heavyVehicles/update/{id}", (
    [FromRoute] int id,
    [FromBody] HeavyVehicle heavyVehicle,
    [FromServices] BamaDB db) =>
{
    var newHeavyVehicle = db.HeavyVehicles.Find(id);
    if (newHeavyVehicle == null)
    {
        return "Not Found!";
    }
    newHeavyVehicle.BodyColor = heavyVehicle.BodyColor;
    newHeavyVehicle.BodyCondition = heavyVehicle.BodyCondition;
    newHeavyVehicle.Brand = heavyVehicle.Brand;
    newHeavyVehicle.Gearbox = heavyVehicle.Gearbox;
    newHeavyVehicle.Madel = heavyVehicle.Madel;
    newHeavyVehicle.Mileage = heavyVehicle.Mileage;
    newHeavyVehicle.OperatingHours = heavyVehicle.OperatingHours;
    newHeavyVehicle.RepairHistory = heavyVehicle.RepairHistory;
    newHeavyVehicle.UserSubcategory = heavyVehicle.UserSubcategory;
    newHeavyVehicle.UserYype = heavyVehicle.UserYype;
    newHeavyVehicle.VehicleType = heavyVehicle.VehicleType;
    newHeavyVehicle.Year = heavyVehicle.Year;
    db.SaveChanges();
    return "HeavyVehicle Updated!";
});
app.MapDelete("api/v2/heavyVehicles/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var heavyVehicles = db.HeavyVehicles.Find(id);
    if (heavyVehicles == null)
    {
        return "Not Found!";
    }
    db.HeavyVehicles.Remove(heavyVehicles);
    db.SaveChanges();
    return "HeavyVehicles Removed!";
});
app.MapPost("api/v1/installments/creat", (Installments installments) =>
{
    var db = new BamaDB();
    db.Installments.Add(installments);
    db.SaveChanges();
    return "Installments Created!";
});
app.MapGet("api/v1/installments/list", () =>
{
    var db = new BamaDB();
    return db.Installments.ToList();
});
app.MapPut("api/v1/installments/update/{id}", (int id, Installments installments) =>
{
    var db = new BamaDB();
    var newInstallments = db.Installments.Find(id);
    if (newInstallments == null)
    {
        return "Not Found!";
    }
    newInstallments.DeliveryTime = installments.DeliveryTime;
    newInstallments.DownPayment = installments.DownPayment;
    newInstallments.InstallmentAmount = installments.InstallmentAmount;
    newInstallments.NumberOfInstallments = installments.NumberOfInstallments;
    newInstallments.PaymentDate = installments.PaymentDate;
    newInstallments.SecondDownPayment = installments.SecondDownPayment;
    db.SaveChanges();
    return "Installments Updated!";
});
app.MapDelete("api/v1/installments/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var installments = db.Installments.Find(id);
    if (installments == null)
    {
        return "Not Found!";
    }
    db.Installments.Remove(installments);
    db.SaveChanges();
    return "Installments Removed";
});
app.MapPost("api/v2/installments/creat", (
    [FromBody] Installments installments,
    [FromServices] BamaDB db) =>
{
    db.Installments.Add(installments);
    db.SaveChanges();
    return "Installments Created!";
});
app.MapGet("api/2/installments/list", ([FromServices] BamaDB db) =>
{
    return db.Installments.ToList();
});
app.MapPut("api/v2/installments/update/{id}", (
    [FromRoute] int id,
    [FromBody] Installments installments,
    [FromServices] BamaDB db) =>
{
    var newInstallments = db.Installments.Find(id);
    if (newInstallments == null)
    {
        return "Not Found!";
    }
    newInstallments.DeliveryTime = installments.DeliveryTime;
    newInstallments.DownPayment = installments.DownPayment;
    newInstallments.InstallmentAmount = installments.InstallmentAmount;
    newInstallments.NumberOfInstallments = installments.NumberOfInstallments;
    newInstallments.PaymentDate = installments.PaymentDate;
    newInstallments.SecondDownPayment = installments.SecondDownPayment;
    db.SaveChanges();
    return "Installments Updated!";
});
app.MapDelete("api/v2/installments/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var installments = db.Installments.Find(id);
    if (installments == null)
    {
        return "Not Found!";
    }
    db.Installments.Remove(installments);
    db.SaveChanges();
    return "Installments Removed";
});
app.MapPost("api/v1/motors/creat", (Motor motor) =>
{
    var db = new BamaDB();
    db.Motors.Add(motor);
    db.SaveChanges();
    return "Motor Created!";
});
app.MapGet("api/v1/motors/list", () =>
{
    var db = new BamaDB();
    return db.Motors.ToList();
});
app.MapPut("api/v1/motors/update/{id}", (int id, Motor motor) =>
{
    var db = new BamaDB();
    var newMotor = db.Motors.Find(id);
    if (newMotor == null)
    {
        return "Not Found!";
    }
    newMotor.BodyColor = motor.BodyColor;
    newMotor.Brand = motor.Brand;
    newMotor.FuelYype = motor.FuelYype;
    newMotor.Gearbox = motor.Gearbox;
    newMotor.Madel = motor.Madel;
    newMotor.Mileage = motor.Mileage;
    newMotor.Year = motor.Year;
    db.SaveChanges();
    return "Motor Updated!";
});
app.MapDelete("api/v1/motors/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var motor = db.Motors.Find(id);
    if (motor == null)
    {
        return "Not Found!";
    }
    db.Motors.Remove(motor);
    db.SaveChanges();
    return "Motor Removed!";
});
app.MapPost("api/v2/motors/creat", (
    [FromBody] Motor motor,
    [FromServices] BamaDB db) =>
{
    db.Motors.Add(motor);
    db.SaveChanges();
    return "Motor Created!";
});
app.MapGet("api/v2/motors/list", ([FromServices] BamaDB db) =>
{
    return db.Motors.ToList();
});
app.MapPut("api/v2/motors/update/{id}", (
    [FromRoute] int id,
    [FromBody] Motor motor,
    [FromServices] BamaDB db) =>
{
    var newMotor = db.Motors.Find(id);
    if (newMotor == null)
    {
        return "Not Found!";
    }
    newMotor.BodyColor = motor.BodyColor;
    newMotor.Brand = motor.Brand;
    newMotor.FuelYype = motor.FuelYype;
    newMotor.Gearbox = motor.Gearbox;
    newMotor.Madel = motor.Madel;
    newMotor.Mileage = motor.Mileage;
    newMotor.Year = motor.Year;
    db.SaveChanges();
    return "Motor Updated!";
});
app.MapDelete("api/v2/motors/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var motor = db.Motors.Find(id);
    if (motor == null)
    {
        return "Not Found!";
    }
    db.Motors.Remove(motor);
    db.SaveChanges();
    return "Motor Removed!";
});
app.MapPost("api/v1/users/creat", (User user) =>
{
    var db = new BamaDB();
    db.Users.Add(user);
    db.SaveChanges();
    return "User Created!";
});
app.MapGet("api/v1/users/list", () =>
{
    var db = new BamaDB();
    return db.Users.ToList();
});
app.MapPut("api/v1/users/update/{id}", (int id, User user) =>
{
    var db = new BamaDB();
    var newUser = db.Users.Find(id);
    if (newUser == null)
    {
        return "Not Found!";
    }
    newUser.PhoneNumber = user.PhoneNumber;
    db.SaveChanges();
    return "User Updated!";
});
app.MapDelete("api/v1/users/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var user = db.Users.Find(id);
    if (user == null)
    {
        return "Not Found!";
    }
    db.Users.Remove(user);
    db.SaveChanges();
    return "User Removed!";
});
app.MapPost("api/v2/users/creat", (
    [FromBody] User user,
    [FromServices] BamaDB db) =>
{
    db.Users.Add(user);
    db.SaveChanges();
    return "User Created!";
});
app.MapGet("api/v2/users/list", ([FromServices] BamaDB db) =>
{
    return db.Users.ToList();
});
app.MapPut("api/v2/users/update/{id}", (
    [FromRoute] int id,
    [FromBody] User user,
    [FromServices] BamaDB db) =>
{
    var newUser = db.Users.Find(id);
    if (newUser == null)
    {
        return "Not Found!";
    }
    newUser.PhoneNumber = user.PhoneNumber;
    db.SaveChanges();
    return "User Updated!";
});
app.MapDelete("api/v2/users/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var user = db.Users.Find(id);
    if (user == null)
    {
        return "Not Found!";
    }
    db.Users.Remove(user);
    db.SaveChanges();
    return "User Removed!";
});
app.MapPost("api/v1/visitLocations/creat", (VisitLocation visitLocation) =>
{
    var db = new BamaDB();
    db.VisitLocations.Add(visitLocation);
    db.SaveChanges();
    return "VisitLocation Created!";
});
app.MapGet("api/v1/visitLocations/list", () =>
{
    var db = new BamaDB();
    return db.VisitLocations.ToList();
});
app.MapPut("api/v1/visitLocations/update/{id}", (int id, VisitLocation visitLocation) =>
{
    var db = new BamaDB();
    var newVisitLocation = db.VisitLocations.Find(id);
    if (newVisitLocation == null)
    {
        return "Not Found!";
    }
    newVisitLocation.City = visitLocation.City;
    newVisitLocation.Province = visitLocation.Province;
    newVisitLocation.Region = visitLocation.Region;
    db.SaveChanges();
    return "VisitLocation Updated!";
});
app.MapDelete("api/v1/visitLocations/remove/{id}", (int id) =>
{
    var db = new BamaDB();
    var visitLocation = db.VisitLocations.Find(id);
    if (visitLocation == null)
    {
        return "Not Found!";
    }
    db.VisitLocations.Remove(visitLocation);
    db.SaveChanges();
    return "VisitLocation Removed!";
});
app.MapPost("api/v2/visitLocations/creat", (
    [FromBody] VisitLocation visitLocation,
    [FromServices] BamaDB db) =>
{
    db.VisitLocations.Add(visitLocation);
    db.SaveChanges();
    return "VisitLocation Created!";
});
app.MapGet("api/v2/visitLocations/list", ([FromServices] BamaDB db) =>
{
    return db.VisitLocations.ToList();
});
app.MapPut("api/v2/visitLocations/update/{id}", (
    [FromRoute] int id,
    [FromBody] VisitLocation visitLocation,
    [FromServices] BamaDB db) =>
{
    var newVisitLocation = db.VisitLocations.Find(id);
    if (newVisitLocation == null)
    {
        return "Not Found!";
    }
    newVisitLocation.City = visitLocation.City;
    newVisitLocation.Province = visitLocation.Province;
    newVisitLocation.Region = visitLocation.Region;
    db.SaveChanges();
    return "VisitLocation Updated!";
});
app.MapDelete("api/v2/visitLocations/remove/{id}", (
    [FromRoute] int id,
    [FromServices] BamaDB db) =>
{
    var visitLocation = db.VisitLocations.Find(id);
    if (visitLocation == null)
    {
        return "Not Found!";
    }
    db.VisitLocations.Remove(visitLocation);
    db.SaveChanges();
    return "VisitLocation Removed!";
});

app.Run();