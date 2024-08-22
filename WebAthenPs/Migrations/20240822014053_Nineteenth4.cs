using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Nineteenth4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c797aec6-fa15-43d1-834b-ecf1a8aba8c7", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1681), "b335adff-f5de-4a94-8662-04a4cb1c20e3", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bd2c31aa-1d36-43dc-a86a-54e38076252a", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1866), "1fcf1794-3d81-4736-9bdb-50425156ac48", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0c4b0f8a-b820-4dc0-b0fa-4e2348c888fb", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1877), "86133eed-4a07-478d-ad08-6dbac521bd6b", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a85877ef-c89a-4060-b7fa-5b07febaeacc", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1889), "249bbba1-3d27-4e15-9e9b-8f9e910874c0", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "39472c3d-faaa-4743-b6e8-9d29f2f78113", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1899), "7113f5f4-6a31-429b-9088-a8782beca22c", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b88eda1b-452e-4af9-9d58-b85c02d88bba", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1910), "f97694ac-27ab-42bf-8bd4-7670446c8f7d", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81394166-0be5-455f-b36f-dc0917aac3f2", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1922), "f1be195a-0f59-4c8c-9fd9-dd14e300a348", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7dc9aeff-ae6a-407b-8fc6-553399c093a1", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1933), "b1749184-ac6c-40e2-b276-f373f656a408", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "08156bd4-c0ab-4eca-91d9-82b5ed78967d", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1944), "1d7d86f0-a62b-41b5-9fd0-f1951f47208a", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2dbba952-8cf9-4abd-8eca-93d10e0c72b0", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1957), "519d03c1-2aab-4473-b11b-419d9250c477", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "32d00245-9488-4f02-88ce-e6fc419d8f13", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1967), "54aa3f96-4d96-4922-b147-bc08440ab0c0", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "66d6856e-5c7f-4884-9591-c273d5818241", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1746), "c1e7d337-0941-493c-86a3-a542d2657b5d", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "08374ff1-c544-4b65-8c83-7a909b61edef", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1980), "2a9fa9d2-b1ea-4cd4-8744-c053f983b07d", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7aed64ad-8d42-4fca-8afa-a8fd7cefa8c4", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1991), "27ff6d66-ad03-4d17-a683-6666584dc2b5", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c149e2cc-6271-4a1a-8468-5e988e63ec06", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2001), "53b47880-7584-48f5-951b-83f59cf7024d", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1f11730c-b267-4e3b-9e17-f83d9597d386", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2014), "2673ffac-35bd-4f00-acbe-c463e2a7d0dd", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "66608f64-1360-4af6-b735-228cd2fb893a", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2024), "27a6ead3-7ce9-46db-8518-9e6793952037", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d956e71-1513-49d9-ae39-3cc55de1609c", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2057), "eb26d352-c5bc-49f2-a477-e26dbd8e04e1", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0629c0d4-0dcb-4c83-83d5-1d02ac0290f8", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2069), "b84c6406-932e-47cc-a304-a24a7592abfc", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "161c5a11-9288-4eee-9f44-77c4361fced7", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2080), "f1b39b39-d730-4523-96e9-8e2bde84571a", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "82da0efd-9cb3-4560-8ca4-1cb35d7dd9fb", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2092), "56c203e4-62b4-441d-8627-467e20fa28dd", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cffbcc5f-6627-4446-8eff-0a880f2a6c5e", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2102), "7d6ceae1-ef24-4677-9ed2-04a6731eea14", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "07c7afbd-edbb-464a-a22b-d9aaa8e717fc", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1758), "87ba8418-f57a-4085-9261-8029520c05dd", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44493e26-d799-49b4-9700-4bb57994deb2", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2113), "b453a9e2-f612-4ab5-8433-c3356de07566", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3688f970-0495-4067-8037-9c63ec82b998", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1770), "d94b4aca-e2e3-4a5b-85d4-aa6173c4f738", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54cdcfe3-2458-48e6-96dc-47dc4302eae1", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1781), "29af583b-f704-4b24-992e-685696b57524", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0f931718-e496-43d2-ada5-782dcb92fe5c", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1792), "42aabcd9-32e0-4541-b20b-2b4adb569859", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4f69e092-76f7-420a-b065-e67f38a87bec", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1804), "8070508f-a1b2-4abc-8851-d2d716d73ffe", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "49ab8dc5-f36e-41c6-8150-0282cb74773a", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1843), "81170073-c245-4964-9482-3c4daf6302d9", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2a8b755c-f9d1-498c-a73e-d4a1202fd13e", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1854), "c067789f-99a7-41e6-9a46-bdb58f746967", new DateTime(2024, 8, 22, 1, 40, 53, 89, DateTimeKind.Utc).AddTicks(1854) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ed300cf3-1ba6-47f1-a745-40b92a02f19b", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7543), "90965101-8cc7-4dba-aca3-49542cb7e6ea", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d62b3280-17a8-4d2f-b610-55ac3cb405ea", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7800), "4ab15192-b09a-42ab-93d1-f7f4bd4dd2c1", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "49eb2863-820b-40e7-990e-a8c80d8fa267", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7812), "483ebdf2-d28a-45fd-86ff-32e81b08f047", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "493469fe-652d-42b2-a729-1d203e960e3a", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7824), "722fc433-cfd5-4500-a794-d2a96329c0b2", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5883ddf7-2bac-4214-82c6-421f809384b1", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7836), "1b9c7e14-978c-4047-bd9b-c9362ef49712", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a2a7506-ea82-44c5-9f55-4c7ee7197310", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7848), "70127c49-06b1-40f5-a794-8a7c97f8ce58", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0ec1f8a8-5afc-4a9f-9b85-f47d869797ec", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7859), "1da8cf6f-043e-4f9e-a2f7-14b1780ded40", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e31b7583-ad79-4f27-8379-9889e6645be5", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7871), "4c96a994-60ee-4278-967a-63837ae0dac6", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "04bab474-da70-437b-b1cc-8f38792cf956", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7883), "148df0bf-691b-4855-b392-684e3c65ef68", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3af2aff9-5268-4318-88bf-1f01babd3da6", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7894), "26b65fc6-56ed-4a0e-9583-2e7824d1cd89", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "51c65fc5-02d0-4d32-965b-6a7e0b8262a1", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7905), "c3fbdc23-959d-4ea6-adac-b15670bfd9da", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2224e74-bbe8-4aa1-b147-8fa5bdfeb480", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7596), "705ebc57-3211-41a6-af35-76b19ea05522", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "87147dc5-4e80-49ce-98ac-150b86ae04a3", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7919), "a1d2c235-efa1-4f65-9f8f-afd61d1b8a15", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f746028e-c42d-47c9-bbf6-dba215a603c4", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7931), "2b1a2c8e-15d5-4357-a8cc-310c33b8f626", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b6c7b19f-6f56-4328-8e2b-e4c356de48a1", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7943), "3ecb443f-f5a2-4607-8ff3-138bcbf332d7", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "22d7a096-1767-43ec-b15d-d458ba7494c7", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7954), "48c4ac24-9d71-463b-8fd1-d0a728d8381c", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d9c5f3a2-741f-479b-997f-56e05eaa2ea8", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7987), "f2d1f2c1-a836-4c69-9867-1d89021378af", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cf6ce25d-48d0-4708-b564-b2f6a9c93304", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8000), "56dda923-a9db-4936-99a8-bbc03e04e34e", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9e2871ef-da95-4300-9c96-b823eba7e12a", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8011), "6e336388-e183-4343-a346-70eb30c69e76", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "46266da8-7f3a-4f45-8c84-1156adc87d95", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8022), "ac1c4ee6-d571-4a4a-9627-e1ce5dedc946", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "620bdf0c-c9df-4950-b327-72bf6c307a81", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8035), "f0311a71-7fc1-4792-a36e-21b88eb489ad", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c25e54fc-0594-43ee-a4ca-6ab2696e9f86", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8046), "3ff52299-9d9b-41c6-a82b-42b5c31d779a", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dc6c9a86-d613-4ef9-af41-06f3b8831036", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7609), "2dca784a-533a-448a-8347-8f8378485058", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eb170c49-4fb1-4ea3-9ddb-f12196ceaf45", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8058), "406026d8-2d46-4ab7-bdfe-ed66d1928719", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1c95ba4e-c9e2-496f-84d4-688aabc9adf9", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7630), "69acbc5e-d489-4523-a924-c94fcc195e4d", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "89dfde24-a876-4c35-8121-11fdb2217d5a", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7641), "4b934423-69d7-4699-80e2-cba2a48beb19", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7af103a9-06d5-401b-9eeb-3b7dc761a27c", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7654), "2b7e904c-5e6a-4b4e-b5e5-cfe02b9aab7d", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5db47b60-bb69-455c-afb0-97e085c4ad6a", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7739), "547da8ee-65fa-4e8b-b17c-1de40b5b52b0", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f4deafb4-e2fa-4e97-ac7d-1d8edc60ef58", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7775), "089cdcbf-4485-4a4b-8fce-183285c952dd", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "388cca85-785f-41cc-9337-a76c51f642c0", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7789), "9058810f-87f7-4c99-8226-efc11064baa9", new DateTime(2024, 8, 22, 1, 40, 0, 945, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ActStep", "Address", "Budget", "City", "ClientId", "ConstructionType", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "ProjectName", "StartDate", "State", "Status", "TotalArea" },
                values: new object[,]
                {
                    { 1, null, "123 Main St", 500000m, "CityA", 1, "Residential", "CountryA", "Residential building item", null, "Downtown", 3, 4, "12345", "Project Alpha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateA", "In Progress", 250.5m },
                    { 2, null, "456 Oak St", 1000000m, "CityB", 0, "Commercial", "CountryB", "Commercial building item", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business District", 5, 10, "23456", "Project Beta", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateB", "Completed", 500.0m },
                    { 3, "Initial Planning", "789 Pine St", 250000m, "CityC", 3, "Residential", "CountryC", "Planning phase", null, "Suburban", 2, 3, "34567", "Project Gamma", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateC", "Planning", 180.0m },
                    { 4, null, "101 Maple St", 750000m, "CityD", 4, "Commercial", "CountryD", "Office building item", null, "Tech Park", 4, 8, "45678", "Project Delta", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateD", "In Progress", 350.0m },
                    { 5, null, "202 Birch St", 300000m, "CityE", 0, "Residential", "CountryE", "Single-family home", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quiet Street", 3, 5, "56789", "Project Epsilon", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateE", "Completed", 220.0m },
                    { 6, null, "303 Cedar St", 1200000m, "CityF", 6, "Commercial", "CountryF", "Shopping mall", null, "Retail Hub", 10, 20, "67890", "Project Zeta", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateF", "Planning", 800.0m },
                    { 7, null, "404 Fir St", 600000m, "CityG", 7, "Residential", "CountryG", "Luxury apartments", null, "Uptown", 4, 6, "78901", "Project Eta", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateG", "In Progress", 350.0m },
                    { 8, null, "505 Spruce St", 500000m, "CityH", 0, "Commercial", "CountryH", "Retail space", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Main Street", 1, 2, "89012", "Project Theta", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateH", "Completed", 150.0m },
                    { 9, null, "606 Hemlock St", 400000m, "CityI", 9, "Residential", "CountryI", "Vacation home", null, "Lakeside", 2, 4, "90123", "Project Iota", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateI", "Planning", 300.0m },
                    { 10, null, "707 Juniper St", 800000m, "CityJ", 10, "Commercial", "CountryJ", "Restaurant", null, "Downtown", 3, 5, "01234", "Project Kappa", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateJ", "In Progress", 250.0m },
                    { 11, null, "808 Willow St", 350000m, "CityK", 11, "Residential", "CountryK", "Townhouse", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic District", 2, 4, "12346", "Project Lambda", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateK", "Completed", 200.0m },
                    { 12, null, "909 Poplar St", 950000m, "CityL", 12, "Commercial", "CountryL", "Corporate office", null, "Business District", 4, 8, "23457", "Project Mu", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateL", "Planning", 400.0m },
                    { 13, null, "1010 Redwood St", 700000m, "CityM", 13, "Residential", "CountryM", "Condo complex", null, "Urban Area", 4, 6, "34568", "Project Nu", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateM", "In Progress", 350.0m },
                    { 14, null, "1111 Cedar St", 1100000m, "CityN", 0, "Commercial", "CountryN", "Tech campus", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Innovation Hub", 15, 30, "45679", "Project Xi", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateN", "Completed", 1000.0m },
                    { 15, null, "1212 Birch St", 550000m, "CityO", 15, "Residential", "CountryO", "Eco-friendly home", null, "Green Valley", 3, 4, "56790", "Project Omicron", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateO", "Planning", 275.0m }
                });
        }
    }
}
