using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace trevette_api.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileSuffix = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "SalesObject",
                columns: table => new
                {
                    SalesObjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesObject", x => x.SalesObjectId);
                    table.ForeignKey(
                        name: "FK_SalesObject_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "Mileage", "Model", "Year" },
                values: new object[,]
                {
                    { 1, 12000, "Porsche 911 Carrera", 1980 },
                    { 2, 40000, "Volvo 240", 1980 },
                    { 3, 3000, "Saab 9-3", 2012 },
                    { 4, 15000, "Ferrari 250 Testa Rossa", 1960 }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "PhotoId", "CarId", "FileSuffix" },
                values: new object[,]
                {
                    { 1, 1, ".jpg" },
                    { 2, 1, ".jpg" },
                    { 3, 1, ".jpg" },
                    { 4, 2, ".jpg" },
                    { 5, 3, ".jpg" },
                    { 6, 4, ".jpg" }
                });

            migrationBuilder.InsertData(
                table: "SalesObject",
                columns: new[] { "SalesObjectId", "CarId", "Description", "InStock", "Price", "StartDate", "Title" },
                values: new object[] { 1, 1, "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.", true, null, new DateTime(2020, 10, 4, 21, 28, 7, 86, DateTimeKind.Local).AddTicks(6795), "Tidlös maskin" });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_CarId",
                table: "Photo",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesObject_CarId",
                table: "SalesObject",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "SalesObject");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
