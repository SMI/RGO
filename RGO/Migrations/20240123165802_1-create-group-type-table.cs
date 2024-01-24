using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.Migrations
{
    /// <inheritdoc />
    public partial class _1creategrouptypetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Types", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Group_Types",
                columns: new[] { "Id", "Created_By", "Created_Date", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 1, 23, 16, 58, 2, 404, DateTimeKind.Local).AddTicks(3116), "Research Group", null, null, null },
                    { 2, "seed", new DateTime(2024, 1, 23, 16, 58, 2, 404, DateTimeKind.Local).AddTicks(3190), "Data Team", null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group_Types");
        }
    }
}
