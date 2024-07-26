using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Nineth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f9a88e4f-23de-4804-aea8-5928fe14812f", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2074), "11371323-f8ca-435c-b6c0-156f68a90866", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db6d265a-6019-4f75-9429-ce3dd3332ae4", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2283), "d1e4fb4f-c160-4f1d-a6d7-392de4220c32", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ba9b92d-6dc6-451a-b894-81e93b600de0", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2294), "fa783b87-878e-4029-809a-21b84b976ccc", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6983d965-30c2-4302-b5c4-248e010861a0", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2306), "f0fc82f0-2663-44ed-90d3-221511aa3dc7", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "80a94019-acd3-4e56-8b23-cb5154521802", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2318), "0495292b-2eb6-4cf0-ad2a-4f724737ca6c", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bab5ac66-bbd3-4e06-bd56-053795e1f471", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2328), "92841570-58a4-4f25-899c-8c3d27b770e6", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4962b48d-2da9-4d03-aa7c-b00b2b81e530", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2339), "41e93431-9b48-498b-8da6-0a95bc3155ed", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "308b149e-1036-411b-b4d4-1a5f9f1e98b1", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2148), "7bc85f33-deae-4ee5-af69-bb816ed8b6b3", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "67e5159c-4d78-4013-a82c-780d754edd60", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2202), "9ede08d8-05a6-43d2-a1c0-9aaceebafb8e", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7cda8fc4-d97c-4129-a735-1bc465c1e328", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2213), "8a95cad1-63c4-49a0-94e0-d70d1bd37bd7", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "93236e25-c5f4-4d32-84c0-1f7d93789759", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2225), "1316d954-33f3-46f9-a6fe-cb6fda4872c3", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d54a33ed-ab75-4425-bb4d-cca9ef6dcae6", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2236), "c9fb3681-94e7-40be-b66f-a075e0b86127", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "295b329d-b98e-4958-8d5a-1572734c0a6f", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2248), "449c8453-a944-4093-9b70-35ba56ff825b", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2c22133a-74a4-4704-833b-a21d72ae0ef9", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2260), "3995df9c-f15e-4a24-b8e2-bff98b0c20ed", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9ce487a5-5ccd-45e0-9123-55f5cbe6a13f", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2271), "d3010f3a-1565-489f-ac84-852a7e199a04", new DateTime(2024, 7, 26, 3, 47, 18, 580, DateTimeKind.Utc).AddTicks(2272) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "32968171-07a0-419a-ba75-e0b03110d8de", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(89), "c4711d32-6dd6-43c2-98dd-8b6d1abd26ac", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aa727988-dfa2-480b-a696-311f4c794862", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(264), "d5735d4f-85b8-4db8-994a-c28b270366a9", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e69e086d-be55-4b61-bee8-eddc744bd6e1", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(306), "a6d1cba8-2695-41c4-812b-16126ced6998", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7c733e50-41e1-4787-b8f2-fa26f202964d", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(320), "a131719c-5016-4fe0-9dfe-b31f2a141925", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20d51b05-2b8a-486a-a0a0-9def270c70f7", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(332), "2c1e28ba-cec4-43ed-9887-55ae0089dcee", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3a30336e-0645-4ec3-8f66-f10be186e97f", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(345), "a7315ae8-2603-47bb-897e-6cba3623cbef", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8ace8702-681c-43b2-ab91-0259ff988301", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(357), "640cb9d4-568a-4aed-9f72-787eb8a69a5d", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a493dd13-7bbd-4d44-9455-527406eb9183", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(164), "70c91246-1ccb-4e5e-8381-49dc0d0d0cd6", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b5d63be7-b62b-4e24-812a-49bbb57a7a8b", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(177), "98b55e3c-3766-4d39-b70b-15f97c9ffdb1", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d565aa84-9dd2-4efd-b3ee-ce120785bf66", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(191), "24387f7c-0e77-49a6-b107-41e0e60423fe", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bfb2805-43b4-4a75-8b7c-1d3de36782bc", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(203), "33d14637-2d1e-437c-b007-278cef54ecfa", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "85d5b8e0-b74e-4402-91e8-22889e505414", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(215), "c6a8638f-89f5-425b-8ad5-e7aaaf18c49b", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cfc5cd80-98b9-44e5-beda-4f0078384440", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(228), "7279e36f-649e-45d6-b888-8f5e806ef948", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c7b3cba5-9a23-49c2-a0a3-be81e8e91cc9", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(239), "0d833b40-41a4-430a-beb5-12f542c217e6", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "31541fb9-a368-455d-b913-eff08639bfbf", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(251), "4137f834-c88d-4ff8-93b5-dbb4e5cfd479", new DateTime(2024, 7, 26, 3, 31, 22, 258, DateTimeKind.Utc).AddTicks(251) });
        }
    }
}
