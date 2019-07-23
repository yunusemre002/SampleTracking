using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.WebUI.Migrations
{
    public partial class entity_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SampleType",
                table: "Samples",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customer",
                table: "Samples",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccessoryOrderDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AksesuarTermin",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artikel",
                table: "Samples",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryhDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GecikmeAciklama",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IstenenAdet",
                table: "Samples",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "MeshFinishDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModelAciklamasi",
                table: "Samples",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModelistVeArgeci",
                table: "Samples",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MusteriModelNumarasi",
                table: "Samples",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaintDeliveryDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PaintFinishDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Renk",
                table: "Samples",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SewingFinishDate",
                table: "Samples",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SonDurum",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Termin",
                table: "Samples",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeslimSuresi",
                table: "Samples",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessoryOrderDate",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "AksesuarTermin",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Artikel",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "DeliveryhDate",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "GecikmeAciklama",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "IstenenAdet",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "MeshFinishDate",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "ModelAciklamasi",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "ModelistVeArgeci",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "MusteriModelNumarasi",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "PaintDeliveryDate",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "PaintFinishDate",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Renk",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "SewingFinishDate",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "SonDurum",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Termin",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "TeslimSuresi",
                table: "Samples");

            migrationBuilder.AlterColumn<string>(
                name: "SampleType",
                table: "Samples",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Customer",
                table: "Samples",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
