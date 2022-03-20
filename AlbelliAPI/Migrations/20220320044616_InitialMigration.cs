using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbelliAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderInfomation",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfomation", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProdcutTypes",
                columns: table => new
                {
                    ProdcutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdcutName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdcutTypes", x => x.ProdcutId);
                });

            migrationBuilder.CreateTable(
                name: "Order_Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Products_OrderInfomation_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderInfomation",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Products_ProdcutTypes_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProdcutTypes",
                        principalColumn: "ProdcutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Products_OrderId",
                table: "Order_Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Products_ProductId",
                table: "Order_Products",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order_Products");

            migrationBuilder.DropTable(
                name: "OrderInfomation");

            migrationBuilder.DropTable(
                name: "ProdcutTypes");
        }
    }
}
