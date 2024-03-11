using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newstart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Column_Templates_RGO_Dataset_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates");

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Column_Templates_RGO_Dataset_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates",
                column: "RGO_Dataset_TemplateId",
                principalTable: "RGO_Dataset_Templates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Column_Templates_RGO_Dataset_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates");

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 27, 16, 37, 6, 777, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Column_Templates_RGO_Dataset_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates",
                column: "RGO_Dataset_TemplateId",
                principalTable: "RGO_Dataset_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
