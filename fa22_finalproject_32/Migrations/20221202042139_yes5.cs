using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22_finalproject_32.Migrations
{
    public partial class yes5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockType",
                table: "Stocks");

            migrationBuilder.AddColumn<int>(
                name: "StockTypeName",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockTypeName",
                table: "Stocks");

            migrationBuilder.AddColumn<string>(
                name: "StockType",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
