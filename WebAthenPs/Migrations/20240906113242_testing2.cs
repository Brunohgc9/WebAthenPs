using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class testing2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_ProjectProfessionals_ProfessionalId",
                table: "ProjectProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("bddff76b-320d-415e-bca3-869a68b28f7a"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("d91ae646-2fc2-48b2-b081-b55cf5f5006b"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("df50d053-3a5a-4706-80eb-24d0529c1747"));

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals",
                columns: new[] { "ProfessionalId", "ProjectId" });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("03cfeb7a-1a7e-4a1a-97f1-2c13f577b8b8"), "Industrial", "112233", 12 },
                    { new Guid("8c803d02-8aa3-4232-93a6-1aac93b755c0"), "Comercial", "654321", 6 },
                    { new Guid("fa80b572-e8c7-4da4-8845-a6a02963ba07"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fba9052f-3a20-4833-a8af-d1aedb6c82aa", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(936), "b172a9bb-db37-4ac6-8505-a84b26546ded", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7add311a-3976-460d-9a11-26d38cc500df", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1123), "b2044ac6-fae1-4c6b-bd4b-3631caa4411d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "48020e6f-80e1-4a50-ad7c-7df893e8ea8b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1135), "fe4a258d-0d1c-4617-a0b0-9aa4a8aac4bd", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1fd126d5-f2e5-428f-a755-755213ed984b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1147), "01f085c3-64cc-4fab-8126-e704d691e4d9", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c4c43412-a178-4caa-9344-a806850d3635", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1160), "497e89f6-1c00-441b-a387-5de9b58790fb", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ea516782-8a90-4d16-a25c-af1177f2ea20", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1171), "a46f92f4-83d7-47da-8c20-6e39d29a0b94", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c18befa-f3a6-47f8-9c28-cff43ac911e0", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1183), "a467e678-5b7d-47f4-973f-3120249a37a9", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca2e7279-30d0-40c5-9c8a-e3f6d04487cd", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1195), "da1c5fce-129e-414d-a30b-0c7b2d94ac2d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a5857515-0c17-431b-8a72-f73f71898c0f", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1206), "65bc7700-cbda-4f61-b49b-31cd9b5d2671", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7af68c0b-7932-4567-980e-093254989ab1", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1219), "13187645-2987-4518-a85f-a748438f9cf1", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d6fe00e6-32a1-4266-9676-a3ad25ccc36b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1230), "f5b8652e-9da0-4cc2-a193-80bfe254282d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fdffad4-726e-4222-9148-68c5241c7bb8", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1005), "0af82cd8-02e6-443e-a15b-44e01766563d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd4795c4-6e7b-47e6-b8ea-600e2f6c5b27", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1241), "aa0f965b-a6c3-478b-8862-640d7f124014", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c214a92f-5ded-4e49-a09f-1f30d75f9e79", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1253), "b7e33f53-4a4b-4d15-9f13-40e61ed15773", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a66a5301-6eee-4349-92b2-5328c362bc8e", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1264), "91b3552f-6348-48bc-998d-f6ea1aa15c94", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "011fa069-c40c-4394-9974-9311ee88789a", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1300), "9483ced1-ee13-4a40-bf5a-feebe72bce78", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "927a4394-1704-431b-a329-4eb774246117", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1311), "25257c65-a15f-4aff-86e2-d3db7a2e76d0", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fe0566a-da45-4dd0-9387-331678855387", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1322), "c8a430aa-a81a-46c7-8bce-78b3150008d4", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1bac6574-c96c-4a9e-90f2-57f982a9790f", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1335), "5e022716-f7b3-42a4-8099-8f2649066eb2", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25782b23-c48b-4ca3-b14d-a85ee55214ef", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1346), "a63d57db-e29a-4077-b455-85f5ca55fc27", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "389503a2-3838-48f9-9274-d19e7211787e", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1357), "293f52a5-49c6-48b5-81fb-28b0a472468c", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5d7eabb2-c9cd-4655-961e-9bf5ffb4a60d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1370), "bc9d6b2e-1827-43f2-bafa-60fdf73d9e84", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ecedc11d-a9ed-479e-b3ea-c1e20bfbbebe", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1017), "251a6fa4-76ed-4165-b400-58f19becb941", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cafd785b-4c4c-4742-b316-0f69c6def939", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1381), "031e0c02-4ce7-442e-b8a5-75d549d69fe8", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "83353325-261c-415e-bae2-4ed0e449c18f", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1029), "100ccbfd-cbdc-4e4c-8032-d1e31ee21f4d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9af8c4dd-96be-477f-b46d-36177048c17c", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1041), "83c8eda2-ff1f-4b01-8510-41d03c6cc34b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9c87a75a-439e-4ce1-b680-502c93df422c", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1076), "1d5e3836-dcad-40fc-8bf0-7add03481491", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b45ab83b-d8d4-4ec1-ac10-2e84b9279b24", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1088), "61c407b1-0d3d-46e8-8a3d-5428838cfb87", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "65c2c1bf-a731-4983-86bc-aa581a5c85f0", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1099), "a1d3ed4b-cc9f-4c26-a2ea-6dcec3638cc7", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0592ffa3-c246-4315-91a2-38aa535c9bb7", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1111), "75739ed2-ee72-425d-b5c9-99a1e3d29706", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "ProfessionalId", "ProjectId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 3 },
                    { 3, 3, 5 },
                    { 4, 4, 7 },
                    { 5, 5, 9 },
                    { 6, 1, 2 },
                    { 7, 2, 4 },
                    { 8, 3, 6 },
                    { 9, 4, 8 },
                    { 10, 5, 10 },
                    { 11, 6, 11 },
                    { 12, 6, 12 },
                    { 13, 7, 13 },
                    { 14, 7, 14 },
                    { 15, 8, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_ProjectId",
                table: "ProjectProfessionals",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_ProjectProfessionals_ProjectId",
                table: "ProjectProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("03cfeb7a-1a7e-4a1a-97f1-2c13f577b8b8"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("8c803d02-8aa3-4232-93a6-1aac93b755c0"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("fa80b572-e8c7-4da4-8845-a6a02963ba07"));

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProfessionals",
                table: "ProjectProfessionals",
                columns: new[] { "ProjectId", "ProfessionalId" });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("bddff76b-320d-415e-bca3-869a68b28f7a"), "Industrial", "112233", 12 },
                    { new Guid("d91ae646-2fc2-48b2-b081-b55cf5f5006b"), "Residencial", "123456", 1 },
                    { new Guid("df50d053-3a5a-4706-80eb-24d0529c1747"), "Comercial", "654321", 6 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eedbf4c7-7c4b-40a3-8ea3-da173cb980ee", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8435), "cf98c3e3-4fb4-4365-9c2c-e0eff0d792d6", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "228d400a-1edc-4303-9d5f-c8af9cf84f30", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8653), "e29d7f15-be55-494e-9640-42121c80d4bb", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77c51762-4670-40ce-a73b-f2fa6e02c628", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8664), "a0ab9d9e-cb21-4fa1-bcc1-4bc47dac1f75", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0617e1aa-3329-4e52-8a44-d3fd32e4b659", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8676), "3ff7ea5e-7050-4d51-b384-17592ce6362b", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9a7da4e0-5272-434e-9ebd-ce276575551e", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8686), "8c37089b-6c10-44a2-9979-34abcb31880f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6fe39da0-e549-4f82-ab55-1d47bc56e8af", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8698), "81f13dee-0c98-4b1b-a0d0-207d0c772b5f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4a9a6741-40a9-42e8-9d29-69e139d490c6", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8710), "a0db765f-ff58-4e9c-a832-0a28498a1b2b", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "11c749fc-2198-469b-b067-f3e0385a551f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8720), "2ce6ded7-95ae-4229-aaf8-651f8ccbadc8", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "89c43f8d-aad7-4482-ae59-d557c4ea1466", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8731), "e83cfa46-8430-4934-9993-cd67f894ad59", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "af7cd112-f366-4f56-bd96-0d36f71511c4", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8764), "9c4da17f-d2bd-4401-90ec-a4fc4c520bcc", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6ddf1bb0-3a9c-4c5d-b5f6-09c38409ad92", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8774), "102b9ee9-8b27-4344-b97d-7bb2548f18d5", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5df9de99-1ae5-4191-ba5a-a62aa0a6663e", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8559), "785ea47c-9b80-4d16-8a3e-ace29ddef449", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c5f8a2cf-32d9-41aa-907b-ee7587ed7d6b", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8786), "cefb2062-754e-4bf6-9598-47f44acc7de6", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92e56dad-b240-469b-8c2d-d46882d804c7", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8797), "07db14b6-4928-4335-8e88-9456f38c6f8f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ec1632a-042d-4954-93bd-24789ade3466", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8808), "36e64130-74ff-4969-9876-9cfe861538c2", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fbba41a8-ba0f-44b8-8695-02a24bbd7dbb", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8820), "9ebc43b3-0637-452c-af5c-b023cc14f6cc", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ea6dfd9-93dc-477d-b886-9c41e16b6330", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8830), "5467706f-dadc-448f-a0d3-29c931422514", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "94acba7b-4e00-4761-80ad-792564a09956", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8842), "941c0cd8-b80b-4048-b38e-9f5e7b6d48c4", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd59d03a-a967-4687-a580-075228528ef3", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8854), "2f4a196b-c7a1-474f-98b4-ede244cc0aa3", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d2e875db-e8ae-4fbd-ae95-c9fafe72a32f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8865), "5e3d9796-ebfd-423c-b523-5d156bad0257", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4f51cc92-5b08-4089-bc5c-72690499c493", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8877), "0b20a659-eb17-4594-a7ed-132ba63f7f93", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8cc70868-36eb-4464-a7fb-3cf364369b3f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8888), "625b4372-4537-446e-885f-5f6d472e8330", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f000567a-b07f-4d81-bc10-c498960bd91f", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8572), "631f7d89-fdf9-4933-96f6-513f30afd6aa", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "78ac026c-f953-406d-87e0-0483d0d0d4bf", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8898), "f729033b-a3c4-4331-80ea-865d5ad81dbb", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "442f56b7-4a8f-4c88-8462-5ef80bac2985", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8585), "3615c124-bd6e-4401-a73b-3d33118f61da", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a51505e4-2f79-489e-a63c-05d0cdee9000", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8596), "50019c16-6c93-4e6e-819b-e825452da16b", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b171638-a956-4570-8e62-4b6ff8c847f5", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8607), "cb67e37c-33a6-48ff-9a50-6d7e972e2859", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "58866933-291c-4dcd-afd2-ff78d63a5167", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8619), "4daafb07-abf4-4854-92eb-80240b14e654", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4c1f325b-4750-4680-ae0d-92770f8dc128", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8630), "f6df03ff-ee10-49fb-a933-921a1600d0e7", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "03af7f1a-4cc3-4eb6-b477-3e25a08c3f05", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8641), "fb7f298c-c9fc-4e21-94a8-273ba3c55578", new DateTime(2024, 9, 6, 11, 18, 45, 252, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "ProfessionalId", "ProjectId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 6, 1, 2 },
                    { 2, 2, 3 },
                    { 7, 2, 4 },
                    { 3, 3, 5 },
                    { 8, 3, 6 },
                    { 4, 4, 7 },
                    { 9, 4, 8 },
                    { 5, 5, 9 },
                    { 10, 5, 10 },
                    { 11, 6, 11 },
                    { 12, 6, 12 },
                    { 13, 7, 13 },
                    { 14, 7, 14 },
                    { 15, 8, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_ProfessionalId",
                table: "ProjectProfessionals",
                column: "ProfessionalId");
        }
    }
}
