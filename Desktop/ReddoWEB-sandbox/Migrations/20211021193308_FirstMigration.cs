using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reddocoin.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReddocoinValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Values = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Holders = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Circulating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketCaps = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReddocoinValues", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReddocoinValues");
        }
    }
}
