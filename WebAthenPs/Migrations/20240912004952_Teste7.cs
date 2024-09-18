using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Teste7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Architects_GenericProfessionals_genericId",
                table: "Architects");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchId",
                table: "GenericProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_GenericProfessionals_ArchId",
                table: "GenericProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_Architects_genericId",
                table: "Architects");

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

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ArchId",
                table: "GenericProfessionals",
                column: "ArchId",
                unique: true,
                filter: "[ArchId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchId",
                table: "GenericProfessionals",
                column: "ArchId",
                principalTable: "Architects",
                principalColumn: "ArchId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchId",
                table: "GenericProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_GenericProfessionals_ArchId",
                table: "GenericProfessionals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f1e3f541-e14c-42b8-a71d-7d4ce56df851", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1436), "ed73f26f-7373-41ad-a247-bc2844d92661", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd4de368-805d-4ac8-bcfa-7285c00119e9", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1783), "afb402e8-9910-4c60-9ab0-1007afd8ad40", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc0fc164-84e5-41bf-8ec4-d480f40c1679", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1843), "57e8ee5c-491f-4d97-a04b-722a82f3696c", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f573eb1c-db81-4549-a17e-e21ecbd4c80e", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1862), "5f04cc2c-e78c-4344-bdd3-ee0f401016dc", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c89fbf11-b4a5-47d6-8c43-fd7d6ac636f7", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1879), "ea11aa34-68a1-436b-b9d5-134181120338", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd072e6a-7cd6-41e7-a767-da659173b368", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1898), "ce2092f0-2d59-491f-9cfc-9c6d8fc10057", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e9b2fd7-a295-402a-935e-b48639277844", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1914), "7b4c540c-3ef2-4622-87de-c38d4b3b0160", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "845feb78-df4e-4225-a26e-7c98f38712e4", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1942), "3eae27c7-19a7-4dd6-8997-94ea67ec810c", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "366c2124-9aa6-41b7-9c87-bf5156535eb8", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1960), "d8ba81f4-ee5f-4056-a94a-d228672ee779", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "96280a93-c5a5-4817-844b-bc156746f088", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1975), "10d55f9d-95e1-47e6-a586-46e0b3ccb8e3", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77bbdeaf-4317-4744-bb94-a9ecd37310cc", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1989), "408d51f0-d8dc-4a9b-99c8-72f8e482778a", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "006db2c3-1281-4771-8523-38ab7566da4f", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1517), "60f02768-0ca9-4545-8711-7e7f0b4aca7c", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3dacbc2c-28aa-4a3d-b969-4f85ab92030b", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2036), "200d3ccc-c478-4b5a-9b3f-66c4d097d613", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "184125e2-79d5-4f89-8ad1-b69611ae3959", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2052), "2ffc443a-e35d-4029-b52e-7cb157859a10", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9fcbf7bc-49da-4c7e-90f4-d208b3a2608a", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2070), "dffb3e41-3cc1-485d-a7a3-ba58e887efc2", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7f272929-153a-4e36-9102-ad87aec284e3", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2085), "799caf8d-ae33-4e22-ae7e-33eaef9185f7", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f413c5cf-7de3-469a-9dab-6b0a5163df6b", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2101), "5fb24201-626b-46d0-8020-d9a2ad10576a", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d3bdcae2-491d-4763-bb17-77a743d77981", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2119), "662b1fd2-bcf2-4c9e-8437-06565d64e364", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "72649004-6d80-4c3e-90f8-8d12d5b4f01f", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2135), "e8c076de-081c-4e27-8b78-bb3972a15709", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a569918-857e-4157-b212-c57f426b34ed", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2151), "bd3b6f6a-3c4a-4f47-8590-7ddce1be4bc8", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d5461c4d-1f53-46b0-a3c1-2907e00d8af0", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2172), "5e544566-ed6c-42cb-8218-8b98fa69b28c", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2941821b-1bc9-44a4-91e6-f7e5ca29715b", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2190), "27311c5f-7a6e-4773-988e-8ca4c3ff3e1d", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb22a28d-5677-4c76-8d2a-2aa94ba3bcf5", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1566), "26721388-47b6-4ae7-83d8-bbfc4d7f16fa", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "23366bb3-77d2-4a4e-b1a2-a2008e008e06", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2209), "09c66c39-f4c1-483b-9853-f32e35cd74fa", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "08d5a5c2-8a0e-4148-9fea-6b325750c2d2", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1593), "7c143b3d-f5c4-4232-ad1d-d306c15c81cb", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d66465aa-0fdc-4f0e-909a-c5664093a671", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1611), "e38dce2f-4525-4e13-850b-1196032ebe77", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "93b5250e-d438-4336-bdd1-42ca17d5d792", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1639), "eafc4c95-1673-4e33-b4a9-75fa8adfc1e4", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d546a253-52ec-47f3-9848-cb221f3accd7", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1655), "78c1b37f-2c9e-4464-9e5d-91f5f4715b5d", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eeb9190d-0bb3-4d6e-9902-fe6a23375f20", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1672), "9d9c41bf-4ea3-41d8-8d52-ba5863046aa5", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a5b675e4-c3f2-44d6-a0ff-b8effdff2ed2", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1763), "1e9ba728-2a76-45ca-bda7-4496d47483ce", new DateTime(2024, 9, 11, 21, 58, 39, 907, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ArchId",
                table: "GenericProfessionals",
                column: "ArchId");

            migrationBuilder.CreateIndex(
                name: "IX_Architects_genericId",
                table: "Architects",
                column: "genericId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Architects_GenericProfessionals_genericId",
                table: "Architects",
                column: "genericId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchId",
                table: "GenericProfessionals",
                column: "ArchId",
                principalTable: "Architects",
                principalColumn: "ArchId");
        }
    }
}
