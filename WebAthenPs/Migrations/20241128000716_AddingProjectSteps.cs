using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingProjectSteps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectSteps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Step1HireArchitectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step2ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step3ApprovalInCityHallId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step4ComplementaryProjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step5BudgetSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step6ConstructionPlanningId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step7PreliminaryServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step8ConstructionLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step9StructuralProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step10MasonryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step11RoofingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step12SanitaryInstallationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step13ElectricalInstallationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step14ComplementaryInstallationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step15FinishesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step16DoorsAndWindowsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step17CeilingsAndFinishesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step18MarbleworkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step19LightingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step20FloorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step21CarpentryWashbasinsAndMetalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step22PaintingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step23LandscapingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step24CleaningOfTheSiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Step25DecorationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSteps_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step10Masonries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step10Masonries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step10Masonries_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step11Roofings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step11Roofings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step11Roofings_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step12SanitaryInstallations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step12SanitaryInstallations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step12SanitaryInstallations_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step13ElectricalInstallations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step13ElectricalInstallations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step13ElectricalInstallations_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step14ComplementaryInstallations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step14ComplementaryInstallations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step14ComplementaryInstallations_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step15Finishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step15Finishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step15Finishes_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step16DoorsAndWindows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step16DoorsAndWindows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step16DoorsAndWindows_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step17CeilingsAndFinishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step17CeilingsAndFinishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step17CeilingsAndFinishes_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step18Marbleworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step18Marbleworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step18Marbleworks_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step19Lightings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step19Lightings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step19Lightings_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step1HireArchitects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step1HireArchitects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step1HireArchitects_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step20Floors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step20Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step20Floors_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step21CarpentryWashbasinsAndMetals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step21CarpentryWashbasinsAndMetals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step21CarpentryWashbasinsAndMetals_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step22Paintings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step22Paintings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step22Paintings_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step23Landscapings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step23Landscapings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step23Landscapings_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step24CleaningOfTheSites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step24CleaningOfTheSites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step24CleaningOfTheSites_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step25Decorations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step25Decorations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step25Decorations_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step2Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step2Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step2Projects_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step3ApprovalInCityHalls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step3ApprovalInCityHalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step3ApprovalInCityHalls_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step4ComplementaryProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step4ComplementaryProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step4ComplementaryProjects_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step5BudgetSheets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step5BudgetSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step5BudgetSheets_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step6ConstructionPlannings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step6ConstructionPlannings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step6ConstructionPlannings_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step7PreliminaryServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step7PreliminaryServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step7PreliminaryServices_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step8ConstructionLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step8ConstructionLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step8ConstructionLocations_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step9StructuralProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStepsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step9StructuralProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step9StructuralProjects_ProjectSteps_ProjectStepsId",
                        column: x => x.ProjectStepsId,
                        principalTable: "ProjectSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b164875-6c3d-4216-8de6-2429cb540a23", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7774), "cf6111c2-ef09-49bb-aa5c-2d21bf14526d", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a9394d94-326e-47dd-b600-fda74c0ecb23", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8042), "5855e4ad-0417-47ca-83e2-b4ee82de8245", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1c71b94-50a0-4693-aa47-9a4dedf29d0d", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8088), "d5d01534-db58-4251-bb94-ae7a50e23f2a", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "12c5af4c-43d9-468a-a5db-d1ee670339d0", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8100), "5c00fd9a-b17b-4eee-aa4d-2cda2a407651", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f495884b-13ec-4fd4-a0b5-81d84b9afa84", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8112), "8bb31c51-ab28-4636-b05e-a69394f8b795", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25a7c3fc-d76a-4dba-a9a0-fb63fc4a1a98", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8122), "e92bccd2-861d-4fbd-b12c-93709beeda73", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1c97ca11-1a93-4c87-8e9b-7a9217ea9293", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8138), "d6164781-26f3-4f48-965f-901c3619ccb2", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "798243fc-900b-4c5e-b1e6-7427b768c929", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8155), "96f1bcb7-f7fd-41cd-869a-e35767dc363f", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "778792ff-48da-4930-9c41-e266fa7c40a3", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8200), "14755bd8-0fb2-48e4-ac7f-963574a24a73", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a5b1d3e8-cf2c-43b7-b3fb-128dd4ea88df", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8213), "969ffa31-4306-42ed-a362-060820721bf8", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4846ff2e-7e2f-4f1d-901b-f90f2972a627", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8224), "505306cd-906a-43a0-8dcc-fc1d690b9715", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cb4af3fd-9f0b-443b-92f1-a034c3b85bb3", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7935), "df7c80ee-1c1f-4c02-96cb-33079a0bea43", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a44859f-f974-40ad-9f9c-5a724e710d99", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8236), "eb837bf7-31a5-418d-b837-6873d97055d8", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c25d1ce6-8c5a-4620-a572-8c71de207944", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8248), "77a9286c-f25c-4d05-95d9-d4cc6e9254ee", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f422a42-d159-43a5-a548-7e596c4d3599", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8259), "26b2b1b2-898d-4c0b-a696-e902340d04dd", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2807599-ec13-4f26-b8a6-f8ac82e914e7", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8271), "c8694bc3-c694-4129-9b65-fc6cbb2ff37a", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1bd109c-ac1d-4025-910f-fba8fb44f7ff", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8283), "5b637313-8abf-4e26-b7cf-1b29d40b17e7", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "69b6b00e-11c6-43ff-b5dd-608d3d596d1a", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8293), "a9825586-c190-4877-abd1-a0341aa65a14", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "561f57f9-a591-4877-b549-f9a2a9f896a9", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8305), "549eb112-a456-4216-9ce9-c7d5010186c0", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "60f8358d-1de1-496d-8e30-e14a1863ed84", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8316), "7f2512cb-ee38-4984-a3f1-757ea2222d3d", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "af95d710-afa6-4edc-b9b3-46567626002e", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8327), "933b83b5-8e61-4ac1-8da1-0d1b3c90d727", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b90ad0ac-27e6-4bb7-95d4-aaf12472dd4b", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8339), "fae80681-e47c-4719-9aa4-47907c1cc5fb", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1352d887-6466-49fa-809e-c0002d0985fa", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7949), "d52a2bbe-c942-4157-8804-3c1c3397d9dc", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "893e105f-75c3-40f5-a8ee-50979c4e99d3", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8350), "6fd343a5-6903-4651-bc51-a4a42c3391ad", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19b4a14c-3456-4bbe-a7a6-582e79a949dd", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7960), "d90ae0ff-9e8d-4e36-b71f-d49064854ca4", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f14586e9-518a-4319-9ee2-e11e81a47d6f", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7973), "c787270a-ad81-4073-9ff6-80483e3a1f83", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71378ea1-9858-4872-809e-fba959c693ea", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7994), "67efc25b-8a11-4d33-85a7-97f6a7d2fb13", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "31772000-e71c-4472-91c4-fd4211d2585b", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8005), "10494ab6-1915-4849-9bb7-b1cb74530761", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4fc06849-b357-4573-b827-f4f307875319", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8018), "b45df76c-fefc-45c2-a403-f3ccd74326e0", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c94bddd1-962d-4e14-81c0-92025fd84dd1", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8029), "34b4fce6-91ed-49b3-9595-b276f5f2c2d6", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_ProjectId",
                table: "ProjectSteps",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step10MasonryId",
                table: "ProjectSteps",
                column: "Step10MasonryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step11RoofingId",
                table: "ProjectSteps",
                column: "Step11RoofingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step12SanitaryInstallationsId",
                table: "ProjectSteps",
                column: "Step12SanitaryInstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step13ElectricalInstallationsId",
                table: "ProjectSteps",
                column: "Step13ElectricalInstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step14ComplementaryInstallationsId",
                table: "ProjectSteps",
                column: "Step14ComplementaryInstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step15FinishesId",
                table: "ProjectSteps",
                column: "Step15FinishesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step16DoorsAndWindowsId",
                table: "ProjectSteps",
                column: "Step16DoorsAndWindowsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step17CeilingsAndFinishesId",
                table: "ProjectSteps",
                column: "Step17CeilingsAndFinishesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step18MarbleworkId",
                table: "ProjectSteps",
                column: "Step18MarbleworkId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step19LightingId",
                table: "ProjectSteps",
                column: "Step19LightingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step1HireArchitectId",
                table: "ProjectSteps",
                column: "Step1HireArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step20FloorsId",
                table: "ProjectSteps",
                column: "Step20FloorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step21CarpentryWashbasinsAndMetalsId",
                table: "ProjectSteps",
                column: "Step21CarpentryWashbasinsAndMetalsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step22PaintingId",
                table: "ProjectSteps",
                column: "Step22PaintingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step23LandscapingId",
                table: "ProjectSteps",
                column: "Step23LandscapingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step24CleaningOfTheSiteId",
                table: "ProjectSteps",
                column: "Step24CleaningOfTheSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step25DecorationId",
                table: "ProjectSteps",
                column: "Step25DecorationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step2ProjectId",
                table: "ProjectSteps",
                column: "Step2ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step3ApprovalInCityHallId",
                table: "ProjectSteps",
                column: "Step3ApprovalInCityHallId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step4ComplementaryProjectsId",
                table: "ProjectSteps",
                column: "Step4ComplementaryProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step5BudgetSheetId",
                table: "ProjectSteps",
                column: "Step5BudgetSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step6ConstructionPlanningId",
                table: "ProjectSteps",
                column: "Step6ConstructionPlanningId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step7PreliminaryServicesId",
                table: "ProjectSteps",
                column: "Step7PreliminaryServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step8ConstructionLocationId",
                table: "ProjectSteps",
                column: "Step8ConstructionLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_Step9StructuralProjectId",
                table: "ProjectSteps",
                column: "Step9StructuralProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Step10Masonries_ProjectStepsId",
                table: "Step10Masonries",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step11Roofings_ProjectStepsId",
                table: "Step11Roofings",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step12SanitaryInstallations_ProjectStepsId",
                table: "Step12SanitaryInstallations",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step13ElectricalInstallations_ProjectStepsId",
                table: "Step13ElectricalInstallations",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step14ComplementaryInstallations_ProjectStepsId",
                table: "Step14ComplementaryInstallations",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step15Finishes_ProjectStepsId",
                table: "Step15Finishes",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step16DoorsAndWindows_ProjectStepsId",
                table: "Step16DoorsAndWindows",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step17CeilingsAndFinishes_ProjectStepsId",
                table: "Step17CeilingsAndFinishes",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step18Marbleworks_ProjectStepsId",
                table: "Step18Marbleworks",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step19Lightings_ProjectStepsId",
                table: "Step19Lightings",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step1HireArchitects_ProjectStepsId",
                table: "Step1HireArchitects",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step20Floors_ProjectStepsId",
                table: "Step20Floors",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step21CarpentryWashbasinsAndMetals_ProjectStepsId",
                table: "Step21CarpentryWashbasinsAndMetals",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step22Paintings_ProjectStepsId",
                table: "Step22Paintings",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step23Landscapings_ProjectStepsId",
                table: "Step23Landscapings",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step24CleaningOfTheSites_ProjectStepsId",
                table: "Step24CleaningOfTheSites",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step25Decorations_ProjectStepsId",
                table: "Step25Decorations",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step2Projects_ProjectStepsId",
                table: "Step2Projects",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step3ApprovalInCityHalls_ProjectStepsId",
                table: "Step3ApprovalInCityHalls",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step4ComplementaryProjects_ProjectStepsId",
                table: "Step4ComplementaryProjects",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step5BudgetSheets_ProjectStepsId",
                table: "Step5BudgetSheets",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step6ConstructionPlannings_ProjectStepsId",
                table: "Step6ConstructionPlannings",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step7PreliminaryServices_ProjectStepsId",
                table: "Step7PreliminaryServices",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step8ConstructionLocations_ProjectStepsId",
                table: "Step8ConstructionLocations",
                column: "ProjectStepsId");

            migrationBuilder.CreateIndex(
                name: "IX_Step9StructuralProjects_ProjectStepsId",
                table: "Step9StructuralProjects",
                column: "ProjectStepsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step10Masonries_Step10MasonryId",
                table: "ProjectSteps",
                column: "Step10MasonryId",
                principalTable: "Step10Masonries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step11Roofings_Step11RoofingId",
                table: "ProjectSteps",
                column: "Step11RoofingId",
                principalTable: "Step11Roofings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step12SanitaryInstallations_Step12SanitaryInstallationsId",
                table: "ProjectSteps",
                column: "Step12SanitaryInstallationsId",
                principalTable: "Step12SanitaryInstallations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step13ElectricalInstallations_Step13ElectricalInstallationsId",
                table: "ProjectSteps",
                column: "Step13ElectricalInstallationsId",
                principalTable: "Step13ElectricalInstallations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step14ComplementaryInstallations_Step14ComplementaryInstallationsId",
                table: "ProjectSteps",
                column: "Step14ComplementaryInstallationsId",
                principalTable: "Step14ComplementaryInstallations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step15Finishes_Step15FinishesId",
                table: "ProjectSteps",
                column: "Step15FinishesId",
                principalTable: "Step15Finishes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step16DoorsAndWindows_Step16DoorsAndWindowsId",
                table: "ProjectSteps",
                column: "Step16DoorsAndWindowsId",
                principalTable: "Step16DoorsAndWindows",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step17CeilingsAndFinishes_Step17CeilingsAndFinishesId",
                table: "ProjectSteps",
                column: "Step17CeilingsAndFinishesId",
                principalTable: "Step17CeilingsAndFinishes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step18Marbleworks_Step18MarbleworkId",
                table: "ProjectSteps",
                column: "Step18MarbleworkId",
                principalTable: "Step18Marbleworks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step19Lightings_Step19LightingId",
                table: "ProjectSteps",
                column: "Step19LightingId",
                principalTable: "Step19Lightings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step1HireArchitects_Step1HireArchitectId",
                table: "ProjectSteps",
                column: "Step1HireArchitectId",
                principalTable: "Step1HireArchitects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step20Floors_Step20FloorsId",
                table: "ProjectSteps",
                column: "Step20FloorsId",
                principalTable: "Step20Floors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step21CarpentryWashbasinsAndMetals_Step21CarpentryWashbasinsAndMetalsId",
                table: "ProjectSteps",
                column: "Step21CarpentryWashbasinsAndMetalsId",
                principalTable: "Step21CarpentryWashbasinsAndMetals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step22Paintings_Step22PaintingId",
                table: "ProjectSteps",
                column: "Step22PaintingId",
                principalTable: "Step22Paintings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step23Landscapings_Step23LandscapingId",
                table: "ProjectSteps",
                column: "Step23LandscapingId",
                principalTable: "Step23Landscapings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step24CleaningOfTheSites_Step24CleaningOfTheSiteId",
                table: "ProjectSteps",
                column: "Step24CleaningOfTheSiteId",
                principalTable: "Step24CleaningOfTheSites",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step25Decorations_Step25DecorationId",
                table: "ProjectSteps",
                column: "Step25DecorationId",
                principalTable: "Step25Decorations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step2Projects_Step2ProjectId",
                table: "ProjectSteps",
                column: "Step2ProjectId",
                principalTable: "Step2Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step3ApprovalInCityHalls_Step3ApprovalInCityHallId",
                table: "ProjectSteps",
                column: "Step3ApprovalInCityHallId",
                principalTable: "Step3ApprovalInCityHalls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step4ComplementaryProjects_Step4ComplementaryProjectsId",
                table: "ProjectSteps",
                column: "Step4ComplementaryProjectsId",
                principalTable: "Step4ComplementaryProjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step5BudgetSheets_Step5BudgetSheetId",
                table: "ProjectSteps",
                column: "Step5BudgetSheetId",
                principalTable: "Step5BudgetSheets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step6ConstructionPlannings_Step6ConstructionPlanningId",
                table: "ProjectSteps",
                column: "Step6ConstructionPlanningId",
                principalTable: "Step6ConstructionPlannings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step7PreliminaryServices_Step7PreliminaryServicesId",
                table: "ProjectSteps",
                column: "Step7PreliminaryServicesId",
                principalTable: "Step7PreliminaryServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step8ConstructionLocations_Step8ConstructionLocationId",
                table: "ProjectSteps",
                column: "Step8ConstructionLocationId",
                principalTable: "Step8ConstructionLocations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSteps_Step9StructuralProjects_Step9StructuralProjectId",
                table: "ProjectSteps",
                column: "Step9StructuralProjectId",
                principalTable: "Step9StructuralProjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step10Masonries_Step10MasonryId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step11Roofings_Step11RoofingId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step12SanitaryInstallations_Step12SanitaryInstallationsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step13ElectricalInstallations_Step13ElectricalInstallationsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step14ComplementaryInstallations_Step14ComplementaryInstallationsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step15Finishes_Step15FinishesId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step16DoorsAndWindows_Step16DoorsAndWindowsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step17CeilingsAndFinishes_Step17CeilingsAndFinishesId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step18Marbleworks_Step18MarbleworkId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step19Lightings_Step19LightingId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step1HireArchitects_Step1HireArchitectId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step20Floors_Step20FloorsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step21CarpentryWashbasinsAndMetals_Step21CarpentryWashbasinsAndMetalsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step22Paintings_Step22PaintingId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step23Landscapings_Step23LandscapingId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step24CleaningOfTheSites_Step24CleaningOfTheSiteId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step25Decorations_Step25DecorationId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step2Projects_Step2ProjectId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step3ApprovalInCityHalls_Step3ApprovalInCityHallId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step4ComplementaryProjects_Step4ComplementaryProjectsId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step5BudgetSheets_Step5BudgetSheetId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step6ConstructionPlannings_Step6ConstructionPlanningId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step7PreliminaryServices_Step7PreliminaryServicesId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step8ConstructionLocations_Step8ConstructionLocationId",
                table: "ProjectSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSteps_Step9StructuralProjects_Step9StructuralProjectId",
                table: "ProjectSteps");

            migrationBuilder.DropTable(
                name: "Step10Masonries");

            migrationBuilder.DropTable(
                name: "Step11Roofings");

            migrationBuilder.DropTable(
                name: "Step12SanitaryInstallations");

            migrationBuilder.DropTable(
                name: "Step13ElectricalInstallations");

            migrationBuilder.DropTable(
                name: "Step14ComplementaryInstallations");

            migrationBuilder.DropTable(
                name: "Step15Finishes");

            migrationBuilder.DropTable(
                name: "Step16DoorsAndWindows");

            migrationBuilder.DropTable(
                name: "Step17CeilingsAndFinishes");

            migrationBuilder.DropTable(
                name: "Step18Marbleworks");

            migrationBuilder.DropTable(
                name: "Step19Lightings");

            migrationBuilder.DropTable(
                name: "Step1HireArchitects");

            migrationBuilder.DropTable(
                name: "Step20Floors");

            migrationBuilder.DropTable(
                name: "Step21CarpentryWashbasinsAndMetals");

            migrationBuilder.DropTable(
                name: "Step22Paintings");

            migrationBuilder.DropTable(
                name: "Step23Landscapings");

            migrationBuilder.DropTable(
                name: "Step24CleaningOfTheSites");

            migrationBuilder.DropTable(
                name: "Step25Decorations");

            migrationBuilder.DropTable(
                name: "Step2Projects");

            migrationBuilder.DropTable(
                name: "Step3ApprovalInCityHalls");

            migrationBuilder.DropTable(
                name: "Step4ComplementaryProjects");

            migrationBuilder.DropTable(
                name: "Step5BudgetSheets");

            migrationBuilder.DropTable(
                name: "Step6ConstructionPlannings");

            migrationBuilder.DropTable(
                name: "Step7PreliminaryServices");

            migrationBuilder.DropTable(
                name: "Step8ConstructionLocations");

            migrationBuilder.DropTable(
                name: "Step9StructuralProjects");

            migrationBuilder.DropTable(
                name: "ProjectSteps");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1dbedbce-c034-4786-8004-a02d47ccbfcd", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8639), "1f6f9f86-2d5b-4cf1-9d5f-d479f9186f86", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef9029dc-537d-4958-91da-db5c4a11163f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8917), "007e9a9d-82e4-4cf4-bfbd-75ae39b85c7b", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8b93595a-e29f-45ce-aeb8-13652622c1a1", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8958), "088e780f-36e1-4e4f-a6ca-c67e69d97bb7", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a930237c-e525-4130-88ff-788000e9ef17", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8972), "bc3672a4-ac1c-4fba-a474-e75b0368ea37", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8bdbd97-329a-4460-ade4-c167eef291c2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8983), "60833720-55ed-45db-bd80-2d665e2660e3", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c9d495f-2c16-4226-837d-0d329a11251e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8995), "847a6def-95b3-4afa-b4a6-ca88f056ccd5", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b50f43c2-4f9a-4c04-83b1-0416c93b77a1", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9008), "e9bf5721-be89-4614-9a1a-46df3c7f4943", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca1644fd-9650-4b10-9ceb-c10a0be6ff4a", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9030), "acac771e-1110-432a-8e41-b62c40104924", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db2c1a70-707d-4c02-bad8-dcd0ad2adca7", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9041), "e0218aa0-27db-4681-80da-62e1d9025d29", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "139356fa-0e54-409b-bbd8-063ef08bd673", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9054), "48c0d315-64c9-4b81-8862-08f0f915d531", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33027b22-3a22-455d-b1fd-7381d40fa02e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9066), "2bf91a1e-7d2b-4c75-9f25-2b98e8935c76", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "feaa01ce-8c3e-41ef-abf0-2b58c0c14645", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8785), "9a6bc4db-1990-411a-9fb1-01cc99578aaf", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dc957fb6-e77d-4326-87a0-c5b59c1e4c7b", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9079), "cce38415-c231-406f-959a-efaf05e94b58", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7c4bfbe7-a3b0-4fa8-b37d-cf74f2c4c0ef", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9090), "c882c48a-c64a-44a5-8e48-539269c3c6c7", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ddb9a488-17ca-4deb-bf6b-fe253a13cafc", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9101), "65ec57ba-d10c-4dc3-b2a7-22a999ff1611", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a8c7aa8-5ce7-4728-a7a2-f5f6edc4cbb3", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9114), "cb7e4aff-3540-46a9-86be-3ca5627f3af2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6cdae722-5fa7-4b78-b3d2-4d8ca77d3bc2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9126), "b38e1e3a-47c8-44b9-b7b3-708f319f1654", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eefbf515-b045-44e6-8ce6-42c3772e5f5c", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9172), "fc141008-0545-4911-a79a-f78e4b9e17a2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3816d023-4f7c-4561-a082-9cc66d96dc78", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9186), "9b04ca46-1cde-434d-85e4-f912a93239bb", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71e4db90-b6a9-4225-bb11-e49c74249a0f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9199), "747f4f48-32bc-4ade-93ac-fe1668120928", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f0f0d72-ed8a-46be-bd83-8ddb04ad893f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9211), "e869606d-3487-4d36-8401-fabe8aba75ad", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34267f99-f2f1-4840-96b0-039f6fc61ba9", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9223), "0a1ab684-5fdc-418c-86bf-20b61613c4e1", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce1f60d3-bea6-4c8e-8045-b1c79b2f9666", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8800), "576b1fed-7a12-4de9-b9ee-ca0e470dbdb3", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf8ba6a7-d683-40d8-83ce-4c664735f039", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9235), "ae890c71-3791-42be-8ca1-245c2dda4699", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4644c349-3e19-4247-80f1-12b26568c183", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8814), "be79edbd-3cec-499c-ae55-dd597660f893", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "58344836-a834-48b3-a86b-0c7b67e01070", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8826), "5499cb51-a4c0-4b3b-bbe1-4076ca9c0e6f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "afbab071-fc1c-460f-b815-d1dd35fb05a9", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8845), "0e2cedef-d667-4c54-a66f-b6f5a7cdc92e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a3cc57f8-8e6f-4b85-a2b7-41942e3d13b8", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8859), "9b7fcdfd-965a-4e70-8f85-6bd572558d3e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f93d92a-14a6-400f-9e87-a4b600e75137", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8870), "9b5e5616-ff81-4116-ae16-f530aac755bb", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "17c82121-7c8d-4427-a491-4359ee02f029", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8904), "5ab0520f-a696-4e64-be3a-77534211cc10", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8904) });
        }
    }
}
