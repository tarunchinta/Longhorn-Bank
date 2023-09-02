using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22_finalproject_32.Migrations
{
    public partial class yes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Disputes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Disputes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
