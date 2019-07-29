using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.WebUI.Migrations
{
    public partial class fileandimageadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalFile",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Samples",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalFile",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Samples");
        }
    }
}
