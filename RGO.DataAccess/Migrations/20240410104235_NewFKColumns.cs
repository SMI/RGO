using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewFKColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 42, 33, 213, DateTimeKind.Utc).AddTicks(6097));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 9, 20, 7, 862, DateTimeKind.Utc).AddTicks(4179));
        }
    }
}
