using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Sixteenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "GenericProfessionals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "622144d0-4ec2-4230-b440-023ec1b9f1ac", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9397), "ca970fc4-2e00-45db-bf52-c7346aa9e3c3", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e0204ac6-3762-47e2-8c78-d7af8377e822", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9589), "c1249403-3ce6-4a94-ac4f-024855439343", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "22a0908a-2907-4bfc-80af-869f10ee5824", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9600), "d7452e99-757e-4501-ac07-c78b96c697f9", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a67a87b3-7e0e-4d7a-9e75-e516ea57bec9", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9609), "a3029ca2-20e8-4eee-869f-138ceca2477c", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c14727d3-72ce-46dd-be2d-2aed20aa4a8c", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9618), "c0b2c965-7280-446e-868d-b4b8449b4884", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c78f8c18-e4da-40eb-9589-26998c1d4c20", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9630), "9a5b532f-1396-496d-9c74-69714916b182", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9d9746ec-02a8-4808-be08-3e6c9385cd3f", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9639), "1e656c19-544f-4916-ae36-22e4e95f60d6", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dc929783-0ae0-4a65-89ae-10b33dabc354", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9648), "673ef6b2-52bc-4424-8e28-b489cf5211f0", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "055c1450-2313-4ab3-9cea-0c3ba911eab1", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9659), "8435b865-6a55-4439-aaa9-ecb1d279b53b", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0ed18b4a-5979-4a3e-930b-bbdeb4c45ff4", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9668), "2fa16da8-59ac-4476-83ca-5ffc5472f15d", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "beb9b916-6942-498e-9f9d-6b18c4c54e15", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9679), "3a5e9465-e914-4400-8e65-a90e82bff189", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fb9c1b2f-884b-41df-bd28-ebf67e0d0c8e", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9455), "9b0d7c05-1e31-492e-b53d-417b43cd06d9", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ecc49d67-09da-4dd7-af1c-0097bdbcc8a2", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9687), "085bef0c-75d6-4b72-be3d-9ca94b2ca9c2", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ef329b3-fbcb-4597-8c97-82d4a3386ff5", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9696), "e0781f72-b3a4-43e1-b5ec-beb28d0e0344", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8eff6777-8032-4bc6-a215-a0c4c627418a", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9707), "616ce9c4-c84c-41fc-9388-0eb679fc9b8d", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "92d3eeb5-b6b8-4502-9f39-09d2e6339a0d", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9716), "b3fc093f-675a-4167-9cd7-627864d04f76", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f2f4c444-0680-4d66-ac75-c58e9f3b6b6c", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9759), "21b56483-d305-4b96-a4ed-2cfc74283917", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f6bece90-a189-4e6e-86bb-f67545a3d92c", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9770), "b91f7f39-a4d9-4f03-9c67-da976bebb8ca", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "666bc4a2-ef24-43a7-8901-9578a66fea2a", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9779), "415e2de7-440c-4aef-b71d-d3af6977308e", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d6e717b3-3241-4698-9b03-33fafb4147b3", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9790), "2d56ac23-728d-4810-9438-b2e04fa2652f", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a093bf56-820d-4aff-a0e0-0e74cf3c1812", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9799), "894292c4-7d63-4736-a95c-59e1d6018424", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "455d9c2c-889c-4711-b491-b40b0d90bcdf", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9808), "78bc6178-c91e-43bf-812e-4fa1db170ca0", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "779a20c6-1640-4853-a0dd-a6c6529233a1", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9478), "fb075b2f-f299-494a-855e-2a3188ecc3b1", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "11df12da-7a62-46b5-908c-d85d9ac00dc4", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9819), "b845f894-2565-4819-aa1c-1ed7b4526fb5", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2a6de335-d9b7-41f5-af29-70e4438e79db", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9487), "6b6a427b-7fec-4470-ac45-be65634d8b72", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "436b9ac9-43da-455d-851d-91b24dece568", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9496), "edf577ff-9010-41e0-8992-4dc673087165", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90e33cdb-3293-4d88-bde5-a5078e27c2b5", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9508), "5cd51c64-a7fa-49a2-848f-7007f08e1c98", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "27af92ba-ce64-4c41-9e7b-443d0f7e6a5d", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9560), "cd3610a5-6410-44c6-bfa2-49eb830c7346", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "871feea9-1736-4be0-856c-9ee0d83b85f8", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9568), "8e413030-e579-41d6-9ae0-435ea1ce2dbb", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e5006e02-2d40-4c8a-a122-ee0a02292d66", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9579), "824ad678-eace-47d6-bfb1-154c89a79f83", new DateTime(2024, 7, 31, 20, 5, 36, 515, DateTimeKind.Utc).AddTicks(9580) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "GenericProfessionals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "014ebe22-bc7c-42d2-bfc8-0ae78b855d47", new DateTime(2024, 7, 30, 14, 0, 58, 983, DateTimeKind.Utc).AddTicks(9962), "601f6a10-bf39-4228-a6a3-5d62e36145bb", new DateTime(2024, 7, 30, 14, 0, 58, 983, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c2a4d6a8-1686-4308-8226-8b8403d43be0", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(152), "235adac0-1c7e-4dde-b88e-e7117a60a0f0", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7d951eb-9923-4d9d-8850-4ba1acdcc00a", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(163), "aa1fad67-206d-40fd-9014-0dfea9117771", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4e050584-948b-44ec-aa33-a892aa321d68", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(175), "a6b6a316-a2dc-4d3d-a1ba-708b813cc9ec", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "055716a9-00d7-4743-816d-9bd225d3d8ac", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(186), "7a8a4d70-9330-4cc9-b045-dff59a8383af", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4dcb3a90-3e9b-4f59-a11c-6503e40ef2ad", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(196), "266925bd-04af-493b-8c65-0f0746a6392a", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b573d528-a36d-4836-ba87-09fc2db47d92", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(230), "19ead207-5edf-46ea-a7a5-3bb0b973c7be", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7d9074c5-a83d-49d9-b363-558dd9001d90", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(241), "f0370ec2-5f50-475c-b142-84639179a6b0", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "101f3dfe-2576-4195-8c27-7564f503c5fc", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(252), "368f9986-403b-40c2-93ed-432d01e79974", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aec8a4ed-bc82-4c4e-b83d-61a10cbb330c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(264), "cb4879ef-55c9-44a3-ab11-2a11b07d9944", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "80e8bafe-86cb-49c8-919d-b2faed77392c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(275), "17843166-3617-4c85-83ce-09188d8b3651", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4ce3df16-586b-4e83-b42b-bebe4256e12c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(60), "b648bad1-ae28-4768-b246-2f2b56c6879e", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "86e397d0-86a9-4f1d-9884-5f54f02a5745", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(287), "b83a7cff-3fbf-4a32-b080-de42735afa86", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37cf6df8-d304-47c9-af82-a663aaee8a58", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(298), "73f09d8c-e698-45b0-964e-e3a1b40c5ef4", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4479aa32-bd3e-4cbb-bf4b-d344e78738fc", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(309), "f94b4e2e-4c98-40e9-b375-392c8993bb3b", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c373572f-77b1-484d-9cdf-9bf310ca429a", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(322), "f577b22f-4b79-4ab0-85f9-d565a8565a8d", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "65eff5e4-2777-4c52-8ee8-92c9b6267d94", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(333), "58d28135-245f-43f0-b173-b115dd02bf07", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7c0be74e-7be8-4abd-abf0-ff6486f2219c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(344), "53105d48-78a2-456d-baa2-0527eef8bb43", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "35efee7c-ab37-4e30-a781-4c94c36e67d1", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(355), "78891687-ee6d-4220-b3b3-a1dcd5536e11", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68384481-50a3-4861-ab3e-4d032f2b1588", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(366), "ec261054-4080-4b9f-a92b-76942823f49d", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88caa875-cc8e-4130-b74c-758bc8afac73", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(378), "6ed44a2f-cf8a-458b-9373-cf571f6fd4ef", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "df0ae504-4363-47f9-b1eb-d7d9c5fb4384", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(389), "26960c1f-5b9a-489f-bffa-67f0869e015f", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e3cd2ed-5947-4e18-8d66-cc2e8c2fe636", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(72), "c42e8333-239e-4502-9a16-09f6d2391c26", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4cb176a1-8c1e-479d-a413-705bf9e29616", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(399), "4cd6d7d6-d7e1-42c0-a67a-7eabb0036829", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9b0788b3-b2f1-41d3-a54e-6d6f2cf04fde", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(84), "3707f14d-d5d1-4696-ad8c-3979eadc69cb", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b32219f6-0fab-4855-a33e-45378f48874e", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(95), "649e8ac2-cab4-4d49-810c-72c09039762c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81a44a90-2a99-4819-b840-c628fbf134b9", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(106), "9d726bfa-f21c-424b-9830-e5c31de26335", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5d26ab5c-ed6e-4492-9cbb-1ac17104ce16", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(118), "98ff433b-7f96-4d63-9db1-872a4968c93e", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9002754a-031b-480d-ab41-c2baa6586f50", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(129), "84c3dc31-a174-4a9d-9e44-407923e4eb7e", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "80e6ad40-c567-43de-b00c-408d0fa2059c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(140), "b84c74ec-949f-4f1c-afdc-e59087f099db", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(140) });
        }
    }
}
