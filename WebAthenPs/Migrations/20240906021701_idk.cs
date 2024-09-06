using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class idk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_Id",
                table: "ProjectProfessionals");

            migrationBuilder.DropTable(
                name: "ProjectProfessional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_ProjectProfessionals_Id",
                table: "ProjectProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("516b3960-9f9a-4ad7-85f7-09e94011eaa2"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("9285f336-798a-415f-b2e7-3400ba6c1796"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("99a71655-8ae6-428d-bfd9-5f09a3ebac30"));

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "Id", "ProjectId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.AddColumn<int>(
                name: "ProfessionalId",
                table: "ProjectProfessionals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals",
                columns: new[] { "ProjectId", "ProfessionalId" });

            migrationBuilder.CreateTable(
                name: "GenericProfessionalProjecty",
                columns: table => new
                {
                    ProfessionalsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionalProjecty", x => new { x.ProfessionalsId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProjecty_GenericProfessionals_ProfessionalsId",
                        column: x => x.ProfessionalsId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProjecty_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("086f006b-9f30-4d66-a439-0d35f3f8fc3f"), "Industrial", "112233", 12 },
                    { new Guid("6762256c-3bad-4ebd-a45b-c2f16b57fa3b"), "Comercial", "654321", 6 },
                    { new Guid("7d5213db-81f9-4451-af79-96318d93f828"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "96d9edc1-d368-4a23-8bbe-9dc410be5ddc", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2259), "5e09cd0c-0ec4-48a1-a239-45a8d74bfa04", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6c1c8207-2a74-4bfd-9971-46d1eea2a029", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2482), "eb8ae3bd-cb3b-46ec-8af3-1125cf7640e2", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1bda934d-e1b0-477d-a452-9ddc42c8bce2", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2497), "2bafee13-879a-4f47-bcbb-afc9100c8069", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c10d6ce1-0896-4cc5-896a-0837454ab3b5", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2510), "ee868116-dd4f-4f3e-b4fc-5f2dffb84690", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "50644c94-a467-4470-b723-3c0200a5c5d7", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2526), "0acaa593-6dcb-4f02-a994-dc92be7dde0b", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "524b9390-40da-4efd-b74f-53632e94eafd", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2540), "1e5555a2-ec0b-4503-bf58-58c77749b8c1", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fa88b802-2103-46cc-99a8-43c0768268c6", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2555), "31c5763d-a6c7-482b-80ff-e52a1f3435b1", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c81340a0-8353-42b8-85c1-06a181fce303", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2570), "2a4acd0e-27d3-4c16-8b55-7524882e8376", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d2e9029c-65c7-4c94-89ec-4adbca68654a", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2583), "17da4b76-57f3-48ab-9374-bc446e5ecc18", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "442837ae-d652-4762-98d1-1cae568e3d23", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2620), "e94daad5-de55-44e4-a9d8-48b2dccb8855", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7031cf04-3de3-4da1-af11-afc677464cbe", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2636), "67372a9d-0c2d-451c-ad7b-a886e955d68a", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0db8009a-5303-4445-86c2-6c251e2e0094", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2354), "4295ea98-bf56-41ef-bc0a-3de5a9a4720f", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9d255d06-74dc-4fe1-92b8-fef8fdba95c2", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2649), "84e9d6e5-f302-4c3e-8ce9-950c2e1fe5c3", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05c701b7-b2a7-4a24-85e3-2d7ea86a0f55", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2665), "79109244-b86b-4efc-b38c-8f44ab57da42", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bb92016-331f-4263-8d5c-8cc6d60837b5", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2678), "d84722c7-5433-45ca-8d0f-a7ce880c7f91", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "669c52ba-48ba-4bca-bc3f-0d8bbd6cb8da", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2692), "47159373-68ca-49e9-9862-2696b7556488", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f0e9bae-ef59-4f4d-9f79-0ee5c02812e8", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2708), "fafea1c2-b1a5-429d-9801-37440b99a797", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6817593a-bf89-44ad-adcd-c43b2574840d", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2721), "787a7266-61e8-4d9f-bde5-e398896a0293", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9e25fd11-8045-43a3-85f5-6811c955906e", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2734), "c920629c-05fc-4668-ac29-b442a95e52a8", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a088e3c5-0925-4846-9707-92bbc2789605", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2750), "e8054b95-9fb2-4a77-bc4b-4e8094d5cb1a", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "466863b4-1ab9-4a1c-9459-f5ecf0d3de1f", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2764), "94fc543a-67ba-4835-b510-571fd39b99f0", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf197ff0-33f5-4032-abc2-063155f2c60f", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2779), "98d2c45a-3ef5-4c46-9bae-614e749feed0", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c735c9ff-9395-4add-8b84-a9e8019e5507", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2381), "33451e7f-c622-4a64-8746-7303b2ac80e1", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef9fedeb-4f5c-4c27-a222-c92ea216c3cb", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2792), "7c3a5e56-131a-4003-944d-37ee4e589695", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c52edb9b-1d84-459f-a7f3-5541a514f31f", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2396), "1f9f2af9-e420-44f5-ba8a-72d3fabc467d", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "970844d5-dfa7-4f8e-ab2e-2489b99ac8a1", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2412), "6a60d554-d7ab-4641-a2d3-b1c2bb0e850e", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "021ee335-e4b3-4f54-9df8-3c0afd78cae4", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2426), "8c02575d-3161-464e-93c3-79872c816b3a", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "87091011-86cb-4159-ad52-2ec826deef84", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2439), "8c2875ff-bdf3-4eb1-ad8b-277b9601ac35", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bec4010f-6659-4a69-bf2d-4842569b9c49", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2455), "57f5ad07-3c68-48d1-8d51-4d937cebfb7d", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a64e649c-5b95-4868-b483-89f0ceee3473", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2469), "76358cc3-9149-4e62-a122-60e75619a934", new DateTime(2024, 9, 6, 2, 17, 1, 1, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_ProfessionalId",
                table: "ProjectProfessionals",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProjecty_ProjectsProjectId",
                table: "GenericProfessionalProjecty",
                column: "ProjectsProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_ProfessionalId",
                table: "ProjectProfessionals",
                column: "ProfessionalId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_ProfessionalId",
                table: "ProjectProfessionals");

            migrationBuilder.DropTable(
                name: "GenericProfessionalProjecty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_ProjectProfessionals_ProfessionalId",
                table: "ProjectProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("086f006b-9f30-4d66-a439-0d35f3f8fc3f"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("6762256c-3bad-4ebd-a45b-c2f16b57fa3b"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("7d5213db-81f9-4451-af79-96318d93f828"));

            migrationBuilder.DropColumn(
                name: "ProfessionalId",
                table: "ProjectProfessionals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals",
                columns: new[] { "ProjectId", "Id" });

            migrationBuilder.CreateTable(
                name: "ProjectProfessional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProfessional_GenericProfessionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProfessional_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("516b3960-9f9a-4ad7-85f7-09e94011eaa2"), "Industrial", "112233", 12 },
                    { new Guid("9285f336-798a-415f-b2e7-3400ba6c1796"), "Comercial", "654321", 6 },
                    { new Guid("99a71655-8ae6-428d-bfd9-5f09a3ebac30"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "256c1bae-12a1-4fe3-a394-424ef8641b40", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(5900), "38cffb04-899f-42cd-a2d1-4ab6a68e62af", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "84736f75-3a99-4d45-9fe5-b493268540e0", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6219), "4f5c6d10-19c4-4d26-8619-9621636aa862", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c25ecb6-7b56-43ba-866b-d64d7860e30d", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6234), "cc97a8eb-4694-4e87-bb6e-b9d4e0f7cb2f", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9fd4c540-d7ac-4172-a317-7b97036f1ad0", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6248), "807aab30-1dc0-43be-9e68-7b1a19bd1231", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02ef8814-fb0c-4577-97d1-d6eaac458bd9", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6260), "f4da2393-61e8-4d36-a08a-90da0b1af2c7", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a89ee89b-71c3-4c37-bf0d-07613c84b5c8", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6271), "10be005d-ee41-4485-9a11-9e26896f3028", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f30f4ec7-0e30-4b9e-a022-381ccb912404", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6284), "e4da27a0-587f-474e-9822-026ef1ebf49d", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8e2845a4-aa57-40ea-8c92-40c0bb3c51f1", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6295), "cf5b131b-09aa-448c-8d9c-c1e6861bbeea", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2cbc6eb4-789c-4ec4-9ab2-5f208e6cb1c1", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6307), "2495d7f3-e2b3-4fd5-9b18-fcfd78c3f4c6", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cf784f0d-edf8-4c3f-a729-253d05986a9d", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6320), "e43f2551-dbc3-4d09-ab3f-6445ca203195", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92c837e8-5adb-4bd4-958c-e8fbcc6dd687", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6331), "d891ab6b-ce64-413d-a1f8-ace0b72119ec", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d63622e-0541-4814-89a6-87d086cffb22", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6021), "06579c18-91bb-4e52-aac6-d0b377c042d1", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ad9f0ca3-ee65-42e7-be4c-5089e069e2a2", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6344), "b5dfc773-2b8d-4d7b-9431-1011b315fe23", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ab1eb7d-6abc-4dc1-a186-a9e0ffbece17", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6355), "28820731-7dac-436d-b2e1-0c03e1b002d8", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2b186fc3-4a79-4221-9515-e607e104fb35", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6366), "9dbed96f-432d-4933-a031-81dd650edf68", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1c66b787-8bb8-49e3-bde1-d3c742cc83bb", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6379), "a276c3cb-9f49-4bcd-b231-a2331ae7c6da", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88f6ef91-4e04-4cbf-aa12-1befd1d1cf11", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6391), "10d4d57b-36e7-4a02-a90d-5bb63a07ab08", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a35d092e-405c-4811-99ad-5b918a2d4b52", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6402), "140d155d-12fb-4bd0-a251-81a1ad36a134", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2225cdd6-db1b-47ab-9541-adf8d9152137", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6415), "486e472d-6a41-411a-a37c-30fe088afc0d", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75bfe12f-9cac-4a92-9208-00afff63889b", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6452), "87a5afa1-4083-4804-a482-d7e18d86f9ef", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "435471fd-da32-4f76-807b-3319cfbff882", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6465), "ab111a57-a4c8-46f6-9eb2-b01a13bb33ec", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fa4d41a-ecb2-4306-88b7-9dc8facff94a", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6477), "3ee24a83-9e03-412b-9f5d-4ff4184339af", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d4f0df77-dc22-4ee2-b4d3-4767938344e8", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6034), "87b983f2-829f-465c-8c58-66d5db3a2723", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aae2093e-9ad4-4432-9738-3dec95a41656", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6489), "0a762024-720a-419b-af6b-59862a53913e", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b8b6ccb-b1ef-424e-a013-58e32395460c", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6047), "16045a84-072a-472b-8306-cad40433c3af", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1f903e4a-c9d5-48e6-bbb3-3b91f59b2fae", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6058), "c9ddf8a0-3716-41e6-ad3b-8be9e405e913", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d53aa8a2-7463-4897-b26b-cfe901aa6436", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6070), "842ec82b-913c-48ce-bcb9-4f7126bb4e9c", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e70cc45a-e68b-4a40-92cb-0c6f4a9084e9", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6082), "d83a7a48-6e4b-4a2c-86e3-59dc213bd504", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b70db2d3-f653-4f2e-baf2-725c75e2cdcd", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6094), "c7b5c2a8-efcb-4d10-913a-9c17a8d1093b", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20b58e2f-fa09-49ae-b319-e72f6047d835", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6106), "0cade379-18d2-4d5b-9d42-5c4c46c4d598", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "Id", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 5 },
                    { 10, 5 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 7 },
                    { 14, 7 },
                    { 1, 8 },
                    { 15, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 4, 10 },
                    { 5, 10 },
                    { 6, 11 },
                    { 7, 11 },
                    { 8, 12 },
                    { 9, 12 },
                    { 10, 13 },
                    { 11, 13 },
                    { 12, 14 },
                    { 13, 14 },
                    { 14, 15 },
                    { 15, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_Id",
                table: "ProjectProfessionals",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessional_ProfessionalId",
                table: "ProjectProfessional",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessional_ProjectId",
                table: "ProjectProfessional",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_Id",
                table: "ProjectProfessionals",
                column: "Id",
                principalTable: "GenericProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
