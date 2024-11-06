using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class correctionTypeFieldChampionshipName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChampionshipsName",
                table: "Championships");

            migrationBuilder.AddColumn<string>(
                name: "ChampionshipName",
                table: "Championships",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChampionshipName",
                table: "Championships");

            migrationBuilder.AddColumn<int>(
                name: "ChampionshipsName",
                table: "Championships",
                type: "int",
                nullable: true);
        }
    }
}
