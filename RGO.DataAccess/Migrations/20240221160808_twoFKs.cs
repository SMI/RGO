using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class twoFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGOutputs_RGO_Types_RGO_TypeId",
                table: "RGOutputs");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RGOutputs_RGO_Types_RGO_TypeId",
                table: "RGOutputs",
                column: "RGO_TypeId",
                principalTable: "RGO_Types",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGOutputs_RGO_Types_RGO_TypeId",
                table: "RGOutputs");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RGOutputs_RGO_Types_RGO_TypeId",
                table: "RGOutputs",
                column: "RGO_TypeId",
                principalTable: "RGO_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
