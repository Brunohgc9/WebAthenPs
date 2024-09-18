using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LikedByUserIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "414af69e-cd2a-4c51-89a3-d3f32c881c19", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5298), "a0dd2e58-9e95-4b68-a612-804d84398fc3", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e442e40f-a530-4e0f-a582-60d021aff227", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5510), "0ee638a6-12b4-4bf8-8dea-e60d677a0e4e", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b1ed76e1-8276-4307-a8c4-170afe880285", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5547), "e36423f8-0d3f-4d4d-8bbc-18d01e8f64ad", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f8ede0f-c39a-438a-a792-5d205bfa9e36", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5559), "b7bd23e9-0d7c-46a2-8371-f70b1e698807", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f6bb262c-6dc3-4c6e-a81e-11e6181dc73c", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5570), "ae2d0993-3a2b-48a5-9e4d-607002566874", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e641e0f2-2a11-4b70-ba88-ad8917d485c0", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5583), "841f2d04-0660-477b-a421-2d69b2895f5b", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f9c8769-e408-4707-bbac-1c4165b44351", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5595), "391e8c14-9de8-4daf-b6f3-20ef87fd0cb0", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8fc453e4-15e9-45b8-976c-c101e7ff06e9", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5613), "6515d4cb-8108-40f2-bd29-bddb8ec0b71b", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34ad2051-d79c-41fe-8deb-6de0f80a8450", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5626), "f730b240-7712-4e83-b22c-c3227eee3770", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34e74a16-104d-4b46-8ef5-f546034c3e00", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5637), "53dbcca8-d193-4442-99b4-1b4f0f8c2b64", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c80fe72-55bf-45d5-bca4-c20763566d77", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5649), "7fd77817-857f-42e0-89bf-7c09beff372b", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db573cf9-489b-466c-ae60-63f7ad5377f6", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5369), "0cd4e593-9c8e-41bf-8d6a-d2854bc84249", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f1240b0-02fa-4cf5-a7e8-2be1d1fd1428", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5661), "f923b6fb-0f4e-4ace-937d-e4ee6907f99f", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e15ce720-0269-4be7-a2a3-079d6c208d60", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5672), "f8fcbd24-b033-40e7-b1ad-48415d37fd71", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0eea06a4-846a-471d-8dc6-8d2a9df3d2b3", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5685), "4b85b0ab-9c6d-4d28-895c-f3e6ccf01996", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7b749a52-e77b-440b-845c-cf4f3ab7c9c5", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5696), "b131f0ec-76e7-4d60-9339-7799a8a80f09", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8bb4e73d-5630-4f2a-b11f-c252afa42930", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5707), "1aee3f6b-a0dc-4df6-b181-9bb9a853f6ee", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1081e6a7-c232-4b85-9209-e4a16463dd7b", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5719), "bfe9fc14-4015-4ba4-aae4-b36ddca26fb1", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8bdd10d5-1bd8-454f-9f3b-04aba904e2a6", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5752), "4f9ea7cb-32c9-4cbc-88dd-c284516548f1", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6585aeb0-429b-4e65-bb63-2542dce78ab7", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5766), "9ebd0065-c777-42f3-a624-baa315c243a9", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92120b99-6230-44f3-9436-3712525fe12c", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5777), "40d0e84b-f9ea-4b36-946c-828cec819553", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ebf633d0-8806-439a-987c-a7e8fd747825", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5788), "83d68192-2c25-4144-8e88-29f555e67eed", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "16119fcc-21e1-490d-9a29-ffe9dc5e0693", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5391), "192669c6-2d03-4189-9aa5-1a917e6f39c1", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d6983d75-0421-4bd7-a76a-0e1311f8e417", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5801), "6f5d61c4-e850-4ef5-8fdd-f53423381c89", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "27bf218e-0eab-4a47-9d33-5c20b2bbb89e", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5402), "c26db2ea-7465-4de4-bb9b-ada37b5021f2", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "069f3447-669d-4a09-bf70-836ecfaa0fb1", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5414), "9faa14ec-4438-4689-b141-dad13934dc99", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cdda2ca0-83f7-4fdc-9dca-9848e29ff6ba", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5433), "a8aaf16d-3307-44b2-b3bb-e28a00141ede", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "51b012ed-cb23-4138-a2b9-1f0beb1a1119", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5444), "73aa1f8a-ac8c-4651-99db-e8e16b2a738f", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "145ccb67-737b-4fe6-af47-e9a7cea69e5d", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5455), "afc32a79-4178-4bad-9f37-f9df8bf66ef7", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d22ddbb0-5931-43ed-9850-ac8ff8db1c96", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5499), "2f6b8eef-89ea-422e-b917-a655ceffa862", new DateTime(2024, 9, 18, 18, 51, 28, 476, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b0fc5f3f-c97a-4f28-a9e5-a8343c22bb6e", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(444), "3e72e4c1-cd86-40f7-aee1-224d10d2ef32", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "52eb8e47-7d9a-40d6-945a-744a3aa0b900", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(703), "87cca292-ead4-43a1-a341-38cebb3b638a", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e26cb82a-fe79-4fdb-a21a-25677ee81b02", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(758), "c6fea0e0-ae17-4cf6-8ae8-ca31c15bed4a", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "679221e3-5fa0-4d47-bdab-7e8def63c293", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(773), "c1c968d3-1aa1-45c8-8d88-f4deed5391d4", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d838c412-c64f-4111-a0dc-115a7ec7bfa6", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(784), "3084b96a-f8c8-45bc-8220-cde7ff7fe8f2", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ac36d06-9101-47c3-a8de-54d413faed0b", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(796), "ce299a0a-7ee0-41b0-b4cc-467a4a9aa862", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4c74d90d-aa6b-4e94-8bc6-bc9baafddfa7", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(809), "69123bc2-a91b-4a71-9250-049307e031dd", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "760c46de-0994-449a-b6e2-1787580e772b", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(830), "f52e9dd9-78f7-454b-a353-a6847b4192d2", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1b738997-4560-4025-b64a-a4be3a287e45", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(843), "f309f2e3-af6f-46e6-9814-246cdd9ccb1d", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "618fcc2d-544e-4e47-a7c1-94a37a8deb62", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(857), "c336f726-719c-4eca-85d4-2d9a96fd6025", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7ba96ff-13a5-49e9-aa25-d25883fb86ac", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(868), "5dd9305e-de65-4ca4-b8e8-239bd60c3a88", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4e859e9c-9772-4a09-8697-9222deb699c7", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(566), "15765ca1-a379-460d-b375-41d17028d7ed", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b56892ec-8266-4a78-ba77-10ab6dcd7d5f", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(882), "ff3d4e57-d8b5-4fe5-ba7f-910de9f043dc", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e828cd30-4336-4dc9-959b-e9fefaae0a4d", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(893), "6fdce123-d6ff-4b8f-9df4-f6724f9ec3bd", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d584d67a-6d7e-4dc2-9253-da004b9ef5af", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(904), "2d92ec15-fa50-42f9-bb10-539aef478415", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "feb4a3cd-6017-498f-b50a-90e8878b073d", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(917), "914ac921-99f6-4742-8186-f295d6a9bdf7", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aad6f9db-944c-44b9-b925-283ad779b5e0", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(930), "f2b1b225-47d7-476a-baa4-57b06e2a1bd7", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a01c6975-fb43-49d1-83d2-0ecba8087a24", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(942), "d00fc68e-ebf5-4d82-aa81-7cb9632350c8", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71af3ca4-d644-4ee8-b52c-ed32bf55b733", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(954), "0b599b2e-c870-4422-b147-5844fc8d8d71", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "334822f0-1096-4a6e-bcd1-fc2d6b8f9d11", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(989), "1dbe2849-c2c5-4cc3-9c1d-7cada00cb0ed", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "685f84b5-1560-4d89-a684-01209ad8bf04", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(1003), "b1f355a1-793b-4ad8-8208-df4b3132dff0", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8268c7e3-7da2-4e9f-9ddd-5456f9abc4bf", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(1015), "f63c512e-d56d-4dfb-b6e3-59eda6227555", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2d6b661c-dcd1-4107-a22f-be497ee7e94c", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(579), "361e9767-f456-431e-b422-d800c248fe8f", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74f9a53e-7a73-4915-8b39-ede82306192e", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(1029), "b22cc064-d4d1-433f-8293-3b8242b50919", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "166e8c97-926d-4e7f-9dda-0ee23f3b3bcd", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(592), "f77ec45f-02e0-4220-90aa-efec3a74a404", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf93b997-97fa-4825-9dba-20e1ce7913fc", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(604), "4685236d-a3b6-4971-94e7-0a14c61faacd", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7a1a4d46-b049-4a9a-b4a9-df7350772d3f", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(622), "9c452392-c407-4142-98a1-757bec801071", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fef3907a-72dd-4cf4-a704-9d688cd38700", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(637), "b945dd0f-46db-4bcc-9610-b98c328e4e4e", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1206c8e7-5080-45ef-95c7-e319d3051ff4", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(649), "057c8ace-580f-4151-a95f-28221c0e6e1a", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "89d50083-e3a0-4213-96c8-c3e2bff2cf90", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(661), "e99b4504-5ba0-4c26-bb28-b8a477d332c9", new DateTime(2024, 9, 12, 0, 49, 50, 960, DateTimeKind.Utc).AddTicks(662) });
        }
    }
}
