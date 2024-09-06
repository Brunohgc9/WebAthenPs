using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class idk2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("3b434c9a-39f3-4fba-b51d-8f86a21406e9"), "Comercial", "654321", 6 },
                    { new Guid("3c403a74-13b5-4e0b-b9bc-ab482612e8ac"), "Industrial", "112233", 12 },
                    { new Guid("65a90eba-45f3-4de7-99af-11ce4dd8b9f9"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d5591fdd-230c-48f9-af01-64c3d0de88f6", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(8908), "759e30d3-e20b-41e7-b00e-3acaed6417b6", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8969a541-1e36-45d5-a588-3f51500d80a2", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9070), "8832c2e3-d986-4ad3-a17b-c62e81ee9012", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c8b8f053-de42-49ed-afc8-7fd3e814685a", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9082), "30dbafe9-005b-432b-a959-a557a9b66e4a", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f06a060c-c9d7-499c-b179-b2506f2766a5", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9093), "4bd58a78-6f68-4dd0-90c1-a2ec4013f6b9", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "79214972-c922-4f91-9d5d-81efbad6d0c7", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9106), "02227547-e333-43e1-a619-57abd993b504", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9040287-85fa-41f1-a810-4d8b1a5f4e82", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9117), "bc09d081-dc37-41a7-a479-60dc58042147", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "24698627-7ea3-4a47-ade0-6f87492d166b", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9127), "b1eaf619-75eb-4799-baf4-2ca724d48fcc", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "205d5a2e-fbba-4c86-9f8a-9386c179d68f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9163), "0eb3124d-7536-4df8-ae47-a97c70c00d74", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "849376e6-3ebf-49b5-a6b9-094398e8c3ce", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9174), "7e15ec5e-5a96-40d0-8fb3-5c81da55fe1d", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e58376a5-51f8-44c1-b142-8725aaeaddf7", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9185), "e83cc9e4-115b-4163-90ab-a5bce2bdb73c", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3c65cd9b-3fca-40e0-859a-e0e095f310ec", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9197), "c3df0f69-2a8c-4ff1-97ea-79bbd5631516", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ffb12438-c173-4510-8bdd-960d4b047b57", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(8970), "d4006eb2-3659-4b13-9707-84a56882a549", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71da4be7-d89f-495e-9c83-2a206693ff67", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9208), "694ca159-b990-45df-9a14-149ddef55a2b", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fa76bff4-5355-411d-924f-c56c5879819f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9220), "aa97ee94-5d4c-4cc0-8545-5f044ba9b146", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c42c1fc4-5cdd-4a3a-9fe7-acb4e535bc25", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9230), "46da4ee1-c91d-49d9-ace3-1adbfd4b5b7f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "28173f87-e5c9-4611-bb26-a8c785c0130f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9242), "5b5299ac-615b-40e0-a3ab-3ff7c16eeed8", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77f15c50-b170-4fd9-9393-096461c392ac", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9255), "2164cc64-c621-4549-a461-92c47c2f135d", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44031c01-b165-4932-bbf8-7c27f9ae6ae6", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9265), "7482fbaa-5ddf-47dc-b800-7fa2dfe6e49c", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7ab7899-70bf-4fdd-aa3b-ff3aea96612e", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9276), "b14d23aa-c6d1-43b4-89c4-60df81dfd59f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "57958f44-209e-429c-ade6-d3fdc9f74f21", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9288), "cf370911-1319-444a-bee6-b31cad50ccd6", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9fcc419-4fbe-40ba-ad15-a67233c7ebb5", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9299), "1b227027-f39e-41b6-ac3e-22f6a88853db", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "238651d7-af6f-4f54-acd6-282fccd55da6", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9312), "026a1281-767d-4208-9ab8-f6149dfe9c0e", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "01a6992b-cbe0-4adf-9637-6ed3a501418c", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(8991), "fd01fcab-4cb1-4d85-8c00-5636605b38d7", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a8365f98-2805-448c-9515-7671c0ea7152", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9324), "52cf51a8-41a0-4fe1-8a8d-8a1078e4be5f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a699c5b4-eb98-4983-bf37-99d6a8a09665", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9002), "c28c8b01-cc70-49d5-bb27-a0fd7f7ca7cd", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "24aea876-e66a-49e0-acab-42c7a5ce4356", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9015), "475c17cc-e61a-4d63-b569-3cdbceaccb01", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c28cbfad-835d-4a58-865b-f057932feaeb", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9025), "9b5a8db9-5e75-4fdc-8282-cc2c363f1710", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b0452b5-5124-4890-9bd9-e348187e653f", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9036), "2d396181-a29d-450b-b365-672d062b4f01", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aeba5d64-3186-4c8f-90e7-52e5f508dfcd", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9048), "78194114-ed45-4474-a102-f1a4c9c9d2aa", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5fb5ff1f-3a84-47cb-b999-53b9a5122adf", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9059), "5a8aba6a-97f1-4218-93c5-35a51ba1f943", new DateTime(2024, 9, 6, 2, 39, 7, 876, DateTimeKind.Utc).AddTicks(9059) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("3b434c9a-39f3-4fba-b51d-8f86a21406e9"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("3c403a74-13b5-4e0b-b9bc-ab482612e8ac"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("65a90eba-45f3-4de7-99af-11ce4dd8b9f9"));

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
        }
    }
}
