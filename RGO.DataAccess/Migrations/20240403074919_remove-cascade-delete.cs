using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removecascadedelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People");

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8982), "MRI Classification Ground Truth Template" });

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 4, 3, 7, 49, 17, 787, DateTimeKind.Utc).AddTicks(8962), "MRI Classification Ground Truth" });

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People",
                column: "RGO_RecordId",
                principalTable: "RGO_Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People");

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(737), "MRI Classification Group Truth" });

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(714), "MRI Classification Group Truth" });

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People",
                column: "RGO_RecordId",
                principalTable: "RGO_Records",
                principalColumn: "Id");
        }
    }
}
