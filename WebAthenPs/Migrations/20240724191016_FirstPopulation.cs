using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstPopulation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenericProfessionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericProfessionals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericProfessionals_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProfessionals",
                columns: table => new
                {
                    ProfessionalsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessionals", x => new { x.ProfessionalsId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_GenericProfessionals_ProfessionalsId",
                        column: x => x.ProfessionalsId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CPF", "City", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RG", "Role", "SecurityStamp", "State", "TwoFactorEnabled", "UpdatedDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user1", 0, "123 Main St", "12345678901", "CityA", "b962b95e-5b45-4df9-9497-d9c2a2c6f26f", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4700), "user1@example.com", false, "M", false, null, null, null, null, null, false, "12345", "1234567", "Admin", "40f77553-9b85-4a1d-b2e7-63932aa3e6d1", "StateA", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4704), "user1@example.com", "Residential" },
                    { "user10", 0, "707 Juniper St", "01234567890", "CityJ", "7e5cfea2-4a57-4efc-a36e-fcfb4f0621aa", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4903), "user10@example.com", false, "F", false, null, null, null, null, null, false, "01234", "0123456", "User", "578c1685-0faa-424b-9a1d-1e4c53d6c06b", "StateJ", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4903), "user10@example.com", "Commercial" },
                    { "user11", 0, "808 Willow St", "12345678901", "CityK", "104ebfe0-efd8-4c3c-98f8-391d7e18bc64", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4917), "user11@example.com", false, "M", false, null, null, null, null, null, false, "12346", "1234568", "Admin", "b3bc6d76-5e7e-4395-a8f8-4860dc3cbfe4", "StateK", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4917), "user11@example.com", "Residential" },
                    { "user12", 0, "909 Poplar St", "23456789012", "CityL", "83c10283-35e3-4f36-bd2c-e7b9b6c1149e", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4928), "user12@example.com", false, "F", false, null, null, null, null, null, false, "23457", "2345679", "User", "3ceef92d-3724-45aa-811e-0bdf05bca291", "StateL", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4928), "user12@example.com", "Commercial" },
                    { "user13", 0, "1010 Redwood St", "34567890123", "CityM", "54d8bf4f-ede2-44d9-aaae-3f7ede4e7ba2", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4939), "user13@example.com", false, "M", false, null, null, null, null, null, false, "34568", "3456790", "Admin", "5386bab0-7e82-460e-942d-b9af0758ace8", "StateM", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4940), "user13@example.com", "Residential" },
                    { "user14", 0, "1111 Fir St", "45678901234", "CityN", "42e71ea0-83bb-45b0-b4ee-dba1b2273eea", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4952), "user14@example.com", false, "F", false, null, null, null, null, null, false, "45679", "4567901", "User", "2e2fcc9f-08d1-482b-a06d-bec6c5884a45", "StateN", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4952), "user14@example.com", "Commercial" },
                    { "user15", 0, "1212 Elm St", "56789012345", "CityO", "418060db-c9b4-4875-a66f-22b552dc8f3f", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4963), "user15@example.com", false, "M", false, null, null, null, null, null, false, "56780", "5678912", "Admin", "bd02d34d-2740-44ae-b308-3923b79e5db5", "StateO", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4963), "user15@example.com", "Residential" },
                    { "user2", 0, "456 Oak St", "23456789012", "CityB", "a237fe3e-e25a-4727-8d3d-df16ed775313", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4764), "user2@example.com", false, "F", false, null, null, null, null, null, false, "23456", "2345678", "User", "55ffb4b2-35b4-4fb5-adfc-cf2890bab6ad", "StateB", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4765), "user2@example.com", "Commercial" },
                    { "user3", 0, "789 Pine St", "34567890123", "CityC", "e17d4ed6-2a21-4328-923d-2e7ce0a15689", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4792), "user3@example.com", false, "M", false, null, null, null, null, null, false, "34567", "3456789", "Admin", "1a818ea1-4e45-4062-a9e4-8fd9f062c670", "StateC", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4792), "user3@example.com", "Residential" },
                    { "user4", 0, "101 Maple St", "45678901234", "CityD", "ffe27947-6c9b-448f-9a6e-7a71ad0151d3", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4803), "user4@example.com", false, "F", false, null, null, null, null, null, false, "45678", "4567890", "User", "2f67ea83-c3ad-4562-a3e6-a7f9af0d0f15", "StateD", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4804), "user4@example.com", "Commercial" },
                    { "user5", 0, "202 Birch St", "56789012345", "CityE", "193441b7-6005-40d8-bdbd-9991aea22d18", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4842), "user5@example.com", false, "M", false, null, null, null, null, null, false, "56789", "5678901", "Admin", "05c5ceaa-cc19-4b5e-aea9-ea6f5c298ab2", "StateE", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4842), "user5@example.com", "Residential" },
                    { "user6", 0, "303 Cedar St", "67890123456", "CityF", "fd31bcc7-50ee-4ba8-9f35-7be520917056", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4856), "user6@example.com", false, "F", false, null, null, null, null, null, false, "67890", "6789012", "User", "606a3f3e-8f9a-46f5-907d-a5e2eac28b86", "StateF", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4856), "user6@example.com", "Commercial" },
                    { "user7", 0, "404 Fir St", "78901234567", "CityG", "4b2347b5-4379-47cb-9c62-4fa1e43c8469", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4867), "user7@example.com", false, "M", false, null, null, null, null, null, false, "78901", "7890123", "Admin", "e146c8e3-2ee2-4bd9-a13c-8aec56a2dcf5", "StateG", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4867), "user7@example.com", "Residential" },
                    { "user8", 0, "505 Spruce St", "89012345678", "CityH", "d4671c68-40a6-44be-aa52-5a8006863baf", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4880), "user8@example.com", false, "F", false, null, null, null, null, null, false, "89012", "8901234", "User", "df7f01ff-9df5-4aaf-9351-d998c35ccad3", "StateH", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4880), "user8@example.com", "Commercial" },
                    { "user9", 0, "606 Hemlock St", "90123456789", "CityI", "5859785f-609c-44e6-8dec-22861a0bbb6d", new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4891), "user9@example.com", false, "M", false, null, null, null, null, null, false, "90123", "9012345", "Admin", "cb3bc8b1-c2a1-43f4-9037-828eb67b40b3", "StateI", false, new DateTime(2024, 7, 24, 19, 10, 16, 56, DateTimeKind.Utc).AddTicks(4892), "user9@example.com", "Residential" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "UserId" },
                values: new object[,]
                {
                    { 1, "user1" },
                    { 2, "user2" },
                    { 3, "user3" },
                    { 4, "user4" },
                    { 5, "user5" },
                    { 6, "user6" },
                    { 7, "user7" },
                    { 8, "user8" },
                    { 9, "user9" },
                    { 10, "user10" },
                    { 11, "user11" },
                    { 12, "user12" },
                    { 13, "user13" },
                    { 14, "user14" },
                    { 15, "user15" }
                });

            migrationBuilder.InsertData(
                table: "GenericProfessionals",
                columns: new[] { "Id", "ClientId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "user1" },
                    { 2, 2, "user2" },
                    { 3, 3, "user3" },
                    { 4, 4, "user4" },
                    { 5, 5, "user5" },
                    { 6, 6, "user6" },
                    { 7, 7, "user7" },
                    { 8, 8, "user8" },
                    { 9, 9, "user9" },
                    { 10, 10, "user10" },
                    { 11, 11, "user11" },
                    { 12, 12, "user12" },
                    { 13, 13, "user13" },
                    { 14, 14, "user14" },
                    { 15, 15, "user15" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Budget", "ClientId", "ConstructionType", "Description", "EndDate", "ProjectName", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, 500000m, 1, "Residential", "Residential building item", null, "Project Alpha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { 2, 1000000m, 2, "Commercial", "Commercial building item", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Beta", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 3, 750000m, 3, "Residential", "New residential item", null, "Project Gamma", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" },
                    { 4, 1200000m, 4, "Commercial", "Office building item", null, "Project Delta", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { 5, 600000m, 5, "Residential", "Luxury residential complex", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Epsilon", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 6, 950000m, 6, "Commercial", "Retail space construction", null, "Project Zeta", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { 7, 700000m, 7, "Residential", "Apartment building", null, "Project Eta", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" },
                    { 8, 1300000m, 8, "Commercial", "Shopping mall", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Theta", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 9, 550000m, 9, "Residential", "Single-family home", null, "Project Iota", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { 10, 800000m, 10, "Commercial", "Warehouse construction", null, "Project Kappa", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" },
                    { 11, 650000m, 11, "Residential", "Residential duplex", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Lambda", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 12, 1100000m, 12, "Commercial", "Hospital building", null, "Project Mu", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { 13, 780000m, 13, "Residential", "Condominium", null, "Project Nu", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planned" },
                    { 14, 900000m, 14, "Commercial", "Office renovation", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Xi", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 15, 500000m, 15, "Residential", "Family home", null, "Project Omicron", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ClientId",
                table: "GenericProfessionals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_UserId",
                table: "GenericProfessionals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_ProjectsProjectId",
                table: "ProjectProfessionals",
                column: "ProjectsProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProjectProfessionals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GenericProfessionals");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
