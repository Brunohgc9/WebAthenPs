using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
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
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ProfessionalType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericProfessionals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: true),
                    NumberOfBathrooms = table.Column<int>(type: "int", nullable: true),
                    ActStep = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessionals", x => new { x.ProjectId, x.Id });
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_GenericProfessionals_Id",
                        column: x => x.Id,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CPF", "City", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RG", "Role", "SecurityStamp", "State", "TwoFactorEnabled", "UpdatedDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "fcda258d-26c7-43bd-9c63-ad100a7d7558", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3788), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "d42e8cbe-1a32-4765-b81a-94ee794a58ca", "SP", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3788), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "eff2455b-94ca-4f2f-9b82-e2d8feb2e87d", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3988), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "451ccd31-0eb2-49e0-a849-3789b25ab469", "AM", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3988), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "33116b12-789b-4497-bb2a-517e360ffcd2", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4002), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "01c06d94-71f8-4a76-b24f-15cd14a46b3e", "MA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4002), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "e7d46dac-d144-4dc4-a23a-2e1708f37dd3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4015), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "4db87ec0-16a0-4d05-a1a0-e916b789916e", "MA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4016), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "290ef670-a72f-4483-9d90-8ba72d941ee3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4030), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "70297c42-4806-4736-87e7-90c0cba9a59b", "PI", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4031), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "20cb1cdf-5dbb-4e17-af32-7f9a406884f5", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4043), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "2b9891cf-a09c-4b09-a6cc-70308d92a9df", "AL", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4043), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "f0bc900e-9139-4b63-bf2c-a28dd21974fc", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4056), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "5309f291-a5e5-4487-a940-58291d85d248", "PB", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4056), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "4aa0ba65-7a88-427b-a469-1d5635c7269c", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4071), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "6561e1ed-26f4-432a-9fec-87fd4900eba3", "SP", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4071), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "12206bd9-a92d-4709-abef-7f93c6cf1508", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4110), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "8b604f9a-3f26-4a41-8075-ff67cf66724a", "RJ", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4110), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "5069b5a0-90e5-44dd-b672-ff02b6a0ccce", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4124), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "01d06ccf-3265-4d2f-97d1-2dcd62091a11", "MG", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4124), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "49e4357c-e98d-4c95-8e83-4bdc391631e4", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4139), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "d622aa39-c523-47af-9308-159fcf7fdc12", "BA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4139), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "234d754e-d379-446d-b995-d12bd60bfa6c", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3874), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "76db39d5-19ff-41f2-873d-d38a94cefba4", "RJ", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3874), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "cda0f4b7-a808-49bb-9abd-e7b9ecc86dec", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4150), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "4c7af87f-e430-407e-950f-cf44b094d6d2", "CE", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4150), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "3e5dc66e-a605-4dc3-bf89-a3c13086c6c5", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4162), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "5bf24aef-e28e-4b59-9601-f472c7831540", "PR", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4162), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "1ef796ac-eb67-4800-8138-00f98f71488e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4173), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "f1dc65ad-843a-450e-80b1-953e3f9de8fa", "RS", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4173), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "5aaf5e21-5765-40f9-837b-6afccec1a733", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4184), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "7181f68d-977f-4b79-bf18-352098e2c97d", "MA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4184), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "dfd82097-e1e4-4cc8-9efe-0d64e6663e08", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4196), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "f3997ba6-1e81-4997-8049-986187a5ad96", "PI", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4196), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "3d64bc6d-ec53-4dd1-a563-337120138d82", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4206), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "24e5d69b-1d7b-45f0-851f-610ec7087b08", "AL", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4207), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "1d884b51-996c-441f-b862-365889811cb8", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4218), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "396c0220-af25-4f9f-a11a-8424c7aa4e17", "PB", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4219), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "beae7b21-3d35-4003-a976-f356b5a0d6f3", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4230), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "a61a102e-3dc4-42ab-8e23-33f8ec2c9e09", "SP", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4230), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "9ea26f46-d7de-43d4-9dff-bedbfbb2e18e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4241), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "c3e7cbf9-68e9-4cc6-92b1-16810127d3f7", "RJ", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4241), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "e69dae3d-cd34-4103-8ce2-61bb495c6c88", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4253), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "ab978af4-860d-4910-af92-db322107e2ef", "MG", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4253), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "de26146a-760d-4e99-83a4-e595fbac0140", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3889), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "372f8ad0-27c5-40b4-b49d-b0c2e27d9a00", "MG", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3889), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "53a8368e-3603-48d3-9414-8e0f1d33c7e4", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4264), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "fc1ab42a-ace7-4467-b065-842038ebae1c", "BA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(4264), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "97fb2734-9133-4737-ada5-f4927ad2883e", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3902), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "310b14ab-dfa6-4615-bd63-5eba044dd77d", "BA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3903), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "54294449-57b8-4d31-a251-5c135ed83352", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3918), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "a76c6b6d-05c0-480e-9d21-25ad17718604", "CE", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3919), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "b0c5d792-34f4-4aa8-acd2-da54c40aa816", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3932), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "47abe447-3cf6-4b68-9788-7a0683360879", "PR", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3932), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "caa1b828-f98b-4b9e-b11f-e03e21b404b0", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3945), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "57d421eb-2efd-474c-8d1b-04bd251d4259", "RS", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3945), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "8ad603ee-5be9-4f1c-bbd3-bd900719be18", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3960), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "a0f6a7dd-f15e-4c0b-b76f-bf96d2f6b92b", "PE", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3960), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "f863446a-d085-411b-ba01-a240d59cf9c9", new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3973), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "189323b2-c344-4244-a70d-346d3b95aa04", "PA", false, new DateTime(2024, 8, 22, 1, 50, 56, 193, DateTimeKind.Utc).AddTicks(3974), "Ricardo Fernandes", "Client" }
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
                columns: new[] { "Id", "ClientId", "ProfessionalType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Arquiteto", "user16" },
                    { 2, 2, "Eletricista", "user17" },
                    { 3, 3, "Engenheiro", "user18" },
                    { 4, 4, "Pedreiro", "user19" },
                    { 5, 5, "Encanador", "user20" },
                    { 6, 6, "Arquiteto", "user21" },
                    { 7, 7, "Eletricista", "user22" },
                    { 8, 8, "Engenheiro", "user23" },
                    { 9, 9, "Pedreiro", "user24" },
                    { 10, 10, "Encanador", "user25" },
                    { 11, 11, "Arquiteto", "user26" },
                    { 12, 12, "Eletricista", "user27" },
                    { 13, 13, "Engenheiro", "user28" },
                    { 14, 14, "Pedreiro", "user29" },
                    { 15, 15, "Encanador", "user30" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ActStep", "Address", "Budget", "City", "ClientId", "ConstructionType", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "ProjectName", "StartDate", "State", "Status", "TotalArea" },
                values: new object[,]
                {
                    { 1, "Phase 1", "123 Main St", 500000m, "CityA", 1, "Residential", "CountryA", "Residential building item", null, "Downtown", 3, 4, "12345", "Project Alpha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateA", "In Progress", 250.5m },
                    { 2, "Phase 2", "456 Oak St", 1000000m, "CityB", 2, "Commercial", "CountryB", "Commercial building item", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business District", 5, 10, "23456", "Project Beta", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateB", "Completed", 500.0m },
                    { 3, "Initial Planning", "789 Pine St", 250000m, "CityC", 3, "Residential", "CountryC", "Planning phase", null, "Suburban", 2, 3, "34567", "Project Gamma", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateC", "Planning", 180.0m },
                    { 4, "Construction", "101 Maple St", 750000m, "CityD", 4, "Commercial", "CountryD", "Office building item", null, "Tech Park", 4, 8, "45678", "Project Delta", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateD", "In Progress", 350.0m },
                    { 5, "Final Touches", "202 Birch St", 300000m, "CityE", 5, "Residential", "CountryE", "Single-family home", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quiet Street", 3, 5, "56789", "Project Epsilon", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateE", "Completed", 220.0m },
                    { 6, "Site Selection", "303 Cedar St", 1200000m, "CityF", 6, "Commercial", "CountryF", "Shopping mall", null, "Retail Hub", 10, 20, "67890", "Project Zeta", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateF", "Planning", 800.0m },
                    { 7, "Structural Work", "404 Fir St", 600000m, "CityG", 7, "Residential", "CountryG", "Luxury apartments", null, "Uptown", 4, 6, "78901", "Project Eta", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateG", "In Progress", 350.0m },
                    { 8, "Inspection", "505 Spruce St", 500000m, "CityH", 8, "Commercial", "CountryH", "Retail space", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Main Street", 1, 2, "89012", "Project Theta", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateH", "Completed", 150.0m },
                    { 9, "Budget Approval", "606 Hemlock St", 400000m, "CityI", 9, "Residential", "CountryI", "Vacation home", null, "Lakeside", 2, 4, "90123", "Project Iota", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateI", "Planning", 300.0m },
                    { 10, "Interior Design", "707 Juniper St", 800000m, "CityJ", 10, "Commercial", "CountryJ", "Restaurant", null, "Downtown", 3, 5, "01234", "Project Kappa", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateJ", "In Progress", 250.0m },
                    { 11, "Landscaping", "808 Willow St", 350000m, "CityK", 11, "Residential", "CountryK", "Townhouse", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic District", 2, 4, "12346", "Project Lambda", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateK", "Completed", 200.0m },
                    { 12, "Permitting", "909 Poplar St", 950000m, "CityL", 12, "Commercial", "CountryL", "Corporate office", null, "Business District", 4, 8, "23457", "Project Mu", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateL", "Planning", 400.0m },
                    { 13, "Framing", "1010 Redwood St", 700000m, "CityM", 13, "Residential", "CountryM", "Condo complex", null, "Urban Area", 4, 6, "34568", "Project Nu", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateM", "In Progress", 350.0m },
                    { 14, "Final Inspection", "1111 Cedar St", 1100000m, "CityN", 14, "Commercial", "CountryN", "Tech campus", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Innovation Hub", 15, 30, "45679", "Project Xi", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateN", "Completed", 1000.0m },
                    { 15, "Design Approval", "1212 Birch St", 550000m, "CityO", 15, "Residential", "CountryO", "Eco-friendly home", null, "Green Valley", 3, 4, "56790", "Project Omicron", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateO", "Planning", 275.0m }
                });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "Id", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 5 },
                    { 10, 5 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 7 },
                    { 14, 7 },
                    { 1, 8 },
                    { 15, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 4, 10 },
                    { 5, 10 },
                    { 6, 11 },
                    { 7, 11 },
                    { 8, 12 },
                    { 9, 12 },
                    { 10, 13 },
                    { 11, 13 },
                    { 12, 14 },
                    { 13, 14 },
                    { 14, 15 },
                    { 15, 15 }
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
                name: "IX_ProjectProfessionals_Id",
                table: "ProjectProfessionals",
                column: "Id");

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
