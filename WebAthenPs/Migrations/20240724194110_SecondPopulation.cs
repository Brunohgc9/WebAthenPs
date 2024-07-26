using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class SecondPopulation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBathrooms",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRooms",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalArea",
                table: "Projects",
                type: "decimal(18,2)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "Address", "City", "Country", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "State", "TotalArea" },
                values: new object[] { "123 Main St", "CityA", "CountryA", "Downtown", 3, 4, "12345", "StateA", 250.5m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "Address", "City", "Country", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "State", "TotalArea" },
                values: new object[] { "456 Oak St", "CityB", "CountryB", "Business District", 5, 10, "23456", "StateB", 500.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "789 Pine St", 250000m, "CityC", "CountryC", "Planning phase", "Suburban", 2, 3, "34567", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateC", "Planning", 180.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "Address", "Budget", "City", "Country", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "TotalArea" },
                values: new object[] { "101 Maple St", 750000m, "CityD", "CountryD", "Tech Park", 4, 8, "45678", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateD", 350.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "TotalArea" },
                values: new object[] { "202 Birch St", 300000m, "CityE", "CountryE", "Single-family home", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quiet Street", 3, 5, "56789", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateE", 220.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "303 Cedar St", 1200000m, "CityF", "CountryF", "Shopping mall", "Retail Hub", 10, 20, "67890", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateF", "Planning", 800.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "404 Fir St", 600000m, "CityG", "CountryG", "Luxury apartments", "Uptown", 4, 6, "78901", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateG", "In Progress", 350.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "State", "TotalArea" },
                values: new object[] { "505 Spruce St", 500000m, "CityH", "CountryH", "Retail space", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Main Street", 1, 2, "89012", "StateH", 150.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 9,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "606 Hemlock St", 400000m, "CityI", "CountryI", "Vacation home", "Lakeside", 2, 4, "90123", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateI", "Planning", 300.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 10,
                columns: new[] { "Address", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "707 Juniper St", "CityJ", "CountryJ", "Restaurant", "Downtown", 3, 5, "01234", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateJ", "In Progress", 250.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 11,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "TotalArea" },
                values: new object[] { "808 Willow St", 350000m, "CityK", "CountryK", "Townhouse", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic District", 2, 4, "12346", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateK", 200.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 12,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "909 Poplar St", 950000m, "CityL", "CountryL", "Corporate office", "Business District", 4, 8, "23457", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateL", "Planning", 400.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 13,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { "1010 Redwood St", 700000m, "CityM", "CountryM", "Condo complex", "Urban Area", 4, 6, "34568", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateM", "In Progress", 350.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 14,
                columns: new[] { "Address", "Budget", "City", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "StartDate", "State", "TotalArea" },
                values: new object[] { "1111 Fir St", 1100000m, "CityN", "CountryN", "Hotel", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resort Area", 30, 50, "45679", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateN", 600.0m });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 15,
                columns: new[] { "Address", "City", "Country", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "State", "TotalArea" },
                values: new object[] { "1212 Elm St", "CityO", "CountryO", "Suburban", 3, 5, "56780", "StateO", 270.0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "NumberOfBathrooms",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "NumberOfRooms",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TotalArea",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b962b95e-5b45-4df9-9497-d9c2a2c6f26f", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4700), "40f77553-9b85-4a1d-b2e7-63932aa3e6d1", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7e5cfea2-4a57-4efc-a36e-fcfb4f0621aa", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4903), "578c1685-0faa-424b-9a1d-1e4c53d6c06b", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "104ebfe0-efd8-4c3c-98f8-391d7e18bc64", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4917), "b3bc6d76-5e7e-4395-a8f8-4860dc3cbfe4", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "83c10283-35e3-4f36-bd2c-e7b9b6c1149e", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4928), "3ceef92d-3724-45aa-811e-0bdf05bca291", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54d8bf4f-ede2-44d9-aaae-3f7ede4e7ba2", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4939), "5386bab0-7e82-460e-942d-b9af0758ace8", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "42e71ea0-83bb-45b0-b4ee-dba1b2273eea", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4952), "2e2fcc9f-08d1-482b-a06d-bec6c5884a45", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "418060db-c9b4-4875-a66f-22b552dc8f3f", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4963), "bd02d34d-2740-44ae-b308-3923b79e5db5", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a237fe3e-e25a-4727-8d3d-df16ed775313", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4764), "55ffb4b2-35b4-4fb5-adfc-cf2890bab6ad", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e17d4ed6-2a21-4328-923d-2e7ce0a15689", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4792), "1a818ea1-4e45-4062-a9e4-8fd9f062c670", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ffe27947-6c9b-448f-9a6e-7a71ad0151d3", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4803), "2f67ea83-c3ad-4562-a3e6-a7f9af0d0f15", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "193441b7-6005-40d8-bdbd-9991aea22d18", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4842), "05c5ceaa-cc19-4b5e-aea9-ea6f5c298ab2", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd31bcc7-50ee-4ba8-9f35-7be520917056", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4856), "606a3f3e-8f9a-46f5-907d-a5e2eac28b86", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b2347b5-4379-47cb-9c62-4fa1e43c8469", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4867), "e146c8e3-2ee2-4bd9-a13c-8aec56a2dcf5", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d4671c68-40a6-44be-aa52-5a8006863baf", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4880), "df7f01ff-9df5-4aaf-9351-d998c35ccad3", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5859785f-609c-44e6-8dec-22861a0bbb6d", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4891), "cb3bc8b1-c2a1-43f4-9037-828eb67b40b3", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "Budget", "Description", "StartDate", "Status" },
                values: new object[] { 750000m, "New residential item", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "Budget", "StartDate" },
                values: new object[] { 1200000m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "Budget", "Description", "EndDate", "StartDate" },
                values: new object[] { 600000m, "Luxury residential complex", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                columns: new[] { "Budget", "Description", "StartDate", "Status" },
                values: new object[] { 950000m, "Retail space construction", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7,
                columns: new[] { "Budget", "Description", "StartDate", "Status" },
                values: new object[] { 700000m, "Apartment building", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 8,
                columns: new[] { "Budget", "Description", "EndDate" },
                values: new object[] { 1300000m, "Shopping mall", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 9,
                columns: new[] { "Budget", "Description", "StartDate", "Status" },
                values: new object[] { 550000m, "Single-family home", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 10,
                columns: new[] { "Description", "StartDate", "Status" },
                values: new object[] { "Warehouse construction", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 11,
                columns: new[] { "Budget", "Description", "EndDate", "StartDate" },
                values: new object[] { 650000m, "Residential duplex", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 12,
                columns: new[] { "Budget", "Description", "StartDate", "Status" },
                values: new object[] { 1100000m, "Hospital building", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 13,
                columns: new[] { "Budget", "Description", "StartDate", "Status" },
                values: new object[] { 780000m, "Condominium", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 14,
                columns: new[] { "Budget", "Description", "EndDate", "StartDate" },
                values: new object[] { 900000m, "Office renovation", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
