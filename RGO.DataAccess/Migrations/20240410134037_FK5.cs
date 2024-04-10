using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FK5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Record_People");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Record_People",
                column: "RGO_Column_TemplateId",
                principalTable: "RGO_Column_Templates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Record_People");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Record_People",
                column: "RGO_Column_TemplateId",
                principalTable: "RGO_Column_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
