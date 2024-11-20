using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewProfessionalTypes : Migration
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
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
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
                name: "ChatAndUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatAndUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatAndUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatAndUsers_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatMessages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                name: "Architects",
                columns: table => new
                {
                    ArchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    genericId = table.Column<int>(type: "int", nullable: false),
                    RegistroConselho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    ProfessionalId = table.Column<int>(type: "int", nullable: false),
                    ContractedAs = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    ToBeContractedAs = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Cabinetmaker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinetmaker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carpenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carpenter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CivilEngineer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivilEngineer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decorator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decorator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalEngineer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalEngineer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Electrician",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electrician", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foreman",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foreman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenericProfessionalProfessionalType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    genericId = table.Column<int>(type: "int", nullable: false),
                    ArchitectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CivilEngineerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ElectricalEngineerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HydraulicEngineerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurveyorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ForemanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ElectricianId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CarpenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RooferId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlastererId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TilerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PainterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MetalworkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GlazierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MarbleWorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LandscaperId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CabinetmakerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InteriorDesignerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DecoratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProfessionalProfessionalType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_Architects_ArchitectId",
                        column: x => x.ArchitectId,
                        principalTable: "Architects",
                        principalColumn: "ArchId");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_Cabinetmaker_CabinetmakerId",
                        column: x => x.CabinetmakerId,
                        principalTable: "Cabinetmaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_Carpenter_CarpenterId",
                        column: x => x.CarpenterId,
                        principalTable: "Carpenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_CivilEngineer_CivilEngineerId",
                        column: x => x.CivilEngineerId,
                        principalTable: "CivilEngineer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_Decorator_DecoratorId",
                        column: x => x.DecoratorId,
                        principalTable: "Decorator",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_ElectricalEngineer_ElectricalEngineerId",
                        column: x => x.ElectricalEngineerId,
                        principalTable: "ElectricalEngineer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_Electrician_ElectricianId",
                        column: x => x.ElectricianId,
                        principalTable: "Electrician",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_Foreman_ForemanId",
                        column: x => x.ForemanId,
                        principalTable: "Foreman",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericProfessionalProfessionalType_GenericProfessionals_genericId",
                        column: x => x.genericId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Glazier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glazier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Glazier_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HydraulicEngineer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydraulicEngineer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydraulicEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InteriorDesigner",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteriorDesigner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InteriorDesigner_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Landscaper",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landscaper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landscaper_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarbleWorker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarbleWorker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarbleWorker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mason",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mason_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Metalworker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metalworker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metalworker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Painter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Painter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plasterer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plasterer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plasterer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plumber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plumber_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roofer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roofer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roofer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Surveyor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveyor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surveyor_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tiler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiler_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "ProfessionalTypeId", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("9876b54c-7952-4f52-a170-ed3036394792"), "Residencial", new Guid("00000000-0000-0000-0000-000000000000"), "123456", 1 },
                    { new Guid("a05cf0e7-d957-44ba-9e2a-313def7408ba"), "Comercial", new Guid("00000000-0000-0000-0000-000000000000"), "654321", 6 },
                    { new Guid("c151318e-3c52-4120-a0c1-b47b35ce07d1"), "Industrial", new Guid("00000000-0000-0000-0000-000000000000"), "112233", 12 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CPF", "City", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RG", "Role", "SecurityStamp", "State", "TwoFactorEnabled", "UpdatedDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "2f1b5b2e-723c-43a3-8615-07391efe34d8", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9557), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "f2bc2f93-c2fe-48dc-b9bd-8c39098dfe0e", "SP", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9560), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "f4860936-1165-475e-b957-2bdd94f8cbb2", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9803), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "444f9402-e069-445a-ae1c-feeb33a9f39c", "AM", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9803), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "16ff764d-9e40-438f-b6b7-d4c526add32a", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9860), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "9ea96628-1a1c-440f-95f5-b40a730b8110", "MA", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9860), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "122a501c-5aec-4323-b45f-c921b423f044", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9872), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "514c8667-6e92-4a71-a197-dd1137513cd1", "MA", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9872), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "d1f03018-a791-4275-b7f9-992106649cff", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9883), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "5b56df92-d354-40fe-a84c-54a283b94ebe", "PI", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9884), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "4f603cf4-9cb5-49b4-9f35-e7dc5c8db822", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9896), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "bb5a948f-2ee8-47e2-81aa-12c93c22e6d6", "AL", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9896), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "421969d6-8667-4848-8c47-0c42696a752c", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9907), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "06aa0e14-334b-4650-91a2-85dea1f4e7c2", "PB", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9911), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "03a4b7ca-b3e9-4de7-821a-1b784066326a", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9935), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "60654242-a94d-4b00-a711-d71a29f07d2e", "SP", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9935), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "f01a239f-5599-46c2-be03-a5439fc26316", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9947), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "fe2b28af-8bb3-49b3-98c1-fa24ee170c0f", "RJ", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9948), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "e7bba4f4-bffd-487e-970d-c779eab286e4", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9973), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "30a6ce5b-d20b-4186-8516-dc0f49b9f58a", "MG", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9973), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "c1a714d7-caea-4eb6-9f9c-532e36253c48", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9984), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "5a75a069-98ee-4dfc-9bb9-183586593745", "BA", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9985), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "fdd7f274-a7b7-4936-84b5-f0fc558ff9de", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9676), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "56c50c99-232c-42d2-adc5-13f91bfc4b76", "RJ", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9676), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "10ae124d-9d51-4514-b4e6-9cc791a7630b", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9997), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "8acaa2e0-9626-428f-98a0-0903060fee49", "CE", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9997), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "06982ebf-17d9-4750-a761-bcb6cd9160c8", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(8), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "97940f63-f74c-4c06-82ce-09b28f397c1c", "PR", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(8), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "48c088ea-40ea-4ca8-86ac-de9daa7be9c7", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(21), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "94c484f4-1624-430c-9afa-ecdf1e7902db", "RS", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(21), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "99b57c3d-a946-4c9d-8ada-b14536631e2b", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(32), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "4172101d-6296-4ba7-8718-af32c3184109", "MA", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(32), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "650bcc51-cb03-4e47-ab5f-48828e2cd259", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(42), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "1c2b6808-0386-4402-be80-d03d8151f9ab", "PI", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(43), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "58517fff-8ed5-4bb1-9467-68fe042e05e3", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(55), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "a5306a45-233d-42d5-a357-4a7affe9afe6", "AL", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(55), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "c93f7ae3-ecec-45d3-9a21-7411b9acb2da", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(66), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "fc3f055f-6a25-406d-9b3a-8c3523ef832b", "PB", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(66), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "259f02b6-8c3b-4ab9-b3cf-2d5ceaae96e8", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(76), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "d4b959b8-feb8-4b1d-95c9-39ed2bc99666", "SP", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(77), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "417bd387-0ecd-49d2-be58-7c1d854407cc", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(88), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "eb7bb4fc-7511-4d98-b254-6b7ea96596a8", "RJ", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(89), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "bc7cf018-f91a-463e-965c-6d6cfa4e4c1e", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(99), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "93876010-bac5-4f59-becf-cf38ee96d8b3", "MG", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(100), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "66473c83-85ad-4278-b44a-2ae4a2cdd0cd", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9691), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "61c51088-5c3b-4364-984a-ee9d4eb00ef5", "MG", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9691), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "eb1ac71f-9540-450e-bd17-9f9ebc1a023f", new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(112), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "4a982498-573e-4c23-a1b7-093fd63dc104", "BA", false, new DateTime(2024, 11, 20, 12, 39, 32, 562, DateTimeKind.Utc).AddTicks(112), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "2066b76b-f780-47de-9d4f-600e2480d2f8", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9713), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "c2aaef83-76d7-4839-9659-9f44550852c2", "BA", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9714), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "f11d99ed-5224-4b1c-b013-1a34eff79e33", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9728), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "92357639-57ff-406c-a5b4-f2a10e1673a7", "CE", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9729), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "22977428-08c2-4c41-a945-ba6cc6ea687c", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9755), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "e4fc0ba9-75ea-495c-b9d3-9d6d6139ae80", "PR", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9755), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "96ce392a-7a38-4040-9a5c-81ed45b8302c", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9768), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "8cb648f7-da50-4818-9abf-0e79fbab079b", "RS", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9768), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "3509db5a-560a-41db-b1e2-15bca0018895", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9779), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "8aa19832-1d93-4d1a-a0f8-67a17df29dd0", "PE", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9779), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "a8c05dc0-e641-4bac-8992-70867b28d49e", new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9792), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "bb85cc3c-15a7-4361-a0d0-07dece399445", "PA", false, new DateTime(2024, 11, 20, 12, 39, 32, 561, DateTimeKind.Utc).AddTicks(9792), "Ricardo Fernandes", "Client" }
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
                columns: new[] { "ProjectId", "ActStep", "Address", "Budget", "City", "ClientDescription", "ClientId", "ConstructionType", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "ProjectName", "ProjectSize", "ProjectType", "StartDate", "State", "Status", "TotalArea" },
                values: new object[,]
                {
                    { 1, "Phase 1", "123 Main St", 500000m, "CityA", null, 1, "Residential", "CountryA", "Residential building item", null, "Downtown", 3, 4, "12345", "Project Alpha", null, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateA", "In Progress", 250.5m },
                    { 2, "Phase 2", "456 Oak St", 1000000m, "CityB", null, 2, "Commercial", "CountryB", "Commercial building item", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business District", 5, 10, "23456", "Project Beta", null, null, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateB", "Completed", 500.0m },
                    { 3, "Initial Planning", "789 Pine St", 250000m, "CityC", null, 3, "Residential", "CountryC", "Planning phase", null, "Suburban", 2, 3, "34567", "Project Gamma", null, null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateC", "Planning", 180.0m },
                    { 4, "Construction", "101 Maple St", 750000m, "CityD", null, 4, "Commercial", "CountryD", "Office building item", null, "Tech Park", 4, 8, "45678", "Project Delta", null, null, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateD", "In Progress", 350.0m },
                    { 5, "Final Touches", "202 Birch St", 300000m, "CityE", null, 5, "Residential", "CountryE", "Single-family home", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quiet Street", 3, 5, "56789", "Project Epsilon", null, null, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateE", "Completed", 220.0m },
                    { 6, "Site Selection", "303 Cedar St", 1200000m, "CityF", null, 6, "Commercial", "CountryF", "Shopping mall", null, "Retail Hub", 10, 20, "67890", "Project Zeta", null, null, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateF", "Planning", 800.0m },
                    { 7, "Structural Work", "404 Fir St", 600000m, "CityG", null, 7, "Residential", "CountryG", "Luxury apartments", null, "Uptown", 4, 6, "78901", "Project Eta", null, null, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateG", "In Progress", 350.0m },
                    { 8, "Inspection", "505 Spruce St", 500000m, "CityH", null, 8, "Commercial", "CountryH", "Retail space", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Main Street", 1, 2, "89012", "Project Theta", null, null, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateH", "Completed", 150.0m },
                    { 9, "Budget Approval", "606 Hemlock St", 400000m, "CityI", null, 9, "Residential", "CountryI", "Vacation home", null, "Lakeside", 2, 4, "90123", "Project Iota", null, null, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateI", "Planning", 300.0m },
                    { 10, "Interior Design", "707 Juniper St", 800000m, "CityJ", null, 10, "Commercial", "CountryJ", "Restaurant", null, "Downtown", 3, 5, "01234", "Project Kappa", null, null, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateJ", "In Progress", 250.0m },
                    { 11, "Landscaping", "808 Willow St", 350000m, "CityK", null, 11, "Residential", "CountryK", "Townhouse", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic District", 2, 4, "12346", "Project Lambda", null, null, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateK", "Completed", 200.0m },
                    { 12, "Permitting", "909 Poplar St", 950000m, "CityL", null, 12, "Commercial", "CountryL", "Corporate office", null, "Business District", 4, 8, "23457", "Project Mu", null, null, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateL", "Planning", 400.0m },
                    { 13, "Framing", "1010 Redwood St", 700000m, "CityM", null, 13, "Residential", "CountryM", "Condo complex", null, "Urban Area", 4, 6, "34568", "Project Nu", null, null, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateM", "In Progress", 350.0m },
                    { 14, "Final Inspection", "1111 Cedar St", 1100000m, "CityN", null, 14, "Commercial", "CountryN", "Tech campus", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Innovation Hub", 15, 30, "45679", "Project Xi", null, null, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateN", "Completed", 1000.0m },
                    { 15, "Design Approval", "1212 Birch St", 550000m, "CityO", null, 15, "Residential", "CountryO", "Eco-friendly home", null, "Green Valley", 3, 4, "56790", "Project Omicron", null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateO", "Planning", 275.0m }
                });

            migrationBuilder.InsertData(
                table: "ProjectProfessionals",
                columns: new[] { "Id", "ContractedAs", "ProfessionalId", "ProjectId" },
                values: new object[,]
                {
                    { 1, "[\"Arquiteto\"]", 1, 1 },
                    { 2, "[\"Arquiteto\"]", 6, 1 },
                    { 3, "[\"Eletricista\"]", 2, 2 },
                    { 4, "[\"Eletricista\"]", 7, 2 },
                    { 5, "[\"Engenheiro\"]", 3, 3 },
                    { 6, "[\"Engenheiro\"]", 8, 3 },
                    { 7, "[\"Pedreiro\"]", 4, 4 },
                    { 8, "[\"Pedreiro\"]", 9, 4 },
                    { 9, "[\"Encanador\"]", 5, 5 },
                    { 10, "[\"Encanador\"]", 10, 5 },
                    { 11, "[\"Eletricista\"]", 11, 6 },
                    { 12, "[\"Arquiteto\"]", 12, 6 },
                    { 13, "[\"Engenheiro\"]", 13, 7 },
                    { 14, "[\"Pedreiro\"]", 14, 7 },
                    { 15, "[\"Encanador\"]", 15, 8 },
                    { 16, "[\"Arquiteto\"]", 1, 8 },
                    { 17, "[\"Arquiteto\"]", 6, 9 },
                    { 18, "[\"Eletricista\"]", 2, 9 },
                    { 19, "[\"Eletricista\"]", 7, 10 },
                    { 20, "[\"Engenheiro\"]", 3, 10 },
                    { 21, "[\"Engenheiro\"]", 8, 11 },
                    { 22, "[\"Pedreiro\"]", 4, 11 },
                    { 23, "[\"Pedreiro\"]", 9, 12 },
                    { 24, "[\"Encanador\"]", 5, 12 },
                    { 25, "[\"Encanador\"]", 10, 13 },
                    { 26, "[\"Eletricista\"]", 11, 13 },
                    { 27, "[\"Arquiteto\"]", 12, 14 },
                    { 28, "[\"Engenheiro\"]", 13, 14 },
                    { 29, "[\"Pedreiro\"]", 14, 15 },
                    { 30, "[\"Encanador\"]", 15, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Architects_ProfessionalTypeId",
                table: "Architects",
                column: "ProfessionalTypeId");

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
                name: "IX_Cabinetmaker_ProfessionalTypeId",
                table: "Cabinetmaker",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Carpenter_ProfessionalTypeId",
                table: "Carpenter",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatAndUsers_ChatId",
                table: "ChatAndUsers",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatAndUsers_UserId",
                table: "ChatAndUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ChatId",
                table: "ChatMessages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_UserId",
                table: "ChatMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CivilEngineer_ProfessionalTypeId",
                table: "CivilEngineer",
                column: "ProfessionalTypeId");

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
                name: "IX_Decorator_ProfessionalTypeId",
                table: "Decorator",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalEngineer_ProfessionalTypeId",
                table: "ElectricalEngineer",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Electrician_ProfessionalTypeId",
                table: "Electrician",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Foreman_ProfessionalTypeId",
                table: "Foreman",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_ArchitectId",
                table: "GenericProfessionalProfessionalType",
                column: "ArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_CabinetmakerId",
                table: "GenericProfessionalProfessionalType",
                column: "CabinetmakerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_CarpenterId",
                table: "GenericProfessionalProfessionalType",
                column: "CarpenterId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_CivilEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "CivilEngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_DecoratorId",
                table: "GenericProfessionalProfessionalType",
                column: "DecoratorId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_ElectricalEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "ElectricalEngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_ElectricianId",
                table: "GenericProfessionalProfessionalType",
                column: "ElectricianId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_ForemanId",
                table: "GenericProfessionalProfessionalType",
                column: "ForemanId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_genericId",
                table: "GenericProfessionalProfessionalType",
                column: "genericId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_GlazierId",
                table: "GenericProfessionalProfessionalType",
                column: "GlazierId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "HydraulicEngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_InteriorDesignerId",
                table: "GenericProfessionalProfessionalType",
                column: "InteriorDesignerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_LandscaperId",
                table: "GenericProfessionalProfessionalType",
                column: "LandscaperId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_MarbleWorkerId",
                table: "GenericProfessionalProfessionalType",
                column: "MarbleWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_MasonId",
                table: "GenericProfessionalProfessionalType",
                column: "MasonId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_MetalworkerId",
                table: "GenericProfessionalProfessionalType",
                column: "MetalworkerId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_PainterId",
                table: "GenericProfessionalProfessionalType",
                column: "PainterId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_PlastererId",
                table: "GenericProfessionalProfessionalType",
                column: "PlastererId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_PlumberId",
                table: "GenericProfessionalProfessionalType",
                column: "PlumberId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_RooferId",
                table: "GenericProfessionalProfessionalType",
                column: "RooferId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_SurveyorId",
                table: "GenericProfessionalProfessionalType",
                column: "SurveyorId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionalProfessionalType_TilerId",
                table: "GenericProfessionalProfessionalType",
                column: "TilerId");

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
                name: "IX_Glazier_ProfessionalTypeId",
                table: "Glazier",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HydraulicEngineer_ProfessionalTypeId",
                table: "HydraulicEngineer",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InteriorDesigner_ProfessionalTypeId",
                table: "InteriorDesigner",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Landscaper_ProfessionalTypeId",
                table: "Landscaper",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MarbleWorker_ProfessionalTypeId",
                table: "MarbleWorker",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mason_ProfessionalTypeId",
                table: "Mason",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Metalworker_ProfessionalTypeId",
                table: "Metalworker",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Painter_ProfessionalTypeId",
                table: "Painter",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plasterer_ProfessionalTypeId",
                table: "Plasterer",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plumber_ProfessionalTypeId",
                table: "Plumber",
                column: "ProfessionalTypeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Roofer_ProfessionalTypeId",
                table: "Roofer",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveyor_ProfessionalTypeId",
                table: "Surveyor",
                column: "ProfessionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiler_ProfessionalTypeId",
                table: "Tiler",
                column: "ProfessionalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Architects_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Architects",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cabinetmaker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Cabinetmaker",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carpenter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Carpenter",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CivilEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "CivilEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decorator_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Decorator",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "ElectricalEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Electrician_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Electrician",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foreman_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Foreman",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Glazier_GlazierId",
                table: "GenericProfessionalProfessionalType",
                column: "GlazierId",
                principalTable: "Glazier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_HydraulicEngineer_HydraulicEngineerId",
                table: "GenericProfessionalProfessionalType",
                column: "HydraulicEngineerId",
                principalTable: "HydraulicEngineer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_InteriorDesigner_InteriorDesignerId",
                table: "GenericProfessionalProfessionalType",
                column: "InteriorDesignerId",
                principalTable: "InteriorDesigner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Landscaper_LandscaperId",
                table: "GenericProfessionalProfessionalType",
                column: "LandscaperId",
                principalTable: "Landscaper",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_MarbleWorker_MarbleWorkerId",
                table: "GenericProfessionalProfessionalType",
                column: "MarbleWorkerId",
                principalTable: "MarbleWorker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Mason_MasonId",
                table: "GenericProfessionalProfessionalType",
                column: "MasonId",
                principalTable: "Mason",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Metalworker_MetalworkerId",
                table: "GenericProfessionalProfessionalType",
                column: "MetalworkerId",
                principalTable: "Metalworker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Painter_PainterId",
                table: "GenericProfessionalProfessionalType",
                column: "PainterId",
                principalTable: "Painter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Plasterer_PlastererId",
                table: "GenericProfessionalProfessionalType",
                column: "PlastererId",
                principalTable: "Plasterer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Plumber_PlumberId",
                table: "GenericProfessionalProfessionalType",
                column: "PlumberId",
                principalTable: "Plumber",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Roofer_RooferId",
                table: "GenericProfessionalProfessionalType",
                column: "RooferId",
                principalTable: "Roofer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Surveyor_SurveyorId",
                table: "GenericProfessionalProfessionalType",
                column: "SurveyorId",
                principalTable: "Surveyor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_Tiler_TilerId",
                table: "GenericProfessionalProfessionalType",
                column: "TilerId",
                principalTable: "Tiler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Architects_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Architects");

            migrationBuilder.DropForeignKey(
                name: "FK_Cabinetmaker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Cabinetmaker");

            migrationBuilder.DropForeignKey(
                name: "FK_Carpenter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Carpenter");

            migrationBuilder.DropForeignKey(
                name: "FK_CivilEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "CivilEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_Decorator_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Decorator");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "ElectricalEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_Electrician_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Electrician");

            migrationBuilder.DropForeignKey(
                name: "FK_Foreman_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Foreman");

            migrationBuilder.DropForeignKey(
                name: "FK_Glazier_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Glazier");

            migrationBuilder.DropForeignKey(
                name: "FK_HydraulicEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "HydraulicEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDesigner_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "InteriorDesigner");

            migrationBuilder.DropForeignKey(
                name: "FK_Landscaper_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Landscaper");

            migrationBuilder.DropForeignKey(
                name: "FK_MarbleWorker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "MarbleWorker");

            migrationBuilder.DropForeignKey(
                name: "FK_Mason_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Mason");

            migrationBuilder.DropForeignKey(
                name: "FK_Metalworker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Metalworker");

            migrationBuilder.DropForeignKey(
                name: "FK_Painter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Painter");

            migrationBuilder.DropForeignKey(
                name: "FK_Plasterer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Plasterer");

            migrationBuilder.DropForeignKey(
                name: "FK_Plumber_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Plumber");

            migrationBuilder.DropForeignKey(
                name: "FK_Roofer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Roofer");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveyor_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Surveyor");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiler_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Tiler");

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
                name: "ChatAndUsers");

            migrationBuilder.DropTable(
                name: "ChatMessages");

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
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "GenericProfessionalProfessionalType");

            migrationBuilder.DropTable(
                name: "Cabinetmaker");

            migrationBuilder.DropTable(
                name: "Carpenter");

            migrationBuilder.DropTable(
                name: "CivilEngineer");

            migrationBuilder.DropTable(
                name: "Decorator");

            migrationBuilder.DropTable(
                name: "ElectricalEngineer");

            migrationBuilder.DropTable(
                name: "Electrician");

            migrationBuilder.DropTable(
                name: "Foreman");

            migrationBuilder.DropTable(
                name: "GenericProfessionals");

            migrationBuilder.DropTable(
                name: "Glazier");

            migrationBuilder.DropTable(
                name: "HydraulicEngineer");

            migrationBuilder.DropTable(
                name: "InteriorDesigner");

            migrationBuilder.DropTable(
                name: "Landscaper");

            migrationBuilder.DropTable(
                name: "MarbleWorker");

            migrationBuilder.DropTable(
                name: "Mason");

            migrationBuilder.DropTable(
                name: "Metalworker");

            migrationBuilder.DropTable(
                name: "Painter");

            migrationBuilder.DropTable(
                name: "Plasterer");

            migrationBuilder.DropTable(
                name: "Plumber");

            migrationBuilder.DropTable(
                name: "Roofer");

            migrationBuilder.DropTable(
                name: "Surveyor");

            migrationBuilder.DropTable(
                name: "Tiler");

            migrationBuilder.DropTable(
                name: "Architects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
