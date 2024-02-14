using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedRGO_Dataset_template : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.InsertData(
                table: "RGO_Dataset_Templates",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "RGOutput_Id", "Updated_By", "Updated_Date" },
                values: new object[] { 1, "seed", new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2348), "Classifying the type of Brain Scans, done by Gerry and Grant", "MRI Classification Group Truth", null, 1, null, null });

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Description" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2313), "Brain Scan Classifications" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Description" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7261), "Classifying the type of Brain Scans, done by Gerry and Grant" });
        }
    }
}
