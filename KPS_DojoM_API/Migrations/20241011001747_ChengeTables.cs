using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class ChengeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoriesId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CategoriesId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AthleteId",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "AthletesAssociationId",
                table: "TheResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AthletesCategoryId",
                table: "TheResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AthletesParentId",
                table: "TheResults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriesEvents",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesEvents", x => new { x.CategoryId, x.EventId });
                    table.ForeignKey(
                        name: "FK_CategoriesEvents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TheResults_AthletesAssociationId_AthletesCategoryId_AthletesParentId",
                table: "TheResults",
                columns: new[] { "AthletesAssociationId", "AthletesCategoryId", "AthletesParentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Senseis_AssociationId",
                table: "Senseis",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesEvents_EventId",
                table: "CategoriesEvents",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Senseis_Association_AssociationId",
                table: "Senseis",
                column: "AssociationId",
                principalTable: "Association",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TheResults_Athletes_AthletesAssociationId_AthletesCategoryId_AthletesParentId",
                table: "TheResults",
                columns: new[] { "AthletesAssociationId", "AthletesCategoryId", "AthletesParentId" },
                principalTable: "Athletes",
                principalColumns: new[] { "AssociationId", "CategoryId", "ParentId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Senseis_Association_AssociationId",
                table: "Senseis");

            migrationBuilder.DropForeignKey(
                name: "FK_TheResults_Athletes_AthletesAssociationId_AthletesCategoryId_AthletesParentId",
                table: "TheResults");

            migrationBuilder.DropTable(
                name: "CategoriesEvents");

            migrationBuilder.DropIndex(
                name: "IX_TheResults_AthletesAssociationId_AthletesCategoryId_AthletesParentId",
                table: "TheResults");

            migrationBuilder.DropIndex(
                name: "IX_Senseis_AssociationId",
                table: "Senseis");

            migrationBuilder.DropColumn(
                name: "AthletesAssociationId",
                table: "TheResults");

            migrationBuilder.DropColumn(
                name: "AthletesCategoryId",
                table: "TheResults");

            migrationBuilder.DropColumn(
                name: "AthletesParentId",
                table: "TheResults");

            migrationBuilder.AddColumn<int>(
                name: "AthleteId",
                table: "Parents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoriesId",
                table: "Events",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoriesId",
                table: "Events",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
