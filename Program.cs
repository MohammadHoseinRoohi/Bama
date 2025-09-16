using Practice4.DbContextes;
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
    var h = db.HeavyVehicles.Find(id);
    if (h == null)
    {
        return "Not Found!";
    }
    db.SaveChanges();
    return "HeavyVehicle Updated!";
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

app.Run();