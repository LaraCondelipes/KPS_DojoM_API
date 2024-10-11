using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class changeTableAthlete_ResultFieldCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AthleteId",
                table: "TheResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AthleteId",
                table: "TheResults");
        }
    }
}
