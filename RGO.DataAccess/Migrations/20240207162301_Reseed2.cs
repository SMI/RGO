using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Reseed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.InsertData(
                table: "People_Group_Roles",
                columns: new[] { "Id", "Created_By", "Created_Date", "End_Date", "Group_Id", "Group_Role_Id", "Notes", "Person_Id", "Start_Date", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6665), null, 1, 3, null, 1, null, null, null },
                    { 2, "seed", new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6668), null, 1, 3, null, 2, null, null, null },
                    { 3, "seed", new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6670), null, 1, 1, null, 3, null, null, null },
                    { 4, "seed", new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6671), null, 1, 2, null, 4, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6718));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9889));
        }
    }
}
