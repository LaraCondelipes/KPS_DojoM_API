using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Association",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssociationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Association", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCellPhone = table.Column<int>(type: "int", nullable: true),
                    ParentNif = table.Column<int>(type: "int", nullable: true),
                    ParentCcNumber = table.Column<int>(type: "int", nullable: true),
                    ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AthleteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Senseis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeinseiName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenseiKYU = table.Column<int>(type: "int", nullable: true),
                    LicenceNumber = table.Column<int>(type: "int", nullable: true),
                    SenseiCellPhone = table.Column<int>(type: "int", nullable: true),
                    SenseiEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociationMemberNumber = table.Column<int>(type: "int", nullable: false),
                    AssociationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senseis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Championships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionshipName = table.Column<int>(type: "int", nullable: true),
                    AssociationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Championships_Association_AssociationId",
                        column: x => x.AssociationId,
                        principalTable: "Association",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TheResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodiumPlace = table.Column<int>(type: "int", nullable: true),
                    ChampionshipsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheResults_Championships_ChampionshipsId",
                        column: x => x.ChampionshipsId,
                        principalTable: "Championships",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheResultsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_TheResults_TheResultsId",
                        column: x => x.TheResultsId,
                        principalTable: "TheResults",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AssociationId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true),
                    AthleteKYU = table.Column<int>(type: "int", nullable: true),
                    AthleteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AthleteBirthdayDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AthleteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AthleteEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AthleteCellPhone = table.Column<int>(type: "int", nullable: true),
                    AthleteNif = table.Column<int>(type: "int", nullable: true),
                    AthleteCcNumber = table.Column<int>(type: "int", nullable: true),
                    Club = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AthleteClubMemberNumber = table.Column<int>(type: "int", nullable: true),
                    AssociationMemberNumber = table.Column<int>(type: "int", nullable: true),
                    CategoriesId = table.Column<int>(type: "int", nullable: true),
                    ParentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => new { x.AssociationId, x.CategoryId, x.ParentId });
                    table.ForeignKey(
                        name: "FK_Athletes_Association_AssociationId",
                        column: x => x.AssociationId,
                        principalTable: "Association",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Athletes_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Athletes_Parents_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Parents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesId = table.Column<int>(type: "int", nullable: true),
                    TheResultsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_TheResults_TheResultsId",
                        column: x => x.TheResultsId,
                        principalTable: "TheResults",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_CategoriesId",
                table: "Athletes",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_ParentsId",
                table: "Athletes",
                column: "ParentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TheResultsId",
                table: "Categories",
                column: "TheResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_AssociationId",
                table: "Championships",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoriesId",
                table: "Events",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TheResultsId",
                table: "Events",
                column: "TheResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_TheResults_ChampionshipsId",
                table: "TheResults",
                column: "ChampionshipsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Senseis");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TheResults");

            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "Association");
        }
    }
}
