using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class ModificationFieldsTableAthlete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AthleteBirthdayDate",
                table: "Athletes",
                newName: "AthleteBirthdayDay");

            migrationBuilder.AddColumn<string>(
                name: "AthleteCity",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AthleteCountry",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AthleteHeight",
                table: "Athletes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AthleteOccupacion",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AthletePlaceOfBirth",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AthleteRegisterDate",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AthleteSignature",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AthleteWeight",
                table: "Athletes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AthleteZipCode",
                table: "Athletes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentAthleteSignature",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegisterNumber",
                table: "Athletes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AthleteCity",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteCountry",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteHeight",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteOccupacion",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthletePlaceOfBirth",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteRegisterDate",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteSignature",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteWeight",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "AthleteZipCode",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "ParentAthleteSignature",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "RegisterNumber",
                table: "Athletes");

            migrationBuilder.RenameColumn(
                name: "AthleteBirthdayDay",
                table: "Athletes",
                newName: "AthleteBirthdayDate");
        }
    }
}
