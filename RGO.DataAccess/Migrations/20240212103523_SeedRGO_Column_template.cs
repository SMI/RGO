using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedRGO_Column_template : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.InsertData(
                table: "RGO_Column_Templates",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "PK_Column_Order", "Potentially_Disclosive", "RGO_Dataset_TemplateId", "Type", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2523), "Identifier of the study that this image is part of", "Study_Identifier", null, 1, "N", 1, "Char", null, null },
                    { 2, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2526), "Identifier of the series that this image is part of", "Series_Identifier", null, 2, "N", 1, "Char", null, null },
                    { 3, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2528), "Identifier of this image", "Image_Identifier", null, 3, "N", 1, "Char", null, null },
                    { 4, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2531), "The ground truth that classifies the type of MRI this is e.g. T1, T2", "MRI_Classification", null, null, "N", 1, "Char", null, null },
                    { 5, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2664), "An expert who generate this ground truth (1)", "Expert_1", null, null, "N", 1, "Int", null, null },
                    { 6, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2668), "An expert who generate this ground truth (2)", "Expert_2", null, null, "N", 1, "Int", null, null },
                    { 7, "seed", new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2670), "The date on which this Ground Truth was recorded", "Date_GT_Recorded", null, null, "N", 1, "Date", null, null }
                });

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2474));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2348));

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
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 25, 20, 664, DateTimeKind.Utc).AddTicks(2313));
        }
    }
}
