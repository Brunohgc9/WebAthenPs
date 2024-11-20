using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class socorro : Migration
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabinetmaker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    genericId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
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
                    EspecializationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_GenericProfessionals_GenericProfessionalProfessionalType_EspecializationsId",
                        column: x => x.EspecializationsId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Glazier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glazier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Glazier_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HydraulicEngineer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydraulicEngineer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydraulicEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InteriorDesigner",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteriorDesigner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InteriorDesigner_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Landscaper",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landscaper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landscaper_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarbleWorker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarbleWorker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarbleWorker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mason",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mason_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Metalworker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metalworker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metalworker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Painter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Painter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plasterer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plasterer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plasterer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plumber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plumber_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roofer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roofer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roofer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Surveyor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveyor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surveyor_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tiler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiler_GenericProfessionalProfessionalType_ProfessionalTypeId",
                        column: x => x.ProfessionalTypeId,
                        principalTable: "GenericProfessionalProfessionalType",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CPF", "City", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RG", "Role", "SecurityStamp", "State", "TwoFactorEnabled", "UpdatedDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "5c4e3a8c-ab56-47bb-80d8-b6bf66446d33", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4210), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "50c7c4f3-3401-47ef-a802-4b9d804eac45", "SP", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4217), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "80735f40-4424-48da-a437-1d7107f5b621", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4432), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "bf84080c-0e3e-4a61-bf2a-458aa898eddf", "AM", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4433), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "b1bddcda-b4cb-401e-aabc-883b947ca57d", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4496), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "93d45840-dc17-4c36-9b25-9b7ab1e604ed", "MA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4497), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "27ee90c1-4b4a-4f2c-b1d0-a22ac08cd6b6", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4512), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "33fab2ba-08f3-4c3b-9075-a5c848c473a3", "MA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4512), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "8a9cbeb3-adbf-4149-b026-bcaae2f5e9aa", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4525), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "9946c509-a669-4503-8e79-e6d9e6cf0682", "PI", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4525), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "80eaa52a-4ee9-4474-8183-8a089cd56dea", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4577), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "c3e1d18b-2cb2-42a6-a87b-91d458d5cfdd", "AL", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4578), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "e30670b1-7390-48f2-b146-da12fac3ca4e", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4590), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "036f9636-e148-4e80-9bc9-7e6107595410", "PB", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4596), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "a62ce7a0-ffe2-40b7-bde7-4aff24c8f786", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4611), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "7535c856-c66b-4bcd-b942-9584dcb51022", "SP", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4611), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "10ef07cc-beda-4c97-bd8d-d0e1abd171ed", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4624), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "6121940a-df27-41d4-b696-b672a6609526", "RJ", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4625), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "e1bbcde1-b347-4e94-afae-217f031ab466", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4637), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "2acb079a-2222-4cb1-8a36-bd707b3f76ee", "MG", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4637), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "39750548-cf0d-4c50-ad4c-a556bcd524ce", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4650), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "5cd12804-754b-4cb4-8a30-2d5118aa51ae", "BA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4650), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "972f3cba-30bc-41fa-81de-9ed8e3389273", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4315), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "e736f281-770c-4106-acc5-59aa7bff32e1", "RJ", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4315), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "5adfa864-4523-450c-93dd-0d98860dd510", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4662), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "b261bf70-bfba-46d9-b561-c55a74bfcde9", "CE", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4663), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "c5405670-2067-4617-bad7-104db915d1e6", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4675), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "4e7daa8e-1c4f-4d71-ae97-10843199e859", "PR", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4675), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "690d71bd-f3db-41dc-8f59-a58430fd5f5e", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4687), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "9f19370a-b349-478f-b656-cd4bcf22b37a", "RS", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4688), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "27039a20-0fe6-4e70-9ed2-dd6d349b8afb", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4700), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "a3fdb452-a8a0-4480-81cb-78ec3262d2ba", "MA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4700), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "bfa2808d-663e-4365-a554-f8803a176f4a", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4712), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "8ff690c9-6b94-486f-b596-85b83041bf20", "PI", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4712), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "ea9bbfe4-2ac3-4081-892a-4057d5366225", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4725), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "05458eed-c754-4094-92dd-15e0d228b171", "AL", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4725), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "ea30ff7c-7ef1-4ab4-b229-36d7ea58e927", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4736), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "7565edb8-3cd7-46ba-8f4a-fad5d0af7d61", "PB", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4737), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "e67e306c-2b83-4bf3-a150-a365596e44fb", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4748), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "334dda0f-4a88-4f7b-b7fa-86ae6dd9cdcd", "SP", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4748), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "99c21e7e-7bd6-4f5c-b739-be8e38d364d5", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4761), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "cd52d830-ab16-4235-9d19-090629f4161b", "RJ", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4761), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "3633e3b5-4490-476d-ba83-070b1cf9ed9f", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4772), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "0a311d5c-0ff8-46f1-9857-9c4133e988eb", "MG", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4772), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "6b4592ca-42ae-474d-96d0-ec10431e2123", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4329), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "7ff75d98-cd23-43f7-8d6f-25c7825756f5", "MG", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4329), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "38014bef-2a91-4485-9e19-fec3a4b0e8f1", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4819), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "3daca538-9bdd-4fba-9618-25be314623d2", "BA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4819), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "0158f8b5-dd29-4df7-90c9-805ef89d5db2", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4349), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "9d2fe591-a445-40f4-967f-eb13de3f39c3", "BA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4349), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "7d4a7e3b-b64c-4673-8e85-faadcba203a3", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4361), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "73f38916-bfa8-440a-9d70-9465e03c1844", "CE", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4362), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "20a96aba-5e46-4ef4-9780-18976975d5a0", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4383), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "24d022b5-86ff-4846-a775-ecc4385bdcfe", "PR", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4383), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "fad71f3e-1ea0-4dfa-b1a7-959ddb34b88d", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4395), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "665e9003-95f0-4fc5-b9f0-38d3259043fe", "RS", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4395), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "c893e552-a96e-4041-ae2c-38656df5ec36", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4407), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "4613c974-c6c2-43b0-8e46-8f2fa2feed3b", "PE", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4407), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "15d3de78-1262-4435-8032-030e1d882122", new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4421), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "72991d0d-de53-4593-84ab-15298b3e2193", "PA", false, new DateTime(2024, 11, 20, 18, 21, 44, 638, DateTimeKind.Utc).AddTicks(4421), "Ricardo Fernandes", "Client" }
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
                columns: new[] { "Id", "ClientId", "EspecializationsId", "ProfessionalTypes", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, "[\"Arquiteto\"]", "user16" },
                    { 2, 2, null, "[\"Eletricista\"]", "user17" },
                    { 3, 3, null, "[\"Engenheiro\"]", "user18" },
                    { 4, 4, null, "[\"Pedreiro\"]", "user19" },
                    { 5, 5, null, "[\"Encanador\"]", "user20" },
                    { 6, 6, null, "[\"Arquiteto\"]", "user21" },
                    { 7, 7, null, "[\"Eletricista\"]", "user22" },
                    { 8, 8, null, "[\"Engenheiro\"]", "user23" },
                    { 9, 9, null, "[\"Pedreiro\"]", "user24" },
                    { 10, 10, null, "[\"Encanador\"]", "user25" },
                    { 11, 11, null, "[\"Eletricista\"]", "user26" },
                    { 12, 12, null, "[\"Arquiteto\"]", "user27" },
                    { 13, 13, null, "[\"Engenheiro\"]", "user28" },
                    { 14, 14, null, "[\"Pedreiro\"]", "user29" },
                    { 15, 15, null, "[\"Encanador\"]", "user30" }
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
                name: "IX_GenericProfessionals_ClientId",
                table: "GenericProfessionals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProfessionals_EspecializationsId",
                table: "GenericProfessionals",
                column: "EspecializationsId");

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
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabinetmaker_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Cabinetmaker",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carpenter_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Carpenter",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CivilEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "CivilEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Decorator_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Decorator",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalEngineer_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "ElectricalEngineer",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Electrician_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Electrician",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foreman_GenericProfessionalProfessionalType_ProfessionalTypeId",
                table: "Foreman",
                column: "ProfessionalTypeId",
                principalTable: "GenericProfessionalProfessionalType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProfessionalProfessionalType_GenericProfessionals_genericId",
                table: "GenericProfessionalProfessionalType",
                column: "genericId",
                principalTable: "GenericProfessionals",
                principalColumn: "Id");

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
                name: "FK_GenericProfessionals_GenericProfessionalProfessionalType_EspecializationsId",
                table: "GenericProfessionals");

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
                name: "Architects");

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
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
