using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingNullableProjectIdToChat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Chats",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "79b60411-c40a-4f53-b397-6c0e3620b970", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4046), "f244abe5-9526-4765-ab98-8ef439629ef8", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b11d0f73-6fe7-4f80-afe2-9d7905a7da1f", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4342), "e6a40b98-c5f7-4057-b231-e56b1a362d09", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "173f2de5-0832-4117-9d31-e591184a83e9", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4380), "5407166b-66c0-4b6e-a1b6-063bec938998", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c0df50b2-b020-44f9-a2ed-48e3bc4b97eb", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4392), "86b769c2-ac96-4e87-b229-89436fc2835d", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ccc5913-94a5-4b18-a691-5743d2de246e", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4404), "31dafb51-dba4-4645-8e40-fb8568afa33b", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "62e08205-97c2-4b57-ae07-a4c1d33ce2ca", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4415), "b9110ab5-0026-4b81-9400-6c9a4462f0cf", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e269219f-d7b0-41a6-9600-babda0d4e0bf", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4527), "7791ec58-8a61-4303-a889-2c8f4ae2d884", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "23ddc32d-190e-49c4-a293-3195c4a0b7c7", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4544), "83faf5a8-8a20-488d-8e37-6376b1f83484", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "443c4a3a-ee36-48e6-9410-f1e68f1cdd8d", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4555), "7ea58c6b-48b7-4dd9-8e05-d29a41b75019", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e728c740-0268-4b65-885f-74045ff5b50d", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4591), "22db1d9b-5144-4326-9b9a-5777a08c595f", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd737959-f3c9-4abb-af2b-3fe61bebb1f7", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4602), "673d4e1f-65d9-4865-ba01-58aae295ab90", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "16f39408-0faa-40f6-badc-cf3580644f40", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4218), "4a2cac5b-f40f-437e-9088-95e4e1c7f507", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "60b79214-c8c3-4992-b194-8905afa2965f", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4615), "bbddee19-a094-4e52-b16e-601d99ca8577", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "35cb1ab5-c89a-4906-a7cb-a140c5906148", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4627), "4d4b393a-45dd-4f07-b4a0-7bcd1575be3f", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ad8f5691-9fc1-42fc-b646-ab97937e353b", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4638), "05a8cdd4-10dc-4218-a425-7c6f091e9592", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d8fc177e-0081-4e46-9c3c-ea8feec2ce2d", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4652), "0d1a4499-89ab-4246-9f97-db894b40a102", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e27b7039-0861-4545-96e2-ad2f2039df1c", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4663), "55185ad7-82d0-475c-830d-3aea0b7f2bcf", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37807b66-816f-4f37-b8c2-edea2c76f864", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4675), "555f89ce-de8c-4799-abbd-8bde27aea40a", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9353ec09-1112-4e9d-a9f2-131ecb5acfaa", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4687), "97ce5d1f-db94-49ba-86b8-e3ccef21e9f3", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "40ba0b0a-6bed-42a0-b58b-a93ac069c72a", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4699), "b9675cd5-8a58-4065-b670-5c3d27699903", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "07c7a732-b241-4509-9269-e1c577759e7c", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4712), "d4f289bc-b1ac-4a15-a51d-a0e69f3c7103", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "24807151-0548-4f82-9cc3-74205925d39a", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4723), "7a9711f0-692e-440e-879f-6a2613b6ad96", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dfa4ca29-96c3-4187-9561-afe6661bb0a3", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4234), "b7537ad8-1d73-47cc-858d-04637dcd6ce6", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1783ad22-23f3-49dc-9ae4-f86c2ab0d3a2", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4735), "02167023-a5d1-41e5-af85-2428e62e61f8", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8418cdd5-8139-4a61-a161-06c63765ab10", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4252), "cf205652-56e7-49f1-ab92-fa2bb0017bc1", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e7f52a3-b323-4b44-a661-4cb598b0cd46", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4270), "588464f0-14a0-471a-bfc9-20cdd2f516b6", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "821bff28-e387-43cd-8866-1ef39c53a0fb", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4294), "8cbb8f52-b06d-4658-8592-2785f94023e2", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1045915-1a98-4155-8951-0a2e784bf590", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4308), "00645b7d-20a2-4129-8fe6-1326ff8170db", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7f7928c1-c4d0-42cc-b658-568b79a73a9f", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4319), "08594d9a-57f6-4fd4-8d2f-64d982140525", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1d346ef-5eb8-42a6-a3a1-306dca34181a", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4330), "edf64dad-7eb6-4c0d-a13e-e021098f1686", new DateTime(2024, 11, 26, 22, 51, 45, 678, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ProjectId",
                table: "Chats",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Projects_ProjectId",
                table: "Chats",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Projects_ProjectId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ProjectId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "543c109f-791f-4db3-ba48-64e5d7108bfe", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6046), "846b99c5-64ca-449c-b0dc-e47cbebbdf25", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2bb46691-a14c-4aa9-a16d-a10a1bd7711e", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6331), "75f8c0e4-d562-4c3a-93c1-13779bbc41aa", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e35e6f9-902c-4b57-980e-f24e94bde8ba", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6389), "ede9829f-f46c-4bb5-81b6-1e1b56c9f601", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2da25c00-cce4-4bd8-8fa5-fbb20ea63734", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6434), "4c8a609b-30de-4959-b007-05a22599bf25", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36146411-0c13-4824-939a-a7bbda973c82", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6452), "a4a4975c-eedc-4cd1-b597-c2d01044b671", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3d6f047f-dcc1-4cfa-bdaa-4e19c0e6d3a5", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6468), "43132090-0872-4c0f-bd0d-727f57162490", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c3a6d049-1d50-41e6-9e97-cdfb67bf73d4", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6484), "8abf4462-7e0f-47b6-8883-34d54014ee29", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "84eb8ac5-658d-4e56-b98e-ed34a05d38fc", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6509), "a82f9ece-f265-40ae-bd1f-61f7780a85fa", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "961ca1eb-a989-473b-855b-8f66a1ce3bd1", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6524), "42f6882b-6d27-434c-82c8-645c30451a95", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8812c8d4-6c34-4a38-b893-2293f4388831", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6542), "3c2b830c-3c30-4134-b012-41e7c5c061bc", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7d74c494-eb59-46c0-bf20-97b213e5d30f", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6556), "8e337b65-277f-4e8c-b60c-8bb4b99e1732", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b517ca0d-6821-4aee-804f-fef0be00b390", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6176), "44ccd86b-e9d5-4675-826f-3c799afdb101", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "39db1d65-bf70-4de1-a637-37c3192ffaf4", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6571), "e111fdf2-a393-4634-8473-f7680e4f27dd", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "86a5833f-e031-4201-8246-86e2ebe14e54", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6588), "58f1e3c3-be52-4fe6-be57-94ad24b59792", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6b6d2cf-8cd5-45d8-a8c3-2ba03901d8b4", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6604), "fbc63a93-4c23-469f-a2d3-85d96e534915", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2aae5fda-3f16-408f-91d4-14558359cec8", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6621), "a849f821-0f54-4b6a-bcdf-01349b1b183e", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8426f3ca-ee1e-45d2-9deb-a069f8f6998f", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6639), "2977ecca-2bab-4223-a74a-1669c31f1ebe", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a4242805-28a1-46b3-b289-a86cdf81bfd9", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6654), "1c3ce9be-6a89-41be-b228-e7eceac23374", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "465adc67-b88b-47ea-9eae-c4063d2394f4", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6671), "2823b5ff-8fc3-4ba9-ae07-282491ed54b0", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f30f3eba-a943-4952-9085-76a9d8d3653b", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6716), "81dec52d-c989-4743-a625-7a64de420fec", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5be91012-1258-4ead-bc29-ac7b7ab321a7", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6731), "29b2fa3c-a78d-4e95-b767-07432c445ac3", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e410c69-e94b-4156-b70d-4fcffd67ab7d", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6747), "ef199d9b-5e2e-42c5-9350-01adea08be2f", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3c2f7fc1-d720-4446-8be4-4b2d8c36f0da", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6195), "4d8f9655-5d6d-49d1-b0e8-0e3f40c6fa7a", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4d88694d-fe1a-45a5-b787-a1ee682d2759", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6762), "226772f7-e250-41cc-a599-606fdedc1162", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d630b5cd-82b4-498a-a2b1-aad3b4f7f02e", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6214), "aad7a9e9-2c67-45c5-828d-d610b4786595", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "adc407c5-70ac-4f13-9083-1135e32bd00c", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6234), "a1414660-f8e7-4d5f-ac45-83af4039c0df", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d227451d-9b98-4066-a556-4b12d9d9b7c7", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6261), "fee54c32-3b1d-47be-b1d3-efa957de3a35", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5557b8ff-d1a7-4468-8fc4-0292514f67dd", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6278), "533c6192-2c34-4b1b-b701-c01d8d6ee702", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9fdf823e-dc61-4602-a3cd-ff5fa82dffd0", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6296), "91d345b8-a63d-448d-9742-505944780a76", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8cabbe61-0066-4a5e-83d4-c86f87fad054", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6313), "e88f4927-759b-4270-b42a-5f76b3830a43", new DateTime(2024, 11, 25, 22, 34, 1, 810, DateTimeKind.Utc).AddTicks(6313) });
        }
    }
}
