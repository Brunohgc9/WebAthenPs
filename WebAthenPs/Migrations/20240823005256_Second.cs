using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientDescription",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90f23a55-9f0c-4115-b6a9-5fdeed99fe84", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9134), "a861eeee-1d65-4bba-b4c3-f4d81f36a188", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d88f4d26-d938-4dd9-a8f1-34c4177d9a22", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9296), "71f5e208-1632-4291-b1a6-8168849d5322", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e46b5e55-aaff-4ebc-afb6-1b005ed987ad", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9362), "b4befb7e-1999-40af-9b80-f352cbf41a87", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3cb17132-e800-406b-92a5-40e85051bd7f", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9374), "a5a4f624-6080-437f-b4c6-dc4471d8cf14", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "10a253d9-1e93-4c9f-b257-be39733c9b03", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9385), "4deb2d22-03e7-4931-97af-f4d3f067f8b8", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "928563a2-f238-4c82-92ee-7907d66c7248", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9397), "25a23352-51f6-4c1f-a182-b8b7e7f1b3ca", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7ef628f4-ae9c-4b44-8603-7d741bd43f02", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9408), "8be5a952-eec6-4b75-b091-5b61140f43be", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ab844988-d1b7-457c-868f-d4fcb1adfc1f", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9418), "c1ce66f2-568b-4119-94f0-3443ab7d4ff4", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02701f69-2c68-4eb3-ac33-1f5fa76a47f5", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9430), "b48ef095-cf59-4fed-80ba-cad2ca8092a1", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d11c2e4-0162-4f90-ad20-7068cb43074d", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9441), "bee7e55d-73e5-45d7-8612-39975cd6dff7", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2277a919-9b5f-4e8b-86e6-41e3743bbb3a", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9453), "6a0b1f98-6824-4a4a-a803-e4e1fa26c08f", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44fd11c8-0641-402c-9ebd-fb32d066756b", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9195), "ef2dbc3a-d0d5-4892-8d28-90fd71b3da92", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "872f6019-34eb-4ec4-8fd4-5715af882c25", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9465), "10a4ae28-9e20-49a5-8c57-4bb2b91b37fb", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "46d9d1cf-7144-48b1-a593-529d61c30c91", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9475), "1b1d651d-05c4-405c-ad35-bb2695c38b42", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "da3d6844-a134-4811-a9a3-771e4f134750", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9488), "2c25a103-1a21-4f21-aa3c-894979440735", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1541d05c-5606-4eed-8098-584b3c8da931", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9498), "c949148c-dfc5-4ac1-bfaf-1198910b1309", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "214e95a7-7458-41ac-b8d5-fc63d21d2db7", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9510), "a91b0f0b-40b5-43f8-aaf2-d97abc25ea85", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8b1c5489-953b-4fe2-8868-5d847cce017d", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9522), "1ca42b96-c632-4988-9315-3b19f4138220", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4a927b0a-82a8-46c4-9ffe-20d9355127e1", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9532), "b91c5662-e334-468d-b6c8-aa3ba496289d", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92e930f3-526a-4a20-80df-97272699a46f", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9567), "205bb377-ee49-45cf-94d7-19966e58a5a2", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "58b21ac9-9c65-4f2b-b5a9-78c3f1750a49", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9577), "b03be2cd-b217-462c-bdf9-d252e6a24bf6", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cef25056-577d-4123-99a7-8774194c8110", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9588), "969e3f54-a5a2-4955-b3f3-6e84859eead3", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "195779fb-3e9c-4a85-af4c-423e1ced9336", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9216), "8309328c-61d7-4f1b-b3ae-ba2096bf16d7", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7b9798bf-fe82-4247-bcd7-972732b1389a", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9600), "de2b9fa7-2d74-411c-93de-119e75dc033a", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bd216e7c-0974-494b-9bdb-567b1fc06fc9", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9227), "c84963de-98a4-4e18-ae56-da69b94b06fa", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d25484ea-28e2-41b9-b27c-5b02138aa018", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9238), "205f9cf0-c344-4390-a030-66c86ca7a7da", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7bef999-0d63-4e4d-b201-68da407db51a", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9252), "f18220c2-c53e-4fa0-a4ff-9be17a052b34", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ee7067d0-4c4c-473f-9c0f-fae7c3027df7", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9262), "c478536c-d35c-499e-8f2c-7ef192c57560", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d79904a8-a4e2-43e1-8266-f58ac542a1ea", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9273), "8db642f6-4c01-43fc-9fb9-3a61f3159e8c", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5c7c63d9-d825-4119-b9bf-ac73237c7463", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9285), "6f4cc16f-62c4-4247-b2a6-9e71b6312f4d", new DateTime(2024, 8, 23, 0, 52, 56, 72, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 9,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 10,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 11,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 12,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 13,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 14,
                column: "ClientDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 15,
                column: "ClientDescription",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientDescription",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fcda258d-26c7-43bd-9c63-ad100a7d7558", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3788), "d42e8cbe-1a32-4765-b81a-94ee794a58ca", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eff2455b-94ca-4f2f-9b82-e2d8feb2e87d", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3988), "451ccd31-0eb2-49e0-a849-3789b25ab469", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33116b12-789b-4497-bb2a-517e360ffcd2", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4002), "01c06d94-71f8-4a76-b24f-15cd14a46b3e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e7d46dac-d144-4dc4-a23a-2e1708f37dd3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4015), "4db87ec0-16a0-4d05-a1a0-e916b789916e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "290ef670-a72f-4483-9d90-8ba72d941ee3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4030), "70297c42-4806-4736-87e7-90c0cba9a59b", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20cb1cdf-5dbb-4e17-af32-7f9a406884f5", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4043), "2b9891cf-a09c-4b09-a6cc-70308d92a9df", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f0bc900e-9139-4b63-bf2c-a28dd21974fc", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4056), "5309f291-a5e5-4487-a940-58291d85d248", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4aa0ba65-7a88-427b-a469-1d5635c7269c", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4071), "6561e1ed-26f4-432a-9fec-87fd4900eba3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "12206bd9-a92d-4709-abef-7f93c6cf1508", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4110), "8b604f9a-3f26-4a41-8075-ff67cf66724a", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5069b5a0-90e5-44dd-b672-ff02b6a0ccce", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4124), "01d06ccf-3265-4d2f-97d1-2dcd62091a11", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "49e4357c-e98d-4c95-8e83-4bdc391631e4", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4139), "d622aa39-c523-47af-9308-159fcf7fdc12", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "234d754e-d379-446d-b995-d12bd60bfa6c", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3874), "76db39d5-19ff-41f2-873d-d38a94cefba4", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cda0f4b7-a808-49bb-9abd-e7b9ecc86dec", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4150), "4c7af87f-e430-407e-950f-cf44b094d6d2", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e5dc66e-a605-4dc3-bf89-a3c13086c6c5", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4162), "5bf24aef-e28e-4b59-9601-f472c7831540", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ef796ac-eb67-4800-8138-00f98f71488e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4173), "f1dc65ad-843a-450e-80b1-953e3f9de8fa", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5aaf5e21-5765-40f9-837b-6afccec1a733", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4184), "7181f68d-977f-4b79-bf18-352098e2c97d", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dfd82097-e1e4-4cc8-9efe-0d64e6663e08", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4196), "f3997ba6-1e81-4997-8049-986187a5ad96", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d64bc6d-ec53-4dd1-a563-337120138d82", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4206), "24e5d69b-1d7b-45f0-851f-610ec7087b08", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d884b51-996c-441f-b862-365889811cb8", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4218), "396c0220-af25-4f9f-a11a-8424c7aa4e17", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "beae7b21-3d35-4003-a976-f356b5a0d6f3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4230), "a61a102e-3dc4-42ab-8e23-33f8ec2c9e09", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9ea26f46-d7de-43d4-9dff-bedbfbb2e18e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4241), "c3e7cbf9-68e9-4cc6-92b1-16810127d3f7", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e69dae3d-cd34-4103-8ce2-61bb495c6c88", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4253), "ab978af4-860d-4910-af92-db322107e2ef", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "de26146a-760d-4e99-83a4-e595fbac0140", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3889), "372f8ad0-27c5-40b4-b49d-b0c2e27d9a00", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "53a8368e-3603-48d3-9414-8e0f1d33c7e4", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4264), "fc1ab42a-ace7-4467-b065-842038ebae1c", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "97fb2734-9133-4737-ada5-f4927ad2883e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3902), "310b14ab-dfa6-4615-bd63-5eba044dd77d", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54294449-57b8-4d31-a251-5c135ed83352", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3918), "a76c6b6d-05c0-480e-9d21-25ad17718604", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b0c5d792-34f4-4aa8-acd2-da54c40aa816", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3932), "47abe447-3cf6-4b68-9788-7a0683360879", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "caa1b828-f98b-4b9e-b11f-e03e21b404b0", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3945), "57d421eb-2efd-474c-8d1b-04bd251d4259", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8ad603ee-5be9-4f1c-bbd3-bd900719be18", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3960), "a0f6a7dd-f15e-4c0b-b76f-bf96d2f6b92b", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f863446a-d085-411b-ba01-a240d59cf9c9", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3973), "189323b2-c344-4244-a70d-346d3b95aa04", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3974) });
        }
    }
}
