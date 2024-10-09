using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class ProjectProfessionalId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LikedByUserIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    ArchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericProfessionals_Architects_ArchId",
                        column: x => x.ArchId,
                        principalTable: "Architects",
                        principalColumn: "ArchId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenericProfessionalProjecty",
                columns: table => new
                {
                    ProfessionalsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionalProjecty", x => new { x.ProfessionalsId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProjecty_GenericProfessionals_ProfessionalsId",
                        column: x => x.ProfessionalsId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProjecty_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProfessionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProfessionals_GenericProfessionals_ProfessionalId",
                        column: x => x.ProfessionalId,
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

            migrationBuilder.CreateTable(
                name: "Proposals",
                columns: table => new
                {
                    ProposalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProposalMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProposalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProposalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.ProposalId);
                    table.ForeignKey(
                        name: "FK_Proposals_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposals_GenericProfessionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proposals_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("9876b54c-7952-4f52-a170-ed3036394792"), "Residencial", "123456", 1 },
                    { new Guid("a05cf0e7-d957-44ba-9e2a-313def7408ba"), "Comercial", "654321", 6 },
                    { new Guid("c151318e-3c52-4120-a0c1-b47b35ce07d1"), "Industrial", "112233", 12 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CPF", "City", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RG", "Role", "SecurityStamp", "State", "TwoFactorEnabled", "UpdatedDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "d4811ba1-bad4-46e9-8831-8bb6653ef5ee", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1541), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "dcc78a56-0692-49b5-81eb-18c1c1261479", "SP", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1544), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "73e0309b-1f1d-4b05-88b1-fec1fe618834", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1761), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "4ae1304c-dd36-496c-a1ab-7c88ea4902d5", "AM", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1761), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "a2f11ae0-65f5-432d-8063-4031fa741d44", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1811), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "fc8f357c-b345-4373-90df-720e83fdfded", "MA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1811), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "ce6c2c0a-1e00-4084-957b-893cf85812cf", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1853), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "7391f852-b519-4a44-967e-b2d7342af6ca", "MA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1853), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "6a4caa17-0641-4bc1-b0b5-d4ce175dc667", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1864), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "8232f345-e16b-4e49-baf5-c68a73b2b667", "PI", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1864), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "b43dc87e-0c7c-4662-90f0-9d73986f1d10", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1877), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "c0576b58-4dd4-45f7-bb09-7e7fa0bfdc67", "AL", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1878), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "31a3f414-62eb-4198-9deb-1103ffc5c563", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1888), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "0c906028-f35e-47b5-bde2-b1cadd614237", "PB", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1892), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "630749bf-410f-40e8-ad75-9da4c7224f49", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1908), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "f9f779a4-64d6-47d8-a5bf-dc688ce9835c", "SP", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1908), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "cbbfbc86-797d-4e3c-b14a-c01ec21110d0", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1919), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "a2193aea-11c5-40ba-84cc-902bf01d390a", "RJ", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1920), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "c0520521-c31e-440e-85db-70969319b5cf", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1930), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "0087119f-6bba-4b10-970c-9053a4d09f8c", "MG", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1930), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "6b465b44-0a6b-42c2-a99b-32e36c5e9a2f", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1942), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "9e42836d-36a7-4e6e-84d3-c99ffb33a5f0", "BA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1942), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "0d8e7927-613f-404c-971a-9868f7e0ddb8", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1653), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "a25b17f1-a4ca-4279-85b4-b270b3cc7201", "RJ", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1653), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "636ec2c9-b75c-4e2f-ad26-d122e55fb379", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1954), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "7de33a6f-973f-4478-8cfa-036108fba17e", "CE", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1954), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "c0af7bb7-75a3-4e2a-a4d6-532a6953caab", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1964), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "d59e091e-5148-4b2d-875b-bd4730b066ac", "PR", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1964), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "2a60f30c-f76f-41c5-90da-46cacf1013ba", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1975), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "f5dcac93-e3c4-4101-b9b5-903d8b77cc8b", "RS", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1975), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "3fa318b7-1f4a-48c8-86be-e75a2ff7a964", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1985), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "ae02e06e-ad1c-471f-80ff-9811df3a635f", "MA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1985), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "0c2e89cd-14c8-4100-aef8-7ebea062af8d", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1995), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "8b1aa000-b4a6-48dc-85fe-ba808088f3d2", "PI", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1995), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "2746e389-7766-4b12-b7a5-b34f77a64596", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2007), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "6b2e0f66-dc03-465d-b2d5-0d926585e4cb", "AL", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2008), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "a73279f6-0ae1-4c38-9d8f-8f96b34fe86a", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2017), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "f1804394-38ae-4459-87c7-56a40c7bd1a9", "PB", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2018), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "a1973775-817c-4182-95a8-5821186aec4e", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2028), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "beda8aa8-aee3-41cb-a233-aea1bd87c8d1", "SP", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2029), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "f377f9b3-37fc-4e0d-a146-87e7bdf9fed9", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2063), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "1a862171-fa7a-42af-879a-4fd4411e64ca", "RJ", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2063), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "e8a1caa2-e26f-4411-84e8-84c1c07e78ec", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2074), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "ee5f833a-a32f-4409-828c-333d5549d51e", "MG", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2074), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "dc639b70-2754-4ad4-88ed-a18598b21fd8", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1676), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "f949eb90-62d1-469c-9a4f-28d799e965cd", "MG", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1677), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "7fa80f57-a772-491f-80f0-e663be4794f2", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2085), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "16234e3a-4766-4597-bb61-3714cc918f4f", "BA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(2085), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "9cc6e976-bd2b-46e0-8c12-058eed68f676", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1688), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "3a016547-4e22-41a6-b340-62867a41de45", "BA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1688), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "1d0cd85e-6dbe-4e5b-bee7-9ae8637cf208", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1698), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "c025f4ea-8902-4240-90de-c35089d5ccf0", "CE", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1698), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "bf3917b5-5593-4ff7-a634-4d59759d0e63", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1716), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "1527e42a-b013-43bc-9c72-7df29114851f", "PR", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1716), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "5c1b7d3b-5a39-429b-88c8-b10d4aa0a007", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1727), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "0d69fed7-4d69-4f9e-9edd-b5f32e7411a2", "RS", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1727), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "022445a8-4c64-411d-bf1d-051d98afb505", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1738), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "3159c665-5c20-493a-a32f-5ec7ffed6ce2", "PE", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1738), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "b9945d80-1b55-46bc-8337-23eddfa1e485", new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1750), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "8a6c0e62-e918-42c4-9665-86136660167f", "PA", false, new DateTime(2024, 10, 9, 21, 24, 48, 608, DateTimeKind.Utc).AddTicks(1750), "Ricardo Fernandes", "Client" }
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
                columns: new[] { "Id", "ArchId", "ClientId", "ProfessionalTypes", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("9876b54c-7952-4f52-a170-ed3036394792"), 1, "[\"Arquiteto\"]", "user16" },
                    { 2, null, 2, "[\"Eletricista\"]", "user17" },
                    { 3, null, 3, "[\"Engenheiro\"]", "user18" },
                    { 4, null, 4, "[\"Pedreiro\"]", "user19" },
                    { 5, null, 5, "[\"Encanador\"]", "user20" },
                    { 6, new Guid("a05cf0e7-d957-44ba-9e2a-313def7408ba"), 6, "[\"Arquiteto\"]", "user21" },
                    { 7, null, 7, "[\"Eletricista\"]", "user22" },
                    { 8, null, 8, "[\"Engenheiro\"]", "user23" },
                    { 9, null, 9, "[\"Pedreiro\"]", "user24" },
                    { 10, null, 10, "[\"Encanador\"]", "user25" },
                    { 11, null, 11, "[\"Eletricista\"]", "user26" },
                    { 12, new Guid("c151318e-3c52-4120-a0c1-b47b35ce07d1"), 12, "[\"Arquiteto\"]", "user27" },
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
                table: "ProjectProfessionals",
                columns: new[] { "Id", "ProfessionalId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 6, 1 },
                    { 3, 2, 2 },
                    { 4, 7, 2 },
                    { 5, 3, 3 },
                    { 6, 8, 3 },
                    { 7, 4, 4 },
                    { 8, 9, 4 },
                    { 9, 5, 5 },
                    { 10, 10, 5 },
                    { 11, 11, 6 },
                    { 12, 12, 6 },
                    { 13, 13, 7 },
                    { 14, 14, 7 },
                    { 15, 15, 8 },
                    { 16, 1, 8 },
                    { 17, 6, 9 },
                    { 18, 2, 9 },
                    { 19, 7, 10 },
                    { 20, 3, 10 },
                    { 21, 8, 11 },
                    { 22, 4, 11 },
                    { 23, 9, 12 },
                    { 24, 5, 12 },
                    { 25, 10, 13 },
                    { 26, 11, 13 },
                    { 27, 12, 14 },
                    { 28, 13, 14 },
                    { 29, 14, 15 },
                    { 30, 15, 15 }
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
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProjecty_ProjectsProjectId",
                table: "GenericProfessionalProjecty",
                column: "ProjectsProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ArchId",
                table: "GenericProfessionals",
                column: "ArchId",
                unique: true,
                filter: "[ArchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_ClientId",
                table: "GenericProfessionals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_UserId",
                table: "GenericProfessionals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_ProfessionalId",
                table: "ProjectProfessionals",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProfessionals_ProjectId",
                table: "ProjectProfessionals",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ClientId",
                table: "Proposals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ProfessionalId",
                table: "Proposals",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ProjectId",
                table: "Proposals",
                column: "ProjectId");
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "GenericProfessionalProjecty");

            migrationBuilder.DropTable(
                name: "ProjectProfessionals");

            migrationBuilder.DropTable(
                name: "Proposals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "GenericProfessionals");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Architects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
