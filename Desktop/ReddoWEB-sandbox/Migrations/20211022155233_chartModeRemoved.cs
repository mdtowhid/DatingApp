using Microsoft.EntityFrameworkCore.Migrations;

namespace Reddocoin.Migrations
{
    public partial class chartModeRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChartMode",
                table: "Charts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChartMode",
                table: "Charts",
                type: "int",
                nullable: true);
        }
    }
}
