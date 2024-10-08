using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class idkkk2 : Migration
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
                name: "Proposals",
                columns: table => new
                {
                    ProposalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProposalMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProposalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProposalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false)
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
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProfessionals", x => new { x.ProfessionalId, x.ProjectId });
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
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "a8080e1d-8fe4-4abe-84a4-5fb2f158b112", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8129), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "688e0477-af08-412e-8e9f-ddf3f9a9273c", "SP", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8132), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "2e7d518c-e673-4587-b87a-61162b58f3e4", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8383), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "5d9b4d2a-b2b7-44c2-8d60-9ea749e8ce48", "AM", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8383), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "cbe0a376-d56e-42b3-83b2-8285f6743d3f", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8450), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "0151d87a-2a10-4ee9-888e-cf9fa95e9b69", "MA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8450), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "5cf86a42-9279-4807-9010-fc2484cd0056", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8465), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "c5adb846-5b99-4295-950c-6bd5c7a03057", "MA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8465), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "c70d4577-84c4-4634-b01a-f4229cf57d61", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8479), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "65fcbfe7-7f02-4b08-a720-b6cf12490134", "PI", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8479), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "7b8fefaa-72bb-4e25-bdcc-f88a9c90fd1a", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8491), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "67353999-97af-4e8d-aed0-addc7c94bb3c", "AL", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8491), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "c6f7773e-e572-4654-a097-3944f5e2a753", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8506), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "456d8fcb-3a9b-428d-977a-20b5a87d008d", "PB", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8511), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "decb87d0-455a-4e48-b244-a5756fbb2726", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8532), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "78737a98-3016-4fe7-b691-cbf0dcf3acda", "SP", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8533), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "1287d92f-d9a6-44be-83b4-be39ce209554", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8600), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "50588624-2326-4a98-be64-17876ce0bca1", "RJ", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8601), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "8045d9a4-df04-4aca-bb50-3b074b064b28", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8615), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "aa2cc6c6-70db-453f-a96e-1b5513233d1d", "MG", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8615), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "fd4aa34a-b75a-43a4-8300-145887b274a1", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8627), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "63862d5d-3b90-4fab-a0e9-281dfc360077", "BA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8627), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "92fe23d9-9a44-45a4-8dc5-faaaa0e94eab", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8269), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "cc952c3d-d2ab-4d20-844e-7d2c33dbf973", "RJ", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8269), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "6108aea4-9ebb-4a6c-86dc-e51f3d348e89", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8641), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "2472e1bd-c097-4c0b-9c6e-56d635f9f44b", "CE", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8642), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "7959c3db-ecc6-4b2b-9030-468aaaaffd60", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8653), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "a1e3a136-e3f9-41eb-9acb-db5434f73ee2", "PR", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8654), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "029a91a5-cd01-4d4d-91a2-030c2845eead", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8665), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "6b5bb1aa-28c0-4ed1-b40a-d9f872852240", "RS", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8666), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "5bd42aff-ae10-4ff9-9096-a4d8fc91dbb0", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8680), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "04bf9b62-523d-4125-a743-e665a1851d2c", "MA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8680), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "6fe0679e-3fd9-4cdb-b321-63a22b30b159", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8693), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "b895afff-2311-4413-b4dd-3ddc1a84ee30", "PI", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8693), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "d21556c5-0153-484b-90f0-424378821001", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8705), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "1fb20f1a-fe9d-4312-9b4d-258bf79edd00", "AL", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8705), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "0878c13a-cadf-4525-a134-e13a4c6b04f3", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8720), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "512a2466-d5bf-4253-b847-e6abe2b21629", "PB", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8720), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "9de60f67-5049-4c05-9941-0f2cb3dd9e51", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8732), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "386a6ecb-c1e3-40c5-9b6a-60957e7a7041", "SP", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8732), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "13bbaa9a-c68e-4bb7-92d4-d22ba89b56d6", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8747), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "966595cd-cec9-4c11-b9e1-7d9dc95ca268", "RJ", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8747), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "c5ece0e5-d5da-4404-9cc8-07a1c8dc0e61", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8759), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "65f4240a-7686-4434-88e5-711b33d14792", "MG", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8759), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "60e50d87-9141-4d2c-8148-b49845bf4a86", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8282), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "2f37ca53-5ceb-42c9-a813-239d1b7e95e0", "MG", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8282), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "e88173c8-42e5-467c-9a1c-9ff45627a1df", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8771), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "ac05390e-08ab-4f75-be62-d2728956efa9", "BA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8771), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "597441cc-0bfa-42b2-afce-788245596280", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8297), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "e98f3eda-e06d-46f1-8c45-ddbb891c1caf", "BA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8298), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "c80a7976-88fc-455c-96e1-7769efa98d91", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8310), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "82f62248-819c-4c61-a0a5-d881f98a5331", "CE", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8310), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "ff5f8d96-f93e-4bc3-980a-ea78d7652d46", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8329), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "7e0fbd0f-5a95-4478-b4d2-a9e3857a21f5", "PR", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8329), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "df679334-65ce-4d61-b46f-8b3339b26fe5", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8344), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "09733840-d953-4251-b2ea-2902f9cff543", "RS", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8344), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "f02209cb-6a5d-48d4-839e-7c235e188368", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8356), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "d7adc2ac-ee50-4285-95b0-a1ea4708f4f4", "PE", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8356), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "fdbc9075-43b0-453a-b8c5-f21b4957c2cb", new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8368), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "7c827c2f-a779-4f76-8739-4cc0fe4b5b2b", "PA", false, new DateTime(2024, 10, 8, 18, 20, 53, 749, DateTimeKind.Utc).AddTicks(8369), "Ricardo Fernandes", "Client" }
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
                columns: new[] { "ProfessionalId", "ProjectId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 8, 1 },
                    { 2, 2, 3 },
                    { 2, 9, 3 },
                    { 3, 3, 5 },
                    { 3, 10, 5 },
                    { 4, 4, 7 },
                    { 4, 11, 7 },
                    { 5, 5, 9 },
                    { 5, 12, 9 },
                    { 6, 1, 2 },
                    { 6, 9, 2 },
                    { 7, 2, 4 },
                    { 7, 10, 4 },
                    { 8, 3, 6 },
                    { 8, 11, 6 },
                    { 9, 4, 8 },
                    { 9, 12, 8 },
                    { 10, 5, 10 },
                    { 10, 13, 10 },
                    { 11, 6, 11 },
                    { 11, 13, 11 },
                    { 12, 6, 12 },
                    { 12, 14, 12 },
                    { 13, 7, 13 },
                    { 13, 14, 13 },
                    { 14, 7, 14 },
                    { 14, 15, 14 },
                    { 15, 8, 15 },
                    { 15, 15, 15 }
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
