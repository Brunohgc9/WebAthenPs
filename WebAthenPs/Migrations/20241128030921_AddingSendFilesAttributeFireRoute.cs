using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingSendFilesAttributeFireRoute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessageFile_ChatMessages_MessageId",
                table: "ChatMessageFile");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatMessageFile_ChatMessageFileId",
                table: "ChatMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatMessageFile",
                table: "ChatMessageFile");

            migrationBuilder.RenameTable(
                name: "ChatMessageFile",
                newName: "ChatMessageFiles");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessageFile_MessageId",
                table: "ChatMessageFiles",
                newName: "IX_ChatMessageFiles_MessageId");

            migrationBuilder.AddColumn<string>(
                name: "FileRoute",
                table: "ChatMessageFiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatMessageFiles",
                table: "ChatMessageFiles",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dfc81fb8-1a3d-4aba-b7e3-58b843e83434", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1789), "41879017-3f39-4e36-b17d-e7f0290866ba", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75f9cbec-f736-4261-82ee-678d1b367cc2", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2042), "a2db8181-7f6f-4cc6-8353-09e4c4b3f40e", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b8d31d6-ca6b-44e0-a3d7-bdca806b6103", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2086), "306a31bd-8929-454c-ae6a-4ce5c554f806", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2ffc2d2-cb37-4ff1-a741-66a9eb0e72c3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2098), "c1365542-37ca-401d-9e5a-ff46b3776ae6", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d303c530-f324-4fdc-9ab6-29a58825f709", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2111), "211d942c-9af8-45fb-b9fc-f8553dea2d26", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7367c942-b09f-439d-a1f8-c252b9e47969", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2125), "266c7f3c-4685-4b62-adcc-4c23be20a19b", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f280ffe6-0a5b-4fe8-81cc-dd620fbffd36", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2142), "1e455f83-8eba-41d7-94b3-d00f818ec96d", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "87034b00-fc7e-4915-9346-5b83afca74d4", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2162), "774454f3-93cf-4bd3-a142-07d70bd0359d", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "55a40266-117c-4f67-8811-b8bd852042e6", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2174), "e2834924-9216-4208-af90-c6fd1774bfc8", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "40180ad3-ee3a-4ac9-9491-e51112b02c30", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2184), "e667d482-e29b-48cf-a1ac-7aaa3522a5de", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7374c254-6987-4a5b-a9f7-ab0e443f74f5", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2197), "f135a10d-b2f3-44dc-904e-ee061d6fec79", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d2a7fa6f-c952-4838-bbc4-4f0ac02fce33", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1892), "6e74bff9-432a-48ba-b6df-b46d3f2b13f3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb31fbb6-e6c0-4646-9b59-fc0d6c3ad903", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2231), "0c6d987a-3fd6-427a-8550-11000d609f53", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eafdf10e-90fa-48d8-8079-b40a63c08b95", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2242), "9bf59d43-0d96-4360-8275-98250f0e19d0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aac2c689-c59d-467c-a128-d2683f1d3ff7", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2256), "1b180ea9-0bba-48dd-9939-2a9565615fae", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0ab214b9-e729-4279-914a-7192e926725e", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2267), "4070d334-85c3-4ea4-ad34-35bebed730fa", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d39024aa-a55c-45bd-8323-7478667e1450", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2279), "c712a033-7342-4286-8dfa-2f67b6ba4b9c", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2a209a38-7eaf-4860-a9fb-86b5004f36e0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2291), "1c011fd0-ae57-4ab3-a707-e1763b462870", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aea8c860-2430-4aa8-bea9-738b1986ec24", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2303), "450ab7cd-40df-48dd-9bb5-8df0ec410ac8", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb72a960-d360-48ae-8c63-77da04ef74e3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2316), "acae9de4-2bcc-4888-8c9c-841c2a326207", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce36e4b5-16ac-4836-a2f2-6f32bedd10cf", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2327), "af82ba72-d252-4cb6-bf92-9430df650f12", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d0b7b2db-8b53-40ce-b29a-72282a98ed61", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2338), "f777ce37-d582-431e-a1d8-03df3d2fa021", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6e66544-7e44-4553-bd48-c42beec656c8", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1915), "875c8bf6-d4e2-4561-96d8-11fb264beafb", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a858b968-95c6-4944-8730-5d056fabfc60", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2350), "e0317186-7ee9-469b-94a7-8f8acd85d4d3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f349f72-234c-4d30-9e63-3c59978d2706", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1953), "12b0cbda-7486-407f-87b1-9a28f5da1980", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "97532f9d-3f9a-4fc1-99cb-7fe071137431", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1968), "8595a2f3-84f2-4b67-a63d-d9056019a41c", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b35fd091-e221-4715-8c5d-b8f681a9a264", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1995), "a84c134a-f151-4603-aeff-13a8d6b4a3c0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ed693dd-2403-4267-a385-c50f1a10c1d9", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2008), "6bc348db-1d63-4d3d-8257-c9f42d07210e", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4d531aa1-01dc-4650-8e93-010e2977eb2d", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2021), "b79bc398-133a-473f-bd8c-839b192cb4f0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd982f3a-7b43-41cc-b1d3-84834cffc40a", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2031), "db3575b9-1fec-4f00-b5d5-562255b6b424", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessageFiles_ChatMessages_MessageId",
                table: "ChatMessageFiles",
                column: "MessageId",
                principalTable: "ChatMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatMessageFiles_ChatMessageFileId",
                table: "ChatMessages",
                column: "ChatMessageFileId",
                principalTable: "ChatMessageFiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessageFiles_ChatMessages_MessageId",
                table: "ChatMessageFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatMessageFiles_ChatMessageFileId",
                table: "ChatMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatMessageFiles",
                table: "ChatMessageFiles");

            migrationBuilder.DropColumn(
                name: "FileRoute",
                table: "ChatMessageFiles");

            migrationBuilder.RenameTable(
                name: "ChatMessageFiles",
                newName: "ChatMessageFile");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessageFiles_MessageId",
                table: "ChatMessageFile",
                newName: "IX_ChatMessageFile_MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatMessageFile",
                table: "ChatMessageFile",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6de29f5f-f225-4c19-8fd7-2e66210e65d7", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3637), "e87765a0-1299-473c-a992-dfec5ee42902", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2b54ee7c-35f6-4632-beff-da480a6f39ea", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3874), "0bb6b620-f5da-4620-bbfa-9f9f1ccb6b18", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "95f3087b-e2aa-4e64-bae8-0db285723860", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3935), "c6a753c7-5269-457f-8be2-d78beb851634", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ed828182-8525-44f7-bd26-a2b79320eb47", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3948), "c164ff03-b33d-4935-8d31-d9d3adb9dc74", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "04cc5c7a-5158-48c9-95e0-357456ba590a", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3983), "469ee3d3-fe20-426e-b69a-62b7d171e9dc", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "de200936-a7d9-401f-91aa-2c62f211f1c2", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3995), "a1566d1d-769e-4a7c-8fa6-0145c6250944", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "04b567b9-72ce-49f7-a3f8-94672b64d80f", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4012), "ea9e2865-9007-4b8f-8908-bddde0cfc416", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "464ad656-878c-4437-ae3f-179ab0e8da15", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4027), "0bfdb6d9-56ff-44a6-a8a0-96a309af0b91", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8404f00-cadb-4116-bd07-00527e30f1fe", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4038), "19d17e6d-00c5-4258-b246-4b5ae8f0a383", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6b1395e-a997-4b25-b0a5-49144740ecac", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4050), "f93da6d8-6de2-4def-a31d-f1e462acdbd1", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc73c90b-ddbf-4a69-96bf-70c2bbe63af2", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4061), "63f0d2bf-7bde-4f02-8fa4-f0f2de0c1bab", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f578881-05c5-494f-b2d8-2792605920f9", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3770), "7a35c3c6-dedc-42f6-962a-8b72926f2cce", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7087a57-575b-4838-ba8c-51bf89e97121", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4073), "4066db7b-0480-4c86-827d-0686df2fbfef", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b7ff0cdb-2a6d-419a-bb7d-b48d292914c2", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4084), "f1a5a6c7-82c5-4e24-8caf-5f6530393320", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "99d1ef36-ab1c-4b1a-9cc1-dc1f8e14f798", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4095), "e49fbead-2109-4d15-acfa-27e095c48ec6", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f46f6bc-66a0-4264-aa31-c0ae2b719686", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4108), "5252c1d6-f812-4d19-814f-1a394a0a2b1e", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "47ffa3c1-ef30-4ce8-85fd-2cd560d5006d", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4118), "ffd75217-baab-4c75-9c59-eaf6217b5ae9", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "10055ed1-85e0-4895-a446-1d4028bfac52", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4129), "9c53fda5-8826-4287-a4ac-88ff4c19441a", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05d525de-dc76-40de-b752-96ee876dab1f", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4141), "57a16824-a466-4cac-aa44-9ef61dca4787", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "702cc2f6-25a9-48ed-bec6-4c3ed82d5cd1", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4152), "162be4b7-ff87-4681-825a-b085ca22dd45", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3cc5a70a-c304-4518-91d1-c804ab949881", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4187), "6c8a3e57-ec1d-49f7-96a2-2aa1d1d9c9cd", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9b81f6a6-1869-4980-b1e4-cb44b172dc62", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4199), "9a76de5c-6207-4c7e-b819-7fa2a2cb11ee", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d69bf7b-d8e1-417f-a857-e9812b25a423", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3782), "864f5c6b-7b38-4859-b41e-e0c27745ebdd", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "69f871fb-8cdc-4200-898b-dd2cb819a121", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4209), "fd09678c-8ee0-4467-9cc3-87fd3929f12b", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a71682b2-8564-4907-a4a7-f35411d18837", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3796), "a314063c-c5ad-4e9f-b530-d1725abcc9a6", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a8e3d6fe-e150-4b3e-a4b0-2760d17fc1e7", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3809), "b18d4024-0ac4-4371-8485-904bc8e40244", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d97e8c5d-6ec2-45d8-924b-89e73f2ca079", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3826), "776101b2-dc7e-4d82-ab4f-6922ac8839d9", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1894debe-07ac-40c7-a8c0-91f42edc9147", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3838), "ada83f81-e751-4d74-837b-c78f162c98e2", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2642c489-d30e-4689-9aac-19ea383f78b5", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3850), "5478a0db-a1c4-4dfb-bc61-45fe2be9a5cf", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "32a24a38-1878-482d-840b-04938c301bb4", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3861), "aa7dfe6b-4c67-4759-b982-aca0edb09398", new DateTime(2024, 11, 28, 3, 7, 2, 700, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessageFile_ChatMessages_MessageId",
                table: "ChatMessageFile",
                column: "MessageId",
                principalTable: "ChatMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatMessageFile_ChatMessageFileId",
                table: "ChatMessages",
                column: "ChatMessageFileId",
                principalTable: "ChatMessageFile",
                principalColumn: "Id");
        }
    }
}
