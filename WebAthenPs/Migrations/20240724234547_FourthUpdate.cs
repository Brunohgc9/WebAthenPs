using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class FourthUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_ProfessionalsId",
                table: "ProjectProfessionals");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProfessionals_Projects_ProjectsProjectId",
                table: "ProjectProfessionals");

            migrationBuilder.RenameColumn(
                name: "ProjectsProjectId",
                table: "ProjectProfessionals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProfessionalsId",
                table: "ProjectProfessionals",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectProfessionals_ProjectsProjectId",
                table: "ProjectProfessionals",
                newName: "IX_ProjectProfessionals_Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd1cffdd-f612-40fa-a949-f12472ff0aba", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(356), "46665ab5-8b2c-43de-8507-73c605179152", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1971a196-3a5b-45a8-85a3-89fc3b0ea200", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(583), "11bacf00-4632-45c3-aedd-fa5ea319a175", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "39ffa364-7ca2-4c08-a098-6276b95bca72", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(594), "2618ca1b-e6e4-4d0f-9143-bab2b0f95816", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd160e47-ab2f-42e1-86f0-74b903417c43", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(608), "0ee6b7e8-b8fe-4988-b0c9-9ba346060853", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e419dbf3-69a3-4cc6-8a46-892d7f72c5c6", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(620), "91e07346-d67a-4519-8b0a-cb810a6f2f98", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77b7f864-ed82-4e6c-94c2-a45497c9d219", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(631), "11700f6e-9d51-437b-8e24-1b3723ac09dd", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "80b95805-5731-4dc7-bbbf-64eddefd96d4", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(644), "88c3e481-cce8-4b75-babe-0fe4657743e9", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3aedce4c-e186-4bdf-ba1d-e1b6657794a9", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(460), "9d5d525b-a2b5-421e-a426-f869b572cdad", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05354b0c-3001-4b85-9380-f485936afd93", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(473), "ecf3de7e-ed93-4d94-a3ea-ef2f85626e15", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c1fc4660-eca9-4019-b186-79bc217b45f9", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(486), "374e9887-867b-4ec0-b6c3-126290c4ca0e", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f4ee8ce-d747-44e4-bb1a-38367fb47617", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(498), "f505f96e-4c94-4efe-98cd-d9f366e70b35", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "83cc3a22-bd49-44c6-8c18-74bcb71e97da", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(534), "c11fb943-f2de-44ec-8291-a8350b765748", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "092968ff-5234-4c84-a2c3-78c7a7a5539d", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(547), "5c8869e1-47ad-4278-a0e0-e6d2a8a1dc78", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02ea2a99-f519-4d46-8357-c9b2cc1a2dcd", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(559), "eae8c6cf-6688-4015-ab05-6caf01c924ff", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef458fd1-6dcb-4ba7-b0ea-7c2630bb1ce6", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(570), "cb742113-c28d-40ae-bdc1-5ad754c60779", new DateTime(2024, 7, 24, 23, 45, 46, 924, DateTimeKind.Utc).AddTicks(570) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_Id",
                table: "ProjectProfessionals",
                column: "Id",
                principalTable: "GenericProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProfessionals_Projects_ProjectId",
                table: "ProjectProfessionals",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_Id",
                table: "ProjectProfessionals");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProfessionals_Projects_ProjectId",
                table: "ProjectProfessionals");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProjectProfessionals",
                newName: "ProjectsProjectId");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ProjectProfessionals",
                newName: "ProfessionalsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectProfessionals_Id",
                table: "ProjectProfessionals",
                newName: "IX_ProjectProfessionals_ProjectsProjectId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "62c988d8-e69f-4f90-b611-97d485055ebc", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5645), "741e1ba0-55d8-48df-b597-b36ad44b7c58", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c398877a-2a6d-4080-93c9-43cf971fa0e0", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5818), "7b84997e-0b59-4b71-867f-be5e84e19b95", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d1c5d3ab-a6c9-43e0-8d3d-f96967240bfa", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5829), "521b0590-703c-4ccb-9183-2f248eddeeb9", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a34a6bbd-5cb3-48c5-9e5a-1a8fc5e8186f", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5842), "717e0f7d-0446-433d-8541-6ab09715a19d", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7ff7a53-c50c-449a-9a01-7f06bab7abd0", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5853), "942fbb6a-40dc-4c43-a7cc-c236948c953d", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74e74d78-6043-4bf4-bea1-0d3272a7df62", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5865), "a915c174-9761-41d3-8533-720180e69178", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54469a42-80d5-4260-b068-6ce9fb126d79", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5877), "de2ce729-9e0c-4e97-8ce4-2e25eb8d0b7b", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "22f08fa4-ae2d-4a1d-a68b-132ce5084b0a", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5712), "bad03f78-f8c4-43ca-8f73-8a7d30caefba", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f755cddf-13b7-4947-a551-1ef67022a052", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5724), "9f00cda1-f239-484d-b141-9fdfbc64c70c", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6cb90547-acf6-41cf-8edd-61ee1643642c", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5744), "fc9ce383-d2fd-4faf-ac80-d14ea6da65a7", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "00d9697b-1658-46ca-aa5a-ee163cd666e9", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5756), "9375db64-7f59-42b1-b34c-ccf8c54e0c6a", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74d12874-5c0c-4d1a-b0cb-800723e0f930", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5769), "49f70c75-1f2a-451d-a13d-c2dedc44dd47", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "57773aa1-7bab-4c64-8d5e-e547e94448d1", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5782), "e1461c61-0d9e-448a-8815-06aeb3500a55", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33212fd2-9a89-42d2-b2a5-c44165563a0b", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5793), "9dee6fbb-d4c7-4c2e-86f2-8ad96605c3a1", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "521d7cb1-fd36-4f8b-9d25-ad29409afd41", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5806), "c058d2a5-9882-4ed8-a3c1-10e9e9b53d13", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProfessionals_GenericProfessionals_ProfessionalsId",
                table: "ProjectProfessionals",
                column: "ProfessionalsId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProfessionals_Projects_ProjectsProjectId",
                table: "ProjectProfessionals",
                column: "ProjectsProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
