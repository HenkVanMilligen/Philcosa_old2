using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Philcosa.Infrastructure.Migrations
{
    public partial class LatestInitialChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CoverThemes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "CoverThemes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CoverThemes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CoverThemes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "CoverThemes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 960, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 963, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 963, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 963, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 963, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 963, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 963, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 993, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 964, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 965, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 965, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 965, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 965, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 965, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 965, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 13, 14, 12, 45, 970, DateTimeKind.Local).AddTicks(4583));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CoverThemes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CoverThemes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CoverThemes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CoverThemes");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "CoverThemes");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 196, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 199, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 199, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 199, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 199, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 199, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 199, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 255, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 201, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 6, 2, 11, 22, 8, 211, DateTimeKind.Local).AddTicks(8235));
        }
    }
}
