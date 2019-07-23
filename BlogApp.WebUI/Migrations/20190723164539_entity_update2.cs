using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.WebUI.Migrations
{
    public partial class entity_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeslimSuresi",
                table: "Samples",
                newName: "FinalState");

            migrationBuilder.RenameColumn(
                name: "SonDurum",
                table: "Samples",
                newName: "DeliveryTime");

            migrationBuilder.RenameColumn(
                name: "Renk",
                table: "Samples",
                newName: "ModelDescription");

            migrationBuilder.RenameColumn(
                name: "MusteriModelNumarasi",
                table: "Samples",
                newName: "DesignerResearcher");

            migrationBuilder.RenameColumn(
                name: "ModelistVeArgeci",
                table: "Samples",
                newName: "CustomerModelNo");

            migrationBuilder.RenameColumn(
                name: "ModelAciklamasi",
                table: "Samples",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "IstenenAdet",
                table: "Samples",
                newName: "RequestedCount");

            migrationBuilder.RenameColumn(
                name: "GecikmeAciklama",
                table: "Samples",
                newName: "DelayDescription");

            migrationBuilder.RenameColumn(
                name: "DeliveryhDate",
                table: "Samples",
                newName: "DeliveryDate");

            migrationBuilder.RenameColumn(
                name: "AksesuarTermin",
                table: "Samples",
                newName: "AccessoryTermin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestedCount",
                table: "Samples",
                newName: "IstenenAdet");

            migrationBuilder.RenameColumn(
                name: "ModelDescription",
                table: "Samples",
                newName: "Renk");

            migrationBuilder.RenameColumn(
                name: "FinalState",
                table: "Samples",
                newName: "TeslimSuresi");

            migrationBuilder.RenameColumn(
                name: "DesignerResearcher",
                table: "Samples",
                newName: "MusteriModelNumarasi");

            migrationBuilder.RenameColumn(
                name: "DeliveryTime",
                table: "Samples",
                newName: "SonDurum");

            migrationBuilder.RenameColumn(
                name: "DeliveryDate",
                table: "Samples",
                newName: "DeliveryhDate");

            migrationBuilder.RenameColumn(
                name: "DelayDescription",
                table: "Samples",
                newName: "GecikmeAciklama");

            migrationBuilder.RenameColumn(
                name: "CustomerModelNo",
                table: "Samples",
                newName: "ModelistVeArgeci");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Samples",
                newName: "ModelAciklamasi");

            migrationBuilder.RenameColumn(
                name: "AccessoryTermin",
                table: "Samples",
                newName: "AksesuarTermin");
        }
    }
}
