using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
