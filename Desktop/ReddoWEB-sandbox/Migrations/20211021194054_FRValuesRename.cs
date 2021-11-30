using Microsoft.EntityFrameworkCore.Migrations;

namespace Reddocoin.Migrations
{
    public partial class FRValuesRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Values",
                table: "ReddocoinValues",
                newName: "RValues");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RValues",
                table: "ReddocoinValues",
                newName: "Values");
        }
    }
}
