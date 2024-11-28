using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingSendFilesAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChatMessageFileId",
                table: "ChatMessages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChatMessageFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessageFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessageFile_ChatMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "ChatMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ChatMessageFileId",
                table: "ChatMessages",
                column: "ChatMessageFileId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessageFile_MessageId",
                table: "ChatMessageFile",
                column: "MessageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatMessageFile_ChatMessageFileId",
                table: "ChatMessages",
                column: "ChatMessageFileId",
                principalTable: "ChatMessageFile",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatMessageFile_ChatMessageFileId",
                table: "ChatMessages");

            migrationBuilder.DropTable(
                name: "ChatMessageFile");

            migrationBuilder.DropIndex(
                name: "IX_ChatMessages_ChatMessageFileId",
                table: "ChatMessages");

            migrationBuilder.DropColumn(
                name: "ChatMessageFileId",
                table: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8966a9f4-1272-40c2-b6c5-77476f7c8691", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2368), "b8e1c21a-6e47-4561-ac2f-95ff564fe74d", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db578ed4-ebfb-4cfc-a9c7-790a712c041c", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2600), "6280b965-64d9-4324-b088-5ef82736be8b", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c90e09f1-b1d3-41e6-80bf-ec518a274d55", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2650), "6ac5e718-d516-4fa5-bd12-6fae3debcecc", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ddae1dc2-05e1-48d3-99cc-1142d4a862fa", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2665), "412ed02b-5cf7-42c4-88c6-7900fd3ca61e", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf1df665-32a3-43da-9f73-5a405353f45c", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2702), "af3084fa-9352-4a06-a178-3fea68fa8713", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "336b5169-d277-4181-b040-633ee1594cc0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2715), "18f066f0-7a03-4e19-9acb-8215042a93e9", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a73dedcb-f0c4-4434-9d98-2b0a8dad88ec", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2737), "25b4478b-6421-44f2-ac99-fc0980fe67ed", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2846d6db-bb68-40c3-b4f9-7ccab007fa03", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2751), "3558980c-fc41-48d7-ad4c-aadc9318d103", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37a203c0-6fe6-40c1-bd20-34510cc1d8d1", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2764), "18466949-2de4-4970-9554-c8264ca32f24", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b16cc6a4-6de9-4a02-a22d-18ff6cf9ffd5", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2778), "3fa97362-9f3d-4e81-ac88-14d8e351e17f", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c25e4205-63e4-4f5f-89a7-b9df34154fc0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2790), "e8a98e44-20c0-490c-901f-835e882ad410", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b1bf88db-5629-431c-840b-d0fd5157a3ae", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2485), "7889b19e-044f-4d90-bbbd-f5951c2d2c16", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "170322ee-238b-4991-839f-b12e87310d65", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2808), "2229389f-443f-4477-8310-484393154a21", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "be4dddb7-5cf3-4326-b303-b9c40c71cd78", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2825), "4b6b57e3-fb90-4291-b2f9-a33dbd0e0ab9", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "096f0d9f-9fdf-479e-be33-c19d440ceabc", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2837), "a6bbecaf-facd-413d-9e7e-cb8d72b44f76", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "359f5b92-b08b-454b-9513-5aca827d8a05", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2853), "dab69d63-527e-4687-b6f7-323d86cafda5", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b53c979e-fd0d-4d48-93cf-b9e6f5c8c8b8", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2866), "9feaf967-51c9-4682-be1a-fb72b2b9d71b", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33844ca3-d006-40f5-9e0b-ca22869f0f21", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2879), "aa450420-8a6b-43a1-8bc8-b91fcab921e8", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9a93ae24-c302-4acb-8cae-62bdd496eaa5", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2895), "f9cf6420-aec6-4668-933d-e1f167581f98", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e566d047-533d-408e-bc50-2df062b9b473", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2906), "6447d541-23e9-4918-9e4a-d46905f73a3f", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90597e08-4e7e-4f25-be98-545d32e37ca2", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2918), "4b078403-71ee-4fd2-af31-9772bc2ed22a", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b00f01c9-3bb2-45c1-9c57-cb18830f1e51", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2957), "b0130de1-ee59-40be-9ec3-216480f9d432", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d55419a4-772a-4d7e-a173-cceea8077642", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2500), "02c58945-4ca1-4f1e-a95d-216381494f85", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a87d93fa-b1f7-40fc-8aa1-3db3bb4834c0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2970), "0b9f721b-0db6-44b6-82dd-dfeb56da7def", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aef70195-433e-4357-9a84-a71fa9012f5f", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2512), "b000f776-a123-4322-ba1f-031b07c0b68a", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "403b3a75-46ca-467d-9507-958c1a744287", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2526), "5849c49b-78f4-45a8-9f40-c74652dd298b", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "193abdf6-9500-466a-9e74-361195d5b466", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2549), "d1f926ea-8c21-4e76-9151-bf1599ffb7a2", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ec04f433-0ba0-4534-a1fb-ebaefb062501", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2563), "515a1411-f7e1-480b-a382-592f1a2aa8c7", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a57d6bc0-e461-48b9-ba12-3cf3e7014f35", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2575), "296ca05e-dd6b-4fc9-951f-3be460ea2bf9", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e166d0b5-2e50-4449-a2c2-c7c8dac1e6e3", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2586), "b93fac39-9f53-4e23-a0c4-533a634be7e0", new DateTime(2024, 11, 28, 2, 50, 20, 911, DateTimeKind.Utc).AddTicks(2587) });
        }
    }
}
