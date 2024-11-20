using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
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
                    { "user1", 0, "Rua A, 123", "12345678901", "São Paulo", "f44e27fa-f9e9-4afb-9ab2-cb47c9e1dc60", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7230), "carlos.silva@example.com", false, "M", false, null, null, null, null, null, false, "01000-000", "1234567", null, "957c9c58-2d99-4f18-bd8e-7789242c9a5b", "SP", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7233), "Carlos Silva", "Client" },
                    { "user10", 0, "Rua J, 707", "01234567890", "Manaus", "93e7c2d4-dc28-45a1-bb18-6373dbf591a5", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7448), "claudia.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "69000-000", "0123456", null, "27b281b6-6560-4400-a95d-e7e43e53a63a", "AM", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7448), "Claudia Rodrigues", "Client" },
                    { "user11", 0, "Rua K, 808", "12345678901", "São Luís", "106c99ad-6c26-462f-a71d-c3a833c40952", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7459), "fernando.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "65000-000", "1234567", null, "174709c2-7696-4e24-8cb2-5ba910c8beef", "MA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7460), "Fernando Oliveira", "Client" },
                    { "user12", 0, "Rua L, 909", "23456789012", "São José de Ribamar", "f0dc579f-1a59-42bc-a78d-44a03ff97c21", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7472), "luciana.pereira@example.com", false, "F", false, null, null, null, null, null, false, "65100-000", "2345678", null, "0d304797-deeb-4642-8ba0-ad0bde0822e7", "MA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7472), "Luciana Pereira", "Client" },
                    { "user13", 0, "Rua M, 1010", "34567890123", "Teresina", "4b57bc09-92b1-4f70-aefb-16718357f785", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7483), "eduardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "64000-000", "3456789", null, "bfb6108f-ba27-480e-b33f-f5d73965b982", "PI", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7484), "Eduardo Costa", "Client" },
                    { "user14", 0, "Rua N, 1111", "45678901234", "Maceió", "72213e0a-f3ec-4125-a6d8-4aef7a0a8425", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7496), "renata.almeida@example.com", false, "F", false, null, null, null, null, null, false, "57000-000", "4567890", null, "724c8485-8eb6-4d0b-807d-92c522a20994", "AL", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7496), "Renata Almeida", "Client" },
                    { "user15", 0, "Rua O, 1212", "56789012345", "João Pessoa", "0a619d9b-7670-4c61-9df7-bdc440664125", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7508), "carlos.eduardo@example.com", false, "M", false, null, null, null, null, null, false, "58000-000", "5678901", null, "03bf4293-dc22-465e-81ad-42b3bc02fe7e", "PB", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7508), "Carlos Eduardo", "Client" },
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "140f226a-aecf-4e90-91f7-283a840a9c90", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7519), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "56cde23a-b00c-425d-b3a4-1ccbbea09b41", "SP", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7520), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "f0fe4ab8-ac28-4ba1-9e3d-dde2572b4b5c", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7532), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "223f4563-9aaa-4379-a5e1-9c35e4eeb02e", "RJ", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7532), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "a3f34e1d-3066-421c-a11d-687aabb1df63", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7543), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "c97bfca3-ce41-4315-afe7-cd735da0a600", "MG", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7543), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "115a2621-b0cd-4d50-9d06-d9c94891ce61", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7554), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "d799b6c0-b376-454d-a644-fa81ea907bee", "BA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7555), "Juliana Costa", "Professional" },
                    { "user2", 0, "Rua B, 456", "23456789012", "Rio de Janeiro", "d8989bc3-4955-4577-a0cd-67b79edeab79", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7309), "ana.souza@example.com", false, "F", false, null, null, null, null, null, false, "20000-000", "2345678", null, "5c321cf0-a6bf-44d3-bc23-22fac53e4bb2", "RJ", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7309), "Ana Souza", "Client" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "2edebec4-de48-4433-ac6e-530202ffd3b1", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7567), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "68d5f67a-0320-4a88-8715-b314d063ee17", "CE", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7567), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "a2804c76-8fed-4292-9f8e-4fe4d2119e01", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7578), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "c1921a0e-66a7-4807-9126-076d8b419d40", "PR", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7578), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "da0f92ec-1db8-45cd-a310-43b67894f243", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7589), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "5494bca4-2aa0-44bf-b2e2-ed43c513ae70", "RS", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7589), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "0e39a3fb-bd5e-4ea3-b6b7-d5f1ea0acf53", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7602), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "1cf26a3c-8239-4f58-bdea-4cb88bace1b3", "MA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7602), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "9b62d58f-98c6-49ad-888d-3f10cf03003c", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7614), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "d2d4bb9b-d546-48ad-9dde-64847f777a95", "PI", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7614), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "f1c55f9d-f4b6-4c87-baec-6b465bc8cb3b", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7659), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "248b7ac6-5c34-428c-9f7c-7659527877ed", "AL", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7660), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "17cd6c67-610c-47cc-b1a1-b3f1f617fd78", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7671), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "0232e665-4001-46d9-a467-5f4de4e4250b", "PB", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7671), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "b7b5d23d-a9d7-4938-a70e-78931d2ae8d9", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7682), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "7a825e5f-efab-4790-959f-ad77b9d99d73", "SP", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7683), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "9ddf9433-5848-410f-9106-3cf3aa169dfe", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7695), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "d9329161-b829-42a9-8583-0ac9846ffee1", "RJ", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7695), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "7294afb3-c9f2-42a7-836e-8b11cb5ee6e6", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7706), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "b1c693d1-6502-4e27-bc83-45e51ebcc75d", "MG", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7707), "Juliana Rodrigues", "Professional" },
                    { "user3", 0, "Rua C, 789", "34567890123", "Belo Horizonte", "30ac8251-db35-4119-85ed-bb67eca3bbd9", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7321), "joao.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "30000-000", "3456789", null, "d361c97e-b59b-4ecf-82f9-779f80da1df7", "MG", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7322), "João Oliveira", "Client" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "2d341339-ca79-4575-9b45-c849d8f7b33a", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7718), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "a94d6384-e006-4a21-938a-07028d108670", "BA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7718), "Roberto Fernandes", "Professional" },
                    { "user4", 0, "Rua D, 101", "45678901234", "Salvador", "30ce4603-9488-496f-be3b-f615d5d044d9", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7341), "maria.santos@example.com", false, "F", false, null, null, null, null, null, false, "40000-000", "4567890", null, "2c4ed21d-0338-4448-a376-a8651b0181b0", "BA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7342), "Maria Santos", "Client" },
                    { "user5", 0, "Rua E, 202", "56789012345", "Fortaleza", "37813135-f81f-48d9-aab2-7ca10b9b9ca1", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7353), "pedro.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60000-000", "5678901", null, "7ecb1a94-130b-4f55-8d50-0e085aeb8336", "CE", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7353), "Pedro Almeida", "Client" },
                    { "user6", 0, "Rua F, 303", "67890123456", "Curitiba", "bff999c2-3bc4-4151-838e-2da91b2fd23c", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7364), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "80000-000", "6789012", null, "9035f1d7-0824-4bb1-94ef-282bbe874f86", "PR", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7364), "Juliana Costa", "Client" },
                    { "user7", 0, "Rua G, 404", "78901234567", "Porto Alegre", "646f4d86-bc50-4376-a36a-5347c106bf33", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7377), "roberto.lima@example.com", false, "M", false, null, null, null, null, null, false, "90000-000", "7890123", null, "15079011-6e5c-445d-bafc-e3df42120560", "RS", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7378), "Roberto Lima", "Client" },
                    { "user8", 0, "Rua H, 505", "89012345678", "Recife", "bfcb8480-25ff-48ad-8c61-99b77bbbf362", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7389), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "50000-000", "8901234", null, "9aa28eda-ba04-4dc6-af35-e377163f6185", "PE", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7389), "Patricia Martins", "Client" },
                    { "user9", 0, "Rua I, 606", "90123456789", "Belém", "af78f174-bf3f-4a4b-95d0-11d600192df9", new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7436), "ricardo.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "66000-000", "9012345", null, "6d98535e-0962-4306-9a56-919229c5939b", "PA", false, new DateTime(2024, 11, 20, 23, 3, 5, 64, DateTimeKind.Utc).AddTicks(7437), "Ricardo Fernandes", "Client" }
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
                    { 1, 1, null, "[\"Arquiteto\",\"Engenheiro\"]", "user16" },
                    { 2, 2, null, "[\"Eletricista\",\"Pedreiro\"]", "user17" },
                    { 3, 3, null, "[\"Engenheiro\",\"Arquiteto\",\"Encanador\"]", "user18" },
                    { 4, 4, null, "[\"Pedreiro\",\"Marceneiro\"]", "user19" },
                    { 5, 5, null, "[\"Encanador\",\"Eletricista\"]", "user20" },
                    { 6, 6, null, "[\"Arquiteto\",\"Pintor\"]", "user21" },
                    { 7, 7, null, "[\"Eletricista\",\"Pintor\",\"Vidraceiro\"]", "user22" },
                    { 8, 8, null, "[\"Engenheiro\",\"Serralheiro\"]", "user23" },
                    { 9, 9, null, "[\"Pedreiro\",\"Vidraceiro\",\"Carpinteiro\"]", "user24" },
                    { 10, 10, null, "[\"Encanador\",\"Marceneiro\"]", "user25" },
                    { 11, 11, null, "[\"Arquiteto\",\"Pintor\",\"Engenheiro\"]", "user26" },
                    { 12, 12, null, "[\"Eletricista\"]", "user27" },
                    { 13, 13, null, "[\"Engenheiro\",\"Pedreiro\"]", "user28" },
                    { 14, 14, null, "[\"Arquiteto\",\"Decorador\"]", "user29" },
                    { 15, 15, null, "[\"Eletricista\",\"Engenheiro\",\"Pedreiro\"]", "user30" }
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
                table: "GenericProfessionalProfessionalType",
                columns: new[] { "Id", "ArchitectId", "CabinetmakerId", "CarpenterId", "CivilEngineerId", "DecoratorId", "ElectricalEngineerId", "ElectricianId", "ForemanId", "GlazierId", "HydraulicEngineerId", "InteriorDesignerId", "LandscaperId", "MarbleWorkerId", "MasonId", "MetalworkerId", "PainterId", "PlastererId", "PlumberId", "RooferId", "SurveyorId", "TilerId", "genericId" },
                values: new object[,]
                {
                    { new Guid("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 7 },
                    { new Guid("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 12 },
                    { new Guid("36f41695-bc6e-4a3f-a7e9-d41643b81245"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 9 },
                    { new Guid("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 14 },
                    { new Guid("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 8 },
                    { new Guid("76e63219-25e6-40f1-9a75-9486d4d478a9"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 6 },
                    { new Guid("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 11 },
                    { new Guid("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 13 },
                    { new Guid("93bd828b-2b6e-42a6-92e3-248f01438d34"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 4 },
                    { new Guid("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 2 },
                    { new Guid("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 5 },
                    { new Guid("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { new Guid("d59c8723-c8a6-44b8-85d4-b72e93c24851"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 15 },
                    { new Guid("eea39b7d-8f13-49bc-8c45-c8e293d64829"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 10 },
                    { new Guid("f13423a1-8b12-4d58-bcc1-2b29f41148c8"), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 3 }
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
