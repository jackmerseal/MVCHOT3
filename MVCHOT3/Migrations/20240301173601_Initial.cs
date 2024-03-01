using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCHOT3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BowlingBalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingBalls", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BowlingBalls",
                columns: new[] { "Id", "Brand", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Motiv", "motiv-venom-shock.jpg", "Venom Shock", 174.99m },
                    { 2, "Roto Grip", "roto-grip-no-rules-exist.jpg", "No Rules Exist", 249.95m },
                    { 3, "Hammer", "hammer-extreme-envy.jpg", "Extreme Envy", 194.95m },
                    { 4, "Pyramid", "pyramid-antidote.jpg", "Antidote", 109.99m },
                    { 5, "Pyramid", "pyramid-blood-moon-rising.jpg", "Blood Moon Rising", 124.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BowlingBalls");
        }
    }
}
