using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class SixthUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "7c2a6338-c5bc-46e6-a5ad-d4abb15174a8", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3217), "john.doe@example.com", "d9302b76-1c92-4435-bfd6-c2afe6f53d14", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3219), "John Doe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "d5135f8c-82fd-4a1f-99b1-c6186a51eecf", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3389), "madison.lee@example.com", "7274a4af-848c-408c-bda5-3d3f0b18e24f", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3389), "Madison Lee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "4dfabeb1-2e27-4771-9292-bf92a01d9a03", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3402), "ethan.harris@example.com", "a6150ec6-0033-4974-acf0-57cf7cb99be7", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3403), "Ethan Harris" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "4c580dd6-9bfa-49c2-a5db-e1a1d7fa9cb6", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3414), "isabella.clark@example.com", "f37c9bcd-abf3-4727-bdc2-f66ba3738893", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3415), "Isabella Clark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "6805f778-cf58-4775-9d49-3e5de5b9ff60", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3425), "alexander.lewis@example.com", "464dbe33-e802-4862-bd80-94cebafcc4f2", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3425), "Alexander Lewis" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "bcaeab15-21cc-4200-840f-bf70191d8998", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3437), "ava.walker@example.com", "2cc9efb5-99d5-45cf-958c-fb0eb0238c28", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3437), "Ava Walker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "0cf168bf-fbe0-4165-a289-b022143ba145", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3476), "liam.young@example.com", "2643554d-9871-44ac-abd2-ea2400605b27", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3476), "Liam Young" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "b027d0a2-dd12-4b15-b421-dd6393549bec", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3284), "jane.smith@example.com", "26085792-6635-41d3-a3aa-d2b37048c643", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3285), "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "41a32bde-53a5-4eae-b5bd-d2946f6918f9", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3305), "michael.johnson@example.com", "a7bc3a98-afb2-4949-8b17-e1ecad9b2197", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3305), "Michael Johnson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "a2d5b4a7-197b-4698-a59d-9a13f0934a1c", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3317), "emily.davis@example.com", "c7e494fa-6bf8-41ac-872f-1cce26649367", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3318), "Emily Davis" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "efef9ca1-1ec3-4ecb-8a29-37514d7d3edc", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3329), "david.wilson@example.com", "bb767e2b-fcce-4b29-9d21-d31db589df56", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3329), "David Wilson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "6303d868-bcad-46f3-8878-85af2004640d", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3343), "sarah.miller@example.com", "332f37d7-4609-45f5-9a54-87323eee0871", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3343), "Sarah Miller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "07116e02-8b4c-4dbc-948d-7d74c9da1569", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3355), "james.moore@example.com", "b6776e53-bf7d-409d-b1f5-fe963b1b3795", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3355), "James Moore" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "ca5c3c5d-2f30-4c43-807b-f9bcc5d9ae35", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3367), "olivia.taylor@example.com", "4dfd6b84-4aea-478a-a03f-1a5370a85a17", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3367), "Olivia Taylor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "fb727d68-a608-479d-b5d3-41f68deafd0a", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3378), "daniel.anderson@example.com", "83a3ec5e-550a-41b6-8753-f0d8ddd50603", new DateTime(2024, 7, 25, 0, 2, 47, 513, DateTimeKind.Utc).AddTicks(3378), "Daniel Anderson" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "21a1f425-a2a1-4afe-8ca9-9cb1b330970d", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1196), "user1@example.com", "4c85fc37-22ca-4c0b-a298-7abafc8bb28a", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1198), "user1@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "df05672f-078f-4a80-a000-89224d9a88c8", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1395), "user10@example.com", "0910ebb1-ee09-446c-91b7-d1f88b60a69a", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1395), "user10@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "267ceb44-38d9-441e-8ca6-c666a4579914", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1406), "user11@example.com", "69a8196e-4225-42ba-aa45-55178d3a88d2", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1406), "user11@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "13c57877-3c80-4c7c-b7d8-33f19d567ac8", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1419), "user12@example.com", "f252add2-641e-449a-bd91-a01e33cbd343", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1419), "user12@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "ec287e60-53e6-4ca3-b639-82d993464afb", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1430), "user13@example.com", "b055c174-3bad-4e39-b87f-c28c2c11588d", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1430), "user13@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "0c3d75ee-bf68-4ac5-b61e-d549b266e5cf", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1441), "user14@example.com", "c1b40fde-d3e9-43d0-86f3-a644d617b6ca", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1442), "user14@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "3ac11121-815b-4ad4-bee6-9ca7aaac5d90", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1477), "user15@example.com", "d036d11f-42b9-4dc4-bb7e-8831c9c78087", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1477), "user15@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "b95a4726-e478-4a0d-a915-30942c58fb40", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1298), "user2@example.com", "bfed853e-cb7b-4f75-8c67-a1be7ae25b8b", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1299), "user2@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "15015302-9b7c-4894-bca5-faac5bcc9c9e", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1310), "user3@example.com", "a9e0a010-29ac-4695-9903-f526750994cf", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1311), "user3@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "c8aa4f8a-acb9-4aa7-8002-862613905fd5", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1323), "user4@example.com", "c0dcbaab-37b4-4ba2-8b3c-2d5edc56a617", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1323), "user4@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "c0c1d4f7-9326-4c62-961a-22561d8b69e7", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1336), "user5@example.com", "890c332d-c9f7-40fe-9357-3567f4100749", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1336), "user5@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "a06db861-0890-42a2-a016-561dbecbde3a", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1347), "user6@example.com", "313a5914-b23e-4479-9ccc-18fbca9a3019", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1347), "user6@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "633fb7f5-5192-4179-8e0d-ad45a0cdbedb", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1360), "user7@example.com", "716e181c-c142-46dc-a23d-7086352be047", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1360), "user7@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "d36bec51-19e5-47df-83f2-323822419747", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1371), "user8@example.com", "7c8a8732-665e-458f-831f-ee97bf7ead3f", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1371), "user8@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "fbff8488-7953-490b-a0d5-a9ef300b7e44", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1382), "user9@example.com", "17cfdfee-e8cd-47f0-aa0c-e8824147792d", new DateTime(2024, 7, 24, 23, 53, 24, 994, DateTimeKind.Utc).AddTicks(1383), "user9@example.com" });
        }
    }
}
