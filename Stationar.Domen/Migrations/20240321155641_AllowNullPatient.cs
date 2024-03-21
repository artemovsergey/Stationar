using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stationar.Domen.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Patients_PatientId",
                table: "Places");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Places",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Patients_PatientId",
                table: "Places",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Patients_PatientId",
                table: "Places");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Patients_PatientId",
                table: "Places",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
