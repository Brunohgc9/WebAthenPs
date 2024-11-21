using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Dbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Architects_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Architects");

            migrationBuilder.DropForeignKey(
                name: "FK_Cabinetmaker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Cabinetmaker");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpenter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Carpenter");

            migrationBuilder.DropForeignKey(
                name: "FK_CivilEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "CivilEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_Decorator_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Decorator");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "ElectricalEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_Electrician_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Electrician");

            migrationBuilder.DropForeignKey(
                name: "FK_Foreman_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Foreman");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Architects_ArchitectId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Cabinetmaker_CabinetmakerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Carpenter_CarpenterId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_CivilEngineer_CivilEngineerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Decorator_DecoratorId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_ElectricalEngineer_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Electrician_ElectricianId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Foreman_ForemanId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_GenericProfessionals_genericId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Glazier_GlazierId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_HydraulicEngineer_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_InteriorDesigner_InteriorDesignerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Landscaper_LandscaperId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_MarbleWorker_MarbleWorkerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Mason_MasonId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Metalworker_MetalworkerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Painter_PainterId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Plasterer_PlastererId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Plumber_PlumberId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Roofer_RooferId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Surveyor_SurveyorId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Tiler_TilerId",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_GenericProfessionalProfessionalType_EspecializationsId",
                table: "GenericProfessionals");

            migrationBuilder.DropForeignKey(
                name: "FK_Glazier_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Glazier");

            migrationBuilder.DropForeignKey(
                name: "FK_HydraulicEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "HydraulicEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDesigner_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "InteriorDesigner");

            migrationBuilder.DropForeignKey(
                name: "FK_Landscaper_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Landscaper");

            migrationBuilder.DropForeignKey(
                name: "FK_MarbleWorker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "MarbleWorker");

            migrationBuilder.DropForeignKey(
                name: "FK_Mason_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Mason");

            migrationBuilder.DropForeignKey(
                name: "FK_Metalworker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Metalworker");

            migrationBuilder.DropForeignKey(
                name: "FK_Painter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Painter");

            migrationBuilder.DropForeignKey(
                name: "FK_Plasterer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Plasterer");

            migrationBuilder.DropForeignKey(
                name: "FK_Plumber_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Plumber");

            migrationBuilder.DropForeignKey(
                name: "FK_Roofer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Roofer");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveyor_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Surveyor");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiler_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Tiler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiler",
                table: "Tiler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveyor",
                table: "Surveyor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roofer",
                table: "Roofer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plumber",
                table: "Plumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plasterer",
                table: "Plasterer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Painter",
                table: "Painter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Metalworker",
                table: "Metalworker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mason",
                table: "Mason");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MarbleWorker",
                table: "MarbleWorker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landscaper",
                table: "Landscaper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InteriorDesigner",
                table: "InteriorDesigner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HydraulicEngineer",
                table: "HydraulicEngineer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Glazier",
                table: "Glazier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenericProfessionalProfessionalType",
                table: "GenericProfessionalProfessionalType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foreman",
                table: "Foreman");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Electrician",
                table: "Electrician");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalEngineer",
                table: "ElectricalEngineer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Decorator",
                table: "Decorator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CivilEngineer",
                table: "CivilEngineer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carpenter",
                table: "Carpenter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cabinetmaker",
                table: "Cabinetmaker");

            migrationBuilder.RenameTable(
                name: "Tiler",
                newName: "Tilers");

            migrationBuilder.RenameTable(
                name: "Surveyor",
                newName: "Surveyors");

            migrationBuilder.RenameTable(
                name: "Roofer",
                newName: "Roofers");

            migrationBuilder.RenameTable(
                name: "Plumber",
                newName: "Plumbers");

            migrationBuilder.RenameTable(
                name: "Plasterer",
                newName: "Plasterers");

            migrationBuilder.RenameTable(
                name: "Painter",
                newName: "Painters");

            migrationBuilder.RenameTable(
                name: "Metalworker",
                newName: "Metalworkers");

            migrationBuilder.RenameTable(
                name: "Mason",
                newName: "Masons");

            migrationBuilder.RenameTable(
                name: "MarbleWorker",
                newName: "MarbleWorkers");

            migrationBuilder.RenameTable(
                name: "Landscaper",
                newName: "Landscapers");

            migrationBuilder.RenameTable(
                name: "InteriorDesigner",
                newName: "InteriorDesigners");

            migrationBuilder.RenameTable(
                name: "HydraulicEngineer",
                newName: "HydraulicEngineers");

            migrationBuilder.RenameTable(
                name: "Glazier",
                newName: "Glaziers");

            migrationBuilder.RenameTable(
                name: "GenericProfessionalProfessionalType",
                newName: "GenericProfessionalProfessionalTypes");

            migrationBuilder.RenameTable(
                name: "Foreman",
                newName: "Foremen");

            migrationBuilder.RenameTable(
                name: "Electrician",
                newName: "Electricians");

            migrationBuilder.RenameTable(
                name: "ElectricalEngineer",
                newName: "ElectricalEngineers");

            migrationBuilder.RenameTable(
                name: "Decorator",
                newName: "Decorators");

            migrationBuilder.RenameTable(
                name: "CivilEngineer",
                newName: "CivilEngineers");

            migrationBuilder.RenameTable(
                name: "Carpenter",
                newName: "Carpenters");

            migrationBuilder.RenameTable(
                name: "Cabinetmaker",
                newName: "Cabinetmakers");

            migrationBuilder.RenameIndex(
                name: "IX_Tiler_ProfessionalTypeId",
                table: "Tilers",
                newName: "IX_Tilers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveyor_ProfessionalTypeId",
                table: "Surveyors",
                newName: "IX_Surveyors_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Roofer_ProfessionalTypeId",
                table: "Roofers",
                newName: "IX_Roofers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Plumber_ProfessionalTypeId",
                table: "Plumbers",
                newName: "IX_Plumbers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Plasterer_ProfessionalTypeId",
                table: "Plasterers",
                newName: "IX_Plasterers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Painter_ProfessionalTypeId",
                table: "Painters",
                newName: "IX_Painters_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Metalworker_ProfessionalTypeId",
                table: "Metalworkers",
                newName: "IX_Metalworkers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mason_ProfessionalTypeId",
                table: "Masons",
                newName: "IX_Masons_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MarbleWorker_ProfessionalTypeId",
                table: "MarbleWorkers",
                newName: "IX_MarbleWorkers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Landscaper_ProfessionalTypeId",
                table: "Landscapers",
                newName: "IX_Landscapers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_InteriorDesigner_ProfessionalTypeId",
                table: "InteriorDesigners",
                newName: "IX_InteriorDesigners_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_HydraulicEngineer_ProfessionalTypeId",
                table: "HydraulicEngineers",
                newName: "IX_HydraulicEngineers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Glazier_ProfessionalTypeId",
                table: "Glaziers",
                newName: "IX_Glaziers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_TilerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_TilerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_SurveyorId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_SurveyorId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_RooferId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_RooferId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_PlumberId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_PlumberId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_PlastererId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_PlastererId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_PainterId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_PainterId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_MetalworkerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_MetalworkerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_MasonId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_MasonId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_MarbleWorkerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_MarbleWorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_LandscaperId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_LandscaperId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_InteriorDesignerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_InteriorDesignerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_HydraulicEngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_GlazierId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_GlazierId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_genericId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_genericId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_ForemanId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_ForemanId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_ElectricianId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_ElectricianId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_ElectricalEngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_DecoratorId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_DecoratorId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_CivilEngineerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_CivilEngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_CarpenterId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_CarpenterId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_CabinetmakerId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_CabinetmakerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalType_ArchitectId",
                table: "GenericProfessionalProfessionalTypes",
                newName: "IX_GenericProfessionalProfessionalTypes_ArchitectId");

            migrationBuilder.RenameIndex(
                name: "IX_Foreman_ProfessionalTypeId",
                table: "Foremen",
                newName: "IX_Foremen_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Electrician_ProfessionalTypeId",
                table: "Electricians",
                newName: "IX_Electricians_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalEngineer_ProfessionalTypeId",
                table: "ElectricalEngineers",
                newName: "IX_ElectricalEngineers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Decorator_ProfessionalTypeId",
                table: "Decorators",
                newName: "IX_Decorators_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CivilEngineer_ProfessionalTypeId",
                table: "CivilEngineers",
                newName: "IX_CivilEngineers_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpenter_ProfessionalTypeId",
                table: "Carpenters",
                newName: "IX_Carpenters_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Cabinetmaker_ProfessionalTypeId",
                table: "Cabinetmakers",
                newName: "IX_Cabinetmakers_ProfessionalTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tilers",
                table: "Tilers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveyors",
                table: "Surveyors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roofers",
                table: "Roofers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plumbers",
                table: "Plumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plasterers",
                table: "Plasterers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Painters",
                table: "Painters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Metalworkers",
                table: "Metalworkers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Masons",
                table: "Masons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarbleWorkers",
                table: "MarbleWorkers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landscapers",
                table: "Landscapers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteriorDesigners",
                table: "InteriorDesigners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HydraulicEngineers",
                table: "HydraulicEngineers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Glaziers",
                table: "Glaziers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenericProfessionalProfessionalTypes",
                table: "GenericProfessionalProfessionalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foremen",
                table: "Foremen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Electricians",
                table: "Electricians",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalEngineers",
                table: "ElectricalEngineers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decorators",
                table: "Decorators",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CivilEngineers",
                table: "CivilEngineers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carpenters",
                table: "Carpenters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cabinetmakers",
                table: "Cabinetmakers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ecea8f8f-78ad-4f28-860a-0f826498e729", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(5998), "e4a16366-3c35-423c-aef7-37cc82fbcb5a", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68ec956f-8c0b-4802-ae00-f746dc71cc6c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6258), "c8b5f3a3-e29a-4cbd-82c6-6d85cd182fd8", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5abbff42-5fc5-49ca-bcfd-80e64893061f", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6318), "ee535c2f-386b-473b-b26d-c75856611a69", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a00d742-997b-43ca-81c2-b063e5c62226", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6379), "ee51587d-04f0-4d21-8a64-35e0b539cdf0", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "51f9f836-879a-4631-ab22-63a8dcde6d59", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6391), "de3f922a-87d0-4f89-adaa-283d73c794cd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19545bee-5dbc-4c03-8176-544b4fc1e93f", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6403), "108d1448-78c0-4af9-a6a6-7fd7a9e2e3cb", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aba1b701-6feb-4076-a881-3cce190f0265", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6417), "aeaa2f44-7455-4177-93e3-ed06c9550de1", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37efbfe9-670a-47ac-95d1-9887ddadd20b", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6747), "664f8fe2-ff0e-44a7-bfd8-f09058c51362", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0f104361-af21-4410-be64-31b26230baca", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6760), "405d21ee-320e-4175-a3cf-bacfa6fc726b", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f964025-ba7a-4c5b-8636-5df42afd35fb", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6774), "31e33983-2f5b-436c-9814-e42db5ef9f3c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b28f3bae-dac3-46ea-b716-224e48cbe555", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6788), "7c618e7b-3176-45ef-b36f-161c3f21eca4", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c5c96c64-d93c-4d1e-8546-9240868a1b65", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6135), "51756994-470e-4a61-8ac3-3367c3534e31", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8e0521f3-13dd-45bc-8014-0e25c2d1bf81", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6801), "8e4c6343-9c2d-4824-8622-1f0ee03de34c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8511b544-1758-4953-8a7e-0e15da1719fc", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6815), "f12b33b8-cc36-4e78-b155-010e43e91485", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "896e66a2-7ea6-4635-893d-276d48a267a2", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6827), "05d5db64-18e2-4469-a2cf-77994ae58723", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a1c53fd-a1aa-43d7-8800-09234e7180ad", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6842), "88646f35-7e86-455f-966b-338671ff8e9d", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36eb31e9-8d0e-473e-8995-f0d80ad45c92", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6854), "1bc2d97e-bb51-4a76-a0ce-695ded4c42d4", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19c228ee-1058-487d-9abb-a178aaa1dae9", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6866), "e98c9362-0b35-400a-9b3f-6d2e9dd40d65", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77d665de-eb36-43a5-b366-7ee0dd2e936c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6880), "e61e52d5-f6d5-4790-ac95-e0bf951d4aae", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88577619-9c37-4161-9105-7a14670eac27", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6937), "0ae65f3b-ae28-4670-a35b-23fe892a901e", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25c5af04-84d0-46b1-b62f-eab6642c96e7", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6952), "ed509a41-9298-4b75-b9f1-607dc76a3d35", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf4b2f3b-fe6b-4300-97c0-63a87850e4e6", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6965), "25b7738b-5f2b-46cc-a60a-47938f992bc9", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ac94fde-d992-49dc-aa17-ba420c93b20e", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6150), "bc696cc4-3cb5-4b4f-8456-9a5c6f760dc8", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "13b5e988-765d-44f6-8796-bde141eecd4c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6978), "c63abbf5-1a79-44fe-bdc7-1d4fc7fa3542", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fcfa88d7-99e6-44a1-b365-b15391e335ca", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6164), "14061b0a-56ce-44d4-a412-d74751f70402", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7164f5c4-76a1-4493-a6ec-63cd4635e81a", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6177), "6c79767e-4f83-4385-9a95-d7041a3b7e6c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e510e402-b453-4a1f-ad38-f5b241ff137f", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6204), "c4ecabfd-2a06-4d29-9c2f-ee041ec4a9bd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8a2dc13-6e36-46ad-8cf8-432b75a8ee83", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6219), "cac6cdc5-06f8-4d7e-87e7-27df5e502ef4", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2780832c-eabe-48fa-b6e2-c99a9db041a1", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6233), "aed2edfd-3aa6-4ef0-8b25-9d4157e31375", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3dd02bf5-8619-4d15-8404-6b5c0f247afd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6245), "da9fe591-09f0-4866-89b2-fde8c320c6fd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("36f41695-bc6e-4a3f-a7e9-d41643b81245"),
                column: "MasonId",
                value: new Guid("36f41695-bc6e-4a3f-a7e9-d41643b81245"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"),
                column: "DecoratorId",
                value: new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"),
                column: "MetalworkerId",
                value: new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"),
                column: "PainterId",
                value: new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"),
                column: "PainterId",
                value: new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"),
                column: "MasonId",
                value: new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34"),
                columns: new[] { "CarpenterId", "MasonId" },
                values: new object[] { new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34"), new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34") });

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"),
                column: "MasonId",
                value: new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"),
                column: "PlumberId",
                value: new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"),
                column: "MasonId",
                value: new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"),
                columns: new[] { "CarpenterId", "PlumberId" },
                values: new object[] { new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"), new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829") });

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalTypes",
                keyColumn: "Id",
                keyValue: new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"),
                column: "PlumberId",
                value: new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"));

            migrationBuilder.AddForeignKey(
                name: "FK_Architects_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Architects",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabinetmakers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Cabinetmakers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carpenters_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Carpenters",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CivilEngineers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "CivilEngineers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Decorators_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Decorators",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalEngineers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "ElectricalEngineers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Electricians_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Electricians",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foremen_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Foremen",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Architects_ArchitectId",
                table: "GenericProfessionalProfessionalTypes",
                column: "ArchitectId",
                principalTable: "Architects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Cabinetmakers_CabinetmakerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "CabinetmakerId",
                principalTable: "Cabinetmakers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Carpenters_CarpenterId",
                table: "GenericProfessionalProfessionalTypes",
                column: "CarpenterId",
                principalTable: "Carpenters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_CivilEngineers_CivilEngineerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "CivilEngineerId",
                principalTable: "CivilEngineers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Decorators_DecoratorId",
                table: "GenericProfessionalProfessionalTypes",
                column: "DecoratorId",
                principalTable: "Decorators",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_ElectricalEngineers_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "ElectricalEngineerId",
                principalTable: "ElectricalEngineers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Electricians_ElectricianId",
                table: "GenericProfessionalProfessionalTypes",
                column: "ElectricianId",
                principalTable: "Electricians",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Foremen_ForemanId",
                table: "GenericProfessionalProfessionalTypes",
                column: "ForemanId",
                principalTable: "Foremen",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_GenericProfessionals_genericId",
                table: "GenericProfessionalProfessionalTypes",
                column: "genericId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Glaziers_GlazierId",
                table: "GenericProfessionalProfessionalTypes",
                column: "GlazierId",
                principalTable: "Glaziers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_HydraulicEngineers_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "HydraulicEngineerId",
                principalTable: "HydraulicEngineers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_InteriorDesigners_InteriorDesignerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "InteriorDesignerId",
                principalTable: "InteriorDesigners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Landscapers_LandscaperId",
                table: "GenericProfessionalProfessionalTypes",
                column: "LandscaperId",
                principalTable: "Landscapers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_MarbleWorkers_MarbleWorkerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "MarbleWorkerId",
                principalTable: "MarbleWorkers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Masons_MasonId",
                table: "GenericProfessionalProfessionalTypes",
                column: "MasonId",
                principalTable: "Masons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Metalworkers_MetalworkerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "MetalworkerId",
                principalTable: "Metalworkers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Painters_PainterId",
                table: "GenericProfessionalProfessionalTypes",
                column: "PainterId",
                principalTable: "Painters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Plasterers_PlastererId",
                table: "GenericProfessionalProfessionalTypes",
                column: "PlastererId",
                principalTable: "Plasterers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Plumbers_PlumberId",
                table: "GenericProfessionalProfessionalTypes",
                column: "PlumberId",
                principalTable: "Plumbers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Roofers_RooferId",
                table: "GenericProfessionalProfessionalTypes",
                column: "RooferId",
                principalTable: "Roofers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Surveyors_SurveyorId",
                table: "GenericProfessionalProfessionalTypes",
                column: "SurveyorId",
                principalTable: "Surveyors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Tilers_TilerId",
                table: "GenericProfessionalProfessionalTypes",
                column: "TilerId",
                principalTable: "Tilers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_GenericProfessionalProfessionalTypes_EspecializationsId",
                table: "GenericProfessionals",
                column: "EspecializationsId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Glaziers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Glaziers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HydraulicEngineers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "HydraulicEngineers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InteriorDesigners_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "InteriorDesigners",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Landscapers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MarbleWorkers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "MarbleWorkers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Masons_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Masons",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Metalworkers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Metalworkers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Painters_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Painters",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plasterers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Plasterers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plumbers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Plumbers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roofers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Roofers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveyors_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Surveyors",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tilers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Tilers",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Architects_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Architects");

            migrationBuilder.DropForeignKey(
                name: "FK_Cabinetmakers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Cabinetmakers");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpenters_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Carpenters");

            migrationBuilder.DropForeignKey(
                name: "FK_CivilEngineers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "CivilEngineers");

            migrationBuilder.DropForeignKey(
                name: "FK_Decorators_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Decorators");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalEngineers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "ElectricalEngineers");

            migrationBuilder.DropForeignKey(
                name: "FK_Electricians_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Electricians");

            migrationBuilder.DropForeignKey(
                name: "FK_Foremen_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Foremen");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Architects_ArchitectId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Cabinetmakers_CabinetmakerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Carpenters_CarpenterId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_CivilEngineers_CivilEngineerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Decorators_DecoratorId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_ElectricalEngineers_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Electricians_ElectricianId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Foremen_ForemanId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_GenericProfessionals_genericId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Glaziers_GlazierId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_HydraulicEngineers_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_InteriorDesigners_InteriorDesignerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Landscapers_LandscaperId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_MarbleWorkers_MarbleWorkerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Masons_MasonId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Metalworkers_MetalworkerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Painters_PainterId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Plasterers_PlastererId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Plumbers_PlumberId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Roofers_RooferId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Surveyors_SurveyorId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionalProfessionalTypes_Tilers_TilerId",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_GenericProfessionalProfessionalTypes_EspecializationsId",
                table: "GenericProfessionals");

            migrationBuilder.DropForeignKey(
                name: "FK_Glaziers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Glaziers");

            migrationBuilder.DropForeignKey(
                name: "FK_HydraulicEngineers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "HydraulicEngineers");

            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDesigners_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "InteriorDesigners");

            migrationBuilder.DropForeignKey(
                name: "FK_Landscapers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Landscapers");

            migrationBuilder.DropForeignKey(
                name: "FK_MarbleWorkers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "MarbleWorkers");

            migrationBuilder.DropForeignKey(
                name: "FK_Masons_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Masons");

            migrationBuilder.DropForeignKey(
                name: "FK_Metalworkers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Metalworkers");

            migrationBuilder.DropForeignKey(
                name: "FK_Painters_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Painters");

            migrationBuilder.DropForeignKey(
                name: "FK_Plasterers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Plasterers");

            migrationBuilder.DropForeignKey(
                name: "FK_Plumbers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Plumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Roofers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Roofers");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveyors_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Surveyors");

            migrationBuilder.DropForeignKey(
                name: "FK_Tilers_GenericProfessionalProfessionalTypes_ProfessionalTypeId",
                table: "Tilers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tilers",
                table: "Tilers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveyors",
                table: "Surveyors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roofers",
                table: "Roofers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plumbers",
                table: "Plumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plasterers",
                table: "Plasterers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Painters",
                table: "Painters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Metalworkers",
                table: "Metalworkers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Masons",
                table: "Masons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MarbleWorkers",
                table: "MarbleWorkers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landscapers",
                table: "Landscapers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InteriorDesigners",
                table: "InteriorDesigners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HydraulicEngineers",
                table: "HydraulicEngineers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Glaziers",
                table: "Glaziers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenericProfessionalProfessionalTypes",
                table: "GenericProfessionalProfessionalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foremen",
                table: "Foremen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Electricians",
                table: "Electricians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalEngineers",
                table: "ElectricalEngineers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Decorators",
                table: "Decorators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CivilEngineers",
                table: "CivilEngineers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carpenters",
                table: "Carpenters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cabinetmakers",
                table: "Cabinetmakers");

            migrationBuilder.RenameTable(
                name: "Tilers",
                newName: "Tiler");

            migrationBuilder.RenameTable(
                name: "Surveyors",
                newName: "Surveyor");

            migrationBuilder.RenameTable(
                name: "Roofers",
                newName: "Roofer");

            migrationBuilder.RenameTable(
                name: "Plumbers",
                newName: "Plumber");

            migrationBuilder.RenameTable(
                name: "Plasterers",
                newName: "Plasterer");

            migrationBuilder.RenameTable(
                name: "Painters",
                newName: "Painter");

            migrationBuilder.RenameTable(
                name: "Metalworkers",
                newName: "Metalworker");

            migrationBuilder.RenameTable(
                name: "Masons",
                newName: "Mason");

            migrationBuilder.RenameTable(
                name: "MarbleWorkers",
                newName: "MarbleWorker");

            migrationBuilder.RenameTable(
                name: "Landscapers",
                newName: "Landscaper");

            migrationBuilder.RenameTable(
                name: "InteriorDesigners",
                newName: "InteriorDesigner");

            migrationBuilder.RenameTable(
                name: "HydraulicEngineers",
                newName: "HydraulicEngineer");

            migrationBuilder.RenameTable(
                name: "Glaziers",
                newName: "Glazier");

            migrationBuilder.RenameTable(
                name: "GenericProfessionalProfessionalTypes",
                newName: "GenericProfessionalProfessionalType");

            migrationBuilder.RenameTable(
                name: "Foremen",
                newName: "Foreman");

            migrationBuilder.RenameTable(
                name: "Electricians",
                newName: "Electrician");

            migrationBuilder.RenameTable(
                name: "ElectricalEngineers",
                newName: "ElectricalEngineer");

            migrationBuilder.RenameTable(
                name: "Decorators",
                newName: "Decorator");

            migrationBuilder.RenameTable(
                name: "CivilEngineers",
                newName: "CivilEngineer");

            migrationBuilder.RenameTable(
                name: "Carpenters",
                newName: "Carpenter");

            migrationBuilder.RenameTable(
                name: "Cabinetmakers",
                newName: "Cabinetmaker");

            migrationBuilder.RenameIndex(
                name: "IX_Tilers_ProfessionalTypeId",
                table: "Tiler",
                newName: "IX_Tiler_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveyors_ProfessionalTypeId",
                table: "Surveyor",
                newName: "IX_Surveyor_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Roofers_ProfessionalTypeId",
                table: "Roofer",
                newName: "IX_Roofer_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Plumbers_ProfessionalTypeId",
                table: "Plumber",
                newName: "IX_Plumber_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Plasterers_ProfessionalTypeId",
                table: "Plasterer",
                newName: "IX_Plasterer_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Painters_ProfessionalTypeId",
                table: "Painter",
                newName: "IX_Painter_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Metalworkers_ProfessionalTypeId",
                table: "Metalworker",
                newName: "IX_Metalworker_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Masons_ProfessionalTypeId",
                table: "Mason",
                newName: "IX_Mason_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MarbleWorkers_ProfessionalTypeId",
                table: "MarbleWorker",
                newName: "IX_MarbleWorker_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Landscapers_ProfessionalTypeId",
                table: "Landscaper",
                newName: "IX_Landscaper_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_InteriorDesigners_ProfessionalTypeId",
                table: "InteriorDesigner",
                newName: "IX_InteriorDesigner_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_HydraulicEngineers_ProfessionalTypeId",
                table: "HydraulicEngineer",
                newName: "IX_HydraulicEngineer_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Glaziers_ProfessionalTypeId",
                table: "Glazier",
                newName: "IX_Glazier_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_TilerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_TilerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_SurveyorId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_SurveyorId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_RooferId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_RooferId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_PlumberId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_PlumberId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_PlastererId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_PlastererId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_PainterId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_PainterId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_MetalworkerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_MetalworkerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_MasonId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_MasonId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_MarbleWorkerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_MarbleWorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_LandscaperId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_LandscaperId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_InteriorDesignerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_InteriorDesignerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_HydraulicEngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_GlazierId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_GlazierId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_genericId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_genericId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_ForemanId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_ForemanId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_ElectricianId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_ElectricianId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_ElectricalEngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_DecoratorId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_DecoratorId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_CivilEngineerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_CivilEngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_CarpenterId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_CarpenterId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_CabinetmakerId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_CabinetmakerId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionalProfessionalTypes_ArchitectId",
                table: "GenericProfessionalProfessionalType",
                newName: "IX_GenericProfessionalProfessionalType_ArchitectId");

            migrationBuilder.RenameIndex(
                name: "IX_Foremen_ProfessionalTypeId",
                table: "Foreman",
                newName: "IX_Foreman_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Electricians_ProfessionalTypeId",
                table: "Electrician",
                newName: "IX_Electrician_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalEngineers_ProfessionalTypeId",
                table: "ElectricalEngineer",
                newName: "IX_ElectricalEngineer_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Decorators_ProfessionalTypeId",
                table: "Decorator",
                newName: "IX_Decorator_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CivilEngineers_ProfessionalTypeId",
                table: "CivilEngineer",
                newName: "IX_CivilEngineer_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Carpenters_ProfessionalTypeId",
                table: "Carpenter",
                newName: "IX_Carpenter_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Cabinetmakers_ProfessionalTypeId",
                table: "Cabinetmaker",
                newName: "IX_Cabinetmaker_ProfessionalTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiler",
                table: "Tiler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveyor",
                table: "Surveyor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roofer",
                table: "Roofer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plumber",
                table: "Plumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plasterer",
                table: "Plasterer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Painter",
                table: "Painter",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Metalworker",
                table: "Metalworker",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mason",
                table: "Mason",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarbleWorker",
                table: "MarbleWorker",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landscaper",
                table: "Landscaper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteriorDesigner",
                table: "InteriorDesigner",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HydraulicEngineer",
                table: "HydraulicEngineer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Glazier",
                table: "Glazier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenericProfessionalProfessionalType",
                table: "GenericProfessionalProfessionalType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foreman",
                table: "Foreman",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Electrician",
                table: "Electrician",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalEngineer",
                table: "ElectricalEngineer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decorator",
                table: "Decorator",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CivilEngineer",
                table: "CivilEngineer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carpenter",
                table: "Carpenter",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cabinetmaker",
                table: "Cabinetmaker",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce368433-85c3-473a-9671-75b078d88c41", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6524), "f7a6bfc5-a086-4fa7-a7e8-12a2526732fa", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "456d0e22-95f7-40ae-96b6-ee276965ce9e", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6783), "075720c9-12a8-42ad-ab35-e61d9b6df9d1", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9cbc6cab-f5eb-4cdf-a926-15314f932adc", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6795), "afc20dd8-c3b7-4caf-8203-865c5a5f09c0", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "39e4c53a-cbbe-446d-aac5-5b9218e78aba", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6808), "38419cf4-28d2-4546-bd87-276b6720ffd9", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "17c56696-5f9f-4b0c-b227-95e5a7b55fd3", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6820), "1f18b427-38ab-4ac5-9272-1ae70c24b1d7", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75662968-6e37-4d7e-af7f-e59096ece070", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6832), "cab895b7-2bae-43e0-ab0b-a29e5fd90641", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "318a0b12-57f6-4e0c-b934-496de3ad5c02", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6845), "3a15457f-f5b0-4202-b4a6-95f41e35f7c5", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2306305f-f6c1-4707-97b8-96efb6e1264e", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6857), "6f2a9b62-2595-4472-932d-b498896c994e", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d061a7b5-42de-48b2-beca-d31fef637827", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6869), "4f3dd097-9803-45d7-adea-9b0f2c5f3f22", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f36fc16a-1f1b-427a-b4bf-36bb0f221c40", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6882), "44225d10-eecf-49cb-b024-84a900e0de11", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ec22ae0f-fed5-4be0-94bc-72e008319c82", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6894), "15f8d5d0-d88c-4901-bd2e-939c81b9994d", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ba9a168-bbec-436b-824e-6b6070eefc56", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6654), "3dc00e10-e726-47b9-a1d4-211f1fd08b92", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2e32479f-e9ce-4800-8f5f-89ccafea9d94", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6949), "ae0bfaa4-06d2-4a0e-a051-91b661ae4e8f", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d30b3c36-6818-490e-8f65-00ac96258bf6", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6964), "b44f97fe-874d-441e-9b9b-ba089440549c", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71d534e4-21cb-4701-bb6f-e50df0f9121f", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6978), "746d6707-d6d9-4ced-9785-5216c03c5b57", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "16a89031-e8d6-45fa-89c0-8e7390b62e4b", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6994), "a8154237-5064-4712-8618-97299c49fa76", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e34c775c-652e-4252-8a1b-88e8b5c8df81", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7009), "e47d8a5b-458a-4a04-9551-8664ef8bd77f", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d539e2e8-b738-4313-adbe-fd8bf10e11eb", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7023), "15d9fa2e-7d21-429a-9a73-a97e7c86fa2f", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5300e1c3-0142-414a-b274-f77e531eb5a0", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7041), "4229c1d5-52de-437b-89a9-eb931631ce0e", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2657ca7e-42d7-4164-a650-fdd25d74d3a0", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7055), "e0d2686a-a906-41c7-8f9a-677b8f36416b", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "09a80f1a-7521-4044-8c12-f864641a092d", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7072), "20f6428a-c753-4756-b87f-5e5e20f4e105", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b0d8d4a5-00ef-4758-b853-76d2d90cf851", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7088), "7cec4ed9-8e5a-487d-8a75-39b262bbde37", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e73f4eca-a627-44a5-8a58-9bce777e866e", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6667), "a8ec07e8-98ba-472c-bf71-1c90d482078a", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c1a53e92-c5b8-4a60-916a-98ed4aaee6e6", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7101), "6b48399b-5611-4bf1-a783-e609198092d6", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db89dec5-a713-412a-8c13-3022171ccbac", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6707), "833b91ed-12cd-4413-aac2-24544e9a5560", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "381586f8-d6f0-4c6e-8f37-7ee153f4c9db", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6720), "fc51f59b-fdbe-44ba-9781-b22245445f88", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8b9103b6-9d7b-4cf6-808b-a99369dec426", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6732), "63f5ccad-034d-49cc-98a1-5d2a4cdc2117", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5694f453-a22f-456b-b15f-cb4e1b652d79", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6745), "f79664d6-8ac7-4d00-883b-1fb6a09cbdef", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7ccf2b01-bf7e-4e6b-9582-c27a6d74fbfe", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6757), "087d1909-b31b-4b14-9f91-721bf544b737", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc94f387-ea7f-4599-a3dc-4959c6efb229", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6770), "920f44a5-2deb-4cd4-b944-6aae8f1e970d", new DateTime(2024, 11, 20, 23, 15, 24, 778, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("36f41695-bc6e-4a3f-a7e9-d41643b81245"),
                column: "MasonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"),
                column: "DecoratorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"),
                column: "MetalworkerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"),
                column: "PainterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"),
                column: "PainterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"),
                column: "MasonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34"),
                columns: new[] { "CarpenterId", "MasonId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"),
                column: "MasonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"),
                column: "PlumberId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"),
                column: "MasonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"),
                columns: new[] { "CarpenterId", "PlumberId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "GenericProfessionalProfessionalType",
                keyColumn: "Id",
                keyValue: new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"),
                column: "PlumberId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Architects_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Architects",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabinetmaker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Cabinetmaker",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carpenter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Carpenter",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CivilEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "CivilEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Decorator_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Decorator",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "ElectricalEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Electrician_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Electrician",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foreman_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Foreman",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Architects_ArchitectId",
                table: "GenericProfessionalProfessionalType",
                column: "ArchitectId",
                principalTable: "Architects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Cabinetmaker_CabinetmakerId",
                table: "GenericProfessionalProfessionalType",
                column: "CabinetmakerId",
                principalTable: "Cabinetmaker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Carpenter_CarpenterId",
                table: "GenericProfessionalProfessionalType",
                column: "CarpenterId",
                principalTable: "Carpenter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_CivilEngineer_CivilEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "CivilEngineerId",
                principalTable: "CivilEngineer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Decorator_DecoratorId",
                table: "GenericProfessionalProfessionalType",
                column: "DecoratorId",
                principalTable: "Decorator",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_ElectricalEngineer_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "ElectricalEngineerId",
                principalTable: "ElectricalEngineer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Electrician_ElectricianId",
                table: "GenericProfessionalProfessionalType",
                column: "ElectricianId",
                principalTable: "Electrician",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Foreman_ForemanId",
                table: "GenericProfessionalProfessionalType",
                column: "ForemanId",
                principalTable: "Foreman",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_GenericProfessionals_genericId",
                table: "GenericProfessionalProfessionalType",
                column: "genericId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Glazier_GlazierId",
                table: "GenericProfessionalProfessionalType",
                column: "GlazierId",
                principalTable: "Glazier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_HydraulicEngineer_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "HydraulicEngineerId",
                principalTable: "HydraulicEngineer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_InteriorDesigner_InteriorDesignerId",
                table: "GenericProfessionalProfessionalType",
                column: "InteriorDesignerId",
                principalTable: "InteriorDesigner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Landscaper_LandscaperId",
                table: "GenericProfessionalProfessionalType",
                column: "LandscaperId",
                principalTable: "Landscaper",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_MarbleWorker_MarbleWorkerId",
                table: "GenericProfessionalProfessionalType",
                column: "MarbleWorkerId",
                principalTable: "MarbleWorker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Mason_MasonId",
                table: "GenericProfessionalProfessionalType",
                column: "MasonId",
                principalTable: "Mason",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Metalworker_MetalworkerId",
                table: "GenericProfessionalProfessionalType",
                column: "MetalworkerId",
                principalTable: "Metalworker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Painter_PainterId",
                table: "GenericProfessionalProfessionalType",
                column: "PainterId",
                principalTable: "Painter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Plasterer_PlastererId",
                table: "GenericProfessionalProfessionalType",
                column: "PlastererId",
                principalTable: "Plasterer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Plumber_PlumberId",
                table: "GenericProfessionalProfessionalType",
                column: "PlumberId",
                principalTable: "Plumber",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Roofer_RooferId",
                table: "GenericProfessionalProfessionalType",
                column: "RooferId",
                principalTable: "Roofer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Surveyor_SurveyorId",
                table: "GenericProfessionalProfessionalType",
                column: "SurveyorId",
                principalTable: "Surveyor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Tiler_TilerId",
                table: "GenericProfessionalProfessionalType",
                column: "TilerId",
                principalTable: "Tiler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_GenericProfessionalProfessionalType_EspecializationsId",
                table: "GenericProfessionals",
                column: "EspecializationsId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Glazier_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Glazier",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HydraulicEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "HydraulicEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InteriorDesigner_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "InteriorDesigner",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscaper_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Landscaper",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MarbleWorker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "MarbleWorker",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mason_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Mason",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Metalworker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Metalworker",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Painter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Painter",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plasterer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Plasterer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plumber_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Plumber",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roofer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Roofer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveyor_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Surveyor",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tiler_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Tiler",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");
        }
    }
}
