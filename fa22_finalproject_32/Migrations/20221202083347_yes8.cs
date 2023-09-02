using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22_finalproject_32.Migrations
{
    public partial class yes8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedStatus",
                table: "Disputes");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Disputes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Disputes");

            migrationBuilder.AddColumn<string>(
                name: "SelectedStatus",
                table: "Disputes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
