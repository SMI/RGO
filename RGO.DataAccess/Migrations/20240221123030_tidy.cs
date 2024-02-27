using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class tidy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 12, 30, 29, 12, DateTimeKind.Utc).AddTicks(6465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 10, 33, 18, 782, DateTimeKind.Utc).AddTicks(2772));
        }
    }
}
