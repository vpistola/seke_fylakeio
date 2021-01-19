﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace seke_fylakeio.Migrations
{
    public partial class AddActiveToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Zygisma",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Zygisma");
        }
    }
}
