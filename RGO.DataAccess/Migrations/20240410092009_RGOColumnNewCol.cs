using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RGOColumnNewCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RGO_Column_TemplateId",
                table: "RGO_Columns",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Columns_RGO_Column_TemplateId",
                table: "RGO_Columns",
                column: "RGO_Column_TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Columns",
                column: "RGO_Column_TemplateId",
                principalTable: "RGO_Column_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                table: "RGO_Columns");

            migrationBuilder.DropIndex(
                name: "IX_RGO_Columns_RGO_Column_TemplateId",
                table: "RGO_Columns");

            migrationBuilder.DropColumn(
                name: "RGO_Column_TemplateId",
                table: "RGO_Columns");

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 10, 8, 7, 31, 832, DateTimeKind.Utc).AddTicks(4260));
        }
    }
}
