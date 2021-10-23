using Microsoft.EntityFrameworkCore.Migrations;

namespace CertificateWebApp.Server.Migrations
{
    public partial class IsUpdatedByWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUpdatedByWorker",
                table: "QRCodeInfoGenerators",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUpdatedByWorker",
                table: "QRCodeInfoGenerators");
        }
    }
}
