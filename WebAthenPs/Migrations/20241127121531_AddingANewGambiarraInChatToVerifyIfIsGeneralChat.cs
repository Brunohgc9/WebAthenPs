using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingANewGambiarraInChatToVerifyIfIsGeneralChat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGeneral",
                table: "Chats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1dbedbce-c034-4786-8004-a02d47ccbfcd", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8639), "1f6f9f86-2d5b-4cf1-9d5f-d479f9186f86", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef9029dc-537d-4958-91da-db5c4a11163f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8917), "007e9a9d-82e4-4cf4-bfbd-75ae39b85c7b", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8b93595a-e29f-45ce-aeb8-13652622c1a1", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8958), "088e780f-36e1-4e4f-a6ca-c67e69d97bb7", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a930237c-e525-4130-88ff-788000e9ef17", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8972), "bc3672a4-ac1c-4fba-a474-e75b0368ea37", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8bdbd97-329a-4460-ade4-c167eef291c2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8983), "60833720-55ed-45db-bd80-2d665e2660e3", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c9d495f-2c16-4226-837d-0d329a11251e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8995), "847a6def-95b3-4afa-b4a6-ca88f056ccd5", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b50f43c2-4f9a-4c04-83b1-0416c93b77a1", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9008), "e9bf5721-be89-4614-9a1a-46df3c7f4943", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca1644fd-9650-4b10-9ceb-c10a0be6ff4a", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9030), "acac771e-1110-432a-8e41-b62c40104924", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db2c1a70-707d-4c02-bad8-dcd0ad2adca7", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9041), "e0218aa0-27db-4681-80da-62e1d9025d29", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "139356fa-0e54-409b-bbd8-063ef08bd673", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9054), "48c0d315-64c9-4b81-8862-08f0f915d531", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33027b22-3a22-455d-b1fd-7381d40fa02e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9066), "2bf91a1e-7d2b-4c75-9f25-2b98e8935c76", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "feaa01ce-8c3e-41ef-abf0-2b58c0c14645", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8785), "9a6bc4db-1990-411a-9fb1-01cc99578aaf", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dc957fb6-e77d-4326-87a0-c5b59c1e4c7b", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9079), "cce38415-c231-406f-959a-efaf05e94b58", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7c4bfbe7-a3b0-4fa8-b37d-cf74f2c4c0ef", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9090), "c882c48a-c64a-44a5-8e48-539269c3c6c7", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ddb9a488-17ca-4deb-bf6b-fe253a13cafc", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9101), "65ec57ba-d10c-4dc3-b2a7-22a999ff1611", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a8c7aa8-5ce7-4728-a7a2-f5f6edc4cbb3", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9114), "cb7e4aff-3540-46a9-86be-3ca5627f3af2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6cdae722-5fa7-4b78-b3d2-4d8ca77d3bc2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9126), "b38e1e3a-47c8-44b9-b7b3-708f319f1654", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eefbf515-b045-44e6-8ce6-42c3772e5f5c", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9172), "fc141008-0545-4911-a79a-f78e4b9e17a2", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3816d023-4f7c-4561-a082-9cc66d96dc78", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9186), "9b04ca46-1cde-434d-85e4-f912a93239bb", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71e4db90-b6a9-4225-bb11-e49c74249a0f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9199), "747f4f48-32bc-4ade-93ac-fe1668120928", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f0f0d72-ed8a-46be-bd83-8ddb04ad893f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9211), "e869606d-3487-4d36-8401-fabe8aba75ad", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34267f99-f2f1-4840-96b0-039f6fc61ba9", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9223), "0a1ab684-5fdc-418c-86bf-20b61613c4e1", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce1f60d3-bea6-4c8e-8045-b1c79b2f9666", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8800), "576b1fed-7a12-4de9-b9ee-ca0e470dbdb3", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf8ba6a7-d683-40d8-83ce-4c664735f039", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9235), "ae890c71-3791-42be-8ca1-245c2dda4699", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4644c349-3e19-4247-80f1-12b26568c183", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8814), "be79edbd-3cec-499c-ae55-dd597660f893", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "58344836-a834-48b3-a86b-0c7b67e01070", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8826), "5499cb51-a4c0-4b3b-bbe1-4076ca9c0e6f", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "afbab071-fc1c-460f-b815-d1dd35fb05a9", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8845), "0e2cedef-d667-4c54-a66f-b6f5a7cdc92e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a3cc57f8-8e6f-4b85-a2b7-41942e3d13b8", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8859), "9b7fcdfd-965a-4e70-8f85-6bd572558d3e", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f93d92a-14a6-400f-9e87-a4b600e75137", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8870), "9b5e5616-ff81-4116-ae16-f530aac755bb", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "17c82121-7c8d-4427-a491-4359ee02f029", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8904), "5ab0520f-a696-4e64-be3a-77534211cc10", new DateTime(2024, 11, 27, 12, 15, 30, 68, DateTimeKind.Utc).AddTicks(8904) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGeneral",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e018f2f-ccf1-4878-a9a6-8c10b85a1e5a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2632), "756c4f05-a7f2-4d79-87af-4684c002aad6", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0610399a-14d5-47d6-81dc-3f5177721b07", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2880), "bb2a5ae8-c2ac-42db-a01c-efe0c6db423c", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a8b7042-bbd8-477c-93ff-751fa9a2196c", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2929), "71fe8316-fee3-4c13-a4c5-a059ae01f165", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76bc4815-0891-44aa-940b-f7347729bb57", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2941), "a1890ba3-670d-4e03-bd58-7c057924f8a6", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "104e69ba-fa20-456b-8db2-677e4bd59578", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2952), "ddba3f56-e44b-4fa1-be42-0c238d99e6a5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "672b20e8-1a48-4979-a000-dba98a79895b", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2964), "0073c965-6e29-4ca8-8657-69a490b3fb38", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "950c16e6-99b3-429e-9b6b-f26163972416", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2976), "890c17d0-669d-4b77-8001-3d05b2d2646e", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "350569fc-0e61-42d5-bb5b-67878c82d42f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3120), "401d41aa-a771-4109-b435-8ccedf0fae57", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37cd9ef7-9989-4dcc-9ab0-8eb747019a59", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3132), "be3cabcf-be03-4411-820b-6f4186fba2ea", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "556715d5-6c53-4b37-9280-139289b55295", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3143), "36a16503-7b13-4210-8eda-a9266a033826", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d972ad6e-1f8d-4924-8044-350b9d9a54b0", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3156), "bb5315e8-47f9-4def-9e9b-2a612f663e6d", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d0297304-8e8c-40d0-8e0d-266dde8290f0", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2739), "17267159-37ad-422c-b28b-4c5abbd390b9", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c5fdb524-4d2e-4b27-8a2a-ed14ba878e91", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3169), "cc3790cc-1fd1-4dd5-8402-82ffbcbbd569", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e05e1149-3b8e-4d96-a0a5-25e2175060c8", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3180), "2d807d0c-f068-4ea1-a7c7-1dbc15166517", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a528189-7d81-46ce-a5ee-c055c27d4b23", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3193), "82bbb07f-6f91-4262-b509-d2ac621b7d5f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ab224a95-0510-4cbc-bb7a-776d974c878d", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3204), "54e1772f-f672-4793-a475-91a3c8745242", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c699287c-8405-4a4e-aaa8-593aad669725", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3243), "05ecde36-f9cb-412e-a292-2b1cd4f0fdf5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a19d094d-bb96-4a5d-8fdc-7f33cc6dd8c4", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3256), "725479e5-5ab5-488b-84f9-488f922362e5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7cabc2c-c814-493c-b09a-ebf1d3fcf319", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3267), "363eae56-d97b-4af0-a770-743a0ee76f5f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc7ed453-d960-4b5a-ad1d-a9b55398b74a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3280), "cd02cdb7-1a98-4379-a59c-233f4841f1f6", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d05816c1-a7de-4445-adac-37fe1bef87dd", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3292), "2e0095ec-73a0-4f2b-baf9-8eed64675e39", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a4b31da-cec2-4ff6-9ea1-a1c2e30bb26d", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3304), "e7d6c669-9a12-4b04-9dc2-3f3b63a3f2cc", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6dd45197-2aa7-4228-af79-0078a8d7f729", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2762), "3b33a587-8d56-46f4-873e-d3a112c60ad5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dd2f1620-b7b1-484a-bd12-489f3d62e764", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3317), "6097eed5-c80d-46bc-8575-ccae6d1defab", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "157e07e6-1116-43b2-abf0-78bd9581ef21", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2775), "fc166d31-c021-4f90-89bd-3a61c83bd499", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9692a9b2-560b-4876-b5c6-90ac1236a3c1", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2786), "23c4a91f-f45a-43de-9fe3-423914734670", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a919f27d-c750-4a8a-bb16-2b49715d7ee8", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2805), "490309f5-9d29-47c4-bb78-14c6f4b99368", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44e266b8-ed29-4471-9d8c-8cbdea44737a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2817), "89088bc8-eb55-4997-bfab-acafe2f32b3f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db092d26-40e1-471a-ac1a-dac1789d0df0", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2858), "d515f9dc-53b6-462a-8ed0-325feabb19d2", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4656fcb2-f56e-426d-b980-1100b7e0652e", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2868), "d3bb1f74-6c81-453d-af2c-083a9ddac40a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2869) });
        }
    }
}
