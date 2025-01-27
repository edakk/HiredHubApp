using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvertisementApp.DataAccess.Migrations
{
    public partial class Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Definiton",
                table: "Genders",
                newName: "Definition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Definition",
                table: "Genders",
                newName: "Definiton");
        }
    }
}
