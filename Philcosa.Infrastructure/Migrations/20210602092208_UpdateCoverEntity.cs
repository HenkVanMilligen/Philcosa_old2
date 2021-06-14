using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Philcosa.Infrastructure.Migrations
{
    public partial class UpdateCoverEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Covers",
                newName: "ImageDataUrl");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageDataUrl",
                table: "Covers",
                newName: "Path");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 298, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 304, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 348, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "CoverIssuers",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 349, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 306, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "CoverValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 307, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 14, 17, 22, 316, DateTimeKind.Local).AddTicks(7034));
        }
    }
}
