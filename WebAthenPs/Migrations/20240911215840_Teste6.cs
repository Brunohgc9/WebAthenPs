using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Teste6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchitectArchId",
                table: "GenericProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("4939d3fc-d07a-4157-9827-18c61800cac2"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("e007a090-6ef8-4aa3-a396-7189d26da0f4"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("e550ff20-f02c-4ebc-b232-68845c3894da"));

            migrationBuilder.RenameColumn(
                name: "ArchitectArchId",
                table: "GenericProfessionals",
                newName: "ArchId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionals_ArchitectArchId",
                table: "GenericProfessionals",
                newName: "IX_GenericProfessionals_ArchId");

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("9876b54c-7952-4f52-a170-ed3036394792"), "Residencial", "123456", 1 },
                    { new Guid("a05cf0e7-d957-44ba-9e2a-313def7408ba"), "Comercial", "654321", 6 },
                    { new Guid("c151318e-3c52-4120-a0c1-b47b35ce07d1"), "Industrial", "112233", 12 }
                });

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

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArchId",
                value: new Guid("9876b54c-7952-4f52-a170-ed3036394792"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArchId",
                value: new Guid("a05cf0e7-d957-44ba-9e2a-313def7408ba"));

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArchId",
                value: new Guid("c151318e-3c52-4120-a0c1-b47b35ce07d1"));

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchId",
                table: "GenericProfessionals",
                column: "ArchId",
                principalTable: "Architects",
                principalColumn: "ArchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchId",
                table: "GenericProfessionals");

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("9876b54c-7952-4f52-a170-ed3036394792"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("a05cf0e7-d957-44ba-9e2a-313def7408ba"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("c151318e-3c52-4120-a0c1-b47b35ce07d1"));

            migrationBuilder.RenameColumn(
                name: "ArchId",
                table: "GenericProfessionals",
                newName: "ArchitectArchId");

            migrationBuilder.RenameIndex(
                name: "IX_GenericProfessionals_ArchId",
                table: "GenericProfessionals",
                newName: "IX_GenericProfessionals_ArchitectArchId");

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("4939d3fc-d07a-4157-9827-18c61800cac2"), "Comercial", "654321", 6 },
                    { new Guid("e007a090-6ef8-4aa3-a396-7189d26da0f4"), "Industrial", "112233", 12 },
                    { new Guid("e550ff20-f02c-4ebc-b232-68845c3894da"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "64da60af-f145-49f5-9549-2a8ef22226fd", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(5946), "2b760be0-257d-44fd-9565-b32cc7021036", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6001cbb0-0258-48f3-8006-8418128f12d1", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6142), "506ca26f-89dc-4c78-aa3d-bdb91286bd1a", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8cfc6b70-2253-42dc-bbaa-6323449f8565", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6153), "8a803b34-4c79-4aba-bea8-55f0512b805c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6babdc2-aedb-460c-962d-52492ce31237", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6166), "80310c1e-9613-4715-bd78-f479b81b1864", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "393f3d17-7178-4383-8fb7-b21ec8fa59df", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6177), "d0bb7cba-14eb-47c9-bd04-6577d8bbf8ea", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a8f8fddd-d1a6-4aea-bc86-0ebba058c6aa", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6189), "9930450b-6768-44d5-9945-18160af82ee1", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7242dbd1-5675-4d86-afaf-02ebd8cb11dd", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6202), "144ad650-cbfb-4725-9693-558c978117f5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81cb9024-0b80-4c9b-a767-7fc3622a961f", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6214), "0ce81f36-53b9-40ab-b120-cd5acb4946dc", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7d29b6a-c3a7-4b13-bb80-d6197efe478c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6225), "27ced3d4-9890-49e8-941c-75835212b341", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9b624213-46a4-4b66-a81a-1e967b0b6a00", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6237), "58ab0463-a04b-44e1-a5ff-2ebb7961c2e2", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "803d88a0-9b6d-4b32-b5c1-bd9c9870fe60", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6249), "68df7227-a6d4-4053-80ca-b4cee4afc4f4", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "220cce54-55e0-4347-80b9-d2be7feed681", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6019), "e59c9210-19a7-4f10-8f4b-81c61f374021", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5bc3e643-6483-4fce-af32-627f8b64da94", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6261), "e3b86eac-e94d-451d-a68a-0b0f6e84a425", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7dc529ac-cc12-4088-a328-23cbc7bc5c20", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6307), "795580e6-f2e7-4401-aab5-9226750ed547", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "183d998b-90d7-4b81-8fe7-ed728ca24e3c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6318), "83d60987-bd95-4c83-b5e9-52e65b8db390", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eb005220-2f48-4bd0-b0cd-bf4245700fc8", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6331), "421e3ebb-acc6-4878-8692-71adc3667bc4", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0dc41a7b-0a6a-4601-b837-7a65d85ee4f5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6343), "e6844ec0-0fb9-429f-9309-c4a0f4cc47fb", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "354f7fac-9266-48d3-a52d-867a6deb6e84", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6355), "f774742a-2efa-412a-9c00-f18f3b65a5a1", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e164bc8d-ba9f-4c2b-9223-7b40adbbcf23", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6368), "71ba498f-b5de-4b36-8023-022290e9d92e", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7040d44-05e4-4b1a-8db5-54b12ccb2da5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6379), "2ae185b4-ca7c-49fa-88e8-0554240200e3", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7e32bd1-37f0-4e37-94c1-2ee6252b857f", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6392), "bae4ae04-bbfd-4582-8a36-32893355634b", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3a33cae5-6fec-45e1-82b3-c9096c4a7cde", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6403), "64a1f286-ee26-4d36-9fff-387a6fc7d3f8", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "da508795-97da-4492-8f5a-d7790e4b2489", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6031), "c41c671f-a15a-4953-abb7-14b68ee1d397", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fddb29d7-703e-4eed-8407-a7cc545fdc80", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6414), "1dacf243-7887-48da-9de4-2b08a82e9865", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b33dec7-94a3-4493-881e-e847643b9aa9", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6046), "b11f30c2-2955-4ac0-8e55-61af41f08538", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "991d0044-4ffc-458a-a9b3-840d77a6ac87", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6081), "6a5b6034-bf19-43a8-b786-a66a0354af95", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "974d8314-6547-4c5e-bb17-a0dd7de817de", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6093), "4750827a-1a88-4ce7-853d-9358a972e69d", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f0082ca-100a-4aa9-a9d6-2207e760eb7c", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6106), "f7ae08ab-0116-45d8-abfb-140ffaba760e", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a112aea-7bce-4e9c-9f05-f24ec1ab10d6", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6118), "2263f139-6fa5-48d3-a3c6-e362828c4f98", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d49cfcca-0ff6-499a-b433-473cb3a443f5", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6129), "104b15b9-247b-424b-a46c-31ef2fa946f3", new DateTime(2024, 9, 11, 21, 41, 6, 206, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 1,
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
                keyValue: 12,
                column: "ArchitectArchId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_Architects_ArchitectArchId",
                table: "GenericProfessionals",
                column: "ArchitectArchId",
                principalTable: "Architects",
                principalColumn: "ArchId");
        }
    }
}
