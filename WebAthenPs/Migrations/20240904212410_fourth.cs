using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("37f68ec0-5c99-462d-9795-6aa0ab7196d9"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("3baca083-93f6-47a0-bbba-ed5d9e71eeb4"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("585fd65e-a85e-49b4-bbdb-2d0d013d2ad2"));

            migrationBuilder.AddColumn<Guid>(
                name: "ArchitectArchId",
                table: "GenericProfessionals",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 11,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 13,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 14,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 15,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ArchitectArchId",
                table: "GenericProfessionals",
                column: "ArchitectArchId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchitectArchId",
                table: "GenericProfessionals",
                column: "ArchitectArchId",
                principalTable: "Architects",
                principalColumn: "ArchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchitectArchId",
                table: "GenericProfessionals");

            migrationBuilder.DropIndex(
                name: "IX_GenericProfessionals_ArchitectArchId",
                table: "GenericProfessionals");

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

            migrationBuilder.DropColumn(
                name: "ArchitectArchId",
                table: "GenericProfessionals");

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("37f68ec0-5c99-462d-9795-6aa0ab7196d9"), "Industrial", "112233", 11 },
                    { new Guid("3baca083-93f6-47a0-bbba-ed5d9e71eeb4"), "Comercial", "654321", 6 },
                    { new Guid("585fd65e-a85e-49b4-bbdb-2d0d013d2ad2"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "447212ed-e9fd-4fbc-8c86-563f8f1e752e", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(8997), "9af3b316-bd9d-4731-b8d9-9f6b5f4b80d6", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9a712e49-1e63-4ed5-be6f-798a11ca147b", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9171), "e69b4fe8-d94f-4117-87cd-92e2ff91b83e", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1f7cd32a-247a-4a2f-8580-fa419cc32113", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9183), "94a77b06-1b6f-47b7-804b-7416b852be71", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "72a067b2-eb93-4388-b208-1edcd8203b5a", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9194), "88fdbad1-a304-407d-bed6-84346fa8ca5f", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1dfb89a0-db64-4b14-91d9-e05982390876", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9205), "de162f56-89b3-4911-9e38-4b44c24d1f8b", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "caf0ebc3-d861-430f-97a4-cd57d3105ad5", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9217), "10977827-79bc-4d12-bc3e-6c19eeaab8c5", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f97a0bf3-f041-4ee3-8f70-9c96ab96efcf", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9227), "f5539868-e484-482c-8a86-487570192680", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d202c15b-aedb-4812-ad4e-731bb2d2c4f5", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9239), "c993f3c7-d28e-4639-a870-c714b9066817", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2b463ac9-45c9-466b-905f-9fad9421724e", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9252), "aa078c8b-0c19-4aec-9736-6c82567133ff", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca6569cf-749f-4ebc-a351-f8af46f633d6", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9286), "8b04c4a2-1d23-4127-af4c-510478d038d2", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36afb92f-a711-4383-b652-db3ec160242f", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9298), "8a122909-b6b7-493e-a4fb-71f6fb8bc302", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a312d46-72b7-4ab5-825b-8c208014d68a", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9070), "56675582-cec6-4577-ac7d-2a135b989003", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d2d1841d-2bf3-4af7-b305-c8df31fb08e0", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9309), "da3d79d9-c30c-41f9-8f0d-7be3ca5e0514", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "786b4e4a-42eb-404f-ac91-e34281a887a9", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9321), "29d7f354-934b-4507-af51-70d789e16bbb", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aa836487-504d-4505-9f8b-c0e9489707bf", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9333), "89a58935-5833-4e16-b0e3-29e9ff5dd0cc", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0211774e-9cf4-45d1-bdf1-2f5cb6023b02", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9344), "6d685c94-91ed-4c83-ac6e-6802ec41ea72", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "405a8d36-c189-4ed5-bba5-7f1fe59aa4c5", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9354), "c0de9bcf-8299-4c95-bd7d-4cca46aaa4ad", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9bd6752e-5fe4-413a-81a2-5cec3e8966a0", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9366), "00fe35e7-2394-4048-b93c-7e5a05f75a0e", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "983953d7-ce10-43e5-b90d-502d17805e08", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9381), "97b3537f-d06d-492c-a25d-9a86f78918fa", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "67a798e9-3c68-4e43-a450-abce01784cde", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9393), "cf88910f-1e23-4a5c-a02a-310e044e3ae3", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7b652b75-6eb8-45fa-b9a2-4ceefd7fda7e", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9404), "babc66c0-0321-41eb-a8ee-298247af8c00", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74df8033-25eb-4f1f-a320-0d631e5f613c", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9415), "186ce247-cac3-49cd-8dd0-17fc8d318b96", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "440e4acf-dc2e-4594-90e8-05858c783d66", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9091), "0d84b3ed-910f-4825-8247-1c88714de2ba", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3dfb1f04-2c3a-4d02-9e0c-edd1aa129bc9", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9427), "1a19de52-3a48-41d1-a46e-0db8d897a7f8", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fae534cd-46ac-4f67-bb56-5aa0c581029d", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9103), "5f55557e-b078-4341-a116-55700d53f019", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "736f7265-8e3e-47ef-8c57-4c9f86139bf6", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9114), "985a7e77-3201-4a4f-8583-a576faea1aff", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f1e2cc75-927d-435b-af48-293bdb3f0949", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9126), "aa450806-6e23-4017-8363-43d470eb8124", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "61ecdbf1-a03f-463c-a159-10dc7eee3ecb", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9137), "193c966d-b4e4-41e7-af60-54cf5ee5996b", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68463f5e-0829-412f-8662-472c26c63c7b", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9148), "7760d585-cb21-42d5-801e-b1847b9ee9c3", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e071a13f-f3bc-46cd-8706-56a668ab22fa", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9160), "ddc9f476-61eb-48b3-804a-d010477c380b", new DateTime(2024, 9, 4, 0, 6, 40, 113, DateTimeKind.Utc).AddTicks(9160) });
        }
    }
}
