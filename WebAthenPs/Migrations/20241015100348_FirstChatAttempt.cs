using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstChatAttempt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ChatId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserChat",
                columns: table => new
                {
                    ChatsChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserChat", x => new { x.ChatsChatId, x.ParticipantsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserChat_AspNetUsers_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserChat_Chat_ChatsChatId",
                        column: x => x.ChatsChatId,
                        principalTable: "Chat",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eb83dd03-5900-4a67-b2b3-b8ab2be2c96d", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2192), "a37c1125-8c5b-4d4e-9049-ffe216c0d010", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ebed7ebd-ea0a-4b1c-99dd-a9a148ea6514", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2434), "ba12d1e7-5677-4a7b-929f-09562b88b8df", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "53dbdb80-8d9f-4515-b418-c60055291663", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2474), "671ad6eb-c462-483e-bbeb-7a695d6c3a92", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6a829d6-9cd3-4881-80fe-5a4f954d4f98", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2489), "0c37d914-0735-4c9f-955b-bd9dc2b02aa2", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd5106be-68f7-4874-acfb-d3fe89a5a048", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2526), "02dc8b9a-b752-4cdb-877c-78406c892ee8", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bff0f3eb-ad51-4ffc-bfaa-0c36b3753cfe", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2538), "970df758-5d89-4d48-b907-ec87513d50fe", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e21eb2a9-fed4-489d-ba87-6f26991a6297", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2552), "be119bfc-b8f4-421c-aff7-5072176b6fb7", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9cd978bc-ffe9-46ae-83db-71a94868387b", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2574), "cf4f3a89-a5c0-4413-91b9-3ac3cc9af6c2", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a057e5f6-0e97-4221-bf89-7adef9f288f6", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2586), "bf79e31b-a644-443e-bf20-f8bb3fbfd3f4", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20625b6a-7c98-4383-bbae-afed6830d2bc", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2599), "1e57422e-5e55-418c-a53d-6a6fa659cb01", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce049314-2a01-4200-a105-dca18af01498", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2612), "cad4a5f6-4081-4aa7-96f3-5a63793af5de", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8274c46c-9ca5-43bd-aa66-29167487bef9", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2319), "57bfa230-17b5-426a-8eeb-bcffd332796c", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1526591-116d-45e2-a772-ab2969e44a1e", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2625), "d8845907-b113-4aa7-b9f4-23e11f7e152c", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "98e649dc-8fdd-44f1-8ef1-34475a0c1b9e", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2637), "d1f04e00-7ed4-4634-ac9f-1cec647d6d24", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dac3c7cb-55c7-4740-8ff5-0d1301097529", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2649), "7d13667c-86a3-4fbc-856b-b4200e20c0d0", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4adff834-711b-48f0-9c4f-bbfadff7ea88", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2662), "37227cdc-a0fb-4490-a576-944dccfbea5a", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "56566ae8-e1ee-4c81-a83a-1f3850afaa35", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2674), "e434192f-530e-4be5-9ac0-bb10232aec51", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c4cc8215-6cb8-4866-89c6-d6ca467ee35a", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2685), "e5423ede-ef98-4b0c-824e-c7b49d7fff07", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "89dc864d-0293-4ae2-a0bd-67fbf2d9de8f", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2698), "f80dcdfd-bd24-4d8f-ad64-acbc6148b47f", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "df8d2be4-feb9-4103-a285-4cf2cb2bf345", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2710), "976cab0f-0021-48c2-8212-673cdb6d5923", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f0cea50b-54a6-4bee-abf9-a49b5c8a8e4b", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2723), "e69691ca-3073-4c58-9b95-a30b84daaeff", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "426f9b08-e9ca-4bcf-83d6-2578e8aef8b9", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2761), "56963388-e1b5-492c-9064-5424d3fd2f20", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "08547b67-0485-4dfa-8aac-33bbf9bb9f37", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2333), "a2072080-e306-4c85-8c3b-f182cbf05003", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6167a449-eb79-4cd4-8478-17430a981fa6", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2775), "84caf4cc-5737-49eb-bb1c-e2099c7635a5", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "45143ed4-5354-4bad-9050-c37019d66743", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2348), "20cf5b2a-38b9-47cf-a181-98464d6cb9ec", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "18a884ca-1e44-40c5-8e0a-23e7075fc3e1", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2360), "fb4fde41-f803-40bd-8e6a-663ebc9b179c", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9fc071ba-fd42-490a-9962-0db227b43f9d", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2378), "2a61ee01-28b9-40ae-b379-6b724a3ad221", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1cb0bebd-b90e-43c2-a644-675ddb066304", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2393), "81432e1d-09e9-4c2f-ac14-a346f1a367ff", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2480ab03-a657-4454-a1c9-d90726531e01", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2407), "baafa4e6-ffea-4f3e-a3d0-d852fa79d584", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f4692f82-23d0-4fef-8b74-c54531d8d2e3", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2420), "47a2e6c4-cc7e-4966-9809-8beb1ef28c9e", new DateTime(2024, 10, 15, 10, 3, 46, 798, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserChat_ParticipantsId",
                table: "ApplicationUserChat",
                column: "ParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserChat");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6cc0024c-a8f4-4cea-9ce6-0ea11c14af68", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(2902), "8a1e5c5f-1378-4903-834b-75d316173ef3", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02467f29-3368-4be7-9139-b7010bf84bd6", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3111), "28d6fb45-ffac-4ff3-a7f0-2f79a9d48a75", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a0b4231-495b-443a-b7c8-3ec774cc2921", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3151), "636eefb2-a83f-4acc-9766-f7cbb6c04148", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05afe187-738b-4287-91f0-cbdaa5bc63b4", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3162), "30415f7b-b66b-4935-a91b-2f455ca5fbc3", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "21c7a6f8-bc7b-4b14-8c64-e4b7676c1826", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3172), "678f0868-d18f-4e43-9766-877992a92fde", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "11a93313-edac-4acf-8a28-814b3017111e", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3182), "4fc95063-9bb3-4b95-a702-36099c50e92c", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f1178bc6-555e-46bb-8193-e5f27660e4e1", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3193), "03749442-9161-4903-87e7-dfb707452f67", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c8ebc17-a1a6-4f40-9425-9aa30a3238b5", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3215), "68217b6f-eef4-4e28-95b0-5060da2c4ab7", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe50cd21-0057-4045-a44e-e23045a2a910", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3255), "ce543016-f53a-41be-8aa1-2aea3cad886d", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f751e5fe-2943-4267-96d4-5a5fa08e9741", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3266), "2470b6c1-f205-4218-9a75-3525511e6575", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bdcdf30c-a099-4ee9-b622-61fc53b29e44", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3276), "2944e41a-3bd9-45ed-b49a-71b46076f05f", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "df1eaacd-b38c-47d4-92a0-fa7f9c2d6b81", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3008), "f37fb0bb-3c80-4777-b210-c39773fe016a", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "18f02e55-8db0-49f6-9fd7-37ebc5ed3483", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3287), "b8fdd3c3-37ca-42f6-888c-70fea87b7c01", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5d06824e-9fa5-4a38-895e-36a1358da49f", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3297), "35edde32-39aa-4bed-a769-fcf76bf2316c", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc4ea53e-b71b-4be7-af19-c01d439a7a5d", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3307), "d914c70f-88d5-446f-b2be-dd86032d67cc", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5b1e3336-b258-4413-845b-113838a97781", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3318), "4f7cdc0a-ca8a-4c91-a4f4-60e1f1ec8ed5", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3f6c84fe-d000-432c-ab5d-36866f7499ed", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3328), "5feda35a-67b5-4cc1-9067-f9c2cb8a23e0", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a40e99d-f36b-46f5-a596-932bcc4f43e2", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3339), "54978d94-2d0e-4cc0-b73a-97a2a6f649ac", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4dd9496a-559d-4e3a-b405-c77241513be2", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3350), "103ed79b-3bf7-416b-92cc-85b3a7cf3302", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b1399397-f047-4870-98df-6f961296c002", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3362), "f8a6e11a-22b9-4d39-a51c-b1a99e8da078", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8c891b49-c51a-4e74-b6de-76b8f5cbbe62", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3374), "65a03854-4e4d-41ea-b4c3-14e1c7cbc0aa", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cb684b7a-1c2c-4741-8210-9dec384fe926", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3386), "bd09ddae-9e6f-49b7-a34e-4694be8cf64b", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1f4945c1-72b5-460d-8dbb-955bf4668a98", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3020), "0d8d8803-0e3a-4b31-bc87-988cd35b2a68", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ba0757b-03ca-4d12-a0bb-eab93e3a236c", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3397), "062af2ed-ce41-4140-95c3-305b07a18d6f", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "58cde251-7db4-444e-b988-9a6eae7b4ae6", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3039), "699b7a36-ad82-4eb5-9591-89903f8928eb", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0ead7769-e9d8-47b5-8baa-4a9db83b285d", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3049), "d005abc6-d93b-4e05-b83e-9d68d5f6c3fe", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f24ccc4-6d04-405d-af18-463d13db26f8", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3067), "da8143e2-fbe8-4f11-b2ad-e10c386903db", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "08c18cff-84d8-4fbe-9847-16ccff66bcb3", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3080), "0c5ec539-2caf-4edf-a1a3-3533357288fb", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a4c61644-ee22-4e9a-9782-782cb3a91a7a", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3090), "24b98775-c544-484d-af8d-6142b46021c1", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2ef782f4-9753-45c3-9cda-f635d0e96c55", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3101), "157aba08-3039-48c7-b3c4-d57a2a0ebcc1", new DateTime(2024, 10, 15, 9, 18, 5, 8, DateTimeKind.Utc).AddTicks(3102) });
        }
    }
}
