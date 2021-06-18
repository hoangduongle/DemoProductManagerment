using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProductManagerment.Migrations
{
    public partial class KhoiTao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cateId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    proId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    cateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.proId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_cateId",
                        column: x => x.cateId,
                        principalTable: "Categories",
                        principalColumn: "cateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cateId", "cateName" },
                values: new object[] { 1, "Asus" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cateId", "cateName" },
                values: new object[] { 2, "Apple" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "proId", "amount", "cateId", "price", "proName" },
                values: new object[] { 1, 100, 1, 10.0, "AsusROG" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "proId", "amount", "cateId", "price", "proName" },
                values: new object[] { 2, 100, 2, 10.0, "Macbook" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_cateId",
                table: "Products",
                column: "cateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
