using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice4.Migrations
{
    /// <inheritdoc />
    public partial class M04070102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "VisitLocations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Prices",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "MotorAdvertisings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Installments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "HeavyVehicles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "HeavyVehicleAdvertisings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Exhibitions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "CarAdvertisements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "VisitLocations");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "MotorAdvertisings");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Installments");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "HeavyVehicles");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "HeavyVehicleAdvertisings");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Exhibitions");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "CarAdvertisements");
        }
    }
}
