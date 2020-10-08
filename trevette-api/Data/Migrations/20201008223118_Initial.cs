using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace trevetteapi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesObject",
                columns: table => new
                {
                    SalesObjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesObject", x => x.SalesObjectId);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    SalesObjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Car_SalesObject_SalesObjectId",
                        column: x => x.SalesObjectId,
                        principalTable: "SalesObject",
                        principalColumn: "SalesObjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photo_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "Manufacturer", "Mileage", "Model", "SalesObjectId", "Year" },
                values: new object[,]
                {
                    { 3, "Saab", 3000, "Saab 9-3", null, 2012 },
                    { 4, "Ferrari", 15000, "Ferrari 250 Testa Rossa", null, 1960 }
                });

            migrationBuilder.InsertData(
                table: "SalesObject",
                columns: new[] { "SalesObjectId", "Description", "InStock", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.", true, null, new DateTime(2020, 10, 9, 0, 31, 18, 74, DateTimeKind.Local).AddTicks(6140), "Tidlös maskin" },
                    { 2, "Denna gamla Volvo är en klassisk bakhjulsdriven personbil och går aldrig fel. Rullar fint.", false, null, new DateTime(2020, 10, 9, 0, 31, 18, 77, DateTimeKind.Local).AddTicks(6430), "Odödlig" }
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "Manufacturer", "Mileage", "Model", "SalesObjectId", "Year" },
                values: new object[,]
                {
                    { 1, "Chevrolet", 9000, "Chevrolet Corvette Stingray", 1, 1976 },
                    { 2, "Volvo", 40000, "Volvo 240", 2, 1980 }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "PhotoId", "CarId", "FileName" },
                values: new object[,]
                {
                    { 5, 3, "5.jpg" },
                    { 6, 4, "6.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "PhotoId", "CarId", "FileName" },
                values: new object[,]
                {
                    { 1, 1, "1.jpg" },
                    { 2, 1, "2.jpg" },
                    { 3, 1, "3.jpg" },
                    { 4, 2, "4.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_SalesObjectId",
                table: "Car",
                column: "SalesObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_CarId",
                table: "Photo",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "SalesObject");
        }
    }
}
