using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class tidy2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 39, 16, 855, DateTimeKind.Utc).AddTicks(6031));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 542, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 542, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 21, 16, 8, 7, 543, DateTimeKind.Utc).AddTicks(193));
        }
    }
}
