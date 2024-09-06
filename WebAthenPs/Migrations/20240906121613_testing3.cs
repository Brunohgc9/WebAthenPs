using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class testing3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("03cfeb7a-1a7e-4a1a-97f1-2c13f577b8b8"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("8c803d02-8aa3-4232-93a6-1aac93b755c0"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("fa80b572-e8c7-4da4-8845-a6a02963ba07"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("7ea2e8ac-d687-4108-9069-8cd4ca67f794"), "Industrial", "112233", 12 },
                    { new Guid("cc9ae146-ca12-4cc3-9087-fc986f7ec651"), "Comercial", "654321", 6 },
                    { new Guid("f2849d06-b1f9-4b6f-ba80-d5e398d91e3a"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "de790659-445c-4d61-a654-ab2cf92f3fd1", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5346), "698c5b17-b256-4276-8301-09df7e091e45", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d949187-8fa2-48aa-93e1-57bcb3ba8a5b", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5544), "c2a3798c-2720-44d1-8211-c0d0d6d684f0", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "115da68b-d83b-49a4-911d-cb709628ce77", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5554), "dc09ddcd-d4f9-4141-b046-f388a870fbe5", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "914e8fa1-cc94-46d3-974d-b81b3013720a", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5567), "1f0d5fd9-0e61-466e-bade-29e121285b34", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "090b092b-3286-4824-82cc-63d60f7aea06", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5577), "5418f146-562f-4a39-8010-451a8377810c", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d83e3d3-e3de-40e7-a23d-09a2c9587272", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5588), "b1eb0735-44b6-4ef0-8f38-f97c07734f15", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "902769de-29bc-4528-b83f-124471580d31", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5600), "44d898bc-6557-4f65-8eaf-24094da92b3a", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1edc50b8-a6da-4b66-9090-a202eb65bf99", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5610), "8300ff7e-84d1-41bb-af09-2f6ca134c947", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8eb0a511-20d7-4020-b429-62b443cddd63", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5622), "820f4b12-eb1a-40e1-8696-708be52bdb5f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6c8b544f-c00d-44e1-90d1-c496b971091a", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5633), "d887290d-163b-40a2-8cf1-0eb990adba46", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1b8d951-8d08-4fcd-ac4a-1c26c6f670e4", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5645), "6e6e9750-0f59-4087-a61c-7a191bf90c8f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "faacf1d5-c3c0-4902-bef7-4c3ab08ecc25", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5406), "5f6211e3-93c1-4b2d-b15c-1e88ff758381", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c0ae0dde-d41c-4b1d-a237-3ef4c3756432", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5656), "89244114-4aac-4952-b2ae-420e4b9fca8e", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d91ee018-0c4b-4fae-9f9e-6c8508accc07", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5688), "d684ee67-6201-4287-a481-f3e2eb6c759c", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "578aab59-76e0-4d75-9c40-35195e1dfc79", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5698), "150f482e-0559-48d0-ae2d-4c53ab839104", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f10441e-2c08-45df-9129-a3a5978038ca", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5710), "c47de0ff-be6a-47ab-a303-0abd1c44107b", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9e8c353-6c8b-48b9-85da-28519995f55b", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5721), "f5b1da51-91c5-475e-a7bd-988da0b39e9e", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b65602f3-a6da-4f25-be64-8f37cfd8dd51", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5733), "93328de5-e60a-41d3-9b7c-b42e235e8bde", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "017c8e16-3cd6-4939-b30e-7b4066c6d3fe", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5743), "20d11ca3-50db-45dd-a674-eb89f895532f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f9c93db8-2b95-431b-b682-c01dff47cf2d", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5754), "6eec3c4b-ab4a-4dfe-bada-0bb6412027b7", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d8818584-e34d-4a89-b32d-862cfac1a468", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5766), "a227c0b2-889d-4fab-9701-996dc199a11c", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b73d88e3-1d11-47f0-8a3a-06c1af2c9ba9", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5777), "4cf7270c-3dcc-4fef-9a70-ebbfabbad090", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "559de549-7675-4cfd-a90a-4650fba9f926", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5418), "156605c6-fecf-4062-98f6-3ea2aec98d0e", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7e719d0f-7897-4201-b4fd-28f5c80ae556", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5788), "7a7f1d95-7c02-48ad-a445-827cdb0f3b09", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e319b75-d7c9-41c1-a94c-837715431b1f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5438), "6f8a5014-a791-4fc1-b971-9fdf7edd870d", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5452d878-6513-4731-95ff-83a29d2d74aa", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5485), "5fd654ba-87fb-4cb5-866e-c1cf96f067f8", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "42ec6cfc-9979-47e0-b4af-bf6873f7ef99", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5496), "ab5e974b-59bd-443b-b38c-dfecbd2c325f", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "04c8d42d-d450-477a-be73-55536a1f4618", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5509), "63404465-b1dc-4c54-a1e4-77ab7da2fff3", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "985426f1-fc03-403c-9f7a-83efe09a8780", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5520), "88d8dbe8-99b9-4f6d-82a4-4f0f3302cab9", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f42ba0ce-e5d7-4353-9672-506b6a7b22ec", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5533), "79701a74-3c0b-47b2-9cdd-ecc2470871f0", new DateTime(2024, 9, 6, 12, 16, 12, 746, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "ProfessionalId", "ProjectId", "Id" },
                values: new object[,]
                {
                    { 1, 8, 1 },
                    { 2, 9, 3 },
                    { 3, 10, 5 },
                    { 4, 11, 7 },
                    { 5, 12, 9 },
                    { 6, 9, 2 },
                    { 7, 10, 4 },
                    { 8, 11, 6 },
                    { 9, 12, 8 },
                    { 10, 13, 10 },
                    { 11, 13, 11 },
                    { 12, 14, 12 },
                    { 13, 14, 13 },
                    { 14, 15, 14 },
                    { 15, 15, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("7ea2e8ac-d687-4108-9069-8cd4ca67f794"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("cc9ae146-ca12-4cc3-9087-fc986f7ec651"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("f2849d06-b1f9-4b6f-ba80-d5e398d91e3a"));

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "ProjectProfessionals",
                keyColumns: new[] { "ProfessionalId", "ProjectId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("03cfeb7a-1a7e-4a1a-97f1-2c13f577b8b8"), "Industrial", "112233", 12 },
                    { new Guid("8c803d02-8aa3-4232-93a6-1aac93b755c0"), "Comercial", "654321", 6 },
                    { new Guid("fa80b572-e8c7-4da4-8845-a6a02963ba07"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fba9052f-3a20-4833-a8af-d1aedb6c82aa", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(936), "b172a9bb-db37-4ac6-8505-a84b26546ded", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7add311a-3976-460d-9a11-26d38cc500df", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1123), "b2044ac6-fae1-4c6b-bd4b-3631caa4411d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "48020e6f-80e1-4a50-ad7c-7df893e8ea8b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1135), "fe4a258d-0d1c-4617-a0b0-9aa4a8aac4bd", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1fd126d5-f2e5-428f-a755-755213ed984b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1147), "01f085c3-64cc-4fab-8126-e704d691e4d9", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c4c43412-a178-4caa-9344-a806850d3635", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1160), "497e89f6-1c00-441b-a387-5de9b58790fb", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ea516782-8a90-4d16-a25c-af1177f2ea20", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1171), "a46f92f4-83d7-47da-8c20-6e39d29a0b94", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c18befa-f3a6-47f8-9c28-cff43ac911e0", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1183), "a467e678-5b7d-47f4-973f-3120249a37a9", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca2e7279-30d0-40c5-9c8a-e3f6d04487cd", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1195), "da1c5fce-129e-414d-a30b-0c7b2d94ac2d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a5857515-0c17-431b-8a72-f73f71898c0f", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1206), "65bc7700-cbda-4f61-b49b-31cd9b5d2671", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7af68c0b-7932-4567-980e-093254989ab1", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1219), "13187645-2987-4518-a85f-a748438f9cf1", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d6fe00e6-32a1-4266-9676-a3ad25ccc36b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1230), "f5b8652e-9da0-4cc2-a193-80bfe254282d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fdffad4-726e-4222-9148-68c5241c7bb8", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1005), "0af82cd8-02e6-443e-a15b-44e01766563d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd4795c4-6e7b-47e6-b8ea-600e2f6c5b27", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1241), "aa0f965b-a6c3-478b-8862-640d7f124014", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c214a92f-5ded-4e49-a09f-1f30d75f9e79", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1253), "b7e33f53-4a4b-4d15-9f13-40e61ed15773", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a66a5301-6eee-4349-92b2-5328c362bc8e", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1264), "91b3552f-6348-48bc-998d-f6ea1aa15c94", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "011fa069-c40c-4394-9974-9311ee88789a", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1300), "9483ced1-ee13-4a40-bf5a-feebe72bce78", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "927a4394-1704-431b-a329-4eb774246117", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1311), "25257c65-a15f-4aff-86e2-d3db7a2e76d0", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fe0566a-da45-4dd0-9387-331678855387", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1322), "c8a430aa-a81a-46c7-8bce-78b3150008d4", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1bac6574-c96c-4a9e-90f2-57f982a9790f", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1335), "5e022716-f7b3-42a4-8099-8f2649066eb2", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25782b23-c48b-4ca3-b14d-a85ee55214ef", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1346), "a63d57db-e29a-4077-b455-85f5ca55fc27", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "389503a2-3838-48f9-9274-d19e7211787e", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1357), "293f52a5-49c6-48b5-81fb-28b0a472468c", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5d7eabb2-c9cd-4655-961e-9bf5ffb4a60d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1370), "bc9d6b2e-1827-43f2-bafa-60fdf73d9e84", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ecedc11d-a9ed-479e-b3ea-c1e20bfbbebe", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1017), "251a6fa4-76ed-4165-b400-58f19becb941", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cafd785b-4c4c-4742-b316-0f69c6def939", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1381), "031e0c02-4ce7-442e-b8a5-75d549d69fe8", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "83353325-261c-415e-bae2-4ed0e449c18f", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1029), "100ccbfd-cbdc-4e4c-8032-d1e31ee21f4d", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9af8c4dd-96be-477f-b46d-36177048c17c", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1041), "83c8eda2-ff1f-4b01-8510-41d03c6cc34b", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9c87a75a-439e-4ce1-b680-502c93df422c", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1076), "1d5e3836-dcad-40fc-8bf0-7add03481491", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b45ab83b-d8d4-4ec1-ac10-2e84b9279b24", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1088), "61c407b1-0d3d-46e8-8a3d-5428838cfb87", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "65c2c1bf-a731-4983-86bc-aa581a5c85f0", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1099), "a1d3ed4b-cc9f-4c26-a2ea-6dcec3638cc7", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0592ffa3-c246-4315-91a2-38aa535c9bb7", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1111), "75739ed2-ee72-425d-b5c9-99a1e3d29706", new DateTime(2024, 9, 6, 11, 32, 42, 322, DateTimeKind.Utc).AddTicks(1111) });
        }
    }
}
