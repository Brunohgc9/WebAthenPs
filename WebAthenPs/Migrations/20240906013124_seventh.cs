using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class seventh : Migration
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
                    ActStep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Architects",
                columns: table => new
                {
                    ArchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    genericId = table.Column<int>(type: "int", nullable: false),
                    RegistroConselho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architects", x => x.ArchId);
                });

            migrationBuilder.CreateTable(
                name: "GenericProfessionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ProfessionalTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchitectArchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericProfessionals_Architects_ArchitectArchId",
                        column: x => x.ArchitectArchId,
                        principalTable: "Architects",
                        principalColumn: "ArchId");
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
                name: "ProjectProfessional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProfessional_GenericProfessionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProfessional_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
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
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "256c1bae-12a1-4fe3-a394-424ef8641b40", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(5900), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "38cffb04-899f-42cd-a2d1-4ab6a68e62af", "SP", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(5902), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "84736f75-3a99-4d45-9fe5-b493268540e0", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6219), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "4f5c6d10-19c4-4d26-8619-9621636aa862", "AM", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6219), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "0c25ecb6-7b56-43ba-866b-d64d7860e30d", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6234), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "cc97a8eb-4694-4e87-bb6e-b9d4e0f7cb2f", "MA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6235), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "9fd4c540-d7ac-4172-a317-7b97036f1ad0", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6248), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "807aab30-1dc0-43be-9e68-7b1a19bd1231", "MA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6248), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "02ef8814-fb0c-4577-97d1-d6eaac458bd9", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6260), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "f4da2393-61e8-4d36-a08a-90da0b1af2c7", "PI", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6260), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "a89ee89b-71c3-4c37-bf0d-07613c84b5c8", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6271), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "10be005d-ee41-4485-9a11-9e26896f3028", "AL", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6271), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "f30f4ec7-0e30-4b9e-a022-381ccb912404", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6284), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "e4da27a0-587f-474e-9822-026ef1ebf49d", "PB", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6284), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "8e2845a4-aa57-40ea-8c92-40c0bb3c51f1", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6295), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "cf5b131b-09aa-448c-8d9c-c1e6861bbeea", "SP", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6296), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "2cbc6eb4-789c-4ec4-9ab2-5f208e6cb1c1", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6307), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "2495d7f3-e2b3-4fd5-9b18-fcfd78c3f4c6", "RJ", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6307), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "cf784f0d-edf8-4c3f-a729-253d05986a9d", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6320), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "e43f2551-dbc3-4d09-ab3f-6445ca203195", "MG", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6320), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "92c837e8-5adb-4bd4-958c-e8fbcc6dd687", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6331), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "d891ab6b-ce64-413d-a1f8-ace0b72119ec", "BA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6331), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "0d63622e-0541-4814-89a6-87d086cffb22", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6021), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "06579c18-91bb-4e52-aac6-d0b377c042d1", "RJ", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6021), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "ad9f0ca3-ee65-42e7-be4c-5089e069e2a2", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6344), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "b5dfc773-2b8d-4d7b-9431-1011b315fe23", "CE", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6344), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "3ab1eb7d-6abc-4dc1-a186-a9e0ffbece17", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6355), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "28820731-7dac-436d-b2e1-0c03e1b002d8", "PR", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6355), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "2b186fc3-4a79-4221-9515-e607e104fb35", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6366), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "9dbed96f-432d-4933-a031-81dd650edf68", "RS", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6367), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "1c66b787-8bb8-49e3-bde1-d3c742cc83bb", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6379), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "a276c3cb-9f49-4bcd-b231-a2331ae7c6da", "MA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6380), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "88f6ef91-4e04-4cbf-aa12-1befd1d1cf11", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6391), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "10d4d57b-36e7-4a02-a90d-5bb63a07ab08", "PI", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6391), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "a35d092e-405c-4811-99ad-5b918a2d4b52", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6402), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "140d155d-12fb-4bd0-a251-81a1ad36a134", "AL", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6402), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "2225cdd6-db1b-47ab-9541-adf8d9152137", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6415), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "486e472d-6a41-411a-a37c-30fe088afc0d", "PB", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6415), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "75bfe12f-9cac-4a92-9208-00afff63889b", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6452), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "87a5afa1-4083-4804-a482-d7e18d86f9ef", "SP", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6453), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "435471fd-da32-4f76-807b-3319cfbff882", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6465), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "ab111a57-a4c8-46f6-9eb2-b01a13bb33ec", "RJ", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6466), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "3fa4d41a-ecb2-4306-88b7-9dc8facff94a", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6477), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "3ee24a83-9e03-412b-9f5d-4ff4184339af", "MG", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6477), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "d4f0df77-dc22-4ee2-b4d3-4767938344e8", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6034), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "87b983f2-829f-465c-8c58-66d5db3a2723", "MG", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6034), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "aae2093e-9ad4-4432-9738-3dec95a41656", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6489), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "0a762024-720a-419b-af6b-59862a53913e", "BA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6490), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "6b8b6ccb-b1ef-424e-a013-58e32395460c", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6047), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "16045a84-072a-472b-8306-cad40433c3af", "BA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6047), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "1f903e4a-c9d5-48e6-bbb3-3b91f59b2fae", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6058), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "c9ddf8a0-3716-41e6-ad3b-8be9e405e913", "CE", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6059), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "d53aa8a2-7463-4897-b26b-cfe901aa6436", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6070), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "842ec82b-913c-48ce-bcb9-4f7126bb4e9c", "PR", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6070), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "e70cc45a-e68b-4a40-92cb-0c6f4a9084e9", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6082), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "d83a7a48-6e4b-4a2c-86e3-59dc213bd504", "RS", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6083), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "b70db2d3-f653-4f2e-baf2-725c75e2cdcd", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6094), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "c7b5c2a8-efcb-4d10-913a-9c17a8d1093b", "PE", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6094), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "20b58e2f-fa09-49ae-b319-e72f6047d835", new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6106), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "0cade379-18d2-4d5b-9d42-5c4c46c4d598", "PA", false, new DateTime(2024, 9, 6, 1, 31, 24, 215, DateTimeKind.Utc).AddTicks(6107), "Ricardo Fernandes", "Client" }
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
                columns: new[] { "Id", "ArchitectArchId", "ClientId", "ProfessionalTypes", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, "[\"Arquiteto\"]", "user16" },
                    { 2, null, 2, "[\"Eletricista\"]", "user17" },
                    { 3, null, 3, "[\"Engenheiro\"]", "user18" },
                    { 4, null, 4, "[\"Pedreiro\"]", "user19" },
                    { 5, null, 5, "[\"Encanador\"]", "user20" },
                    { 6, null, 6, "[\"Arquiteto\"]", "user21" },
                    { 7, null, 7, "[\"Eletricista\"]", "user22" },
                    { 8, null, 8, "[\"Engenheiro\"]", "user23" },
                    { 9, null, 9, "[\"Pedreiro\"]", "user24" },
                    { 10, null, 10, "[\"Encanador\"]", "user25" },
                    { 11, null, 11, "[\"Eletricista\"]", "user26" },
                    { 12, null, 12, "[\"Arquiteto\"]", "user27" },
                    { 13, null, 13, "[\"Engenheiro\"]", "user28" },
                    { 14, null, 14, "[\"Pedreiro\"]", "user29" },
                    { 15, null, 15, "[\"Encanador\"]", "user30" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ActStep", "Address", "Budget", "City", "ClientDescription", "ClientId", "ConstructionType", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "ProjectName", "StartDate", "State", "Status", "TotalArea" },
                values: new object[,]
                {
                    { 1, "Phase 1", "123 Main St", 500000m, "CityA", null, 1, "Residential", "CountryA", "Residential building item", null, "Downtown", 3, 4, "12345", "Project Alpha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateA", "In Progress", 250.5m },
                    { 2, "Phase 2", "456 Oak St", 1000000m, "CityB", null, 2, "Commercial", "CountryB", "Commercial building item", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business District", 5, 10, "23456", "Project Beta", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateB", "Completed", 500.0m },
                    { 3, "Initial Planning", "789 Pine St", 250000m, "CityC", null, 3, "Residential", "CountryC", "Planning phase", null, "Suburban", 2, 3, "34567", "Project Gamma", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateC", "Planning", 180.0m },
                    { 4, "Construction", "101 Maple St", 750000m, "CityD", null, 4, "Commercial", "CountryD", "Office building item", null, "Tech Park", 4, 8, "45678", "Project Delta", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateD", "In Progress", 350.0m },
                    { 5, "Final Touches", "202 Birch St", 300000m, "CityE", null, 5, "Residential", "CountryE", "Single-family home", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quiet Street", 3, 5, "56789", "Project Epsilon", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateE", "Completed", 220.0m },
                    { 6, "Site Selection", "303 Cedar St", 1200000m, "CityF", null, 6, "Commercial", "CountryF", "Shopping mall", null, "Retail Hub", 10, 20, "67890", "Project Zeta", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateF", "Planning", 800.0m },
                    { 7, "Structural Work", "404 Fir St", 600000m, "CityG", null, 7, "Residential", "CountryG", "Luxury apartments", null, "Uptown", 4, 6, "78901", "Project Eta", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateG", "In Progress", 350.0m },
                    { 8, "Inspection", "505 Spruce St", 500000m, "CityH", null, 8, "Commercial", "CountryH", "Retail space", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Main Street", 1, 2, "89012", "Project Theta", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateH", "Completed", 150.0m },
                    { 9, "Budget Approval", "606 Hemlock St", 400000m, "CityI", null, 9, "Residential", "CountryI", "Vacation home", null, "Lakeside", 2, 4, "90123", "Project Iota", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateI", "Planning", 300.0m },
                    { 10, "Interior Design", "707 Juniper St", 800000m, "CityJ", null, 10, "Commercial", "CountryJ", "Restaurant", null, "Downtown", 3, 5, "01234", "Project Kappa", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateJ", "In Progress", 250.0m },
                    { 11, "Landscaping", "808 Willow St", 350000m, "CityK", null, 11, "Residential", "CountryK", "Townhouse", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic District", 2, 4, "12346", "Project Lambda", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateK", "Completed", 200.0m },
                    { 12, "Permitting", "909 Poplar St", 950000m, "CityL", null, 12, "Commercial", "CountryL", "Corporate office", null, "Business District", 4, 8, "23457", "Project Mu", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateL", "Planning", 400.0m },
                    { 13, "Framing", "1010 Redwood St", 700000m, "CityM", null, 13, "Residential", "CountryM", "Condo complex", null, "Urban Area", 4, 6, "34568", "Project Nu", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateM", "In Progress", 350.0m },
                    { 14, "Final Inspection", "1111 Cedar St", 1100000m, "CityN", null, 14, "Commercial", "CountryN", "Tech campus", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Innovation Hub", 15, 30, "45679", "Project Xi", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateN", "Completed", 1000.0m },
                    { 15, "Design Approval", "1212 Birch St", 550000m, "CityO", null, 15, "Residential", "CountryO", "Eco-friendly home", null, "Green Valley", 3, 4, "56790", "Project Omicron", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateO", "Planning", 275.0m }
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("516b3960-9f9a-4ad7-85f7-09e94011eaa2"), "Industrial", "112233", 12 },
                    { new Guid("9285f336-798a-415f-b2e7-3400ba6c1796"), "Comercial", "654321", 6 },
                    { new Guid("99a71655-8ae6-428d-bfd9-5f09a3ebac30"), "Residencial", "123456", 1 }
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
                name: "IX_Architects_genericId",
                table: "Architects",
                column: "genericId",
                unique: true);

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
                name: "IX_GenericProfessionals_ArchitectArchId",
                table: "GenericProfessionals",
                column: "ArchitectArchId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ClientId",
                table: "GenericProfessionals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_UserId",
                table: "GenericProfessionals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessional_ProfessionalId",
                table: "ProjectProfessional",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessional_ProjectId",
                table: "ProjectProfessional",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_Id",
                table: "ProjectProfessionals",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Architects_GenericProfessionals_genericId",
                table: "Architects",
                column: "genericId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Architects_GenericProfessionals_genericId",
                table: "Architects");

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
                name: "ProjectProfessional");

            migrationBuilder.DropTable(
                name: "ProjectProfessionals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "GenericProfessionals");

            migrationBuilder.DropTable(
                name: "Architects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
