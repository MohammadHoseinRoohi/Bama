using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice4.Migrations
{
    /// <inheritdoc />
    public partial class M04061801 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Madel = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<double>(type: "REAL", nullable: false),
                    VehicleType = table.Column<string>(type: "TEXT", nullable: false),
                    Mileage = table.Column<string>(type: "TEXT", nullable: false),
                    BodyColor = table.Column<string>(type: "TEXT", nullable: false),
                    BodyCondition = table.Column<string>(type: "TEXT", nullable: false),
                    InteriorColor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exhibitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExhibitionType = table.Column<string>(type: "TEXT", nullable: false),
                    ExhibitionName = table.Column<string>(type: "TEXT", nullable: false),
                    YourName = table.Column<string>(type: "TEXT", nullable: false),
                    OwnerName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<double>(type: "REAL", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    Landline = table.Column<double>(type: "REAL", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeavyVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserYype = table.Column<string>(type: "TEXT", nullable: true),
                    UserSubcategory = table.Column<string>(type: "TEXT", nullable: true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Madel = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<double>(type: "REAL", nullable: false),
                    VehicleType = table.Column<string>(type: "TEXT", nullable: false),
                    Mileage = table.Column<string>(type: "TEXT", nullable: false),
                    BodyCondition = table.Column<string>(type: "TEXT", nullable: false),
                    BodyColor = table.Column<string>(type: "TEXT", nullable: false),
                    Gearbox = table.Column<string>(type: "TEXT", nullable: true),
                    RepairHistory = table.Column<bool>(type: "INTEGER", nullable: true),
                    OperatingHours = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeavyVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Installments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstallmentAmount = table.Column<double>(type: "REAL", nullable: false),
                    DownPayment = table.Column<double>(type: "REAL", nullable: false),
                    SecondDownPayment = table.Column<double>(type: "REAL", nullable: true),
                    NumberOfInstallments = table.Column<string>(type: "TEXT", nullable: false),
                    DeliveryTime = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Madel = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<double>(type: "REAL", nullable: false),
                    FuelYype = table.Column<string>(type: "TEXT", nullable: false),
                    Gearbox = table.Column<string>(type: "TEXT", nullable: true),
                    Mileage = table.Column<string>(type: "TEXT", nullable: false),
                    BodyColor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneNumber = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Region = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cash = table.Column<double>(type: "REAL", nullable: true),
                    InstallmentsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Installments_InstallmentsId",
                        column: x => x.InstallmentsId,
                        principalTable: "Installments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarAdvertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceId = table.Column<int>(type: "INTEGER", nullable: true),
                    PictureOrVideo = table.Column<string>(type: "TEXT", nullable: true),
                    VisitLocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    FreeRegion = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAdvertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarAdvertisements_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarAdvertisements_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarAdvertisements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarAdvertisements_VisitLocations_VisitLocationId",
                        column: x => x.VisitLocationId,
                        principalTable: "VisitLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeavyVehicleAdvertisings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    HeavyVehicleId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceId = table.Column<int>(type: "INTEGER", nullable: true),
                    Picture = table.Column<string>(type: "TEXT", nullable: true),
                    VisitLocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeavyVehicleAdvertisings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeavyVehicleAdvertisings_HeavyVehicles_HeavyVehicleId",
                        column: x => x.HeavyVehicleId,
                        principalTable: "HeavyVehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeavyVehicleAdvertisings_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HeavyVehicleAdvertisings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeavyVehicleAdvertisings_VisitLocations_VisitLocationId",
                        column: x => x.VisitLocationId,
                        principalTable: "VisitLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorAdvertisings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    MotorId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceId = table.Column<int>(type: "INTEGER", nullable: true),
                    Picture = table.Column<string>(type: "TEXT", nullable: true),
                    VisitLocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorAdvertisings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorAdvertisings_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorAdvertisings_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MotorAdvertisings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorAdvertisings_VisitLocations_VisitLocationId",
                        column: x => x.VisitLocationId,
                        principalTable: "VisitLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisements_CarId",
                table: "CarAdvertisements",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisements_PriceId",
                table: "CarAdvertisements",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisements_UserId",
                table: "CarAdvertisements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisements_VisitLocationId",
                table: "CarAdvertisements",
                column: "VisitLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_HeavyVehicleAdvertisings_HeavyVehicleId",
                table: "HeavyVehicleAdvertisings",
                column: "HeavyVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HeavyVehicleAdvertisings_PriceId",
                table: "HeavyVehicleAdvertisings",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_HeavyVehicleAdvertisings_UserId",
                table: "HeavyVehicleAdvertisings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HeavyVehicleAdvertisings_VisitLocationId",
                table: "HeavyVehicleAdvertisings",
                column: "VisitLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorAdvertisings_MotorId",
                table: "MotorAdvertisings",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorAdvertisings_PriceId",
                table: "MotorAdvertisings",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorAdvertisings_UserId",
                table: "MotorAdvertisings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorAdvertisings_VisitLocationId",
                table: "MotorAdvertisings",
                column: "VisitLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_InstallmentsId",
                table: "Prices",
                column: "InstallmentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarAdvertisements");

            migrationBuilder.DropTable(
                name: "Exhibitions");

            migrationBuilder.DropTable(
                name: "HeavyVehicleAdvertisings");

            migrationBuilder.DropTable(
                name: "MotorAdvertisings");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "HeavyVehicles");

            migrationBuilder.DropTable(
                name: "Motors");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VisitLocations");

            migrationBuilder.DropTable(
                name: "Installments");
        }
    }
}
