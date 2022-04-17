using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProvisionSecond.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ForexBuying = table.Column<double>(type: "double precision", nullable: false),
                    ForexSelling = table.Column<double>(type: "double precision", nullable: false),
                    BanknoteBuying = table.Column<double>(type: "double precision", nullable: false),
                    BanknoteSelling = table.Column<double>(type: "double precision", nullable: false),
                    CrossRateUsd = table.Column<double>(type: "double precision", nullable: false),
                    CrossRateOther = table.Column<double>(type: "double precision", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
