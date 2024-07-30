using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Fourteenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfessionalTye",
                table: "GenericProfessionals",
                newName: "ProfessionalType");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalArea",
                table: "Projects",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRooms",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfBathrooms",
                table: "Projects",
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
                values: new object[] { "43ee8865-9456-490d-a23b-e61338f69034", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1077), "751bce85-f5f6-4593-bd0d-890f0cd73da2", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4a03b176-22f4-41f8-b1d6-c6939ada3da2", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1242), "dcc8860b-0b46-4c67-8844-4430d76d0653", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "21e79358-0e18-4d9c-b4cd-d235764d488c", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1253), "ba557920-3faf-4244-9b8c-22413a24cf81", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "17bc040b-5a78-41f0-93cd-8fd5bf9b5fdc", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1265), "57fd4bf1-e4bf-4e92-9778-005ac96c0449", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef81655a-0a89-4427-9ba8-7b6c8aab8189", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1277), "548c1164-ba42-4933-be0c-9f1e91dbcc81", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "503fe4e7-7d05-4e18-9efd-88df5c7631ee", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1288), "5371bebb-8245-4e48-906f-8b1cebd350b8", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f916b96-d8e5-4c5d-85b2-5ec88464d953", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1300), "8fc97062-2abf-4f7c-a9d7-c1a23701f827", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e89267f2-0c4b-4ae4-9af2-cb8c5299a808", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1148), "e6441bc7-12ae-48d8-a9d4-631bb451db4c", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1cddcbb0-9fed-46fc-863a-7a0b5937c858", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1161), "73014813-04e5-4f89-b159-88d45897a978", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a5fc741-4451-412a-bd97-7b23808cae1e", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1172), "59923096-13a6-4fb3-a754-04291661191e", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19c6b37e-c403-4fb8-acc4-0f67229fa91a", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1184), "cda320d2-3b38-43c9-a3a8-535cc5dd5c68", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0ffad964-47be-4707-ba04-e59598eb1320", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1195), "a4abd29b-d5f1-4041-b586-b29c7680445e", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b388425a-29e0-45ff-be83-b1e5cb5f601a", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1208), "2bd5c7d8-6c61-4842-a426-2a6090528d34", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05dde34a-eb41-4ffb-918e-3d263d87d998", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1219), "a528d58a-e582-452e-a789-c2518e34b41c", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b7768239-43cf-49b3-9dd4-03523259ebd5", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1229), "33e89c13-7e8e-4ecd-a605-54658eec5005", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 1,
                column: "ProfessionalType",
                value: "Arquiteto");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 2,
                column: "ProfessionalType",
                value: "Eletricista");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 3,
                column: "ProfessionalType",
                value: "Engenheiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 4,
                column: "ProfessionalType",
                value: "Pedreiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 5,
                column: "ProfessionalType",
                value: "Encanador");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 6,
                column: "ProfessionalType",
                value: "Arquiteto");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 7,
                column: "ProfessionalType",
                value: "Eletricista");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 8,
                column: "ProfessionalType",
                value: "Engenheiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 9,
                column: "ProfessionalType",
                value: "Pedreiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 10,
                column: "ProfessionalType",
                value: "Encanador");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 11,
                column: "ProfessionalType",
                value: "Arquiteto");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 12,
                column: "ProfessionalType",
                value: "Eletricista");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 13,
                column: "ProfessionalType",
                value: "Engenheiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 14,
                column: "ProfessionalType",
                value: "Pedreiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 15,
                column: "ProfessionalType",
                value: "Encanador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfessionalType",
                table: "GenericProfessionals",
                newName: "ProfessionalTye");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalArea",
                table: "Projects",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRooms",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfBathrooms",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5bac82b7-a725-45a5-878c-9819164e8dc4", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7505), "767e202b-dd56-43cd-a8ea-9c867412726b", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "45429808-717c-4b00-9079-f1b79295d790", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7722), "ce696f24-0986-4a17-a124-75ecca457ce3", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fb8dc8f0-c9ed-40e3-a605-02d1d9e000a4", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7733), "ca314ec2-1b8c-411b-8f87-697fe512a6a1", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e2648c2d-63d7-40dd-b59f-92001f7f2de8", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7745), "2f83090b-36ca-46e3-ba1c-fcca1b48218d", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fad8c9fe-b057-465b-a844-16ecb69e6016", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7756), "6978cce7-466a-4ad0-8fce-6fe4f83d731e", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ca00da0-d9a2-4b8a-bf2c-8058863aa77a", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7767), "353aa517-ef04-46e7-9f5d-31573b14badd", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "62b9ffc5-516c-4212-8f8e-a54b486ec94b", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7780), "693c1f8d-f611-4801-bd80-3471a1365a14", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6ecf0573-e26c-42fd-b471-eab575a0d2ff", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7561), "f44a6383-c3e7-420f-af7f-f96188f75150", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "01342379-1530-4c33-956b-f90a1cc9eb91", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7573), "96b5aae0-7d9a-4dfa-b62e-63a88a586af9", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3b9276cf-4e4e-4a55-9c47-15041b4cd695", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7595), "f309c352-78a7-48a5-9346-9e6cca2d533e", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b9ef2bf6-fc8e-4d01-9000-5d5439f70c6f", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7665), "d51680dd-0058-4427-8457-9909e07261c6", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2bee6bd6-2b14-4d78-a3fd-0b6425d5214d", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7676), "7fcbd9d2-1ca8-4662-8dde-bf232623129e", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c657950c-5d26-4ed4-ade6-539b87ba85ce", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7688), "0b765117-8238-46ea-9510-3f9024f82ce8", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e09d8561-484b-45c0-b7a3-1ebb86915bf5", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7699), "7a3624aa-96a9-4c62-9531-093016797a4b", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "74ff7ab2-19d8-4458-bec2-8e9570e4e3d7", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7712), "8f8dcc18-d375-4112-9d58-b1409eb1631b", new DateTime(2024, 7, 30, 12, 30, 54, 704, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 1,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 2,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 3,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 4,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 5,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 6,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 7,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 8,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 9,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 10,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 11,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 12,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 13,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 14,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 15,
                column: "ProfessionalTye",
                value: null);
        }
    }
}
