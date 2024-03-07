using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dbwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_People_PersonId",
                table: "RGO_Record_People");

            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People");

            migrationBuilder.CreateTable(
                name: "Evidence_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidence_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evidences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Evidence_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenceDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "RGO_Evidences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Evidence_Id = table.Column<int>(type: "int", nullable: false),
                    RGOutput_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Evidence_Types",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3683), "", "Peer Reviewed Publication", null, null, null },
                    { 2, "seed", new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3685), "", "Requested by another Research Project", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 6, 15, 56, 59, 417, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.CreateIndex(
                name: "IX_Evidences_Evidence_TypeId",
                table: "Evidences",
                column: "Evidence_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Evidences_Evidence_Id",
                table: "RGO_Evidences",
                column: "Evidence_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RGO_Evidences_RGOutput_Id",
                table: "RGO_Evidences",
                column: "RGOutput_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_People_PersonId",
                table: "RGO_Record_People",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People",
                column: "RGO_RecordId",
                principalTable: "RGO_Records",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_People_PersonId",
                table: "RGO_Record_People");

            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People");

            migrationBuilder.DropTable(
                name: "RGO_Evidences");

            migrationBuilder.DropTable(
                name: "Evidences");

            migrationBuilder.DropTable(
                name: "Evidence_Types");

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 2, 18, 26, 14, 615, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_People_PersonId",
                table: "RGO_Record_People",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Record_People_RGO_Records_RGO_RecordId",
                table: "RGO_Record_People",
                column: "RGO_RecordId",
                principalTable: "RGO_Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
