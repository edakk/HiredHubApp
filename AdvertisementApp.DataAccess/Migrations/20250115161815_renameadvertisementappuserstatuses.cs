using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvertisementApp.DataAccess.Migrations
{
    public partial class renameadvertisementappuserstatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertisementAppUsers_advertisementAppUserStatuses_AdvertisementAppUserStatusId",
                table: "AdvertisementAppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_advertisementAppUserStatuses",
                table: "advertisementAppUserStatuses");

            migrationBuilder.RenameTable(
                name: "advertisementAppUserStatuses",
                newName: "AdvertisementAppUserStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertisementAppUserStatuses",
                table: "AdvertisementAppUserStatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertisementAppUsers_AdvertisementAppUserStatuses_AdvertisementAppUserStatusId",
                table: "AdvertisementAppUsers",
                column: "AdvertisementAppUserStatusId",
                principalTable: "AdvertisementAppUserStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertisementAppUsers_AdvertisementAppUserStatuses_AdvertisementAppUserStatusId",
                table: "AdvertisementAppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertisementAppUserStatuses",
                table: "AdvertisementAppUserStatuses");

            migrationBuilder.RenameTable(
                name: "AdvertisementAppUserStatuses",
                newName: "advertisementAppUserStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_advertisementAppUserStatuses",
                table: "advertisementAppUserStatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertisementAppUsers_advertisementAppUserStatuses_AdvertisementAppUserStatusId",
                table: "AdvertisementAppUsers",
                column: "AdvertisementAppUserStatusId",
                principalTable: "advertisementAppUserStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
