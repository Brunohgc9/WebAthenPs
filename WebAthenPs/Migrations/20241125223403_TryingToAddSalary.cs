using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class TryingToAddSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "ProjectProfessionals",
                type: "decimal(18,2)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 3,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 8,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 9,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 10,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 11,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 13,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 14,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 15,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 16,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 17,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 18,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 19,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 20,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 21,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 22,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 23,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 24,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 25,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 26,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 27,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 28,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 29,
                column: "Salary",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectProfessionals",
                keyColumn: "Id",
                keyValue: 30,
                column: "Salary",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "ProjectProfessionals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ecea8f8f-78ad-4f28-860a-0f826498e729", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(5998), "e4a16366-3c35-423c-aef7-37cc82fbcb5a", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68ec956f-8c0b-4802-ae00-f746dc71cc6c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6258), "c8b5f3a3-e29a-4cbd-82c6-6d85cd182fd8", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5abbff42-5fc5-49ca-bcfd-80e64893061f", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6318), "ee535c2f-386b-473b-b26d-c75856611a69", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a00d742-997b-43ca-81c2-b063e5c62226", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6379), "ee51587d-04f0-4d21-8a64-35e0b539cdf0", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "51f9f836-879a-4631-ab22-63a8dcde6d59", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6391), "de3f922a-87d0-4f89-adaa-283d73c794cd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19545bee-5dbc-4c03-8176-544b4fc1e93f", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6403), "108d1448-78c0-4af9-a6a6-7fd7a9e2e3cb", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aba1b701-6feb-4076-a881-3cce190f0265", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6417), "aeaa2f44-7455-4177-93e3-ed06c9550de1", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37efbfe9-670a-47ac-95d1-9887ddadd20b", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6747), "664f8fe2-ff0e-44a7-bfd8-f09058c51362", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0f104361-af21-4410-be64-31b26230baca", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6760), "405d21ee-320e-4175-a3cf-bacfa6fc726b", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f964025-ba7a-4c5b-8636-5df42afd35fb", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6774), "31e33983-2f5b-436c-9814-e42db5ef9f3c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b28f3bae-dac3-46ea-b716-224e48cbe555", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6788), "7c618e7b-3176-45ef-b36f-161c3f21eca4", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c5c96c64-d93c-4d1e-8546-9240868a1b65", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6135), "51756994-470e-4a61-8ac3-3367c3534e31", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8e0521f3-13dd-45bc-8014-0e25c2d1bf81", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6801), "8e4c6343-9c2d-4824-8622-1f0ee03de34c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8511b544-1758-4953-8a7e-0e15da1719fc", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6815), "f12b33b8-cc36-4e78-b155-010e43e91485", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "896e66a2-7ea6-4635-893d-276d48a267a2", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6827), "05d5db64-18e2-4469-a2cf-77994ae58723", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a1c53fd-a1aa-43d7-8800-09234e7180ad", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6842), "88646f35-7e86-455f-966b-338671ff8e9d", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36eb31e9-8d0e-473e-8995-f0d80ad45c92", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6854), "1bc2d97e-bb51-4a76-a0ce-695ded4c42d4", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19c228ee-1058-487d-9abb-a178aaa1dae9", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6866), "e98c9362-0b35-400a-9b3f-6d2e9dd40d65", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77d665de-eb36-43a5-b366-7ee0dd2e936c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6880), "e61e52d5-f6d5-4790-ac95-e0bf951d4aae", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88577619-9c37-4161-9105-7a14670eac27", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6937), "0ae65f3b-ae28-4670-a35b-23fe892a901e", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25c5af04-84d0-46b1-b62f-eab6642c96e7", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6952), "ed509a41-9298-4b75-b9f1-607dc76a3d35", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf4b2f3b-fe6b-4300-97c0-63a87850e4e6", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6965), "25b7738b-5f2b-46cc-a60a-47938f992bc9", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ac94fde-d992-49dc-aa17-ba420c93b20e", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6150), "bc696cc4-3cb5-4b4f-8456-9a5c6f760dc8", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "13b5e988-765d-44f6-8796-bde141eecd4c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6978), "c63abbf5-1a79-44fe-bdc7-1d4fc7fa3542", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fcfa88d7-99e6-44a1-b365-b15391e335ca", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6164), "14061b0a-56ce-44d4-a412-d74751f70402", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7164f5c4-76a1-4493-a6ec-63cd4635e81a", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6177), "6c79767e-4f83-4385-9a95-d7041a3b7e6c", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e510e402-b453-4a1f-ad38-f5b241ff137f", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6204), "c4ecabfd-2a06-4d29-9c2f-ee041ec4a9bd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8a2dc13-6e36-46ad-8cf8-432b75a8ee83", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6219), "cac6cdc5-06f8-4d7e-87e7-27df5e502ef4", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2780832c-eabe-48fa-b6e2-c99a9db041a1", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6233), "aed2edfd-3aa6-4ef0-8b25-9d4157e31375", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3dd02bf5-8619-4d15-8404-6b5c0f247afd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6245), "da9fe591-09f0-4866-89b2-fde8c320c6fd", new DateTime(2024, 11, 21, 0, 24, 14, 826, DateTimeKind.Utc).AddTicks(6245) });
        }
    }
}
