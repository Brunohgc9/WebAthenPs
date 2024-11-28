using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingSendFilesAttributeSendAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SentAt",
                table: "ChatMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ddf1b62c-3067-43e1-9165-8bd652650a6e", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(7901), "b9c50882-43f7-4b51-b35a-5597e7b4c9ea", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f6b0ad25-2b33-4d20-bf8c-689691a1e93d", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8147), "f44f6d9b-8867-4f7c-b2ed-54abdf462388", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e37564d0-9df5-4b30-a882-e270329215f1", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8193), "903ca127-8107-420d-ad2d-15c396976d09", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "79f8f8f7-8f0d-462d-891e-8e18e113754d", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8210), "15a62f64-1a9f-4bc1-baed-70ea1bacbd12", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "418f545b-5a28-423f-86f0-0de6ca140d53", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8223), "667a7bff-44c2-4561-a2db-b9a03a8b84f0", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33bd4c74-f459-48fb-9fbd-44ca4033933f", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8257), "9539f69f-4f89-4d3d-b572-aadf052528af", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "40a3729d-c113-4215-9b51-026d378e64a2", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8286), "eb0e9f29-0515-46cc-9cd2-942a601fda6d", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d45ec106-66c2-4ef2-b2d7-1dec71ea424b", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8302), "7047bad0-4814-49f1-b862-f43ebd4b4a7b", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44b9295d-a075-4db7-854e-e294cd4e94ba", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8314), "bc9b3c65-22ac-4f2a-82d2-7c7b5c904363", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2d16d3e6-0b7c-431f-9dba-01d482e37f7b", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8325), "458ee24e-e3de-43f5-b0bf-611cb21803ff", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b4c18190-b5bd-4a33-964f-76f82f8ee586", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8338), "85d8b1eb-b875-4e47-b482-ee4ed85843f9", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3f6f5d01-3e65-4d0d-8bd6-4b393c62a29e", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(7999), "3067cbe2-ce91-4830-a326-0f95c1987a00", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce4c7a74-687f-4930-b250-17a5e8b92f9a", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8349), "d5e560fc-f5fb-4229-a10b-f0092dc1d8a6", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d73cb56d-faca-4821-b7d2-4803cfec9380", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8362), "28695dde-9df7-409e-9fa8-9f30e8f5c818", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "47c7bbb6-a71d-4d9f-99d9-b7289fa6b421", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8374), "e1ec768e-9bb2-4538-91d0-0822d1c2add9", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "11b08d8e-ade6-48bf-a947-fb02204287a0", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8385), "8d9489b1-d926-4d4c-a124-2adeb5d7f4ee", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81cd45f4-8f7c-4707-b38d-254a69964f05", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8397), "a0d9f28d-475b-401d-b3ac-4383672f8b0f", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "456ec3ae-1402-4a72-a15e-175994b90946", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8408), "6c8b25b7-0751-4f5d-84ea-ebae6299d182", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c3bb86bf-3180-4c64-aa03-156512e891ec", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8419), "9a536a68-d542-4365-a888-5d64c2b8f957", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "189bce03-8867-4e14-8e77-574e7d083221", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8431), "630f41ab-cffa-42a9-8971-1a94c27f5e9b", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ecfe59c-18a7-411d-af65-53d4339d6165", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8442), "fc52bc89-7cd5-4709-a65a-354567507a94", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "065fc09f-a429-4ef8-9268-11a728bc48b3", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8490), "420bf6fd-d436-4e94-bfea-5c3526d0c4ea", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "45b123e4-e8e1-42d1-abeb-ae2353c48294", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8028), "3ca276d1-5ce5-4655-ab1b-b8c78a7fdb7a", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "15abb822-156a-4d91-a509-8168e2850c52", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8502), "a0a480a5-ff98-44d4-a038-1165c33346d6", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9364924f-49a6-4dcc-b396-47549ce98a6f", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8043), "59e97706-1c1d-4b13-a592-081841d7f7cd", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a8f12e64-15b3-43b2-ae31-0cb179e69b67", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8063), "963374be-c49a-4922-a5e1-b5905ef7aa10", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c251a2a8-b973-4ff7-87da-0d7530ad9992", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8085), "48056b08-8b13-4b36-8280-4587f78d96d9", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "125002d7-bd41-429b-9982-6ff66657a595", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8099), "93f5eff8-a4cc-4a82-942c-8668154499d1", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20d019a8-2f14-4fc2-8f05-2650c047f4a1", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8116), "ca48086a-66c5-4b49-9741-143c18d80e8a", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "26e5634e-7da9-4fc4-a679-f7cc0dc40a5a", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8131), "9667fb8f-260c-4eeb-8187-530d304b06c7", new DateTime(2024, 11, 28, 3, 22, 51, 740, DateTimeKind.Utc).AddTicks(8132) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentAt",
                table: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dfc81fb8-1a3d-4aba-b7e3-58b843e83434", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1789), "41879017-3f39-4e36-b17d-e7f0290866ba", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75f9cbec-f736-4261-82ee-678d1b367cc2", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2042), "a2db8181-7f6f-4cc6-8353-09e4c4b3f40e", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b8d31d6-ca6b-44e0-a3d7-bdca806b6103", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2086), "306a31bd-8929-454c-ae6a-4ce5c554f806", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2ffc2d2-cb37-4ff1-a741-66a9eb0e72c3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2098), "c1365542-37ca-401d-9e5a-ff46b3776ae6", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d303c530-f324-4fdc-9ab6-29a58825f709", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2111), "211d942c-9af8-45fb-b9fc-f8553dea2d26", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7367c942-b09f-439d-a1f8-c252b9e47969", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2125), "266c7f3c-4685-4b62-adcc-4c23be20a19b", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f280ffe6-0a5b-4fe8-81cc-dd620fbffd36", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2142), "1e455f83-8eba-41d7-94b3-d00f818ec96d", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "87034b00-fc7e-4915-9346-5b83afca74d4", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2162), "774454f3-93cf-4bd3-a142-07d70bd0359d", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "55a40266-117c-4f67-8811-b8bd852042e6", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2174), "e2834924-9216-4208-af90-c6fd1774bfc8", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "40180ad3-ee3a-4ac9-9491-e51112b02c30", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2184), "e667d482-e29b-48cf-a1ac-7aaa3522a5de", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7374c254-6987-4a5b-a9f7-ab0e443f74f5", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2197), "f135a10d-b2f3-44dc-904e-ee061d6fec79", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d2a7fa6f-c952-4838-bbc4-4f0ac02fce33", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1892), "6e74bff9-432a-48ba-b6df-b46d3f2b13f3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb31fbb6-e6c0-4646-9b59-fc0d6c3ad903", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2231), "0c6d987a-3fd6-427a-8550-11000d609f53", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eafdf10e-90fa-48d8-8079-b40a63c08b95", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2242), "9bf59d43-0d96-4360-8275-98250f0e19d0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aac2c689-c59d-467c-a128-d2683f1d3ff7", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2256), "1b180ea9-0bba-48dd-9939-2a9565615fae", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0ab214b9-e729-4279-914a-7192e926725e", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2267), "4070d334-85c3-4ea4-ad34-35bebed730fa", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d39024aa-a55c-45bd-8323-7478667e1450", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2279), "c712a033-7342-4286-8dfa-2f67b6ba4b9c", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2a209a38-7eaf-4860-a9fb-86b5004f36e0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2291), "1c011fd0-ae57-4ab3-a707-e1763b462870", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aea8c860-2430-4aa8-bea9-738b1986ec24", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2303), "450ab7cd-40df-48dd-9bb5-8df0ec410ac8", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb72a960-d360-48ae-8c63-77da04ef74e3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2316), "acae9de4-2bcc-4888-8c9c-841c2a326207", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ce36e4b5-16ac-4836-a2f2-6f32bedd10cf", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2327), "af82ba72-d252-4cb6-bf92-9430df650f12", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d0b7b2db-8b53-40ce-b29a-72282a98ed61", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2338), "f777ce37-d582-431e-a1d8-03df3d2fa021", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e6e66544-7e44-4553-bd48-c42beec656c8", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1915), "875c8bf6-d4e2-4561-96d8-11fb264beafb", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a858b968-95c6-4944-8730-5d056fabfc60", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2350), "e0317186-7ee9-469b-94a7-8f8acd85d4d3", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f349f72-234c-4d30-9e63-3c59978d2706", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1953), "12b0cbda-7486-407f-87b1-9a28f5da1980", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "97532f9d-3f9a-4fc1-99cb-7fe071137431", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1968), "8595a2f3-84f2-4b67-a63d-d9056019a41c", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b35fd091-e221-4715-8c5d-b8f681a9a264", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1995), "a84c134a-f151-4603-aeff-13a8d6b4a3c0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ed693dd-2403-4267-a385-c50f1a10c1d9", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2008), "6bc348db-1d63-4d3d-8257-c9f42d07210e", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4d531aa1-01dc-4650-8e93-010e2977eb2d", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2021), "b79bc398-133a-473f-bd8c-839b192cb4f0", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd982f3a-7b43-41cc-b1d3-84834cffc40a", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2031), "db3575b9-1fec-4f00-b5d5-562255b6b424", new DateTime(2024, 11, 28, 3, 9, 19, 731, DateTimeKind.Utc).AddTicks(2032) });
        }
    }
}
