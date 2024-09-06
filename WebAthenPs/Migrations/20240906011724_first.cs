using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("30ce08ef-f668-46b5-a2e9-0c1c8c0f263a"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("616567b7-8765-400f-a46e-11120841980f"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("ba0a386a-0d4d-4e68-b896-b6254f3f7572"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("1b87a086-65d7-4a37-8a2e-ba68b508d2e4"), "Residencial", "123456", 1 },
                    { new Guid("8c37fa5b-9e8e-42cb-8fb9-d52f1621242b"), "Comercial", "654321", 6 },
                    { new Guid("f87cd949-b167-47f8-9cce-76427a357681"), "Industrial", "112233", 11 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "66730d95-df06-4f92-8461-d768911ce8f6", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2546), "826ed14e-29b6-4a64-ba2f-5513dcca0347", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fbdd53d6-7ca3-4348-a89e-808bba5a16ee", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2729), "bfa907b9-7a43-444e-bd00-4007d5758337", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d8afe97-a356-4f73-934e-2004c5ef4125", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2740), "39a8b2e7-1b74-43f0-a79e-30fa65ad8232", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c0394f4c-3121-4e78-87d3-3858155a8d9c", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2752), "bf340ecd-39f8-447e-81cf-7769d67549e8", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "09f9d93b-dc29-4cec-a100-7b9ff272c9d4", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2763), "18ba79dd-53fd-4dec-a19a-bc5a1e4be7eb", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76ae7b38-5599-48f2-b363-cdb5a9797a71", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2776), "9358fbed-f83d-4baf-9778-35e78577fe31", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "622afdc1-b01d-483e-91ee-8895f8a07506", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2786), "a5a5f58e-0d0f-4a36-a5d2-16a86ebad4be", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "17dea1ec-3267-4760-92e0-0c10b4e0a10b", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2797), "5e0c8896-b6b7-4af3-8665-06f94c98b76b", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "24abee91-af25-4cec-ae5a-1cbeff721d9e", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2809), "e56c40f6-57b4-462e-a810-05ab21de516c", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "86e33994-c0a5-485c-a3c2-e29735e091d8", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2820), "63043849-7009-4031-9514-48066dfe1d98", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1935a731-a2c3-404a-88f3-70022563b623", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2831), "ef525728-e4f7-4bb3-8615-b7b10715c0d2", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "abc61bdc-9a74-40ba-a65d-4949970c1cd2", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2615), "f5fda5c5-f5bb-4811-b13a-170d67b47f76", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b3c4355a-8193-4335-a56d-32a4fc045393", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2843), "4f0f4770-0862-4e24-9418-635166dcd957", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9e665e71-97be-4c9a-a7fb-fa2d7ca5ac95", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2854), "18944265-82ba-4dc6-9963-6fde9dd3f250", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8e16af99-ec5b-43b7-91a4-71dc278ee92f", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2865), "68c23ef4-69fc-4f7c-b8bc-e131870aca81", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81c98b98-a144-4831-9ab6-e2346a1eb26e", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2876), "4c2fcbba-0259-4abe-be0a-b3d8d81c3752", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c9b16fea-9a84-4359-aacb-c0b4745bce63", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2942), "c8abf4b0-98d0-4822-87f3-b65f0c8960ef", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2189dff7-f6a7-49c2-b366-59961a7f16c7", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2955), "9f60a910-29d8-4b95-8131-35ea5fdf9291", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2dc17c0-e06a-41c5-af0e-6270eaab52b3", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2966), "68f94942-70c3-4bc3-afe5-de9f986cc7b0", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe43952e-d52a-4832-ba00-07ac6c75c84e", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2977), "64c8630e-4e21-4f47-8eac-5c69ab5a07c2", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b578f34e-cb8c-453f-a1ec-c9fe2a304265", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2989), "cb4a2e5d-6dbb-4941-82cd-6cf056d07bd8", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6eb04161-c5e1-4704-ba94-1571ac00ea59", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(3000), "a557d38c-600b-4f7c-8887-6528d66c80d9", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68d6b27c-1bc0-4cb1-be16-597cc6ee72de", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2627), "3ff64037-e3b0-4cfe-9444-d459ca7ab0c0", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19f1e875-7b7e-4254-ae0c-992494b106d9", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(3012), "5387d371-5188-4dca-8e10-a61da71cfae3", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "053c1556-d3d7-411d-ab60-01d79af475a5", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2647), "a6951770-257f-41b9-a637-4848ff20bb87", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2ab0586-c241-4ef1-bcfe-40a9cde3ed29", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2658), "20b004da-257e-4386-9e20-d86a52382b78", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e65dcdc-f1fa-4d46-a9fb-432f5c44d168", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2671), "ddcf68bd-09b3-4a0c-8526-b71274140bd9", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37d1f3da-476e-48a3-9149-8ff6506b1d58", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2682), "a2c29742-720f-4d9e-90c3-94f35ca6cfb6", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d7e3b90-189c-4610-b1f7-91dad5a439c3", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2707), "51a10821-3d98-418a-9767-a7d707a8752e", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ca5e992-c3ae-4653-ba47-5468f86c756e", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2718), "7c35ad42-04b4-42c6-8cca-82564fdfb759", new DateTime(2024, 9, 6, 1, 17, 24, 163, DateTimeKind.Utc).AddTicks(2718) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("1b87a086-65d7-4a37-8a2e-ba68b508d2e4"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("8c37fa5b-9e8e-42cb-8fb9-d52f1621242b"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("f87cd949-b167-47f8-9cce-76427a357681"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("30ce08ef-f668-46b5-a2e9-0c1c8c0f263a"), "Residencial", "123456", 1 },
                    { new Guid("616567b7-8765-400f-a46e-11120841980f"), "Comercial", "654321", 6 },
                    { new Guid("ba0a386a-0d4d-4e68-b896-b6254f3f7572"), "Industrial", "112233", 11 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d97b96e8-8baa-4330-9a9b-5fa1247b3ed1", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2714), "7538e0c3-f0f1-43de-ba4f-78ab86f6c291", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4f14ac9f-d44e-45a8-b873-d55657a2757e", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2874), "85ec5852-139d-412d-b42a-2ac407e81456", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "49b995ee-d684-4d4b-a3ba-bb439e151449", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2886), "61885c65-9ad5-4989-9208-bf1d3bc21707", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8422eb14-9930-4390-b9fc-f27d135b84b0", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2897), "27d36f5e-b45e-4558-be74-437693a3b5d2", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a5e27352-9ec3-4952-aa12-6cbb301b5b80", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2908), "2fa7fa61-6a66-4479-a24e-b3ffde463462", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "08a00058-e38a-46ce-bd32-2ac565062a4e", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2921), "644bb4a2-5de7-47da-89a9-8e1580f1c9ed", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c34d17e5-6b03-414b-8dad-124bb89f3ed4", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2931), "9480eb4e-0af4-4714-a7b5-dd8bcc2959d9", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6eb2bbaf-0e1d-4806-87bd-af6d1df12ff0", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2961), "08e74fec-7f4a-4c9e-8db9-b44dd0a6019d", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1456ddd2-95ca-4720-81ac-32889ff2b148", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2971), "676fd7cf-7c71-4d52-8ea8-93a592bed73d", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7c3af933-0373-4e79-a2aa-fda4d6c92de6", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2982), "af78afbb-37b9-486c-b958-1b34b97d0db3", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "52fa7a01-b784-4d6c-8598-b30b1a6e0e26", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2995), "aea5e028-686f-4b74-bd5f-1a555549ba6c", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "40d88bd6-23cb-4e77-b7ce-4939cdceaca2", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2774), "95418dd1-39e0-4dc9-a045-598bfe8f510b", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7cde7063-3184-47c3-bd55-9158317137f1", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3005), "31f64a00-a5af-4374-9eaf-038000778390", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9223f063-475e-4525-aaa6-71d0116cc15f", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3017), "0e225193-94bb-42aa-b741-b3c0ff551ae6", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "27f76bb7-0a0a-4570-b8e1-bb1208f4c624", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3028), "3773741c-e833-4e5c-823c-86f9ac0586d0", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ca9550e-303f-44db-bce4-9b96a0e42f08", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3039), "80d002d5-ca68-4bbe-90e5-bc35d481c4df", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "64ce75ac-21ae-4892-99ec-c2bfa294f232", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3051), "6f0985e9-4f63-4770-b1b9-cde886817c07", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "959970e5-de88-432d-be7b-8604428f7812", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3062), "c5258ad3-af83-43df-a3af-7db2912f9d5d", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ab0ef617-836a-46af-b06f-f2141ca3d1f2", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3073), "c3e56c7a-8a52-4c8f-80cc-57a87100d4b8", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a165f9bb-930e-4861-8ab3-46303f73a55e", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3085), "0d4ebf07-af65-4c1b-b183-5ee428daaf00", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "72d22597-2c1e-4a44-829c-00fc08d1a864", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3096), "12bc1cae-e8ea-4ba7-923f-1946067af6c8", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c573dca2-b136-41fd-96b7-f59d08b6b764", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3107), "31832154-a990-431e-b994-a743cab1845d", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ac32f09-6368-4464-a672-0c35c8e8aeb6", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2794), "3972f402-492b-4a3d-97e5-5f685ff3e5ed", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e10afdd-416c-4f90-ad9e-4e5c16b36981", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3118), "186f4c80-becb-4ab9-83f3-393c06efa00f", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "efeec5ce-68ad-43e1-88d2-9707c49b7ddb", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2806), "d5f2bb34-b068-455e-ae2a-599a158a7bff", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "238c7a46-17c4-4705-b0b4-478f65970738", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2818), "799611af-965f-4449-9f4f-41a07114fe5d", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e368aa84-08f3-4e4a-a2ae-134abcb7da79", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2829), "db85ae5f-c35f-4195-955b-808903f29ef6", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c3b2d680-f140-4111-b1aa-b6e08f30d4e6", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2840), "06668c19-b9c5-4339-a519-309223bdaa72", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "adbf2ffd-19e7-4865-a68f-0aa8e78e0fd5", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2852), "063e0eb3-6c17-45e5-853c-4ddfa36e544b", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c80e8ddc-942d-4129-b50d-8e5f7a9a3872", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2863), "00a26b73-5d09-48e1-9b1f-5ee4afc3fa07", new DateTime(2024, 9, 6, 1, 16, 12, 3, DateTimeKind.Utc).AddTicks(2863) });
        }
    }
}
