using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class ProjectProfessionalContractedAs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContractedAs",
                table: "ProjectProfessionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5104fbc6-bc64-4ac7-812b-313d3d99bc43", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4612), "f5939e7d-a2b0-4029-833d-04f2d686bdbd", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bdb9fd00-a20c-4499-a978-933edbe99488", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4864), "49246644-58bb-4d9d-bed9-46285d2bec5e", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2db3caa-3974-4650-9465-232c91b5c22a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4910), "a6a75136-22a3-44b5-ba27-5859db1181a8", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1d29d25-373c-4124-a8ea-460c39ef313a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4924), "8375c360-8cae-4624-8e14-69bd27b5369e", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90c21d0c-b3ef-454e-a1b9-1b55770456eb", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4935), "7faca28e-1d11-4af6-b464-8e406b288a4c", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c82b07d8-76b0-4d5c-8f32-e6345a208a0c", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4945), "63fc46cc-52ed-40a7-8007-ff26f76c6191", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "85c14b03-8404-42f2-b991-cdb0c1c4e928", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4958), "4f9f8188-d1ac-469d-b1e7-5dd37b8f7b30", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81d32f52-06f8-4921-8a25-3034ff7178d6", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4987), "845933bd-7d0a-4f2b-8799-765f0836d45b", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c7b66d32-1391-4e68-a127-171f58b890a5", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4998), "513a11a5-9b19-46fc-b4a5-4f889f548f3a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ebf6f39d-f7e6-47e0-88a1-1afda4b86b0a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5010), "0d56d958-e704-468e-9265-f42e3fe6290e", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "69831873-2bb2-4bd4-a59e-652c92c860b7", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5020), "12610df4-acfe-4d79-8dfe-b431108130c5", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f5c83c0-25ee-4604-acf9-bcd96c32e027", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4728), "d8969944-b5d6-4328-bf0c-39243d417023", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c09e6f3e-0a6d-4b54-a1b0-2a49827301cc", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5031), "a2a8d4c0-8be6-449f-81e1-b6b44882fd93", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4654b477-4ddf-44fd-b5ac-ea46c5ecbc5a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5064), "838bfc57-0007-4c9f-b607-29abb44adfa5", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c4ff36c5-f2a4-4f55-8053-7301d6c5612d", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5075), "346c9cc2-cbac-4bd0-a56c-79ef64ac9781", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f3db793-e45f-47f5-a385-92007669759b", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5087), "8583a46a-3021-4b75-a514-4708e8f14112", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c31e1e97-8160-48b8-be5e-40218f428c58", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5098), "7e6b0b40-64f4-41ff-8b5f-3ed7dd9eba6d", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "272cdc42-3b0c-4400-8b85-c027a2718e21", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5108), "5564b801-fae9-47c6-85d1-7f9dfeef7b37", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b5368c8-e9b9-4adc-b08b-e0090f7e6cd6", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5120), "62cdc326-7492-4f1e-8a3a-e2c9bd1f2b4a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4d5c3c3e-d07e-446d-a71f-0b27cbcb4114", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5131), "4233f03a-c1b6-4a6a-bab7-34d3f499bcf3", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f06ad35c-9193-4e1a-84d2-91ea9d55a559", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5144), "a84cd1c2-3491-4d00-8b6e-34d85d5fc5db", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca776b70-7fbd-4e66-bcc9-36587222425f", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5154), "33a7e192-f1df-4c6f-9d11-8cef43d179ec", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d262ef97-846a-46f8-ae77-fa911de4a650", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4740), "42588ae3-5b94-4fa2-be22-832273ae83a0", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f76195aa-ef0d-404a-96ff-dd8fd1142fdf", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5164), "9e286f9a-7140-4d35-91d0-ee1cfec4d0a0", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e72e3f6-4fea-4656-9ca3-7d65becb1c66", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4752), "22db6cc9-b654-4d1c-89fc-9e382984ba93", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1136c1e2-0fed-45fd-a0a5-a3541826e638", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4796), "803cd0e7-609e-4d27-8b8e-0a1c14fcba85", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "13d5b448-09cf-4cc6-9877-e8bf39bbd44f", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4815), "4907dd08-be6d-4f63-8d33-1040f4884eae", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f2e06938-63a9-4b7c-a483-395b986b2181", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4828), "4f5b94c2-f068-40a8-9b3d-1cd45e9a70ce", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ad5b852e-e683-4305-9b0d-6f01addaca60", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4841), "a1543945-dded-45a9-9fec-007da0b7d317", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d9ec50f-78cd-4031-9d4d-01834c4ea2df", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4852), "939661fa-4b80-46ab-9b48-d5e08858369d", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContractedAs",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContractedAs",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContractedAs",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ContractedAs",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ContractedAs",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ContractedAs",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ContractedAs",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 8,
                column: "ContractedAs",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 9,
                column: "ContractedAs",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 10,
                column: "ContractedAs",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 11,
                column: "ContractedAs",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "ContractedAs",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 13,
                column: "ContractedAs",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 14,
                column: "ContractedAs",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 15,
                column: "ContractedAs",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 16,
                column: "ContractedAs",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 17,
                column: "ContractedAs",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 18,
                column: "ContractedAs",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 19,
                column: "ContractedAs",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 20,
                column: "ContractedAs",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 21,
                column: "ContractedAs",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 22,
                column: "ContractedAs",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 23,
                column: "ContractedAs",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 24,
                column: "ContractedAs",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 25,
                column: "ContractedAs",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 26,
                column: "ContractedAs",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 27,
                column: "ContractedAs",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 28,
                column: "ContractedAs",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 29,
                column: "ContractedAs",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 30,
                column: "ContractedAs",
                value: "[\"Encanador\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractedAs",
                table: "ProjectProfessionals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d4811ba1-bad4-46e9-8831-8bb6653ef5ee", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1541), "dcc78a56-0692-49b5-81eb-18c1c1261479", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "73e0309b-1f1d-4b05-88b1-fec1fe618834", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1761), "4ae1304c-dd36-496c-a1ab-7c88ea4902d5", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2f11ae0-65f5-432d-8063-4031fa741d44", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1811), "fc8f357c-b345-4373-90df-720e83fdfded", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce6c2c0a-1e00-4084-957b-893cf85812cf", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1853), "7391f852-b519-4a44-967e-b2d7342af6ca", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a4caa17-0641-4bc1-b0b5-d4ce175dc667", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1864), "8232f345-e16b-4e49-baf5-c68a73b2b667", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b43dc87e-0c7c-4662-90f0-9d73986f1d10", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1877), "c0576b58-4dd4-45f7-bb09-7e7fa0bfdc67", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "31a3f414-62eb-4198-9deb-1103ffc5c563", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1888), "0c906028-f35e-47b5-bde2-b1cadd614237", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "630749bf-410f-40e8-ad75-9da4c7224f49", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1908), "f9f779a4-64d6-47d8-a5bf-dc688ce9835c", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cbbfbc86-797d-4e3c-b14a-c01ec21110d0", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1919), "a2193aea-11c5-40ba-84cc-902bf01d390a", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c0520521-c31e-440e-85db-70969319b5cf", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1930), "0087119f-6bba-4b10-970c-9053a4d09f8c", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b465b44-0a6b-42c2-a99b-32e36c5e9a2f", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1942), "9e42836d-36a7-4e6e-84d3-c99ffb33a5f0", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d8e7927-613f-404c-971a-9868f7e0ddb8", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1653), "a25b17f1-a4ca-4279-85b4-b270b3cc7201", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "636ec2c9-b75c-4e2f-ad26-d122e55fb379", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1954), "7de33a6f-973f-4478-8cfa-036108fba17e", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c0af7bb7-75a3-4e2a-a4d6-532a6953caab", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1964), "d59e091e-5148-4b2d-875b-bd4730b066ac", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2a60f30c-f76f-41c5-90da-46cacf1013ba", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1975), "f5dcac93-e3c4-4101-b9b5-903d8b77cc8b", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fa318b7-1f4a-48c8-86be-e75a2ff7a964", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1985), "ae02e06e-ad1c-471f-80ff-9811df3a635f", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c2e89cd-14c8-4100-aef8-7ebea062af8d", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1995), "8b1aa000-b4a6-48dc-85fe-ba808088f3d2", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2746e389-7766-4b12-b7a5-b34f77a64596", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2007), "6b2e0f66-dc03-465d-b2d5-0d926585e4cb", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a73279f6-0ae1-4c38-9d8f-8f96b34fe86a", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2017), "f1804394-38ae-4459-87c7-56a40c7bd1a9", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1973775-817c-4182-95a8-5821186aec4e", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2028), "beda8aa8-aee3-41cb-a233-aea1bd87c8d1", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f377f9b3-37fc-4e0d-a146-87e7bdf9fed9", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2063), "1a862171-fa7a-42af-879a-4fd4411e64ca", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8a1caa2-e26f-4411-84e8-84c1c07e78ec", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2074), "ee5f833a-a32f-4409-828c-333d5549d51e", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dc639b70-2754-4ad4-88ed-a18598b21fd8", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1676), "f949eb90-62d1-469c-9a4f-28d799e965cd", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7fa80f57-a772-491f-80f0-e663be4794f2", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2085), "16234e3a-4766-4597-bb61-3714cc918f4f", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9cc6e976-bd2b-46e0-8c12-058eed68f676", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1688), "3a016547-4e22-41a6-b340-62867a41de45", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d0cd85e-6dbe-4e5b-bee7-9ae8637cf208", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1698), "c025f4ea-8902-4240-90de-c35089d5ccf0", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf3917b5-5593-4ff7-a634-4d59759d0e63", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1716), "1527e42a-b013-43bc-9c72-7df29114851f", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5c1b7d3b-5a39-429b-88c8-b10d4aa0a007", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1727), "0d69fed7-4d69-4f9e-9edd-b5f32e7411a2", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "022445a8-4c64-411d-bf1d-051d98afb505", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1738), "3159c665-5c20-493a-a32f-5ec7ffed6ce2", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b9945d80-1b55-46bc-8337-23eddfa1e485", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1750), "8a6c0e62-e918-42c4-9665-86136660167f", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1750) });
        }
    }
}
