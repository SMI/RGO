using System;
using FAnsi.Discovery.TypeTranslation;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TypeGuesser;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class reseed : Migration
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
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    ContactInfo = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    OrcId = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(string), 20)), maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Group_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    ContactInfo = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Group_Types_Group_TypeId",
                        column: x => x.Group_TypeId,
                        principalTable: "Group_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RGOutputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Originating_GroupId = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGOutputs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGOutputs_Groups_Originating_GroupId",
                        column: x => x.Originating_GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGOutputs_RGO_Types_RGO_TypeId",
                        column: x => x.RGO_TypeId,
                        principalTable: "RGO_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Dataset_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGOutput_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_Dataset_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    PK_Column_Order = table.Column<int>(type: "int", nullable: true),
                    IsIdentifier = table.Column<bool>(type: "bool", nullable: true),
                    Type = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Potentially_Disclosive = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
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

            migrationBuilder.CreateTable(
                name: "RGO_Datasets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_Dataset_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Dataset_Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Dataset_Status = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_DatasetId = table.Column<int>(type: "int", nullable: false),
                    Record_Status = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_RecordId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    PK_Column_Order = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Potentially_Disclosive = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Column_Value = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Column_Status = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    IsIdentifier = table.Column<bool>(type: "bool", nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
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

            migrationBuilder.CreateTable(
                name: "RGO_Record_People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1").Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    RGO_RecordId = table.Column<int>(type: "int", nullable: false),
                    Person_Record_Role = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Record_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Record_People_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                        column: x => x.RGO_RecordId,
                        principalTable: "RGO_Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Groups_Group_TypeId",
                table: "Groups",
                column: "Group_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Column_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates",
                column: "RGO_Dataset_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Columns_RGO_RecordId",
                table: "RGO_Columns",
                column: "RGO_RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Dataset_Templates_RGOutput_Id",
                table: "RGO_Dataset_Templates",
                column: "RGOutput_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Datasets_RGO_Dataset_TemplateId",
                table: "RGO_Datasets",
                column: "RGO_Dataset_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Record_People_PersonId",
                table: "RGO_Record_People",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Record_People_RGO_RecordId",
                table: "RGO_Record_People",
                column: "RGO_RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Records_RGO_DatasetId",
                table: "RGO_Records",
                column: "RGO_DatasetId");

            migrationBuilder.CreateIndex(
                name: "IX_RGOutputs_Originating_GroupId",
                table: "RGOutputs",
                column: "Originating_GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RGOutputs_RGO_TypeId",
                table: "RGOutputs",
                column: "RGO_TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGO_Column_Templates");

            migrationBuilder.DropTable(
                name: "RGO_Columns");

            migrationBuilder.DropTable(
                name: "RGO_Record_People");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "RGO_Records");

            migrationBuilder.DropTable(
                name: "RGO_Datasets");

            migrationBuilder.DropTable(
                name: "RGO_Dataset_Templates");

            migrationBuilder.DropTable(
                name: "RGOutputs");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "RGO_Types");

            migrationBuilder.DropTable(
                name: "Group_Types");
        }
    }
}
