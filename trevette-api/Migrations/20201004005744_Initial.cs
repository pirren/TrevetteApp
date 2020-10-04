using Microsoft.EntityFrameworkCore.Migrations;

namespace trevette_api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    BadgeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.BadgeId);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    InStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "CarBadge",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false),
                    BadgeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBadge", x => new { x.CarId, x.BadgeId });
                    table.ForeignKey(
                        name: "FK_CarBadge_Badge_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badge",
                        principalColumn: "BadgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarBadge_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
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
                table: "Badge",
                columns: new[] { "BadgeId", "Title" },
                values: new object[,]
                {
                    { 1, "V8 Motor" },
                    { 2, "Läderinredning" },
                    { 3, "Specialobjekt" }
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "Description", "InStock", "Mileage", "Model", "Price", "Title", "Year" },
                values: new object[] { 1, "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.", true, 15000, "Porsche 911 Carrera", null, "Tidlös maskin", 1980 });

            migrationBuilder.InsertData(
                table: "CarBadge",
                columns: new[] { "CarId", "BadgeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CarBadge",
                columns: new[] { "CarId", "BadgeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CarBadge",
                columns: new[] { "CarId", "BadgeId" },
                values: new object[] { 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_CarBadge_BadgeId",
                table: "CarBadge",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_CarId",
                table: "Photo",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarBadge");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Badge");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
