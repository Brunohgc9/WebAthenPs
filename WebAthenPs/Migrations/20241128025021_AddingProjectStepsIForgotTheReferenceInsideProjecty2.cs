using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingProjectStepsIForgotTheReferenceInsideProjecty2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step9StructuralProjects",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step8ConstructionLocations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step7PreliminaryServices",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step6ConstructionPlannings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step5BudgetSheets",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step4ComplementaryProjects",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step3ApprovalInCityHalls",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step2Projects",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step25Decorations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step24CleaningOfTheSites",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step23Landscapings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step22Paintings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step21CarpentryWashbasinsAndMetals",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step20Floors",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArchitectId",
                table: "Step1HireArchitects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step1HireArchitects",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step19Lightings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step18Marbleworks",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step17CeilingsAndFinishes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step16DoorsAndWindows",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step15Finishes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step14ComplementaryInstallations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step13ElectricalInstallations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step12SanitaryInstallations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step11Roofings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Step10Masonries",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8966a9f4-1272-40c2-b6c5-77476f7c8691", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2368), "b8e1c21a-6e47-4561-ac2f-95ff564fe74d", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db578ed4-ebfb-4cfc-a9c7-790a712c041c", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2600), "6280b965-64d9-4324-b088-5ef82736be8b", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c90e09f1-b1d3-41e6-80bf-ec518a274d55", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2650), "6ac5e718-d516-4fa5-bd12-6fae3debcecc", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ddae1dc2-05e1-48d3-99cc-1142d4a862fa", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2665), "412ed02b-5cf7-42c4-88c6-7900fd3ca61e", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf1df665-32a3-43da-9f73-5a405353f45c", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2702), "af3084fa-9352-4a06-a178-3fea68fa8713", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "336b5169-d277-4181-b040-633ee1594cc0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2715), "18f066f0-7a03-4e19-9acb-8215042a93e9", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a73dedcb-f0c4-4434-9d98-2b0a8dad88ec", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2737), "25b4478b-6421-44f2-ac99-fc0980fe67ed", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2846d6db-bb68-40c3-b4f9-7ccab007fa03", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2751), "3558980c-fc41-48d7-ad4c-aadc9318d103", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37a203c0-6fe6-40c1-bd20-34510cc1d8d1", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2764), "18466949-2de4-4970-9554-c8264ca32f24", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b16cc6a4-6de9-4a02-a22d-18ff6cf9ffd5", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2778), "3fa97362-9f3d-4e81-ac88-14d8e351e17f", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c25e4205-63e4-4f5f-89a7-b9df34154fc0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2790), "e8a98e44-20c0-490c-901f-835e882ad410", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b1bf88db-5629-431c-840b-d0fd5157a3ae", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2485), "7889b19e-044f-4d90-bbbd-f5951c2d2c16", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "170322ee-238b-4991-839f-b12e87310d65", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2808), "2229389f-443f-4477-8310-484393154a21", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "be4dddb7-5cf3-4326-b303-b9c40c71cd78", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2825), "4b6b57e3-fb90-4291-b2f9-a33dbd0e0ab9", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "096f0d9f-9fdf-479e-be33-c19d440ceabc", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2837), "a6bbecaf-facd-413d-9e7e-cb8d72b44f76", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "359f5b92-b08b-454b-9513-5aca827d8a05", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2853), "dab69d63-527e-4687-b6f7-323d86cafda5", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b53c979e-fd0d-4d48-93cf-b9e6f5c8c8b8", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2866), "9feaf967-51c9-4682-be1a-fb72b2b9d71b", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33844ca3-d006-40f5-9e0b-ca22869f0f21", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2879), "aa450420-8a6b-43a1-8bc8-b91fcab921e8", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9a93ae24-c302-4acb-8cae-62bdd496eaa5", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2895), "f9cf6420-aec6-4668-933d-e1f167581f98", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e566d047-533d-408e-bc50-2df062b9b473", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2906), "6447d541-23e9-4918-9e4a-d46905f73a3f", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90597e08-4e7e-4f25-be98-545d32e37ca2", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2918), "4b078403-71ee-4fd2-af31-9772bc2ed22a", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b00f01c9-3bb2-45c1-9c57-cb18830f1e51", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2957), "b0130de1-ee59-40be-9ec3-216480f9d432", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d55419a4-772a-4d7e-a173-cceea8077642", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2500), "02c58945-4ca1-4f1e-a95d-216381494f85", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a87d93fa-b1f7-40fc-8aa1-3db3bb4834c0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2970), "0b9f721b-0db6-44b6-82dd-dfeb56da7def", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aef70195-433e-4357-9a84-a71fa9012f5f", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2512), "b000f776-a123-4322-ba1f-031b07c0b68a", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "403b3a75-46ca-467d-9507-958c1a744287", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2526), "5849c49b-78f4-45a8-9f40-c74652dd298b", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "193abdf6-9500-466a-9e74-361195d5b466", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2549), "d1f926ea-8c21-4e76-9151-bf1599ffb7a2", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ec04f433-0ba0-4534-a1fb-ebaefb062501", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2563), "515a1411-f7e1-480b-a382-592f1a2aa8c7", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a57d6bc0-e461-48b9-ba12-3cf3e7014f35", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2575), "296ca05e-dd6b-4fc9-951f-3be460ea2bf9", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e166d0b5-2e50-4449-a2c2-c7c8dac1e6e3", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2586), "b93fac39-9f53-4e23-a0c4-533a634be7e0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.CreateIndex(
                name: "IX_Step1HireArchitects_ArchitectId",
                table: "Step1HireArchitects",
                column: "ArchitectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Step1HireArchitects_Architects_ArchitectId",
                table: "Step1HireArchitects",
                column: "ArchitectId",
                principalTable: "Architects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Step1HireArchitects_Architects_ArchitectId",
                table: "Step1HireArchitects");

            migrationBuilder.DropIndex(
                name: "IX_Step1HireArchitects_ArchitectId",
                table: "Step1HireArchitects");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step9StructuralProjects");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step8ConstructionLocations");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step7PreliminaryServices");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step6ConstructionPlannings");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step5BudgetSheets");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step4ComplementaryProjects");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step3ApprovalInCityHalls");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step2Projects");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step25Decorations");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step24CleaningOfTheSites");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step23Landscapings");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step22Paintings");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step21CarpentryWashbasinsAndMetals");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step20Floors");

            migrationBuilder.DropColumn(
                name: "ArchitectId",
                table: "Step1HireArchitects");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step1HireArchitects");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step19Lightings");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step18Marbleworks");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step17CeilingsAndFinishes");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step16DoorsAndWindows");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step15Finishes");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step14ComplementaryInstallations");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step13ElectricalInstallations");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step12SanitaryInstallations");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step11Roofings");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Step10Masonries");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9c0747a2-f274-403a-8427-75e9c52bbc31", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(365), "176d68ac-122f-47d3-80c6-67f0e3de3a32", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76204834-78be-4b79-96fd-007d0e355368", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(663), "7a7abf44-5f21-4584-8366-b280aa621a2b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "41a07a32-9250-490c-96a9-01978644908b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(707), "18c51151-2753-4ca5-9f3b-8a0196842237", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b9c27cc-f45e-4c5c-a0c1-4ae4ac677c2b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(721), "decd89c4-9393-4abb-be3c-0c6454303dcd", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0270a804-6714-4643-b7de-0642d524641f", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(733), "764e1d81-a850-4b9e-bdb7-6edfa5f93019", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e4652cc-0a9e-4ecf-9c38-c8c8d41e7cc2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(745), "f246e02a-0e0f-4408-a385-39307876fc19", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "12e20da1-b75b-4e20-aaf3-a0f5b01ed0bf", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(761), "de9fade7-aadd-40e4-b6fb-ef528eb3f4ed", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4177e6a3-0cec-467d-b6ed-dfc94a2d8533", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(775), "4afe70cd-e969-4545-9659-d49c7d5f96a1", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f5eded8a-8754-41f9-8111-509eb9122806", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(789), "1533fb4c-7a10-46b7-9caf-3effdf5d7247", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9759bee-7e79-4ec2-a17a-ae321000573b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(802), "be6470ab-3a48-434d-8b20-456dd1c55e41", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f3bffb9-b64d-4382-b285-daaa38c5978c", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(814), "17d490a3-89fb-4872-9b1e-4a5920676597", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c9df1a74-cc94-4237-b456-249bf00eff98", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(516), "8b74b7aa-9306-4595-8a46-028dd8b80b70", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f3cedc7-f1cc-4ad1-854c-b33b8d0f5a74", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(826), "7e0e8786-d56d-42e2-bf89-3a13d8d8432d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "397dae6b-5756-44cc-a66a-41b1856dc474", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(857), "d1dfd6e6-5d02-427c-9e30-601b331d6f91", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0cd118b2-f9f8-472a-b3e3-329c4a6dd872", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(869), "be24c125-65ed-4be3-b1ba-48192ce2486f", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19a3c0e2-44d8-4587-a1ec-286b23f5d34e", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(885), "515cf714-3c8c-48bf-816a-2d58a583ae88", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e25e6e7c-5601-4f18-b7f7-f135ef5db9a2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(896), "cd2cde8b-3250-494d-976b-c9f918f97473", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cbf8840a-8070-4bf7-8396-ff0bf21e717e", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(910), "6e134e06-e230-4016-ab0e-e4570f41979d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d35ee2d0-5f34-4982-9457-79cebf94256e", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(924), "ecd00f35-d098-4a61-a19f-3eabd9751487", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a4edd41f-a643-4fc8-b61f-e6a64b56d728", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(936), "225aaf8d-c557-4e16-8fdd-18283ceb59e2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f266d003-5ef4-4611-ba6f-7d43e9aebfba", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(949), "8ff160e6-3393-4d91-af11-224d41753b62", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a76d706-420a-4979-a390-9030c2426cf2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(961), "b9f6d693-93a0-4079-92f9-66c87328b963", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "710f1a0b-90f2-4fd3-b085-b89ffb6b7815", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(529), "951eed0f-7428-4db9-8ef4-3af3d2dbf1ff", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "28a85ff9-419a-43d8-a933-934533ab8a6d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(972), "a03f01df-9a82-4dfa-a49a-142403a76ae5", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "91b59584-3bbb-4a81-98c3-9df1960fd590", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(543), "fc757ca3-07f9-49b9-bc47-56b2b8133ce3", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "14294145-7112-443b-af2d-412808add84d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(554), "41ccefac-edcd-4ca1-b605-e8e4f9d2bb94", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e41a0752-d1a2-4c8c-999e-d3d3fc877bab", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(612), "f0ef98c9-c835-4d0a-83db-40ea3454a109", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ed02366-c109-4178-bb4c-493bd3cae202", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(625), "f2a0175f-eae4-4c97-8922-23014c7d2aa7", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f4cc061-96ee-4f50-b21a-4979d9df9bb9", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(638), "93dc3bb1-e6e8-46ef-b937-f9569a2735a1", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb244566-e012-4e78-802b-1004c81f4c9b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(650), "599327ec-c11f-4545-bfde-ff96332d2a78", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(650) });
        }
    }
}
