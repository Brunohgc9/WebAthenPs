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
            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[,]
                {
                    { new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"), new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e") },
                    { new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"), new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9") },
                    { new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"), new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2") },
                    { new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"), new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1") },
                    { new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"), new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f473d988-66c0-49e7-931e-9a5e0eaf6127", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(799), "3727ec39-2f16-49ee-bac1-b86719d49a67", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "622d1d68-6267-49ab-a752-9a6b78a06bbc", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1007), "7fa04184-bd06-4718-9817-3cdaa44bafbc", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "91dcd2c9-45cf-41d0-9a4f-15ba075432b7", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1095), "1734b1da-0e78-4e33-90de-aa5073d0c6ee", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b6dac2a2-cec1-4013-b8eb-e84bcdeebb28", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1110), "e11d67c2-8ff3-4794-bc0c-6dc471b39054", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d83504a7-bb23-4fc7-99fc-b251e84e4f39", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1122), "43d1dae8-6ad6-4181-b4a6-b5593acf9d79", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fb3e654c-cca2-406d-baf7-737417d27850", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1136), "4b20a25b-0deb-4ee1-af31-51a4ae90edf7", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5b9eb890-d466-4fbc-bfcc-54c4df3defe2", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1151), "316ebe55-ee5f-4cf7-a2df-371f0dcab0e1", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37745c0a-d4be-4303-b60c-abc6f3183f88", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1174), "01cb285a-9bdb-4854-a963-cf03d09bb95c", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "91d45975-23cc-49ab-b2aa-720e19fd7750", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1188), "bbdac948-ca3b-4af0-a75d-f7768e3fc1c2", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37debb69-9c95-44ee-a659-95af8b213823", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1199), "4b70a02e-e0eb-4a83-ba99-658133fe20ef", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34dd4196-3e83-4922-b521-975075a9cf93", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1212), "8374c99e-9d9a-4a5c-ba1a-dfc2b7b209f8", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ae55f362-55cd-4b35-ae50-21c436479e45", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(891), "34d9cecc-60dd-47ca-b2f0-b11fede797e8", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0bfc3898-ecd4-44ba-b547-68e37352ad2c", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1225), "8159162f-0417-4920-bef3-8d4aee71ad5c", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "41bb326c-baf2-4850-a109-f750087eda1c", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1236), "38a9f385-83ad-444d-88a4-33a12364ad40", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "455ac149-d025-4870-99c4-2c8b4f6e8f89", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1247), "42fae7d8-8913-48ba-b995-1ae435179515", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8c98e78d-0cf3-49df-a8b3-790dcb013cbb", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1260), "504e276d-12e2-4130-bbfc-a0438e3fc1ee", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5da284e5-6b0d-4717-813b-c557cdd904ca", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1273), "918e3ee3-736c-4c43-b973-0ccccde64f74", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6d63b125-6412-47c9-bf98-268233457c98", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1286), "d014aa85-0668-4ec2-bd28-636ebaa192e3", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d4b6ab12-1268-4121-bdb7-f357e44eded1", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1324), "c7714c1c-f3f4-4691-b430-f79d097c440f", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "69f1de2c-58d7-4529-8a66-b2632dd4c430", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1335), "f421400a-e323-41c4-95c5-73a26803da78", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4e492384-e8c4-4abf-ad36-c797f4526f28", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1349), "b001062c-a17d-45b5-b951-3d267fe6bcb3", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9b3f6ab-c1d4-4efa-a265-08bb637da68e", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1360), "d875db25-e391-43c0-97a7-979b144af73c", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f572ef6-3a61-4232-b779-9b192ad45da7", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(904), "3fb1ddfa-c347-4d7e-bf96-5fedb106f12c", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f02664d4-2c8f-4dca-8619-a3290a3f536b", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1372), "e67f8da2-8421-4a4b-9d25-d9e3fc320f56", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02cf1929-5201-4c90-bf42-dcf3b878ac61", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(924), "719b54a2-f1a9-4c7b-b248-997223abbfa6", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a72882d4-0867-4b0a-bdb5-06507dbab2f0", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(936), "bc9b6e8b-c0db-426a-8321-64466fc5616f", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "43cef233-8b0c-415c-92f7-e4235ecbf892", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(956), "afb7a144-222f-4647-ac64-a29e45ce8930", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "992889e2-f01f-4301-86ba-4eaf5e9b13f9", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(970), "112a59c3-0096-4a43-83ee-d93c2dcc96ed", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b64ffd9b-8d4a-4912-9abb-fe824a4813ac", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(982), "3de36162-fa14-4c1a-a5c2-12fac0c74880", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8075a55a-e27f-4110-84e1-aa9371752f59", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(995), "39275c69-ab70-4043-912a-c3f082cf54b9", new DateTime(2024, 11, 20, 23, 7, 46, 91, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.InsertData(
                table: "Carpenter",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[,]
                {
                    { new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34"), new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34") },
                    { new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"), new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829") }
                });

            migrationBuilder.InsertData(
                table: "CivilEngineer",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[,]
                {
                    { new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"), new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2") },
                    { new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"), new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3") },
                    { new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"), new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1") },
                    { new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"), new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851") },
                    { new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"), new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8") }
                });

            migrationBuilder.InsertData(
                table: "Decorator",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[] { new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"), new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e") });

            migrationBuilder.InsertData(
                table: "Electrician",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[,]
                {
                    { new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"), new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84") },
                    { new Guid("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6"), new Guid("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6") },
                    { new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"), new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648") },
                    { new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"), new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4") },
                    { new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"), new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851") }
                });

            migrationBuilder.InsertData(
                table: "Glazier",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[] { new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"), new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84") });

            migrationBuilder.InsertData(
                table: "Metalworker",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[] { new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"), new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27") });

            migrationBuilder.InsertData(
                table: "Painter",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[,]
                {
                    { new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"), new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9") },
                    { new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"), new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2") }
                });

            migrationBuilder.InsertData(
                table: "Plumber",
                columns: new[] { "Id", "ProfessionalTypeId" },
                values: new object[,]
                {
                    { new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"), new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4") },
                    { new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"), new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829") },
                    { new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"), new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "Id",
                keyValue: new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "Id",
                keyValue: new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "Id",
                keyValue: new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "Id",
                keyValue: new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "Id",
                keyValue: new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"));

            migrationBuilder.DeleteData(
                table: "Carpenter",
                keyColumn: "Id",
                keyValue: new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34"));

            migrationBuilder.DeleteData(
                table: "Carpenter",
                keyColumn: "Id",
                keyValue: new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"));

            migrationBuilder.DeleteData(
                table: "CivilEngineer",
                keyColumn: "Id",
                keyValue: new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"));

            migrationBuilder.DeleteData(
                table: "CivilEngineer",
                keyColumn: "Id",
                keyValue: new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"));

            migrationBuilder.DeleteData(
                table: "CivilEngineer",
                keyColumn: "Id",
                keyValue: new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"));

            migrationBuilder.DeleteData(
                table: "CivilEngineer",
                keyColumn: "Id",
                keyValue: new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"));

            migrationBuilder.DeleteData(
                table: "CivilEngineer",
                keyColumn: "Id",
                keyValue: new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"));

            migrationBuilder.DeleteData(
                table: "Decorator",
                keyColumn: "Id",
                keyValue: new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"));

            migrationBuilder.DeleteData(
                table: "Electrician",
                keyColumn: "Id",
                keyValue: new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"));

            migrationBuilder.DeleteData(
                table: "Electrician",
                keyColumn: "Id",
                keyValue: new Guid("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6"));

            migrationBuilder.DeleteData(
                table: "Electrician",
                keyColumn: "Id",
                keyValue: new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"));

            migrationBuilder.DeleteData(
                table: "Electrician",
                keyColumn: "Id",
                keyValue: new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"));

            migrationBuilder.DeleteData(
                table: "Electrician",
                keyColumn: "Id",
                keyValue: new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"));

            migrationBuilder.DeleteData(
                table: "Glazier",
                keyColumn: "Id",
                keyValue: new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"));

            migrationBuilder.DeleteData(
                table: "Metalworker",
                keyColumn: "Id",
                keyValue: new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"));

            migrationBuilder.DeleteData(
                table: "Painter",
                keyColumn: "Id",
                keyValue: new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"));

            migrationBuilder.DeleteData(
                table: "Painter",
                keyColumn: "Id",
                keyValue: new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"));

            migrationBuilder.DeleteData(
                table: "Plumber",
                keyColumn: "Id",
                keyValue: new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"));

            migrationBuilder.DeleteData(
                table: "Plumber",
                keyColumn: "Id",
                keyValue: new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"));

            migrationBuilder.DeleteData(
                table: "Plumber",
                keyColumn: "Id",
                keyValue: new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4d5b23dc-3e52-4521-94ed-61960a0a0771", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7215), "deb5b4f8-a025-4c8d-8629-34c6084b1328", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c1c0dfe7-6700-40d9-a56b-9891062b6e34", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7459), "0cf01287-6da3-4b90-b592-e5ac1bab895a", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "badaf213-4e8f-47d7-8c64-ce72c85e1224", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7517), "d0978583-942d-4557-a945-f8a374b4f4be", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1b745a95-9c7f-4fce-a33d-af8b5a357923", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7531), "4846dfbe-f05f-45b1-9ec8-9300f594138b", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d1ce737b-6ff1-4659-949b-c4114ceec953", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7569), "33c235fd-5132-4b6c-8274-24f91e3f317e", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4612915d-5c9c-4fda-89db-25672159f594", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7581), "123b5054-e15c-4df0-99df-a59279461bc0", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7b7e5d51-cbc0-4bc8-8cfe-2f026ff66c2d", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7595), "2235207d-ee6e-4b36-a35d-e8aaab235035", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2ccce341-e1b3-4857-8056-654f83f14acc", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7616), "583c0c81-6946-42fc-8273-2e90956c6778", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92f412ac-2202-4249-8af8-3619835ad9a4", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7628), "1320d064-0bce-4fe0-ac04-7060684a8868", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f28f503-5844-4601-9cdb-75034bac287b", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7642), "d22b97c0-f6a2-4687-93ba-7b95a42410b3", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cac979c9-93ab-4c93-9430-a1da4bb84695", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7654), "d8818897-b5ac-4686-b863-a91839869620", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c68e57e5-0513-48d0-b838-17f40415af1c", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7345), "6ccf3e22-f3da-4eca-bd5b-d39c6c01ffa4", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3c8dae92-7a7d-47d7-a25e-5ddbfc3e9500", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7667), "3a4ff759-5cbc-46f1-b0c0-e3f695c90ec7", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f4a45f75-57c9-491d-b8a5-0be954ef3809", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7679), "d1684a36-2b32-4196-9cea-cbb236cbe0d9", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4e00d960-7688-44fb-a991-3bcbd3fbf5d0", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7691), "43c42f36-27b7-45e0-b7a7-2d475037c1d5", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "191c4b43-875c-459a-b57c-c9321c20337c", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7705), "15b30b81-620d-4f3c-846a-0004da4e7e3b", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ae48d476-c75f-4bde-8fcd-2010c88ae690", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7717), "499a2564-c144-4c45-974c-a9935d3834a5", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "279543a3-2e53-4c4b-964a-cb7691e547bc", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7729), "0b2b2ecd-685e-4cbf-aebd-fc4152a3a07a", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f6238f43-5319-44c4-8a1d-569b83b1b5b7", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7743), "f2acd539-fae7-47a9-a133-2376ee6c56b5", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2382489-49c8-416f-8893-9a07b818c6f2", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7755), "7d262ac2-40bc-4dee-81ec-bfb337865be2", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "214db6c1-9fa0-4474-b83e-db19c68844e2", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7768), "28faf887-3e0d-48e2-a2b1-ed22c9957477", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9bfe20e9-6344-4f4a-abef-1537c05be774", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7808), "981cf51f-2836-40e6-8781-2f034aed9ca6", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d32aca71-f074-4d97-9e81-51cbbbac5c42", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7359), "cf056198-a5e8-4b90-bb1b-1c72a32e6dc2", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5bb09a20-725c-429a-a6c8-6e82cdf8692b", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7821), "712b9b85-9ddf-42e2-8f2a-43bb69aba5b1", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4bcdc9f5-0cf1-4ac2-8aa9-7a69d7178abf", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7373), "b04f9070-1800-46b9-8aff-ba0f1e7615e3", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "22dd70a0-d0e8-45fe-9c06-cdab9dadebf1", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7385), "e63dc52a-64f7-49c5-b25c-7944cc0b9601", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "72641aa9-ad23-4ef8-870c-da5c597af52d", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7405), "075ef375-5d46-4066-b10a-d029a22d1a69", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2dc43fc-22c5-4a88-be07-858ce902dc22", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7419), "0ce3e4af-96ce-4a45-9c52-ca54d28c21fc", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c3e906e9-568f-44bc-9443-a7c02f32d3fd", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7432), "521aafd9-ef13-4703-8c2a-952382d269ea", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "52be7adc-f503-4827-9c53-20a40ef44e0a", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7445), "46ae71db-be7b-4a3b-ad84-a63e6e1e0091", new DateTime(2024, 11, 20, 23, 3, 37, 209, DateTimeKind.Utc).AddTicks(7446) });
        }
    }
}
