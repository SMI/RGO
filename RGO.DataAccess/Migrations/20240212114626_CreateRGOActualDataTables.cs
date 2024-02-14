using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateRGOActualDataTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RGO_Datasets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RGO_Dataset_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Dataset_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dataset_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Datasets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Datasets_RGO_Dataset_Templates_RGO_Dataset_TemplateId",
                        column: x => x.RGO_Dataset_TemplateId,
                        principalTable: "RGO_Dataset_Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RGO_DatasetId = table.Column<int>(type: "int", nullable: false),
                    Record_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Records_RGO_Datasets_RGO_DatasetId",
                        column: x => x.RGO_DatasetId,
                        principalTable: "RGO_Datasets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Columns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RGO_RecordId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PK_Column_Order = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Potentially_Disclosive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Column_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Column_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Columns_RGO_Records_RGO_RecordId",
                        column: x => x.RGO_RecordId,
                        principalTable: "RGO_Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 11, 46, 25, 679, DateTimeKind.Utc).AddTicks(2686));

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

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Columns_RGO_RecordId",
                table: "RGO_Columns",
                column: "RGO_RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Datasets_RGO_Dataset_TemplateId",
                table: "RGO_Datasets",
                column: "RGO_Dataset_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Records_RGO_DatasetId",
                table: "RGO_Records",
                column: "RGO_DatasetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGO_Columns");

            migrationBuilder.DropTable(
                name: "RGO_Records");

            migrationBuilder.DropTable(
                name: "RGO_Datasets");

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

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 35, 23, 86, DateTimeKind.Utc).AddTicks(2670));

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
    }
}
