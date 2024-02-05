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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group_Types");
        }
    }
}
