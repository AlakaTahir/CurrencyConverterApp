using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Converter.Migrations.Migrations
{
    public partial class createdateupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CurrencyInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CurrencyInfos");
        }
    }
}
