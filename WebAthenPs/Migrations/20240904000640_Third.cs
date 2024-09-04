using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Architects",
                columns: table => new
                {
                    ArchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    genericId = table.Column<int>(type: "int", nullable: false),
                    RegistroConselho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architects", x => x.ArchId);
                    table.ForeignKey(
                        name: "FK_Architects_GenericProfessionals_genericId",
                        column: x => x.genericId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Architects_genericId",
                table: "Architects",
                column: "genericId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Architects");

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
        }
    }
}
