using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RGO_Evidence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 14, 31, 56, 63, DateTimeKind.Utc).AddTicks(2866));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 40, 36, 99, DateTimeKind.Utc).AddTicks(5372));
        }
    }
}
