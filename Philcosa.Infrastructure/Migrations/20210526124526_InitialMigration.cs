using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Philcosa.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateTable(
                name: "AuditTrails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    TableName = table.Column<string>(type: "text", nullable: true),
                    DateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    OldValues = table.Column<string>(type: "text", nullable: true),
                    NewValues = table.Column<string>(type: "text", nullable: true),
                    AffectedColumns = table.Column<string>(type: "text", nullable: true),
                    PrimaryKey = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTrails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Tax = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoverTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoverValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    MinValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MaxValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IssuedByEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuedByEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ProfilePictureDataUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Barcode = table.Column<string>(type: "text", nullable: true),
                    ImageDataURL = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Rate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    BrandId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Covers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoverDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IdOnDate = table.Column<string>(type: "text", nullable: true),
                    IssuedById = table.Column<int>(type: "integer", nullable: true),
                    Number = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    AmountIssued = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true),
                    Atlas = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    Alberta = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    CoverTypeId = table.Column<int>(type: "integer", nullable: true),
                    ValueId = table.Column<int>(type: "integer", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Covers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Covers_CoverTypes_CoverTypeId",
                        column: x => x.CoverTypeId,
                        principalTable: "CoverTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Covers_CoverValues_ValueId",
                        column: x => x.ValueId,
                        principalTable: "CoverValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Covers_IssuedByEntities_IssuedById",
                        column: x => x.IssuedById,
                        principalTable: "IssuedByEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: true),
                    ToUserId = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatHistory_Users_FromUserId",
                        column: x => x.FromUserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatHistory_Users_ToUserId",
                        column: x => x.ToUserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoverThemes",
                columns: table => new
                {
                    CoverId = table.Column<int>(type: "integer", nullable: false),
                    ThemeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverThemes", x => new { x.CoverId, x.ThemeId });
                    table.ForeignKey(
                        name: "FK_CoverThemes_Covers_CoverId",
                        column: x => x.CoverId,
                        principalTable: "Covers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoverThemes_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, "VEN", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 791, DateTimeKind.Local).AddTicks(2227), null, null, "Venda" },
                    { 2, "TRA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 795, DateTimeKind.Local).AddTicks(1619), null, null, "Transkei" },
                    { 3, "CIS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 795, DateTimeKind.Local).AddTicks(1636), null, null, "Ciskei" },
                    { 4, "BOP", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 795, DateTimeKind.Local).AddTicks(1639), null, null, "Bophuthatswana" },
                    { 5, "SWA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 795, DateTimeKind.Local).AddTicks(1641), null, null, "South West Africa" },
                    { 6, "RSA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 795, DateTimeKind.Local).AddTicks(1642), null, null, "South Africa" },
                    { 7, "NAM", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 795, DateTimeKind.Local).AddTicks(1644), null, null, "Namibia" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 9, "RWY", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7853), null, null, "Railway" },
                    { 8, "BAL", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7851), null, null, "Balloon" },
                    { 7, "FIL", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7849), null, null, "Filatelic" },
                    { 6, "MIL", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7846), null, null, "Military" },
                    { 2, "CMC", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7837), null, null, "Comemorative" },
                    { 4, "SLK", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7843), null, null, "Silk" },
                    { 3, "FLT", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7841), null, null, "Flight" },
                    { 1, "FDC", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7509), null, null, "First Day" },
                    { 5, "GLD", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 796, DateTimeKind.Local).AddTicks(7845), null, null, "Gold Foiled" }
                });

            migrationBuilder.InsertData(
                table: "CoverValues",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "MaxValue", "MinValue" },
                values: new object[,]
                {
                    { 6, "$$$$$$", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 797, DateTimeKind.Local).AddTicks(6435), null, null, null, 500.01m },
                    { 5, "$$$$$", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 797, DateTimeKind.Local).AddTicks(6432), null, null, 500m, 150.01m },
                    { 4, "$$$$", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 797, DateTimeKind.Local).AddTicks(6430), null, null, 150m, 50.01m },
                    { 2, "$$", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 797, DateTimeKind.Local).AddTicks(6386), null, null, 15m, 5.01m },
                    { 1, "$", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 797, DateTimeKind.Local).AddTicks(5113), null, null, 5m, 0m },
                    { 3, "$$$", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 797, DateTimeKind.Local).AddTicks(6428), null, null, 50m, 15.01m }
                });

            migrationBuilder.InsertData(
                table: "IssuedByEntities",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 20, "SAAM", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(199), null, null, "South African Airways Museum" },
                    { 21, "P", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(212), null, null, "Private" },
                    { 22, "SATS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(226), null, null, "SA Transport Services" },
                    { 23, "SHS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(240), null, null, "Simonstown Historical Society" },
                    { 24, "WP", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(253), null, null, "Warner Pharmaceuticals" },
                    { 26, "KPPS_M", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(283), null, null, "Kempton Park Philatelic Society (Kemp Maksikard)" },
                    { 27, "SARS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(297), null, null, "SA Railway Services" },
                    { 28, "KPPS_K", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(311), null, null, "Kempton Park Philatelic Society (Kemp Kover)" },
                    { 30, "SAAFM_S", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(370), null, null, "SA Air Force Museum (Spesials)" },
                    { 31, "FA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(383), null, null, "Foreign Airline" },
                    { 32, "SAN", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(396), null, null, "SA Navy" },
                    { 33, "CA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(410), null, null, "Caprivi Airways" },
                    { 34, "SAAFM_AF", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(426), null, null, "SA Air Force Museum (Anniversary Flights)" },
                    { 35, "F", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(439), null, null, "Flitestar" },
                    { 36, "A", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(586), null, null, "Airphilsa" },
                    { 29, "SAAFM_WWS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(327), null, null, "SA Air Force Museum (World War Series)" },
                    { 19, "FED", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(185), null, null, "Federation" },
                    { 25, "SAFM", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(268), null, null, "SA Air Force Museum (Original Series)" },
                    { 17, "SAA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(156), null, null, "South African Airways" },
                    { 18, "SAPF", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(172), null, null, "SA Philatelic Foundation" },
                    { 2, "AEROBIC", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9832), null, null, "South African Air Force (Aerobic)" },
                    { 3, "SAAR", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9856), null, null, "SA Army" },
                    { 4, "DF", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9871), null, null, "Namib Air/Air Namibia (Delivery flights)" },
                    { 5, "UN", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9885), null, null, "United Nations" },
                    { 6, "WWF", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9906), null, null, "World Wildlife Fund" },
                    { 7, "NA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9920), null, null, "Namib Air/Air Namibia" },
                    { 8, "GOLD", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9935), null, null, "First Day Fabrics (Gold)" },
                    { 1, "SILK", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(7622), null, null, "First Day Fabrics (Silk)" },
                    { 10, "TRS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9964), null, null, "The Railway Society" },
                    { 11, "SAP", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9977), null, null, "SA Police" },
                    { 12, "SNM", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9991), null, null, "Simonstown Navy Museum" },
                    { 13, "NP", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(101), null, null, "Nam Post" },
                    { 14, "SADF", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(115), null, null, "SA Defence Force" },
                    { 15, "SAPO", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(129), null, null, "SA Post Office" },
                    { 9, "KA", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 846, DateTimeKind.Local).AddTicks(9949), null, null, "Kempton Park Philatelic Society (Kemp Air)" },
                    { 16, "SSS", "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 847, DateTimeKind.Local).AddTicks(142), null, null, "Ship Society of SA" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 97, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1749), null, null, "Windmills" },
                    { 98, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1750), null, null, "Mining/Minerals" },
                    { 99, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1752), null, null, "Forts and Castles" },
                    { 100, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1753), null, null, "Diplomacy" },
                    { 101, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1755), null, null, "Mushrooms/Fungi" },
                    { 102, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1756), null, null, "Dams" },
                    { 103, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1758), null, null, "Languages" },
                    { 106, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1762), null, null, "Archaeology" },
                    { 105, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1761), null, null, "Arts/Culture/Traditions" },
                    { 107, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1764), null, null, "Telecommunication" },
                    { 108, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1765), null, null, "Rugby" },
                    { 109, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1767), null, null, "Fish and Marine Life" },
                    { 110, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1768), null, null, "van Riebeeck" },
                    { 96, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1747), null, null, "Boxing" },
                    { 111, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1770), null, null, "Orchids" },
                    { 104, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1759), null, null, "Sharks" },
                    { 95, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1745), null, null, "Settlers" },
                    { 86, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1732), null, null, "Space" },
                    { 93, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1742), null, null, "Millenium" },
                    { 112, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1771), null, null, "Jan van Riebeeck" },
                    { 78, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1720), null, null, "Platinum" },
                    { 79, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1721), null, null, "Literature/Writers" },
                    { 80, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1723), null, null, "Unicef" },
                    { 81, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1724), null, null, "Rivers" },
                    { 82, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1726), null, null, "Royals" },
                    { 83, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1727), null, null, "National Festivals" },
                    { 84, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1729), null, null, "United Nations" },
                    { 85, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1730), null, null, "Manufacturing/Industries" },
                    { 87, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1733), null, null, "Fossils" },
                    { 88, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1735), null, null, "Birds" },
                    { 89, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1736), null, null, "Meteorology/Weather" },
                    { 90, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1738), null, null, "Olympic Games" },
                    { 91, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1739), null, null, "Astronomy" },
                    { 92, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1741), null, null, "Weapons" },
                    { 94, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1744), null, null, "Spiders" },
                    { 113, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1773), null, null, "Flight and Aircraft" },
                    { 142, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1868), null, null, "Triangle Stamps" },
                    { 115, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1776), null, null, "Folklore" },
                    { 136, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1859), null, null, "Monuments" },
                    { 137, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1860), null, null, "Wildlife" },
                    { 138, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1862), null, null, "Community Services" },
                    { 139, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1863), null, null, "Uniforms" },
                    { 140, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1865), null, null, "Ships/Maritime" },
                    { 141, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1866), null, null, "Reptiles" },
                    { 77, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1718), null, null, "Health/Medicine" },
                    { 143, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1869), null, null, "Energy" },
                    { 144, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1871), null, null, "Child" },
                    { 145, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1872), null, null, "Snakes" },
                    { 146, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1874), null, null, "Stamp Day" },
                    { 147, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1875), null, null, "Watersports" },
                    { 148, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1877), null, null, "Waterfalls" },
                    { 149, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1878), null, null, "Military" },
                    { 150, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1880), null, null, "Rotary International" },
                    { 135, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1857), null, null, "Butterflies" },
                    { 134, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1856), null, null, "Towns/Cities History" },
                    { 133, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1854), null, null, "Snails" },
                    { 132, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1852), null, null, "Balloon Flights" },
                    { 116, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1777), null, null, "Cars" },
                    { 117, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1779), null, null, "Gold" },
                    { 118, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1780), null, null, "Afrikaans language" },
                    { 119, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1782), null, null, "Communication" },
                    { 120, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1783), null, null, "Boy Scouts" },
                    { 121, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1785), null, null, "Bats" },
                    { 122, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1786), null, null, "Solar System" },
                    { 114, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1774), null, null, "Telephone" },
                    { 123, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1788), null, null, "Architecture" },
                    { 125, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1791), null, null, "Dinosaurs" },
                    { 126, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1792), null, null, "Presidents and Leaders" },
                    { 127, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1794), null, null, "Bridges" },
                    { 128, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1795), null, null, "Museums" },
                    { 129, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1797), null, null, "Hunting" },
                    { 130, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1849), null, null, "Flora/Flowers" },
                    { 131, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1851), null, null, "Constitution" },
                    { 124, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1789), null, null, "Scuptures" },
                    { 76, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1717), null, null, "Cricket" },
                    { 47, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1631), null, null, "Equestrian" },
                    { 74, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1714), null, null, "Motorsport" },
                    { 20, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1588), null, null, "Child Paintings" },
                    { 21, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1589), null, null, "Turtles" },
                    { 22, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1591), null, null, "WWF" },
                    { 23, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1593), null, null, "Religion/Churches" },
                    { 24, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1594), null, null, "Lions International" },
                    { 25, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1596), null, null, "Boer War" },
                    { 26, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1597), null, null, "Red Cross" },
                    { 27, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1599), null, null, "Trees" },
                    { 28, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1600), null, null, "Easter" },
                    { 29, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1602), null, null, "Dogs" },
                    { 30, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1603), null, null, "Transport" },
                    { 31, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1605), null, null, "Gem Stones/Jewels" },
                    { 32, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1606), null, null, "Railway/Trains" },
                    { 33, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1608), null, null, "History" },
                    { 34, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1611), null, null, "Shells" },
                    { 19, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1586), null, null, "Costumes" },
                    { 35, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1612), null, null, "Geology" },
                    { 18, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1585), null, null, "Frogs" },
                    { 16, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1581), null, null, "Swimming" },
                    { 1, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1139), null, null, "ITU" },
                    { 2, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1553), null, null, "Famous Persons" },
                    { 3, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1556), null, null, "Sport" },
                    { 4, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1558), null, null, "Police" },
                    { 5, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1559), null, null, "UPU" },
                    { 6, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1564), null, null, "Mandela" },
                    { 7, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1566), null, null, "Fishing/Angling" },
                    { 8, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1567), null, null, "Landscapes/Nature" },
                    { 9, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1569), null, null, "Heraldry/Coat of Arms" },
                    { 10, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1571), null, null, "Water and Sanitation" },
                    { 11, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1573), null, null, "Agriculture/Farming" },
                    { 12, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1574), null, null, "Golf" },
                    { 13, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1576), null, null, "Cartoon" },
                    { 14, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1577), null, null, "Lizards" },
                    { 15, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1579), null, null, "Law" },
                    { 17, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1582), null, null, "Stamp on Stamps" },
                    { 36, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1614), null, null, "Cats" },
                    { 37, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1615), null, null, "Grasses" },
                    { 38, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1617), null, null, "Whales" },
                    { 59, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1690), null, null, "Submarines" },
                    { 60, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1691), null, null, "Monkeys and Baboons" },
                    { 61, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1693), null, null, "Stamp Exhibition" },
                    { 62, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1695), null, null, "Fruits" },
                    { 63, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1696), null, null, "Road Safety" },
                    { 64, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1698), null, null, "Mountains" },
                    { 65, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1699), null, null, "Forestry/Trees" },
                    { 66, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1702), null, null, "Atletics" },
                    { 67, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1703), null, null, "Voortrekkers" },
                    { 68, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1705), null, null, "Insects" },
                    { 69, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1706), null, null, "Roses" },
                    { 70, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1708), null, null, "Tourism" },
                    { 71, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1709), null, null, "Postal History" },
                    { 72, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1711), null, null, "Musical Instruments" },
                    { 73, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1712), null, null, "Music" },
                    { 58, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1688), null, null, "Helicopters" },
                    { 57, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1686), null, null, "Wines and Beer" },
                    { 56, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1645), null, null, "Horses" },
                    { 55, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1643), null, null, "Hares/Rabbits" },
                    { 39, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1618), null, null, "Apartheid" },
                    { 40, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1620), null, null, "Government and Politics" },
                    { 41, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1621), null, null, "Football/Soccer" },
                    { 42, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1623), null, null, "Tennis" },
                    { 43, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1624), null, null, "Hockey" },
                    { 44, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1626), null, null, "Chicken" },
                    { 45, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1628), null, null, "Nursing" },
                    { 75, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1715), null, null, "Antarctica" },
                    { 46, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1629), null, null, "Flags" },
                    { 48, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1632), null, null, "Disabled" },
                    { 49, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1634), null, null, "Owls" },
                    { 50, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1635), null, null, "Definitive Series" },
                    { 51, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1637), null, null, "Girl Guides" },
                    { 52, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1638), null, null, "Maps" },
                    { 53, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1640), null, null, "Christmas" },
                    { 54, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1642), null, null, "Science and Technology" },
                    { 151, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1881), null, null, "Paintings" },
                    { 152, "DataSeed", new DateTime(2021, 5, 26, 14, 45, 25, 803, DateTimeKind.Local).AddTicks(1883), null, null, "Education" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistory_FromUserId",
                table: "ChatHistory",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistory_ToUserId",
                table: "ChatHistory",
                column: "ToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Covers_CountryId",
                table: "Covers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Covers_CoverTypeId",
                table: "Covers",
                column: "CoverTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Covers_IssuedById",
                table: "Covers",
                column: "IssuedById");

            migrationBuilder.CreateIndex(
                name: "IX_Covers_ValueId",
                table: "Covers",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_CoverThemes_ThemeId",
                table: "CoverThemes",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditTrails");

            migrationBuilder.DropTable(
                name: "ChatHistory");

            migrationBuilder.DropTable(
                name: "CoverThemes");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Covers");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CoverTypes");

            migrationBuilder.DropTable(
                name: "CoverValues");

            migrationBuilder.DropTable(
                name: "IssuedByEntities");
        }
    }
}
