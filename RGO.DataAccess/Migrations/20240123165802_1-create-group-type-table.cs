using System;
using FAnsi.Discovery.TypeTranslation;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RGO.Utility;
using TypeGuesser;
#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _1creategrouptypetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            TypeTranslater dbTranslator = DatabaseHelper.Instance.GetTypeTranslator();

            migrationBuilder.CreateTable(
                name: "Group_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(string), 20)), maxLength: 20, nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Types", x => x.Id);
                });

            //migrationBuilder.InsertData(
            //    table: "Group_Types",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Name", "Notes", "Updated_By", "Updated_Date" },
            //    values: new object[,]
            //    {
            //        { 1, "seed", new DateTime(2024, 1, 23, 16, 58, 2, 404, DateTimeKind.Local).AddTicks(3116), "Research Group", null, null, null },
            //        { 2, "seed", new DateTime(2024, 1, 23, 16, 58, 2, 404, DateTimeKind.Local).AddTicks(3190), "Data Team", null, null, null }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group_Types");
        }
    }
}
