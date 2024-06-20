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
    public partial class restart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            TypeTranslater dbTranslator = DatabaseHelper.Instance.GetTypeTranslator();
            migrationBuilder.CreateTable(
                name: "Evidence_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(string), 50)), maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidence_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    ContactInfo = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    OrcId = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                name: "RGO_ReIdentification_Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Server = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Database = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Table = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    DeIdentifiedColumn = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    IdentityColumn = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Username = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Password = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    DatabaseType = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_ReIdentification_Configurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Release_Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(string), 20)), maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Available_For_Release = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Release_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RGO_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(string), 20)), maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                name: "Evidences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Evidence_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    EvidenceDetails = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Doi = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    StandardAcknowledgement = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evidences_Evidence_Types_Evidence_TypeId",
                        column: x => x.Evidence_TypeId,
                        principalTable: "Evidence_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Group_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    ContactInfo = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Reference_number = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                      .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Originating_GroupId = table.Column<int>(type: "int", nullable: false),
                    Doi = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    StandardAcknowledgement = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RGO_Dataset_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGOutput_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Release_Status_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Dataset_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Dataset_Templates_RGO_Release_Statuses_Release_Status_Id",
                        column: x => x.Release_Status_Id,
                        principalTable: "RGO_Release_Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Dataset_Templates_RGOutputs_RGOutput_Id",
                        column: x => x.RGOutput_Id,
                        principalTable: "RGOutputs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RGO_Evidences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Evidence_Id = table.Column<int>(type: "int", nullable: false),
                    RGOutput_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Evidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Evidences_Evidences_Evidence_Id",
                        column: x => x.Evidence_Id,
                        principalTable: "Evidences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Evidences_RGOutputs_RGOutput_Id",
                        column: x => x.RGOutput_Id,
                        principalTable: "RGOutputs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RGO_Column_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_Dataset_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Description = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    PK_Column_Order = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    Potentially_Disclosive = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    IsIdentifier = table.Column<int>(type: "int", nullable: false),
                    Release_Status_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Column_Templates_RGO_Release_Statuses_Release_Status_Id",
                        column: x => x.Release_Status_Id,
                        principalTable: "RGO_Release_Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RGO_Datasets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_Dataset_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Dataset_Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Doi = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Dataset_Status = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: false),
                    RGO_ReIdentificationConfigurationId = table.Column<int>(type: "int", nullable: true),
                    Release_Status_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Datasets_RGO_ReIdentification_Configurations_RGO_ReIdentificationConfigurationId",
                        column: x => x.RGO_ReIdentificationConfigurationId,
                        principalTable: "RGO_ReIdentification_Configurations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Datasets_RGO_Release_Statuses_Release_Status_Id",
                        column: x => x.Release_Status_Id,
                        principalTable: "RGO_Release_Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RGO_Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_DatasetId = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                     .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RGO_RecordId = table.Column<int>(type: "int", nullable: false),
                    RGO_Column_TemplateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    PK_Column_Order = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Potentially_Disclosive = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Column_Value = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    IsIdentifier = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: false),
                    Updated_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Updated_Date = table.Column<DateTime>(type: dbTranslator.GetSQLDBTypeForCSharpType(new DatabaseTypeRequest(typeof(DateTime))), nullable: true),
                    Notes = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGO_Columns_RGO_Column_Templates_RGO_Column_TemplateId",
                        column: x => x.RGO_Column_TemplateId,
                        principalTable: "RGO_Column_Templates",
                        principalColumn: "Id");
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
                       .Annotation("SqlServer.Identity", "1, 1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    RGO_Column_TemplateId = table.Column<int>(type: "int", nullable: false),
                    RGO_RecordId = table.Column<int>(type: "int", nullable: false),
                    Person_Record_Role = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
                    Created_By = table.Column<string>(type: dbTranslator.GetStringDataTypeWithUnlimitedWidth(), nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Record_People_RGO_Column_Templates_RGO_Column_TemplateId",
                        column: x => x.RGO_Column_TemplateId,
                        principalTable: "RGO_Column_Templates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                        column: x => x.RGO_RecordId,
                        principalTable: "RGO_Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.InsertData(
            //    table: "Evidence_Types",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
            //    values: new object[,]
            //    {
            //        { 1, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4035), "", "Peer Reviewed Publication", null, null, null },
            //        { 2, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4043), "", "Requested by another Research Project", null, null, null }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Group_Types",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Name", "Notes", "Updated_By", "Updated_Date" },
            //    values: new object[,]
            //    {
            //        { 1, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(3860), "Research Group", null, null, null },
            //        { 2, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(3863), "Data Team", null, null, null }
            //    });

            //migrationBuilder.InsertData(
            //    table: "People",
            //    columns: new[] { "Id", "ContactInfo", "Created_By", "Created_Date", "Name", "Notes", "OrcId", "Updated_By", "Updated_Date" },
            //    values: new object[,]
            //    {
            //        { 1, null, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4068), "Gerry Thomson", "Academic Neuroradiologist", "123ABC", null, null },
            //        { 2, null, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4070), "Grant Mair", "Senior Clinical Lecturer in Neuroradiology", "456DEF", null, null },
            //        { 3, null, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4072), "Smarti Reel", "Postdoctoral Researcher", "", null, null },
            //        { 4, null, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4074), "Kara Moraw", "EPCC Applications Developer", "", null, null }
            //    });

            //migrationBuilder.InsertData(
            //    table: "RGO_Release_Statuses",
            //    columns: new[] { "Id", "Available_For_Release", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
            //    values: new object[,]
            //    {
            //        { 1, "N", "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4232), "See Notes for reasons", "Held", null, null, null },
            //        { 2, "Y", "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4235), "Available for other researchers", "Released", null, null, null }
            //    });

            //migrationBuilder.InsertData(
            //    table: "RGO_Types",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
            //    values: new object[] { 1, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4107), "Annotations that have been manually created or validated by a human expert", "Ground Truth", null, null, null });

            //migrationBuilder.InsertData(
            //    table: "Groups",
            //    columns: new[] { "Id", "ContactInfo", "Created_By", "Created_Date", "Group_TypeId", "Name", "Notes", "Reference_number", "Updated_By", "Updated_Date" },
            //    values: new object[] { 1, null, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4010), 1, "Classification of Brain Images", null, null, null, null });

            //migrationBuilder.InsertData(
            //    table: "RGOutputs",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Doi", "Name", "Notes", "Originating_GroupId", "RGO_TypeId", "StandardAcknowledgement", "Updated_By", "Updated_Date" },
            //    values: new object[] { 1, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4143), "Brain Scan Classifications", null, "MRI Classification Ground Truth", null, 1, 1, null, null, null });

            //migrationBuilder.InsertData(
            //    table: "RGO_Dataset_Templates",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "RGOutput_Id", "Release_Status_Id", "Updated_By", "Updated_Date" },
            //    values: new object[] { 1, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4177), "Classifying the type of Brain Scans, done by Gerry and Grant", "MRI Classification Ground Truth Template", null, 1, 1, null, null });

            //migrationBuilder.InsertData(
            //    table: "RGO_Column_Templates",
            //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "IsIdentifier", "Name", "Notes", "PK_Column_Order", "Potentially_Disclosive", "RGO_Dataset_TemplateId", "Release_Status_Id", "Type", "Updated_By", "Updated_Date" },
            //    values: new object[,]
            //    {
            //        { 1, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4201), "Identifier of this image", 0, "Image_Identifier", null, 1, "N", 1, 1, "Int", null, null },
            //        { 2, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4205), "The first ground truther's label", 0, "MRI_Classification_Ground_Truther_1", null, null, "N", 1, 1, "Char", null, null },
            //        { 3, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4207), "The second ground truther's label", 0, "MRI_Classification_Ground_Truther_2", null, null, "N", 1, 1, "Char", null, null },
            //        { 4, "seed", new DateTime(2024, 4, 24, 13, 2, 17, 373, DateTimeKind.Utc).AddTicks(4209), "This holds labels where both ground truthers agreed", 0, "MRI_Classification_Consensus", null, null, "N", 1, 1, "Char", null, null }
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Evidences_Evidence_TypeId",
                table: "Evidences",
                column: "Evidence_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Group_TypeId",
                table: "Groups",
                column: "Group_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Column_Templates_Release_Status_Id",
                table: "RGO_Column_Templates",
                column: "Release_Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Column_Templates_RGO_Dataset_TemplateId",
                table: "RGO_Column_Templates",
                column: "RGO_Dataset_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Columns_RGO_Column_TemplateId",
                table: "RGO_Columns",
                column: "RGO_Column_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Columns_RGO_RecordId",
                table: "RGO_Columns",
                column: "RGO_RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Dataset_Templates_Release_Status_Id",
                table: "RGO_Dataset_Templates",
                column: "Release_Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Dataset_Templates_RGOutput_Id",
                table: "RGO_Dataset_Templates",
                column: "RGOutput_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Datasets_Release_Status_Id",
                table: "RGO_Datasets",
                column: "Release_Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Datasets_RGO_Dataset_TemplateId",
                table: "RGO_Datasets",
                column: "RGO_Dataset_TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Datasets_RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets",
                column: "RGO_ReIdentificationConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Evidences_Evidence_Id",
                table: "RGO_Evidences",
                column: "Evidence_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Evidences_RGOutput_Id",
                table: "RGO_Evidences",
                column: "RGOutput_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Record_People_PersonId",
                table: "RGO_Record_People",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Record_People_RGO_Column_TemplateId",
                table: "RGO_Record_People",
                column: "RGO_Column_TemplateId");

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
                name: "RGO_Columns");

            migrationBuilder.DropTable(
                name: "RGO_Evidences");

            migrationBuilder.DropTable(
                name: "RGO_Record_People");

            migrationBuilder.DropTable(
                name: "Evidences");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "RGO_Column_Templates");

            migrationBuilder.DropTable(
                name: "RGO_Records");

            migrationBuilder.DropTable(
                name: "Evidence_Types");

            migrationBuilder.DropTable(
                name: "RGO_Datasets");

            migrationBuilder.DropTable(
                name: "RGO_Dataset_Templates");

            migrationBuilder.DropTable(
                name: "RGO_ReIdentification_Configurations");

            migrationBuilder.DropTable(
                name: "RGO_Release_Statuses");

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