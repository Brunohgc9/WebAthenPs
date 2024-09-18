using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Comments2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bd15e3f-3e2e-4879-8507-3a27015cfdeb", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7183), "8958f1fe-e0ad-40ee-b7a3-d19e0da55d9e", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5131304d-be0e-40a4-9238-dce22f71db30", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7422), "b0f0c131-2b03-4317-8fd0-f221ed409e03", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fec3b8f-3fd8-410c-bece-b1f9630dddf8", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7465), "4197ffb7-5350-489f-b724-d99283a1083f", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e3f60fbf-8690-4df7-972b-830445cd43d3", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7479), "12eb6315-6af1-432d-bae2-79e987f0ef33", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bd9dc1ef-f74d-4047-994b-c09b58650b56", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7490), "43e4a788-0d26-4a23-85b4-6d3d1f980bf8", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "336ab0e9-e141-4bf8-a8f1-115b726e5aae", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7502), "d6684244-a4b3-4540-879f-f4b6f4f5e71b", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "63ee849f-c1eb-4183-965a-1ebaa1398b7f", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7515), "cc0019b1-ba23-4ce2-9ca3-058e4e7648ab", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9001603-a98a-48dc-98b3-b55a0a0b0039", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7536), "12a5aaea-3506-4b6a-9926-a6456ed1afa0", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fdbf7084-69a8-426c-ad62-ee7b36819ca8", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7548), "12b7182a-d9a7-40ab-b6a7-29f4e027a2b5", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "318ba312-4abc-4957-9c87-c8ed879b93bc", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7561), "2fbc5c54-faa7-4df1-a410-427c60ff26c7", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9bd66e89-f4cc-4965-ab05-839d2c09344e", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7572), "7cc70974-1386-4627-b18c-de0994b84e07", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2c6f307c-c473-4b58-87d5-1b67b61a2826", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7291), "afa5d95d-12ac-4b1d-8e72-6371bda95ce2", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e32d5ff9-a7fc-444d-9843-4d3de6675003", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7585), "98982cf8-87d8-4df8-8326-e93ec6f347d6", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4ede6e3f-050d-4617-ba3a-f1ac52a0cbbd", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7596), "4b088d37-2d7a-4592-89c3-7751324aecab", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b7533c87-e71f-4156-9e1b-23bfb98b6a0e", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7609), "137062a4-dfad-47ca-ac96-c06e02903658", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "99735b4b-038d-484a-84ed-b6eae74cb28c", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7621), "c7979a63-b509-4149-bcab-db910c63a989", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "51147a86-69de-4287-a43c-09c32daca7e5", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7657), "9efb1496-318f-47d5-8ee8-fdefbea93e31", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "912d678e-70f7-4a19-a139-be3f6ca11695", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7670), "4aa41bd5-eb0d-4630-bba1-756fd46e7779", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "55e9a8ee-bc59-4718-b03b-2e33d43c4f7a", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7685), "ab337a4d-8d7a-4251-bb6c-ef285fa493a7", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92e6a349-8803-41bc-a749-82978e1bd763", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7696), "4ae670a2-aef4-4bc1-be6e-cc09e549e141", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88a7a2e0-fcfe-4a0e-bbf8-316230ab1178", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7709), "e933c376-fd5e-4eb1-9881-0d850ac05fe6", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b456de0-11e7-4f71-8930-31abcab50285", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7721), "4b909398-3102-4034-9f0d-48015de89782", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77dbc968-c89a-4548-8488-60d76d32e554", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7304), "666b6680-e006-433b-945a-5c1024152e1f", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8c443d73-6116-4bf3-8b84-01285482020d", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7732), "05107948-19f7-4b00-81ab-bd9bfa477dec", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d039b71-7e24-4ea8-9575-682f1f55457d", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7317), "9cb9de33-3cdd-4e7b-ac5c-ea9dedde3138", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ac773fe-22ce-4883-a3f8-0a2e473f3b38", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7329), "f351e544-225a-4860-b82e-f6c4be082768", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "853c6033-c99b-44c5-8cb6-affbde748f05", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7349), "55e0e647-5f7e-4930-8cf5-275c75d37ce8", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8b4a9376-98f5-4de1-b102-05b37763532e", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7384), "e257d05d-327a-447f-a9f9-7e5eb8bdf7a6", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4a12db8c-f8f7-4d35-8d11-02a2f45aa728", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7395), "5c7f60b8-dfed-4542-b178-9ebf767f5d78", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ef9bd6c-1666-4dce-8a98-7b1f7d442add", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7408), "2ee8c6b4-bd5d-4eb3-94dd-e3b40c55ca4d", new DateTime(2024, 9, 18, 20, 0, 55, 487, DateTimeKind.Utc).AddTicks(7408) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Comments");

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
        }
    }
}
