using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ReidentificationLookup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9921));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2366));
        }
    }
}
