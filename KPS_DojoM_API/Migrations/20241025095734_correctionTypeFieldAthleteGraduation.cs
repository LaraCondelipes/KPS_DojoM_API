using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class correctionTypeFieldAthleteGraduation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AthleteGraduation",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AthleteGraduation",
                table: "Athletes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
