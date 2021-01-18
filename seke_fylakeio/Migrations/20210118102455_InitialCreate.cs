using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace seke_fylakeio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zygisma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrossWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TareWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsOk = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zygisma", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zygisma");
        }
    }
}
