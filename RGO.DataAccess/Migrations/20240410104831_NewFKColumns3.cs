using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewFKColumns3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Columns");

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 10, 48, 30, 15, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Columns",
                column: "RGO_Column_TemplateId",
                principalTable: "RGO_Column_Templates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Columns");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Columns",
                column: "RGO_Column_TemplateId",
                principalTable: "RGO_Column_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
