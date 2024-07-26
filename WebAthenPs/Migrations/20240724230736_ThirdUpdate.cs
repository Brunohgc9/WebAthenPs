using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class ThirdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_AspNetUsers_UserId",
                table: "GenericProfessionals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "62c988d8-e69f-4f90-b611-97d485055ebc", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5645), "741e1ba0-55d8-48df-b597-b36ad44b7c58", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c398877a-2a6d-4080-93c9-43cf971fa0e0", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5818), "7b84997e-0b59-4b71-867f-be5e84e19b95", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d1c5d3ab-a6c9-43e0-8d3d-f96967240bfa", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5829), "521b0590-703c-4ccb-9183-2f248eddeeb9", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a34a6bbd-5cb3-48c5-9e5a-1a8fc5e8186f", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5842), "717e0f7d-0446-433d-8541-6ab09715a19d", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7ff7a53-c50c-449a-9a01-7f06bab7abd0", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5853), "942fbb6a-40dc-4c43-a7cc-c236948c953d", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74e74d78-6043-4bf4-bea1-0d3272a7df62", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5865), "a915c174-9761-41d3-8533-720180e69178", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54469a42-80d5-4260-b068-6ce9fb126d79", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5877), "de2ce729-9e0c-4e97-8ce4-2e25eb8d0b7b", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "22f08fa4-ae2d-4a1d-a68b-132ce5084b0a", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5712), "bad03f78-f8c4-43ca-8f73-8a7d30caefba", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f755cddf-13b7-4947-a551-1ef67022a052", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5724), "9f00cda1-f239-484d-b141-9fdfbc64c70c", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6cb90547-acf6-41cf-8edd-61ee1643642c", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5744), "fc9ce383-d2fd-4faf-ac80-d14ea6da65a7", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "00d9697b-1658-46ca-aa5a-ee163cd666e9", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5756), "9375db64-7f59-42b1-b34c-ccf8c54e0c6a", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74d12874-5c0c-4d1a-b0cb-800723e0f930", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5769), "49f70c75-1f2a-451d-a13d-c2dedc44dd47", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "57773aa1-7bab-4c64-8d5e-e547e94448d1", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5782), "e1461c61-0d9e-448a-8815-06aeb3500a55", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33212fd2-9a89-42d2-b2a5-c44165563a0b", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5793), "9dee6fbb-d4c7-4c2e-86f2-8ad96605c3a1", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "521d7cb1-fd36-4f8b-9d25-ad29409afd41", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5806), "c058d2a5-9882-4ed8-a3c1-10e9e9b53d13", new DateTime(2024, 7, 24, 23, 7, 35, 758, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_AspNetUsers_UserId",
                table: "GenericProfessionals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProfessionals_AspNetUsers_UserId",
                table: "GenericProfessionals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2e2b229a-da65-4da8-b09b-42bee3617f50", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8528), "0588f39b-821f-4fd2-a732-01de8dd7d898", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20746dc2-8317-4f7c-8f6e-7615900441ea", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8689), "134fa86c-6d63-4033-a080-facb8a3997ec", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7d22b665-23d2-474a-9e0a-2808b76b6198", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8701), "d31119e1-94b1-4ed9-a917-87bbdcc30fc0", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0953d18a-3123-48f5-91a3-6ac3a1011551", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8715), "075f2942-07b7-4cab-9cef-e130cde56e8c", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6d70228d-7e84-4e78-b579-d7593a5e6be3", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8752), "46e6fb03-bc2d-4059-b8a4-281278129072", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "717e0f27-3e6a-40ba-8e99-4465a299948c", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8763), "348a818c-1ead-491c-9796-4133d4d5eb19", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4f11e8f0-86cf-4dd2-82bc-8091eae9e333", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8777), "958a6b71-0153-4872-879b-7c2d576708c8", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cad86cf0-e030-4c8a-ad74-07b66bd2b366", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8581), "64898d2f-ddd7-4cfa-a187-60bc1bdaaac5", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "03c4823d-399d-447c-b7b6-b2cab4ebba22", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8594), "29938d5e-8755-4a4d-87d8-96db5e2aae04", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b0bd6acc-e57a-4290-97d7-6ec211dc2d1a", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8614), "68a332ce-a349-4c5f-b5ac-88fe4b346979", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2fafd37-58de-41ce-9483-07bc8516e47c", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8626), "34a47a64-5ad7-45b6-905c-6018bd2d1c27", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef764571-2be9-41d0-9a31-956e0b176eff", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8639), "800389f2-3c5e-494d-b35c-07ccfde3adb6", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a24c1d2b-6232-4639-8325-a9f2d9032513", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8652), "c4a806ca-c24d-4abe-8baf-c49989751936", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2bfa580a-b8c4-496a-ac79-5ec04b0d0b8b", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8664), "2e3e5eb5-5dc2-4241-9c57-57117be345c4", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "820c67b8-5eeb-42b0-b78a-d6acc0da0cee", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8678), "5c183c3a-ad5b-4e3b-ac7e-1b5d704bd159", new DateTime(2024, 7, 24, 19, 41, 9, 790, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionals_AspNetUsers_UserId",
                table: "GenericProfessionals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
