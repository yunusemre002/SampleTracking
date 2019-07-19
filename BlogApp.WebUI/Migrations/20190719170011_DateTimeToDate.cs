using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.WebUI.Migrations
{
    public partial class DateTimeToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestDate",
                table: "Samples",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
