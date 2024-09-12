using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Teste5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("7ea2e8ac-d687-4108-9069-8cd4ca67f794"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("cc9ae146-ca12-4cc3-9087-fc986f7ec651"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("f2849d06-b1f9-4b6f-ba80-d5e398d91e3a"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("4939d3fc-d07a-4157-9827-18c61800cac2"), "Comercial", "654321", 6 },
                    { new Guid("e007a090-6ef8-4aa3-a396-7189d26da0f4"), "Industrial", "112233", 12 },
                    { new Guid("e550ff20-f02c-4ebc-b232-68845c3894da"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "64da60af-f145-49f5-9549-2a8ef22226fd", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(5946), "2b760be0-257d-44fd-9565-b32cc7021036", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6001cbb0-0258-48f3-8006-8418128f12d1", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6142), "506ca26f-89dc-4c78-aa3d-bdb91286bd1a", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8cfc6b70-2253-42dc-bbaa-6323449f8565", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6153), "8a803b34-4c79-4aba-bea8-55f0512b805c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6babdc2-aedb-460c-962d-52492ce31237", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6166), "80310c1e-9613-4715-bd78-f479b81b1864", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "393f3d17-7178-4383-8fb7-b21ec8fa59df", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6177), "d0bb7cba-14eb-47c9-bd04-6577d8bbf8ea", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a8f8fddd-d1a6-4aea-bc86-0ebba058c6aa", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6189), "9930450b-6768-44d5-9945-18160af82ee1", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7242dbd1-5675-4d86-afaf-02ebd8cb11dd", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6202), "144ad650-cbfb-4725-9693-558c978117f5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81cb9024-0b80-4c9b-a767-7fc3622a961f", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6214), "0ce81f36-53b9-40ab-b120-cd5acb4946dc", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7d29b6a-c3a7-4b13-bb80-d6197efe478c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6225), "27ced3d4-9890-49e8-941c-75835212b341", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9b624213-46a4-4b66-a81a-1e967b0b6a00", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6237), "58ab0463-a04b-44e1-a5ff-2ebb7961c2e2", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "803d88a0-9b6d-4b32-b5c1-bd9c9870fe60", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6249), "68df7227-a6d4-4053-80ca-b4cee4afc4f4", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "220cce54-55e0-4347-80b9-d2be7feed681", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6019), "e59c9210-19a7-4f10-8f4b-81c61f374021", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5bc3e643-6483-4fce-af32-627f8b64da94", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6261), "e3b86eac-e94d-451d-a68a-0b0f6e84a425", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7dc529ac-cc12-4088-a328-23cbc7bc5c20", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6307), "795580e6-f2e7-4401-aab5-9226750ed547", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "183d998b-90d7-4b81-8fe7-ed728ca24e3c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6318), "83d60987-bd95-4c83-b5e9-52e65b8db390", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eb005220-2f48-4bd0-b0cd-bf4245700fc8", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6331), "421e3ebb-acc6-4878-8692-71adc3667bc4", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0dc41a7b-0a6a-4601-b837-7a65d85ee4f5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6343), "e6844ec0-0fb9-429f-9309-c4a0f4cc47fb", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "354f7fac-9266-48d3-a52d-867a6deb6e84", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6355), "f774742a-2efa-412a-9c00-f18f3b65a5a1", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e164bc8d-ba9f-4c2b-9223-7b40adbbcf23", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6368), "71ba498f-b5de-4b36-8023-022290e9d92e", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7040d44-05e4-4b1a-8db5-54b12ccb2da5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6379), "2ae185b4-ca7c-49fa-88e8-0554240200e3", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7e32bd1-37f0-4e37-94c1-2ee6252b857f", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6392), "bae4ae04-bbfd-4582-8a36-32893355634b", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3a33cae5-6fec-45e1-82b3-c9096c4a7cde", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6403), "64a1f286-ee26-4d36-9fff-387a6fc7d3f8", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "da508795-97da-4492-8f5a-d7790e4b2489", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6031), "c41c671f-a15a-4953-abb7-14b68ee1d397", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fddb29d7-703e-4eed-8407-a7cc545fdc80", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6414), "1dacf243-7887-48da-9de4-2b08a82e9865", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b33dec7-94a3-4493-881e-e847643b9aa9", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6046), "b11f30c2-2955-4ac0-8e55-61af41f08538", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "991d0044-4ffc-458a-a9b3-840d77a6ac87", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6081), "6a5b6034-bf19-43a8-b786-a66a0354af95", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "974d8314-6547-4c5e-bb17-a0dd7de817de", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6093), "4750827a-1a88-4ce7-853d-9358a972e69d", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f0082ca-100a-4aa9-a9d6-2207e760eb7c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6106), "f7ae08ab-0116-45d8-abfb-140ffaba760e", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a112aea-7bce-4e9c-9f05-f24ec1ab10d6", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6118), "2263f139-6fa5-48d3-a3c6-e362828c4f98", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d49cfcca-0ff6-499a-b433-473cb3a443f5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6129), "104b15b9-247b-424b-a46c-31ef2fa946f3", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6130) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("4939d3fc-d07a-4157-9827-18c61800cac2"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("e007a090-6ef8-4aa3-a396-7189d26da0f4"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("e550ff20-f02c-4ebc-b232-68845c3894da"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("7ea2e8ac-d687-4108-9069-8cd4ca67f794"), "Industrial", "112233", 12 },
                    { new Guid("cc9ae146-ca12-4cc3-9087-fc986f7ec651"), "Comercial", "654321", 6 },
                    { new Guid("f2849d06-b1f9-4b6f-ba80-d5e398d91e3a"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "de790659-445c-4d61-a654-ab2cf92f3fd1", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5346), "698c5b17-b256-4276-8301-09df7e091e45", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d949187-8fa2-48aa-93e1-57bcb3ba8a5b", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5544), "c2a3798c-2720-44d1-8211-c0d0d6d684f0", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "115da68b-d83b-49a4-911d-cb709628ce77", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5554), "dc09ddcd-d4f9-4141-b046-f388a870fbe5", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "914e8fa1-cc94-46d3-974d-b81b3013720a", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5567), "1f0d5fd9-0e61-466e-bade-29e121285b34", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "090b092b-3286-4824-82cc-63d60f7aea06", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5577), "5418f146-562f-4a39-8010-451a8377810c", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d83e3d3-e3de-40e7-a23d-09a2c9587272", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5588), "b1eb0735-44b6-4ef0-8f38-f97c07734f15", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "902769de-29bc-4528-b83f-124471580d31", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5600), "44d898bc-6557-4f65-8eaf-24094da92b3a", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1edc50b8-a6da-4b66-9090-a202eb65bf99", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5610), "8300ff7e-84d1-41bb-af09-2f6ca134c947", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8eb0a511-20d7-4020-b429-62b443cddd63", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5622), "820f4b12-eb1a-40e1-8696-708be52bdb5f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6c8b544f-c00d-44e1-90d1-c496b971091a", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5633), "d887290d-163b-40a2-8cf1-0eb990adba46", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1b8d951-8d08-4fcd-ac4a-1c26c6f670e4", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5645), "6e6e9750-0f59-4087-a61c-7a191bf90c8f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "faacf1d5-c3c0-4902-bef7-4c3ab08ecc25", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5406), "5f6211e3-93c1-4b2d-b15c-1e88ff758381", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c0ae0dde-d41c-4b1d-a237-3ef4c3756432", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5656), "89244114-4aac-4952-b2ae-420e4b9fca8e", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d91ee018-0c4b-4fae-9f9e-6c8508accc07", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5688), "d684ee67-6201-4287-a481-f3e2eb6c759c", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "578aab59-76e0-4d75-9c40-35195e1dfc79", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5698), "150f482e-0559-48d0-ae2d-4c53ab839104", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f10441e-2c08-45df-9129-a3a5978038ca", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5710), "c47de0ff-be6a-47ab-a303-0abd1c44107b", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9e8c353-6c8b-48b9-85da-28519995f55b", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5721), "f5b1da51-91c5-475e-a7bd-988da0b39e9e", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b65602f3-a6da-4f25-be64-8f37cfd8dd51", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5733), "93328de5-e60a-41d3-9b7c-b42e235e8bde", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "017c8e16-3cd6-4939-b30e-7b4066c6d3fe", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5743), "20d11ca3-50db-45dd-a674-eb89f895532f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f9c93db8-2b95-431b-b682-c01dff47cf2d", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5754), "6eec3c4b-ab4a-4dfe-bada-0bb6412027b7", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d8818584-e34d-4a89-b32d-862cfac1a468", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5766), "a227c0b2-889d-4fab-9701-996dc199a11c", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b73d88e3-1d11-47f0-8a3a-06c1af2c9ba9", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5777), "4cf7270c-3dcc-4fef-9a70-ebbfabbad090", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "559de549-7675-4cfd-a90a-4650fba9f926", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5418), "156605c6-fecf-4062-98f6-3ea2aec98d0e", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7e719d0f-7897-4201-b4fd-28f5c80ae556", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5788), "7a7f1d95-7c02-48ad-a445-827cdb0f3b09", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e319b75-d7c9-41c1-a94c-837715431b1f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5438), "6f8a5014-a791-4fc1-b971-9fdf7edd870d", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5452d878-6513-4731-95ff-83a29d2d74aa", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5485), "5fd654ba-87fb-4cb5-866e-c1cf96f067f8", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "42ec6cfc-9979-47e0-b4af-bf6873f7ef99", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5496), "ab5e974b-59bd-443b-b38c-dfecbd2c325f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "04c8d42d-d450-477a-be73-55536a1f4618", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5509), "63404465-b1dc-4c54-a1e4-77ab7da2fff3", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "985426f1-fc03-403c-9f7a-83efe09a8780", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5520), "88d8dbe8-99b9-4f6d-82a4-4f0f3302cab9", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f42ba0ce-e5d7-4353-9672-506b6a7b22ec", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5533), "79701a74-3c0b-47b2-9cdd-ecc2470871f0", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5533) });
        }
    }
}
