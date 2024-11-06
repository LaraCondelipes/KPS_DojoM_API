using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Association",
                columns: table => new
                {
                    AssociationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssociationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Association", x => x.AssociationId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kyu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCellPhone = table.Column<int>(type: "int", nullable: true),
                    ParentNif = table.Column<int>(type: "int", nullable: true),
                    ParentCcNumber = table.Column<int>(type: "int", nullable: true),
                    ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentsId);
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
                        principalColumn: "AssociationId");
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
                    table.ForeignKey(
                        name: "FK_Senseis_Association_AssociationId",
                        column: x => x.AssociationId,
                        principalTable: "Association",
                        principalColumn: "AssociationId");
                });

            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    AthletesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    AssociationId = table.Column<int>(type: "int", nullable: true),
                    ParentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.AthletesId);
                    table.ForeignKey(
                        name: "FK_Athletes_Association_AssociationId",
                        column: x => x.AssociationId,
                        principalTable: "Association",
                        principalColumn: "AssociationId");
                    table.ForeignKey(
                        name: "FK_Athletes_Parents_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Parents",
                        principalColumn: "ParentsId");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionshipId = table.Column<int>(type: "int", nullable: true),
                    ChampionshipsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Championships_ChampionshipsId",
                        column: x => x.ChampionshipsId,
                        principalTable: "Championships",
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
                    AthletesId = table.Column<int>(type: "int", nullable: true),
                    CategoriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheResults_Athletes_AthletesId",
                        column: x => x.AthletesId,
                        principalTable: "Athletes",
                        principalColumn: "AthletesId");
                    table.ForeignKey(
                        name: "FK_TheResults_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "CategoriesId");
                });

            migrationBuilder.CreateTable(
                name: "CategoriesEvents",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    EventsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesEvents", x => new { x.CategoriesId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_CategoriesEvents_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "CategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesEvents_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_AssociationId",
                table: "Athletes",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_ParentsId",
                table: "Athletes",
                column: "ParentsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesEvents_EventsId",
                table: "CategoriesEvents",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_AssociationId",
                table: "Championships",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ChampionshipsId",
                table: "Events",
                column: "ChampionshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Senseis_AssociationId",
                table: "Senseis",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_TheResults_AthletesId",
                table: "TheResults",
                column: "AthletesId");

            migrationBuilder.CreateIndex(
                name: "IX_TheResults_CategoriesId",
                table: "TheResults",
                column: "CategoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesEvents");

            migrationBuilder.DropTable(
                name: "Senseis");

            migrationBuilder.DropTable(
                name: "TheResults");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Association");
        }
    }
}
