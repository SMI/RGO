using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColTempSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 7);

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
                columns: new[] { "Created_Date", "Description", "Name" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8409), "Identifier of this image", "Image_Identifier" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Date", "Description", "Name", "PK_Column_Order" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8411), "The ground truth that classifies the type of MRI this is e.g. T1, T2", "MRI_Classification", null });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "Description", "Name", "PK_Column_Order", "Type" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8413), "An expert who generate this ground truth (1)", "Expert_1", null, "Int" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_Date", "Description", "Name", "Type" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8415), "An expert who generate this ground truth (2)", "Expert_2", "Int" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_Date", "Description", "Name", "Type" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 1, 43, 451, DateTimeKind.Utc).AddTicks(8417), "The date on which this Ground Truth was recorded", "Date_GT_Recorded", "Date" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "Description", "Name" },
                values: new object[] { new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2620), "Identifier of the study that this image is part of", "Study_Identifier" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Date", "Description", "Name", "PK_Column_Order" },
                values: new object[] { new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2622), "Identifier of the series that this image is part of", "Series_Identifier", 2 });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "Description", "Name", "PK_Column_Order", "Type" },
                values: new object[] { new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2625), "Identifier of this image", "Image_Identifier", 3, "Char" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_Date", "Description", "Name", "Type" },
                values: new object[] { new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2626), "The ground truth that classifies the type of MRI this is e.g. T1, T2", "MRI_Classification", "Char" });

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_Date", "Description", "Name", "Type" },
                values: new object[] { new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2682), "An expert who generate this ground truth (1)", "Expert_1", "Int" });

            migrationBuilder.InsertData(
                table: "RGO_Column_Templates",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "PK_Column_Order", "Potentially_Disclosive", "RGO_Dataset_TemplateId", "Type", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 6, "seed", new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2684), "An expert who generate this ground truth (2)", "Expert_2", null, null, "N", 1, "Int", null, null },
                    { 7, "seed", new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2686), "The date on which this Ground Truth was recorded", "Date_GT_Recorded", null, null, "N", 1, "Date", null, null }
                });

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2556));
        }
    }
}
