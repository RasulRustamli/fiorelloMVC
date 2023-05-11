using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fiorelloMVC.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatagoryProduct");

            migrationBuilder.AddColumn<int>(
                name: "CatagoriesId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatagoriesId",
                table: "Products",
                column: "CatagoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catagories_CatagoriesId",
                table: "Products",
                column: "CatagoriesId",
                principalTable: "Catagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catagories_CatagoriesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatagoriesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CatagoriesId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "CatagoryProduct",
                columns: table => new
                {
                    CatagoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryProduct", x => new { x.CatagoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CatagoryProduct_Catagories_CatagoriesId",
                        column: x => x.CatagoriesId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatagoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatagoryProduct_ProductsId",
                table: "CatagoryProduct",
                column: "ProductsId");
        }
    }
}
