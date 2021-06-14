using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Philcosa.Infrastructure.Migrations
{
    public partial class Initial : Migration
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
                name: "CoverIssuers",
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
                    table.PrimaryKey("PK_CoverIssuers", x => x.Id);
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
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    CoverIssuerId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_Covers_CoverIssuers_CoverIssuerId",
                        column: x => x.CoverIssuerId,
                        principalTable: "CoverIssuers",
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
                    { 1, "VEN", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 298, DateTimeKind.Local).AddTicks(8750), null, null, "Venda" },
                    { 2, "TRA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9528), null, null, "Transkei" },
                    { 3, "CIS", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9558), null, null, "Ciskei" },
                    { 4, "BOP", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9560), null, null, "Bophuthatswana" },
                    { 5, "SWA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9563), null, null, "South West Africa" },
                    { 6, "RSA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9565), null, null, "South Africa" },
                    { 7, "NAM", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9570), null, null, "Namibia" }
                });

            migrationBuilder.InsertData(
                table: "CoverIssuers",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 23, "NAV", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2664), null, null, "SA Navy" },
                    { 24, "FOU", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2712), null, null, "SA Philatelic Foundation" },
                    { 25, "SAP", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2724), null, null, "SA Police" },
                    { 26, "SPO", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2735), null, null, "SA Post Office" },
                    { 27, "SAR", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2746), null, null, "SA Railway Services" },
                    { 28, "SAT", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2758), null, null, "SA Transport Services" },
                    { 29, "SHP", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2769), null, null, "Ship Society of SA" },
                    { 30, "SHS", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2780), null, null, "Simonstown Historical Society" },
                    { 33, "SAA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2815), null, null, "South African Airways" },
                    { 32, "AER", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2804), null, null, "South African Air Force (Aerobic)" },
                    { 22, "DEF", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2653), null, null, "SA Defence Force" },
                    { 34, "SAM", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2828), null, null, "South African Airways Museum" },
                    { 35, "TRS", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2839), null, null, "The Railway Society" },
                    { 36, "UNN", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2850), null, null, "United Nations" },
                    { 37, "WPH", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2861), null, null, "Warner Pharmaceuticals" },
                    { 38, "WWF", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(3145), null, null, "World Wildlife Fund" },
                    { 31, "SNM", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2792), null, null, "Simonstown Navy Museum" },
                    { 21, "ARM", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2642), null, null, "SA Army" },
                    { 20, "SMW", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2631), null, null, "SA Air Force Museum (World War Series)" },
                    { 6, "FST", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2355), null, null, "Flitestar" },
                    { 1, "APH", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 348, DateTimeKind.Local).AddTicks(9901), null, null, "Airphilsa" },
                    { 2, "CAP", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2288), null, null, "Caprivi Airways" },
                    { 3, "FED", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2310), null, null, "Philatelic Federation" },
                    { 4, "GLD", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2323), null, null, "First Day Fabrics (GOLD)" },
                    { 5, "SLK", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2335), null, null, "First Day Fabrics (SILK)" },
                    { 19, "SMS", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2619), null, null, "SA Air Force Museum (Spesials)" },
                    { 8, "KPA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2482), null, null, "Kempton Park Philatelic Society (Kemp Air)" },
                    { 9, "KPC", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2495), null, null, "Kempton Park Philatelic Society (Kemp kard)" },
                    { 7, "FAL", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2367), null, null, "Foreign Airline" },
                    { 11, "KPM", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2522), null, null, "Kempton Park Philatelic Society (Kemp Maksikard)" },
                    { 12, "NAM", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2534), null, null, "Nam Post" },
                    { 13, "NAA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2545), null, null, "Namib Air/Air Namibia" },
                    { 14, "NAD", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2558), null, null, "Namib Air/Air Namibia (Delivery flights)" },
                    { 15, "PRV", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2569), null, null, "Private" },
                    { 16, "PRC", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2581), null, null, "Private (Ciskei Handcancelled)" },
                    { 17, "SMA", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2593), null, null, "SA Air Force Museum (Anniversary Flights)" },
                    { 18, "SMO", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2607), null, null, "SA Air Force Museum (Original Series)" },
                    { 10, "KPK", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2509), null, null, "Kempton Park Philatelic Society (Kemp Kover" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 8, "BAL", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(310), null, null, "Balloon" },
                    { 1, "FDC", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 306, DateTimeKind.Local).AddTicks(9996), null, null, "First Day" },
                    { 2, "CMC", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(301), null, null, "Comemorative" },
                    { 3, "FLT", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(304), null, null, "Flight" },
                    { 4, "MIL", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(306), null, null, "Military" },
                    { 5, "FIL", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(308), null, null, "Filatelic" },
                    { 9, "RWY", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(312), null, null, "Railway" }
                });

            migrationBuilder.InsertData(
                table: "CoverValues",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "MaxValue", "MinValue" },
                values: new object[,]
                {
                    { 5, "$$$$$", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9817), null, null, 500m, 150.01m },
                    { 4, "$$$$", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9815), null, null, 150m, 50.01m },
                    { 6, "$$$$$$", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9865), null, null, null, 500.01m },
                    { 2, "$$", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9764), null, null, 15m, 5.01m },
                    { 3, "$$$", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9812), null, null, 50m, 15.01m },
                    { 1, "$", "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(8551), null, null, 5m, 0m }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 61, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6317), null, null, "Manufacturing/Industries" },
                    { 86, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6561), null, null, "Roses" },
                    { 85, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6552), null, null, "Road Safety" },
                    { 84, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6543), null, null, "Rivers" },
                    { 83, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6533), null, null, "Religion/Churches" },
                    { 82, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6524), null, null, "Red Cross" },
                    { 81, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6515), null, null, "Railway/Trains" },
                    { 80, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6506), null, null, "Presidents and Leaders" },
                    { 79, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6498), null, null, "Postal History" },
                    { 78, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6490), null, null, "Police" },
                    { 77, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6481), null, null, "Platinum" },
                    { 76, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6472), null, null, "Paintings" },
                    { 75, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6462), null, null, "Orchids" },
                    { 74, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6420), null, null, "Olympic Games" },
                    { 72, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6403), null, null, "National Festivals" },
                    { 71, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6395), null, null, "Music" },
                    { 70, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6387), null, null, "Mushrooms/Fungi" },
                    { 69, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6379), null, null, "Museums" },
                    { 68, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6371), null, null, "Monuments" },
                    { 67, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6363), null, null, "Monkeys and Baboons" },
                    { 66, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6355), null, null, "Mining/Minerals" },
                    { 65, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6346), null, null, "Millenium" },
                    { 64, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6339), null, null, "Military" },
                    { 63, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6331), null, null, "Meteorology/Weather" },
                    { 62, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6324), null, null, "Maps" },
                    { 87, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6570), null, null, "Rotary International" },
                    { 73, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6412), null, null, "Nursing" },
                    { 89, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6589), null, null, "Rugby" },
                    { 90, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6599), null, null, "Science and Technology" },
                    { 60, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6310), null, null, "Mandela" },
                    { 115, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(7010), null, null, "Wildlife" },
                    { 114, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6997), null, null, "Whales/Dolphins/Sharks" },
                    { 113, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6986), null, null, "Waterfalls" },
                    { 112, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6975), null, null, "Water and Sanitation" },
                    { 111, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6963), null, null, "Voortrekkers" },
                    { 110, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6952), null, null, "van Riebeeck" },
                    { 109, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6941), null, null, "UPU" },
                    { 108, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6930), null, null, "United Nations" },
                    { 107, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6919), null, null, "Uniforms/Costumes" },
                    { 106, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6897), null, null, "Unicef" },
                    { 105, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6885), null, null, "Triangle Stamps" },
                    { 88, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6579), null, null, "Royals" },
                    { 104, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6874), null, null, "Transport" },
                    { 102, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6850), null, null, "Tourism" },
                    { 101, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6831), null, null, "Tennis" },
                    { 100, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6702), null, null, "Swimming" },
                    { 99, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6691), null, null, "Stamp on Stamps" },
                    { 98, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6681), null, null, "Stamp Exhibition" },
                    { 97, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6671), null, null, "Stamp Day" },
                    { 96, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6660), null, null, "Sport" },
                    { 95, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6650), null, null, "Spiders" },
                    { 94, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6638), null, null, "Snakes/Lizards/Reptiles" },
                    { 93, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6629), null, null, "Ships/Maritime" },
                    { 92, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6619), null, null, "Shells" },
                    { 91, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6608), null, null, "Settlers" },
                    { 103, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6862), null, null, "Towns/Cities History" },
                    { 59, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6303), null, null, "Literature/Writers" },
                    { 30, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6099), null, null, "Education" },
                    { 57, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6289), null, null, "Law" },
                    { 26, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6081), null, null, "Dinosaurs/Fossils/Archaeology" },
                    { 25, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6077), null, null, "Definitive Series" },
                    { 24, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6073), null, null, "Cricket" },
                    { 23, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6070), null, null, "Constitution" },
                    { 22, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6066), null, null, "Community Services" },
                    { 21, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6062), null, null, "Communication" },
                    { 20, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6059), null, null, "Christmas" },
                    { 19, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6055), null, null, "Child Paintings" },
                    { 18, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6051), null, null, "Child" },
                    { 17, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6047), null, null, "Cats/Dogs" },
                    { 16, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6044), null, null, "Cars" },
                    { 15, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6041), null, null, "Butterflies" },
                    { 27, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6085), null, null, "Diplomacy" },
                    { 14, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6038), null, null, "Bridges/Dams" },
                    { 12, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6032), null, null, "Boxing" },
                    { 11, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6029), null, null, "Boer War" },
                    { 10, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6026), null, null, "Birds/Bats" },
                    { 9, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6023), null, null, "Balloon Flights" },
                    { 8, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6013), null, null, "Atletics" },
                    { 7, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6011), null, null, "Astronomy/Space" },
                    { 6, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6009), null, null, "Arts/Culture/Traditions" },
                    { 5, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6001), null, null, "Architecture" },
                    { 4, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(5999), null, null, "Apartheid" },
                    { 3, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(5997), null, null, "Antarctica" },
                    { 2, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(5988), null, null, "Agriculture/Farming" },
                    { 1, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(4542), null, null, "Afrikaans language" },
                    { 13, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6035), null, null, "Boy Scouts/Girl Guides" },
                    { 58, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6296), null, null, "Lions International" },
                    { 28, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6089), null, null, "Disabled" },
                    { 116, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(7022), null, null, "Writing" },
                    { 56, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6283), null, null, "Landscapes/Nature" },
                    { 55, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6276), null, null, "ITU" },
                    { 54, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6270), null, null, "Insects/Bees" },
                    { 53, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6263), null, null, "Horses/Equestrian" },
                    { 52, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6257), null, null, "Hockey" },
                    { 51, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6250), null, null, "Heraldry/Coat of Arms" },
                    { 50, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6245), null, null, "Health/Medicine" },
                    { 49, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6238), null, null, "Hares/Rabbits" },
                    { 48, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6232), null, null, "Grasses" },
                    { 47, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6226), null, null, "Government and Politics" },
                    { 46, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6221), null, null, "Golf" },
                    { 45, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6215), null, null, "Geology" },
                    { 29, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6094), null, null, "Easter" },
                    { 44, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6209), null, null, "Gem Stones/Jewels" },
                    { 42, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6199), null, null, "Frogs" },
                    { 41, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6193), null, null, "Forts and Castles" },
                    { 40, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6188), null, null, "Forestry/Trees" },
                    { 39, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6183), null, null, "Football/Soccer" },
                    { 38, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6177), null, null, "Food and Drink" },
                    { 37, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6172), null, null, "Flora/Flowers" },
                    { 36, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6168), null, null, "Flight and Aircraft" },
                    { 35, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6163), null, null, "Flags" },
                    { 34, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6158), null, null, "Fishing/Angling" },
                    { 33, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6112), null, null, "Fish and Marine Life" },
                    { 32, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6107), null, null, "Famous Persons" },
                    { 31, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6103), null, null, "Energy" },
                    { 43, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6204), null, null, "Fruit/Vegetables" },
                    { 117, "DataSeed", new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(7034), null, null, "WWF" }
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
                name: "IX_Covers_CoverIssuerId",
                table: "Covers",
                column: "CoverIssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_Covers_CoverTypeId",
                table: "Covers",
                column: "CoverTypeId");

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
                name: "CoverIssuers");

            migrationBuilder.DropTable(
                name: "CoverTypes");

            migrationBuilder.DropTable(
                name: "CoverValues");
        }
    }
}
