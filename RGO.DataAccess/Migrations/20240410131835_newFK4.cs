using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newFK4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RGO_Column_TemplateId",
                table: "RGO_Record_People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 13, 18, 33, 730, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Record_People_RGO_Column_TemplateId",
                table: "RGO_Record_People",
                column: "RGO_Column_TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Record_People",
                column: "RGO_Column_TemplateId",
                principalTable: "RGO_Column_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Record_People");

            migrationBuilder.DropIndex(
                name: "IX_RGO_Record_People_RGO_Column_TemplateId",
                table: "RGO_Record_People");

            migrationBuilder.DropColumn(
                name: "RGO_Column_TemplateId",
                table: "RGO_Record_People");

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
        }
    }
}
