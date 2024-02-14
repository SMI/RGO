using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnwantedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People_Group_Roles");

            migrationBuilder.DropTable(
                name: "Group_Roles");

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 25, 50, 855, DateTimeKind.Utc).AddTicks(3364));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People_Group_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group_Id = table.Column<int>(type: "int", nullable: false),
                    Group_Role_Id = table.Column<int>(type: "int", nullable: false),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People_Group_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Group_Roles_Group_Roles_Group_Role_Id",
                        column: x => x.Group_Role_Id,
                        principalTable: "Group_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_Group_Roles_Groups_Group_Id",
                        column: x => x.Group_Id,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_Group_Roles_People_Person_Id",
                        column: x => x.Person_Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Group_Roles",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(391), "Principal Investigator", "PI", null, null, null },
                    { 2, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(393), "Research Assistant", "RA", null, null, null },
                    { 3, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(395), "Ground Truther", "GT", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.InsertData(
                table: "People_Group_Roles",
                columns: new[] { "Id", "Created_By", "Created_Date", "End_Date", "Group_Id", "Group_Role_Id", "Notes", "Person_Id", "Start_Date", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(424), null, 1, 3, null, 1, null, null, null },
                    { 2, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(426), null, 1, 3, null, 2, null, null, null },
                    { 3, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(428), null, 1, 1, null, 3, null, null, null },
                    { 4, "seed", new DateTime(2024, 2, 12, 14, 19, 27, 51, DateTimeKind.Utc).AddTicks(429), null, 1, 2, null, 4, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_Group_Roles_Group_Id",
                table: "People_Group_Roles",
                column: "Group_Id");

            migrationBuilder.CreateIndex(
                name: "IX_People_Group_Roles_Group_Role_Id",
                table: "People_Group_Roles",
                column: "Group_Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_People_Group_Roles_Person_Id",
                table: "People_Group_Roles",
                column: "Person_Id");
        }
    }
}
