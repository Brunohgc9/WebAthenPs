using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class seventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("259f4d97-80dd-4cf1-9047-4146e07666ad"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("2d1d1a53-4b6c-4788-a30a-4a8020ea8a50"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("80ee912d-9dc4-47ec-a837-64d7d26e7fe8"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectConnectionConnectionId",
                table: "Projects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GenericProfessionalProjecty",
                columns: table => new
                {
                    ProfessionalsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionalProjecty", x => new { x.ProfessionalsId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProjecty_GenericProfessionals_ProfessionalsId",
                        column: x => x.ProfessionalsId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProjecty_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectConnections",
                columns: table => new
                {
                    ConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    GenericProfessionalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectConnections", x => x.ConnectionId);
                    table.ForeignKey(
                        name: "FK_ProjectConnections_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectConnections_GenericProfessionals_GenericProfessionalId",
                        column: x => x.GenericProfessionalId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectConnections_GenericProfessionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectConnections_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("334b7cd1-71db-4291-8540-cc3ea52a774d"), "Comercial", "654321", 6 },
                    { new Guid("5630df84-37d6-4ff7-93ac-2a7495599da8"), "Industrial", "112233", 11 },
                    { new Guid("8f4a137b-097a-450b-b48d-ebb4fb827ae4"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f86d399-8782-4c86-af51-07b745856e1b", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9469), "37f6b0cd-b7ed-4853-99a0-d1d68abe541c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d03e4c9a-001a-4002-80bc-ebe74d1ce3ab", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9636), "3a41aa1f-eae9-43a5-829c-80e5e092fc5c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ba9471f6-b0c2-48b3-ac94-56dd1b66bed1", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9648), "955f55cb-e3b3-47f2-a383-82449e80f8cd", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "899226d1-433a-42b3-b4f9-3665dcdde8ca", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9684), "089815ef-9161-4d4d-9504-34f4c3466379", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e4955fdf-0860-470c-a665-34e18b3f06d3", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9694), "bc17d299-649a-4af1-bc6a-8361dc7ba36a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2ad21e8-412e-4792-a9e0-2929105f8a41", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9707), "521c8cc5-258f-438d-9a5d-2738e542574e", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bc374244-3725-436d-9193-7cd0830e9091", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9719), "dca3f4c2-2668-4ff3-9173-b0fe1e956dbe", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f39b7e7-f858-4285-9dde-4cc1a322bab4", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9730), "9d6e57c4-1bc6-4932-a0f0-0f73f8366df4", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "93986e57-9d24-4c67-aad5-91ec54d6aef9", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9742), "be11cf5e-4b20-4dd3-95e1-de2a130ec2cd", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1c47089a-5742-4b02-be6d-e0b84ebeb99d", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9754), "6acc9ba3-cf18-4548-a16b-0d21b2da8c91", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "66c1e57f-555b-4022-bafb-8ea5141a69db", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9766), "22f35837-5203-4d54-9a27-f6cd62d324ae", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7f1cfaa-3f3f-406d-a1c8-4b96e116450c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9531), "26bd876a-9d31-44c6-84e8-ef58b5ef1d8f", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc76763d-b96f-4913-ac55-652b6e35d034", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9777), "1f8b0ab4-4ae2-4622-9a18-89808a8f6381", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e2421e0f-f6e3-48ca-b59a-c3ea92d7f1a7", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9789), "4a8ba20d-32aa-4dad-b903-8df46fa77af8", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "806fd935-82fb-454a-80f1-8d00fe58bd9a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9802), "55ad17d6-0814-495f-b58d-f1253c5d2986", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3325335f-049f-49ca-8465-76e44d558f97", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9813), "59dd81c7-22f1-4a19-866e-1187c4334546", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f214892a-d4ab-4252-b56f-f456431c1970", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9824), "0c7aa67c-17eb-465a-a9e9-c23f3319c10a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "14522e0a-ad0a-4bbc-9f89-923dd8d5aa1c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9837), "5d182990-2463-46c9-9de6-b16d6d67c6b6", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6270a877-39b3-4460-ae01-f6355885b140", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9848), "50843fb2-c812-416d-9fd8-8b1fdc376a23", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1c8d772-c5cf-443d-bf0c-f73031277e93", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9860), "1f003e38-1722-4552-94e4-04fa394999b9", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5865644d-466e-498f-8c13-e11a41e8cb7d", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9873), "4977ea0d-7c8f-4af8-92d2-feceeab3a798", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d8b96bc7-8ad9-45ea-95fd-fa89b36a4aad", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9905), "a19368b1-b1b4-47fa-8bc1-7adc74c5688e", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b2b7809-268d-4f4d-ade4-1bf239192a4a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9552), "402d3446-054d-4bb6-8aaa-ed1850734282", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2161fc21-d990-4b6c-8aee-2c1d5e6082de", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9919), "6de0317b-1c56-4f19-86b4-3664a0d1f203", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "50062a41-bcaa-4f67-8394-1e7b7a2363a1", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9564), "63d0f1af-afc2-4183-9c89-26327c9079c9", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8cf4e796-fbf9-4700-98ab-bcf0a73e2014", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9575), "0c65c176-0398-4a1d-9e25-e218fb0f6d18", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7b6422a-9bff-441e-8220-6743666542cf", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9588), "db6ea8c0-e04f-4ee8-88da-63d53964b35f", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f0d58882-0668-47fd-8b3b-d2e2f512692e", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9600), "8a8cff52-d6f3-439f-853c-cc09efa7f3c7", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e8719a3-6b0f-400f-a17f-39cea095569f", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9612), "4d0da625-dff5-4a2d-bd48-5b566648f821", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a4c0aed-4a2e-4df3-918b-58bc52785317", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9624), "5e29f8d4-d7cb-4d2f-b135-bf3b503bc2b8", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.InsertData(
                table: "ProjectConnections",
                columns: new[] { "ConnectionId", "ClientId", "GenericProfessionalId", "ProfessionalId", "ProjectId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 1, null, 1, 1 },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 1, null, 2, 1 },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 2, null, 3, 2 },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 2, null, 4, 2 },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 3, null, 5, 3 },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 3, null, 6, 3 },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 4, null, 7, 4 },
                    { new Guid("00000000-0000-0000-0000-000000000008"), 4, null, 8, 4 },
                    { new Guid("00000000-0000-0000-0000-000000000009"), 5, null, 9, 5 },
                    { new Guid("00000000-0000-0000-0000-000000000010"), 5, null, 10, 5 },
                    { new Guid("00000000-0000-0000-0000-000000000011"), 6, null, 11, 6 },
                    { new Guid("00000000-0000-0000-0000-000000000012"), 6, null, 12, 6 },
                    { new Guid("00000000-0000-0000-0000-000000000013"), 7, null, 13, 7 },
                    { new Guid("00000000-0000-0000-0000-000000000014"), 7, null, 14, 7 },
                    { new Guid("00000000-0000-0000-0000-000000000015"), 8, null, 15, 8 },
                    { new Guid("00000000-0000-0000-0000-000000000016"), 8, null, 1, 8 },
                    { new Guid("00000000-0000-0000-0000-000000000017"), 9, null, 2, 9 },
                    { new Guid("00000000-0000-0000-0000-000000000018"), 9, null, 3, 9 },
                    { new Guid("00000000-0000-0000-0000-000000000019"), 10, null, 4, 10 },
                    { new Guid("00000000-0000-0000-0000-000000000020"), 10, null, 5, 10 },
                    { new Guid("00000000-0000-0000-0000-000000000021"), 11, null, 6, 11 },
                    { new Guid("00000000-0000-0000-0000-000000000022"), 11, null, 7, 11 },
                    { new Guid("00000000-0000-0000-0000-000000000023"), 12, null, 8, 12 },
                    { new Guid("00000000-0000-0000-0000-000000000024"), 12, null, 9, 12 },
                    { new Guid("00000000-0000-0000-0000-000000000025"), 13, null, 10, 13 },
                    { new Guid("00000000-0000-0000-0000-000000000026"), 13, null, 11, 13 },
                    { new Guid("00000000-0000-0000-0000-000000000027"), 14, null, 12, 14 },
                    { new Guid("00000000-0000-0000-0000-000000000028"), 14, null, 13, 14 },
                    { new Guid("00000000-0000-0000-0000-000000000029"), 15, null, 14, 15 },
                    { new Guid("00000000-0000-0000-0000-000000000030"), 15, null, 15, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 9,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 10,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 11,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 12,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 13,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 14,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 15,
                column: "ProjectConnectionConnectionId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectConnectionConnectionId",
                table: "Projects",
                column: "ProjectConnectionConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProjecty_ProjectsProjectId",
                table: "GenericProfessionalProjecty",
                column: "ProjectsProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectConnections_ClientId",
                table: "ProjectConnections",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectConnections_GenericProfessionalId",
                table: "ProjectConnections",
                column: "GenericProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectConnections_ProfessionalId",
                table: "ProjectConnections",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectConnections_ProjectId",
                table: "ProjectConnections",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectConnections_ProjectConnectionConnectionId",
                table: "Projects",
                column: "ProjectConnectionConnectionId",
                principalTable: "ProjectConnections",
                principalColumn: "ConnectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectConnections_ProjectConnectionConnectionId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "GenericProfessionalProjecty");

            migrationBuilder.DropTable(
                name: "ProjectConnections");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectConnectionConnectionId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("334b7cd1-71db-4291-8540-cc3ea52a774d"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("5630df84-37d6-4ff7-93ac-2a7495599da8"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("8f4a137b-097a-450b-b48d-ebb4fb827ae4"));

            migrationBuilder.DropColumn(
                name: "ProjectConnectionConnectionId",
                table: "Projects");

            migrationBuilder.CreateTable(
                name: "ProjectProfessionals",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessionals", x => new { x.ProjectId, x.Id });
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_GenericProfessionals_Id",
                        column: x => x.Id,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("259f4d97-80dd-4cf1-9047-4146e07666ad"), "Residencial", "123456", 1 },
                    { new Guid("2d1d1a53-4b6c-4788-a30a-4a8020ea8a50"), "Comercial", "654321", 6 },
                    { new Guid("80ee912d-9dc4-47ec-a837-64d7d26e7fe8"), "Industrial", "112233", 11 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36e37099-4875-45e4-ab99-d7b21274c23a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2732), "750832e6-79dd-4a56-9c82-f858f19bcdb2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9a5f559e-5966-45cd-9506-bfb489554063", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2931), "837c4e10-db6b-4230-a5eb-bb90d51134a7", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf652324-db17-402e-a1cc-68cefe0c1279", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2943), "ece7d7a5-a852-4cd9-ba73-d51f6050dfa1", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d5274849-5597-40a9-b504-e0b3fefc412b", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2954), "8f3c842e-6fe5-45f7-97fb-8dcac1de8184", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ede134ee-61e3-45f8-a8f1-09a95ab76ba2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2966), "250e508b-fe5c-4d47-a6b9-272d10fa7de0", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dd2937e8-9dd4-41ae-b640-ee8b22664a87", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2978), "53521165-a8c2-4f0b-a13e-89551365ab21", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02b13eef-9b13-4000-b9a5-76f3217aa164", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2989), "5516cba2-5e70-4da0-9bf5-6c6d1c3c900a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ffcc617c-654f-4ee3-bdb6-8a88a9d751d4", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3000), "7200c8a3-9834-4a9e-9777-d9ee2fbfe814", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "deded771-43b4-4704-8f98-e8467804a4a2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3014), "8fff3ef6-4722-4ad2-a92b-7fda7f4b5268", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "09bbb044-c5b1-404e-85a9-73a729e9ae87", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3025), "221d1750-1da9-4307-b908-490350e2dd9a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fadb2f1d-bd8b-40ea-9085-af67833783e9", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3038), "bda62e59-10a0-4e43-901f-ced807869b90", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f9f490ca-17a1-4810-b4d9-4247a14ea441", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2793), "bcf7c457-fb35-4353-935f-ebaa2f2c1ca1", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8fbf1cd8-2622-4f17-9cd8-003131258610", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3078), "742412bc-fccf-4da5-830d-661424258b23", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "116b8c45-7a99-49e1-bce3-8cca6217cecb", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3090), "3092a4d2-d183-4216-af63-3f6b61a3f356", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6ea18c9f-b5fb-48c7-a7c8-be986465c21e", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3103), "2eeddd8b-385f-437e-bcc6-6f75a7ad62a0", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3f31fc61-bb06-4bd4-8532-e75f5e1d502a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3114), "44096433-1801-4936-9d07-e577756ef79f", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "52070d67-22f3-4ebc-832b-1a7bef21b7fb", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3126), "7aa84a4c-decc-412f-b406-77e856fb71f8", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75c668d5-51d7-41a2-abcf-5bd456ae60fa", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3138), "b29961ac-19a4-4b16-b11b-f269458056fe", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d6a7cb53-90e7-498b-8077-9e2ec57b7d22", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3149), "4d304c1e-9568-494f-9b6c-0b0114184677", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aa72673b-b2ac-4240-81f1-fcbfb0d65c5d", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3162), "e58528a1-0483-4446-a486-63e53e04230a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "42978c87-3365-4d0f-ae31-6c4903ac13d6", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3173), "95196c81-e9ba-4f00-b444-da195d226b44", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe16e034-609e-4540-830e-59b4fdd953b1", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3185), "87acb264-7e40-4a8b-b998-874f6d89f80c", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a31a70b-c5dd-4f2a-bc6c-f0ce17d506d2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2846), "13339d06-f55d-467d-b17a-3bb43f6707c4", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "199e8393-c178-4a4d-8504-96ce49a41651", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3198), "eab26efa-f6ce-4d2f-a82e-b2f06c8f9183", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b3a8fc7d-263c-4765-8481-96fccba79929", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2859), "e24ddc3e-e304-4fde-b15a-8d45ec318176", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "610e6034-c4ba-4aec-829f-d14ad085081e", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2870), "55034b79-14c5-4889-8856-e7099c631cf6", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3eaf810d-4574-4ab3-a527-8420f3853110", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2884), "4abe9d47-638f-414a-be68-aa69b83407e4", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c6f2214d-c4bf-4b74-bd1f-fb90588d68d5", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2895), "bd2304c8-3d43-4724-af42-ca8f66f755f3", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e841737e-b24b-4141-9e3f-a987a5d0488b", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2907), "fee3240f-e7ba-492c-be44-cef0e68a45d0", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5522eb9b-cfd9-4e5f-a865-f851035c0f24", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2919), "bf54bccd-c94f-46af-a266-53e9a990967d", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "Id", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 5 },
                    { 10, 5 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 7 },
                    { 14, 7 },
                    { 1, 8 },
                    { 15, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 4, 10 },
                    { 5, 10 },
                    { 6, 11 },
                    { 7, 11 },
                    { 8, 12 },
                    { 9, 12 },
                    { 10, 13 },
                    { 11, 13 },
                    { 12, 14 },
                    { 13, 14 },
                    { 14, 15 },
                    { 15, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_Id",
                table: "ProjectProfessionals",
                column: "Id");
        }
    }
}
