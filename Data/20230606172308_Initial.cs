using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApp.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ProfilePicture = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GoodsTable",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProfilePicture", "Quantity" },
                values: new object[] { 1, 0, "Nice men's Leather Jacket for outing", "Leather Jacket", 18.300000000000001, "~/images/jacket.jpg", 7 });

            migrationBuilder.InsertData(
                table: "GoodsTable",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProfilePicture", "Quantity" },
                values: new object[] { 2, 1, "Nice heels for outing", "Fashion Heels", 13.300000000000001, "~/images/heels.jpg", 5 });

            migrationBuilder.InsertData(
                table: "GoodsTable",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProfilePicture", "Quantity" },
                values: new object[] { 3, 4, "Keeps your Cat busy all day", "Electric Mouse", 9.6999999999999993, "~/images/emouse.jpg", 0 });

            migrationBuilder.InsertData(
                table: "GoodsTable",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProfilePicture", "Quantity" },
                values: new object[] { 4, 3, "High quality cargo pant for kids", "Combat Joggers", 15.0, "~/images/joggers.jpg", 16 });

            migrationBuilder.InsertData(
                table: "GoodsTable",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProfilePicture", "Quantity" },
                values: new object[] { 5, 5, "Exclusive waterproof watch for all", "Hublot Wristwatch", 24.989999999999998, "~/images/hublot.jpg", 6 });

            migrationBuilder.InsertData(
                table: "GoodsTable",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProfilePicture", "Quantity" },
                values: new object[] { 6, 2, "Sexy short gown ladies", "Mini Gown", 19.199999999999999, "~/images/gown.jpg", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsTable");
        }
    }
}
