using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stationar.Domen.Migrations
{
    /// <inheritdoc />
    public partial class DeletePlaceIdFromRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Rooms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
