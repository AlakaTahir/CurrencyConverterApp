using Microsoft.EntityFrameworkCore.Migrations;

namespace Converter.Migrations.Migrations
{
    public partial class initialdataupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ForecastInfos",
                table: "ForecastInfos");

            migrationBuilder.RenameTable(
                name: "ForecastInfos",
                newName: "CurrencyInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyInfos",
                table: "CurrencyInfos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyInfos",
                table: "CurrencyInfos");

            migrationBuilder.RenameTable(
                name: "CurrencyInfos",
                newName: "ForecastInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForecastInfos",
                table: "ForecastInfos",
                column: "Id");
        }
    }
}
