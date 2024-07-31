using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Thirteenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfessionalTye",
                table: "GenericProfessionals",
                type: "nvarchar(max)",
                nullable: true);

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
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProfessionalTye",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProfessionalTye",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfessionalTye",
                table: "GenericProfessionals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36865a4b-30c3-4031-98b9-e4bf006b429c", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9288), "42439a04-892b-4dc7-b339-cc1e558c76bb", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ad71f0c-4abe-4084-9506-4a0c6924a51e", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9480), "a669a93f-da71-42d0-9045-3164d4e5f0fd", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "abf5f39c-a430-447c-bd4b-d735ce07ce53", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9491), "dc50eb05-c951-4b06-a5c0-a36e698a9de9", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ae2c5816-abe0-4b83-879a-c75e0e7740b4", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9504), "dbe74217-3cce-4c58-8160-dd277ea8039a", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cde1b1bf-d2e6-464f-a381-7ccebc423095", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9515), "5fe76a55-b0ec-49ad-8661-18ddfcf02c13", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d13158a-e252-467e-9ba9-05fe02ca1844", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9527), "f4b2930a-a68e-4b04-8f94-d2c4886636dd", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7f1de827-a284-433b-884b-f36a7633837d", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9538), "a4dbedf4-21b7-4a61-b001-67f0803f7ab6", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4ae6e24b-bd3f-4181-a729-4c061ff11bb9", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9347), "1468ede0-791a-4435-9438-d968ad5cb4f7", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "af97d056-dbc5-496b-84b3-6eb0bd152310", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9359), "8018dbd1-eef7-41e3-9cdc-2c0c3ad8b060", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f90afe07-1652-40ca-bd9b-3c35b94aa459", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9389), "9f9fcabe-041c-4e35-9b53-943e0bc10191", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "99bb04e1-49ba-49dc-8ce5-4bae0d3b046e", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9400), "67f18af3-afd9-4f09-b96d-4ccb3f6fc582", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7c8632a2-00b1-4a47-8fe2-fead94676d41", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9413), "04aa2acc-519e-44e0-86af-3d2d69aa710c", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d97ffb87-441f-4e2d-9813-702767b7b548", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9424), "79313d8b-2c69-4b6d-8938-2c5e3610e80b", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cbc900fe-7a93-4439-8225-8b612d0e8dc8", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9435), "3e34e0f0-930c-464a-b49e-c39d7d84e894", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9c505b5-c8cd-400b-8ee8-986bada3efb0", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9470), "888049ed-eb7b-4948-801b-f7172b797cd6", new DateTime(2024, 7, 29, 21, 44, 32, 107, DateTimeKind.Utc).AddTicks(9470) });
        }
    }
}
