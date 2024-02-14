using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataSetAndColumnTemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RGO_Dataset_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RGOutput_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Dataset_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Dataset_Templates_RGOutputs_RGOutput_Id",
                        column: x => x.RGOutput_Id,
                        principalTable: "RGOutputs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Column_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RGO_Dataset_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PK_Column_Order = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Potentially_Disclosive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Column_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Column_Templates_RGO_Dataset_Templates_RGO_Dataset_TemplateId",
                        column: x => x.RGO_Dataset_TemplateId,
                        principalTable: "RGO_Dataset_Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 10, 21, 23, 45, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Column_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates",
                column: "RGO_Dataset_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Dataset_Templates_RGOutput_Id",
                table: "RGO_Dataset_Templates",
                column: "RGOutput_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGO_Column_Templates");

            migrationBuilder.DropTable(
                name: "RGO_Dataset_Templates");

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

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "People_Group_Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 7, 16, 23, 0, 370, DateTimeKind.Utc).AddTicks(6671));

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
    }
}
