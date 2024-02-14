using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreatePersonRecordRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4577), "Ground_Truther_1" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4581), "Ground_Truther_2" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_Date", "Description" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4584), "The date on which this Ground Truth was finalised" });

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 15, 29, 682, DateTimeKind.Utc).AddTicks(4474));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8413), "Expert_1" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_Date", "Name" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8415), "Expert_2" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_Date", "Description" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8417), "The date on which this Ground Truth was recorded" });

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8365));
        }
    }
}
