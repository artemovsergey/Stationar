using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stationar.Domen.Migrations
{
    /// <inheritdoc />
    public partial class AddColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Places_PlaceId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_PlaceId",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Places_RoomId",
                table: "Places",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Rooms_RoomId",
                table: "Places",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Rooms_RoomId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_RoomId",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Places");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PlaceId",
                table: "Rooms",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Places_PlaceId",
                table: "Rooms",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
