using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Migrations
{
    public partial class NOVABAZA : Migration
    {
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
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "ApplicationUsages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsages_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUsages_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ComputerOsses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerOsses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerOsses_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerOsses_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counties_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Counties_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Departments_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeviceServers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceServers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceServers_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceServers_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeviceStatesNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceStatesNew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceStatesNew_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceStatesNew_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EntityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HDDSpeeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDSpeeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDDSpeeds_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDDSpeeds_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HDDTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDDTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDDTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MobileDeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileDeviceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobileDeviceTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobileDeviceTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonitorFormats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorFormats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitorFormats_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitorFormats_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonitorSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "varchar(5)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitorSizes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitorSizes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonitorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitorTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitorTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Multifunctionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multifunctionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multifunctionals_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Multifunctionals_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Others",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Others", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Others_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Others_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PartnerContactTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nchar(10)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerContactTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartnerContactTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartnerContactTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partners_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partners_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrinterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrinterTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrinterTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RAMTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RAMTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roles_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Scanners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ScanA3 = table.Column<bool>(type: "bit", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scanners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scanners_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scanners_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Locations_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Photos_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Photos_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MobileDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileDeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    ScreenSize = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    InternalMemory = table.Column<int>(type: "int", nullable: true),
                    ExternalMemory = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobileDevices_MobileDeviceTypes_MobileDeviceTypeId",
                        column: x => x.MobileDeviceTypeId,
                        principalTable: "MobileDeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobileDevices_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MobileDevices_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonitorResolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    MonitorFormatId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorResolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitorResolutions_MonitorFormats_MonitorFormatId",
                        column: x => x.MonitorFormatId,
                        principalTable: "MonitorFormats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitorResolutions_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MonitorResolutions_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactTypeId = table.Column<int>(type: "int", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_PartnerContactTypes_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "PartnerContactTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Contacts_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: false),
                    Settlement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalNumber = table.Column<int>(type: "int", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Counties_CountyId",
                        column: x => x.CountyId,
                        principalTable: "Counties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Addresses_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Addresses_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrinterTypeId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    PortUSB = table.Column<bool>(type: "bit", nullable: true),
                    PortLAN = table.Column<bool>(type: "bit", nullable: true),
                    PortLPT = table.Column<bool>(type: "bit", nullable: true),
                    A3Print = table.Column<bool>(type: "bit", nullable: true),
                    Color = table.Column<bool>(type: "bit", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Printers_PrinterTypes_PrinterTypeId",
                        column: x => x.PrinterTypeId,
                        principalTable: "PrinterTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Printers_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Printers_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    ComputerOSId = table.Column<int>(type: "int", nullable: true),
                    HDDTypeId = table.Column<int>(type: "int", nullable: true),
                    RAMTypeId = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HDDModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDDCapacity = table.Column<int>(type: "int", nullable: false),
                    NumberOfDiskDrives = table.Column<int>(type: "int", nullable: true),
                    HDDSpeedId = table.Column<int>(type: "int", nullable: false),
                    Laptop = table.Column<bool>(type: "bit", nullable: false),
                    License = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_ComputerOsses_ComputerOSId",
                        column: x => x.ComputerOSId,
                        principalTable: "ComputerOsses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_HDDTypes_HDDTypeId",
                        column: x => x.HDDTypeId,
                        principalTable: "HDDTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_RAMTypes_RAMTypeId",
                        column: x => x.RAMTypeId,
                        principalTable: "RAMTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Computers_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buildings_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Buildings_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResolutionId = table.Column<int>(type: "int", nullable: false),
                    MonitorTypeId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    InputHDMI = table.Column<bool>(type: "bit", nullable: true),
                    InputVGA = table.Column<bool>(type: "bit", nullable: true),
                    InputDVI = table.Column<bool>(type: "bit", nullable: true),
                    InputDP = table.Column<bool>(type: "bit", nullable: true),
                    PivotCapable = table.Column<bool>(type: "bit", nullable: true),
                    MonitorSizeId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_MonitorResolutions_ResolutionId",
                        column: x => x.ResolutionId,
                        principalTable: "MonitorResolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monitors_MonitorTypes_MonitorTypeId",
                        column: x => x.MonitorTypeId,
                        principalTable: "MonitorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Monitors_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Monitors_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    DeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: true),
                    InventoryNumber = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuaranteeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ServiceNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    Decom = table.Column<bool>(type: "bit", nullable: true),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceStatesNew_StateId",
                        column: x => x.StateId,
                        principalTable: "DeviceStatesNew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Devices_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Devices_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Devices_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servers_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servers_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Servers_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    ResponsibleEmployeeId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentLogs_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentLogs_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentLogs_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DocumentLogs_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Version = table.Column<string>(type: "nchar(10)", nullable: true),
                    ResponsibleEmployeeId = table.Column<int>(type: "int", nullable: true),
                    NumberOfUsers = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Maintence = table.Column<bool>(type: "bit", nullable: true),
                    MaintenceExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUsageId = table.Column<int>(type: "int", nullable: true),
                    ServerId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nchar(15)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_ApplicationUsages_ApplicationUsageId",
                        column: x => x.ApplicationUsageId,
                        principalTable: "ApplicationUsages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Applications_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Applications_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Applications_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logs_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Logs_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountyId",
                table: "Addresses",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PartnerId",
                table: "Addresses",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserCreatedId",
                table: "Addresses",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserModifiedId",
                table: "Addresses",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationUsageId",
                table: "Applications",
                column: "ApplicationUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EmployeeId",
                table: "Applications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ServerId",
                table: "Applications",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserCreatedId",
                table: "Applications",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserModifiedId",
                table: "Applications",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsages_UserCreatedId",
                table: "ApplicationUsages",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsages_UserModifiedId",
                table: "ApplicationUsages",
                column: "UserModifiedId");

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
                name: "IX_Buildings_LocationId",
                table: "Buildings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserCreatedId",
                table: "Buildings",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserModifiedId",
                table: "Buildings",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserCreatedId",
                table: "Classes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserModifiedId",
                table: "Classes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOsses_UserCreatedId",
                table: "ComputerOsses",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOsses_UserModifiedId",
                table: "ComputerOsses",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_ComputerOSId",
                table: "Computers",
                column: "ComputerOSId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_HDDTypeId",
                table: "Computers",
                column: "HDDTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_RAMTypeId",
                table: "Computers",
                column: "RAMTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_UserCreatedId",
                table: "Computers",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_UserModifiedId",
                table: "Computers",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactTypeId",
                table: "Contacts",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserCreatedId",
                table: "Contacts",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserModifiedId",
                table: "Contacts",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_UserCreatedId",
                table: "Counties",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_UserModifiedId",
                table: "Counties",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UserCreatedId",
                table: "Departments",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UserModifiedId",
                table: "Departments",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_BuildingId",
                table: "Devices",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_EmployeeId",
                table: "Devices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_PartnerId",
                table: "Devices",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_StateId",
                table: "Devices",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UserCreatedId",
                table: "Devices",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UserModifiedId",
                table: "Devices",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceServers_UserCreatedId",
                table: "DeviceServers",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceServers_UserModifiedId",
                table: "DeviceServers",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatesNew_UserCreatedId",
                table: "DeviceStatesNew",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatesNew_UserModifiedId",
                table: "DeviceStatesNew",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_UserCreatedId",
                table: "DeviceTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_UserModifiedId",
                table: "DeviceTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLogs_DeviceId",
                table: "DocumentLogs",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLogs_DocumentTypeId",
                table: "DocumentLogs",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLogs_UserCreatedId",
                table: "DocumentLogs",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLogs_UserModifiedId",
                table: "DocumentLogs",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserCreatedId",
                table: "Employee",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserModifiedId",
                table: "Employee",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_UserCreatedId",
                table: "EntityTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_UserModifiedId",
                table: "EntityTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDSpeeds_UserCreatedId",
                table: "HDDSpeeds",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDSpeeds_UserModifiedId",
                table: "HDDSpeeds",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDTypes_UserCreatedId",
                table: "HDDTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDTypes_UserModifiedId",
                table: "HDDTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DepartmentId",
                table: "Locations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserCreatedId",
                table: "Locations",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserModifiedId",
                table: "Locations",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_ApplicationId",
                table: "Logs",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserCreatedId",
                table: "Logs",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserModifiedId",
                table: "Logs",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_MobileDeviceTypeId",
                table: "MobileDevices",
                column: "MobileDeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_UserCreatedId",
                table: "MobileDevices",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_UserModifiedId",
                table: "MobileDevices",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDeviceTypes_UserCreatedId",
                table: "MobileDeviceTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDeviceTypes_UserModifiedId",
                table: "MobileDeviceTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorFormats_UserCreatedId",
                table: "MonitorFormats",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorFormats_UserModifiedId",
                table: "MonitorFormats",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorResolutions_MonitorFormatId",
                table: "MonitorResolutions",
                column: "MonitorFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorResolutions_UserCreatedId",
                table: "MonitorResolutions",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorResolutions_UserModifiedId",
                table: "MonitorResolutions",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_MonitorTypeId",
                table: "Monitors",
                column: "MonitorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_ResolutionId",
                table: "Monitors",
                column: "ResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_UserCreatedId",
                table: "Monitors",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_UserModifiedId",
                table: "Monitors",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorSizes_UserCreatedId",
                table: "MonitorSizes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorSizes_UserModifiedId",
                table: "MonitorSizes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorTypes_UserCreatedId",
                table: "MonitorTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorTypes_UserModifiedId",
                table: "MonitorTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Multifunctionals_UserCreatedId",
                table: "Multifunctionals",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Multifunctionals_UserModifiedId",
                table: "Multifunctionals",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Others_UserCreatedId",
                table: "Others",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Others_UserModifiedId",
                table: "Others",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerContactTypes_UserCreatedId",
                table: "PartnerContactTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerContactTypes_UserModifiedId",
                table: "PartnerContactTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_UserCreatedId",
                table: "Partners",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_UserModifiedId",
                table: "Partners",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_EntityTypeId",
                table: "Photos",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserCreatedId",
                table: "Photos",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserModifiedId",
                table: "Photos",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_PrinterTypeId",
                table: "Printers",
                column: "PrinterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_UserCreatedId",
                table: "Printers",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_UserModifiedId",
                table: "Printers",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterTypes_UserCreatedId",
                table: "PrinterTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterTypes_UserModifiedId",
                table: "PrinterTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMTypes_UserCreatedId",
                table: "RAMTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMTypes_UserModifiedId",
                table: "RAMTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserCreatedId",
                table: "Roles",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserModifiedId",
                table: "Roles",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Scanners_UserCreatedId",
                table: "Scanners",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Scanners_UserModifiedId",
                table: "Scanners",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_BuildingId",
                table: "Servers",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_UserCreatedId",
                table: "Servers",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_UserModifiedId",
                table: "Servers",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

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
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DeviceServers");

            migrationBuilder.DropTable(
                name: "DocumentLogs");

            migrationBuilder.DropTable(
                name: "HDDSpeeds");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MobileDevices");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "MonitorSizes");

            migrationBuilder.DropTable(
                name: "Multifunctionals");

            migrationBuilder.DropTable(
                name: "Others");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Scanners");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ComputerOsses");

            migrationBuilder.DropTable(
                name: "HDDTypes");

            migrationBuilder.DropTable(
                name: "RAMTypes");

            migrationBuilder.DropTable(
                name: "PartnerContactTypes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "MobileDeviceTypes");

            migrationBuilder.DropTable(
                name: "MonitorResolutions");

            migrationBuilder.DropTable(
                name: "MonitorTypes");

            migrationBuilder.DropTable(
                name: "EntityTypes");

            migrationBuilder.DropTable(
                name: "PrinterTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "DeviceStatesNew");

            migrationBuilder.DropTable(
                name: "DeviceTypes");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "ApplicationUsages");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "MonitorFormats");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
