using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("7ec0fa7b-4bd5-4b81-b3b2-c30b7a917cc5"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("984a7399-1a79-4499-a397-8810a7b93b15"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("af25f4bb-b553-4d56-8a75-cc819c0aa27a"));

            migrationBuilder.AlterColumn<string>(
                name: "RegistroConselho",
                table: "Architects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("88ab7c1d-00f3-4635-af57-878e58349ebd"), "Comercial", "654321", 6 },
                    { new Guid("f27f329d-8571-4f8a-90ec-d950203f8fa8"), "Industrial", "112233", 11 },
                    { new Guid("faa9a6fa-42e4-46c1-a654-ce1176e99d68"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3a010d00-ba47-4a9e-a0d1-c18edc291202", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(569), "3fdeb60b-7b40-43f8-8ded-cfc74f04858f", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68e3add2-d204-4f68-bd0b-5af3c8d08113", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(735), "8560b735-4494-45c0-865b-da394db9ed9a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d89a7aca-13a1-4c93-8841-3b4540d026e6", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(747), "0f1089ce-a620-4cea-b5c5-13ea49f3f1c9", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1bbd8cd0-1cfd-42d0-b29c-17f0201eb8ec", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(780), "2bec1fc1-44aa-41b1-a181-24b11a42665e", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "60def7d2-b041-4bc8-98e1-03d30b69096a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(792), "972c5493-ff6f-4448-ac72-b15073e9aac2", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ed0b18a0-d61c-4efd-bfb2-9c13a2eb2d3c", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(804), "5b14a4e9-6cd3-4851-9779-dccea35f555f", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3631365f-6c77-4895-9f9d-468be02a6123", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(815), "3712efc1-130d-463f-a9bb-64aae0ef4c43", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bb082d5-97e4-407b-b0d7-fc530eda3f48", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(828), "2e68d62e-1c2b-41c8-b1e6-615f1bfd32d9", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2121f451-c92b-491f-9c90-6f0229b94128", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(838), "f1a3b751-22d1-4d54-9f27-25685aeeb6f8", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "777c8a8b-7a79-44a9-8905-0ee82ced7db6", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(850), "322f6e2f-d0fc-4825-b6a7-68c7844ec36b", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc089b40-f362-481e-9a8f-4252228a59c5", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(862), "1ccac29f-4a44-4b74-b34d-abd6115df34c", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ce94cef-ff9f-47c9-8ead-524e253bc5f1", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(631), "bd01c1d9-e478-4aee-b40b-554f1d35f3a1", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5843948f-745e-4f42-a7b5-061bed373d75", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(873), "45c39558-9eab-4038-9de7-5060ed27dc91", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bfc9c1c8-53f8-4b3a-a244-c5a7c3052759", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(885), "3dda68e4-5a08-4db5-971f-757b31fab156", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2990beee-786b-4be8-a31b-03772024acd7", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(897), "d28ac616-a4f3-4095-9572-3bfcb3d2966c", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b514136d-8245-4e6b-af25-da56e66a5407", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(908), "7f451972-c26b-45b3-b62a-f9554ab2ea50", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "35361860-dd47-4a81-bd3f-bce2df42cacf", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(919), "710cec31-ad78-4cd6-bfce-ffdf910ae020", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4df4d1a1-4ba1-4243-817a-f240884468a7", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(930), "1ae5fb8e-c588-40d6-bf6c-ca1542857577", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "781a7b20-2e31-4b3b-99ce-2f52a1f570e2", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(941), "32a1936e-10bb-4193-8b57-602237419ae1", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb786475-7bdd-47e3-ab08-dd76abd036fa", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(953), "ac89e6c8-5967-48e5-bb69-05151359140a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "27237bb3-a829-407a-964b-3bf2e4598037", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(984), "0ef7fe39-8035-413e-b2cd-ef7f002ea095", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "487688a9-7aa3-4db2-b2bc-07a2dca03f88", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(995), "653341e7-0e48-48a4-adb0-e072336ea76a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "10b2260e-9e24-4880-aa21-59ba5870e0c2", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(652), "f39f1482-64ea-4630-ba50-59c7f1c5affc", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a1c8b5e-95b7-4357-a8ef-44da1af874dd", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(1007), "048b70ef-22a5-4d74-abd1-6b04a74aaa9d", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b9b7d6e7-8640-437a-bf9e-1d0cdeb74dbb", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(663), "127dc31b-0f6d-4cf7-864d-d5bcf1e5f4e5", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "91b203cf-8d4a-41bb-98e2-95d64ad6b79e", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(674), "e00c65c8-7ab9-43b8-97bb-d063f8dab3a0", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "248bc8ab-b2b5-4950-9f7c-fa9df5b1fbba", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(687), "b6eceb83-cff2-4803-8709-537ff2c26ed4", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "acfbbbd6-e4c8-4142-824e-c324a013d6a7", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(697), "c9563428-b6a2-4eaa-8571-3a840ab6d2e8", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ffe4893e-a2d6-4be4-b5e5-badb0e888571", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(714), "d2339e6c-a4bd-4dd3-b2bf-e02536226274", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "56889661-b54d-467f-8f80-607b9ea32883", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(725), "0d9f75f5-0268-49d0-b2d0-0c89f1ac1c25", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(725) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("88ab7c1d-00f3-4635-af57-878e58349ebd"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("f27f329d-8571-4f8a-90ec-d950203f8fa8"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("faa9a6fa-42e4-46c1-a654-ce1176e99d68"));

            migrationBuilder.AlterColumn<string>(
                name: "RegistroConselho",
                table: "Architects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("7ec0fa7b-4bd5-4b81-b3b2-c30b7a917cc5"), "Industrial", "112233", 11 },
                    { new Guid("984a7399-1a79-4499-a397-8810a7b93b15"), "Comercial", "654321", 6 },
                    { new Guid("af25f4bb-b553-4d56-8a75-cc819c0aa27a"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f18dca1d-45a6-4197-8d5a-a98f1a8ba085", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8224), "d218b6b0-4b03-44b5-ad91-5195facdb6fd", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "59938b20-f3ad-47d4-ac64-c11262fd2459", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8390), "9f72942d-5f6b-4b23-a406-f37d8e6c0e6e", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8982af04-e39e-4857-a827-6ece348e3354", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8402), "c5bb0432-7a47-4e43-89d2-1e421201eed2", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "98e808cc-9ca7-42d0-89ee-cb0d98fbc891", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8414), "8b9a1dfa-38e9-48de-b041-02e3724d7bb7", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1342cf4-1e42-4449-85ed-be5a89749f2b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8425), "5f49a593-9620-476f-b1ce-7ff699a23440", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e0a1309e-9cbe-449a-9769-c5e519ea0e84", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8439), "e8278d93-36ae-4fb9-b707-09aef9699651", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9e195fb4-0620-4c66-b0f1-635eb8c298d0", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8450), "1fcaac34-2118-4007-9048-f1189eb20181", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1f235afd-f89b-42b5-9b96-c3a97d23cf9d", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8461), "81d1aa7d-ac07-48ca-b4d4-7d4795e3a7c6", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ac878bf-66d2-47a3-9b73-a0216163a54b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8502), "0251b0d0-b9fa-47ab-9c45-90f6918f9bec", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "657d4c4f-8bcf-4eae-bf5c-53f84c4cea4b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8514), "59018605-dd5a-42bc-bcdc-1f8b5cb61f24", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90b65438-d7eb-4e80-8e2d-7aae3dcd974b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8527), "47a4ecbc-e7f4-4058-b73a-ad23075f7386", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b774980e-e247-4ed5-b292-25dc52a1f864", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8284), "bf2bdaab-a1bc-4b1a-b0d5-1064d2d8fc19", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "61412bbf-18cb-498e-8e0f-37abf1e6b2ac", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8538), "3913ef37-4e43-4aa1-aa8b-5e466a3bfdcb", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "483d786f-7769-467b-94a2-7a26035ba4a0", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8549), "fe06bc59-9f87-4be7-b897-be4ea4b68a61", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b0b02da-c1d7-4571-83a9-a52c74feff6b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8562), "5d0db259-bd71-40f7-867c-4b457a6580b6", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0458d7cb-51a2-4408-9d1b-beae69ab1a6b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8573), "f846e5a9-9f5f-497c-a3c8-6580d40debbf", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "216c73e6-63c6-4d5d-9cd8-24cc6ca88e5a", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8584), "fca8d005-9774-4d5d-ae97-d39313b5b9cd", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "475b5359-5523-4abf-8f88-d364a2206968", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8598), "04e48aea-1148-4f20-ac8c-6280ac7765ef", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e7ae3de0-9b49-406c-abbd-887879bffb86", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8609), "f750efd5-6fa4-4435-a62b-75accd6fe548", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3102ac23-8ce1-4b39-8d87-95b04af84d4d", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8621), "ee5ce540-7ecb-4a3b-b079-76ff784a5973", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6abcd485-02ce-4a78-9d80-0cd255889fbf", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8632), "55dd4027-a15c-4829-ad91-c27002650a9a", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "23432a15-fa89-462c-9792-3141fb278918", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8644), "112b6324-96b3-46ed-aa07-b5d07ecdc971", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2e9291f3-1ad2-465e-8cd7-b730c2d9e787", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8306), "01e50044-7a10-41d4-8258-e4fe1b44c27e", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "739d9ad8-aaa0-47fd-baea-daa32a3fae0b", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8656), "b4c0435d-8789-441e-9838-313ef43b75aa", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "23010fc2-ad5e-4c2e-a7e4-df08252e82db", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8318), "d868a905-3ed7-40e3-a3a2-ca86126fa765", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34f2013f-4c92-475a-a3a3-6dcd61e1d3ab", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8330), "77a859cf-613f-44df-be61-c60270743826", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dcf3839a-9ccc-4ff1-a48d-0bc2a462471e", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8342), "d9b149d5-8c50-4259-839b-97122acbc557", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "50887580-d38c-49f5-8241-3f910b165c62", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8353), "6bfb461f-6e2d-4267-8eab-b74d21e4cd8a", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "545c1f17-b134-44c2-b9ee-235ced138fc9", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8365), "35a973d8-7cf9-4163-911d-c3bb142eeef6", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7979affc-c90a-4f08-ab3e-9d8e6271d107", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8378), "0cb42f88-e2f4-4f5d-8874-823183126494", new DateTime(2024, 9, 4, 21, 24, 9, 996, DateTimeKind.Utc).AddTicks(8378) });
        }
    }
}
