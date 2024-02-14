using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Reseed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Group_Roles", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrcId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Group_Types_Group_TypeId",
                        column: x => x.Group_TypeId,
                        principalTable: "Group_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People_Group_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group_Id = table.Column<int>(type: "int", nullable: false),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    Group_Role_Id = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "RGOutputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RGO_TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Originating_GroupId = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGOutputs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RGOutputs_Groups_Originating_GroupId",
                        column: x => x.Originating_GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RGOutputs_RGO_Types_RGO_TypeId",
                        column: x => x.RGO_TypeId,
                        principalTable: "RGO_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Group_Roles",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9848), "Principal Investigator", "PI", null, null, null },
                    { 2, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9850), "Research Assistant", "RA", null, null, null },
                    { 3, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9852), "Ground Truther", "GT", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Group_Types",
                columns: new[] { "Id", "Created_By", "Created_Date", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9658), "Research Group", null, null, null },
                    { 2, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9660), "Data Team", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "ContactInfo", "Created_By", "Created_Date", "Name", "Notes", "OrcId", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "gerry@yahoo.ac.uk", "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9824), "Gerry Thomson", "Academic Neuroradiologist", "123ABC", null, null },
                    { 2, "grant@yahoo.ac.uk", "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9826), "Grant Mair", "Senior Clinical Lecturer in Neuroradiology", "456DEF", null, null },
                    { 3, "smarti@yahoo.ac.uk", "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9828), "Smarti Reel", "Postdoctoral Researcher", "", null, null },
                    { 4, "kara@yahoo.ac.uk", "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9830), "Kara Moraw", "EPCC Applications Developer", "", null, null }
                });

            migrationBuilder.InsertData(
                table: "RGO_Types",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[] { 1, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9869), "Annotations that have been manually created or validated by a human expert", "Group Truth", null, null, null });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "ContactInfo", "Created_By", "Created_Date", "Group_TypeId", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[] { 1, null, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9800), 1, "Classification of Brain Images", null, null, null });

            migrationBuilder.InsertData(
                table: "RGOutputs",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Originating_GroupId", "RGO_TypeId", "Updated_By", "Updated_Date" },
                values: new object[] { 1, "seed", new DateTime(2024, 2, 7, 16, 21, 29, 147, DateTimeKind.Utc).AddTicks(9889), "Classifying the type of Brain Scans, done by Gerry and Grant", "MRI Classification Group Truth", null, 1, 1, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Group_TypeId",
                table: "Groups",
                column: "Group_TypeId");

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
                name: "People_Group_Roles");

            migrationBuilder.DropTable(
                name: "RGOutputs");

            migrationBuilder.DropTable(
                name: "Group_Roles");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "RGO_Types");

            migrationBuilder.DropTable(
                name: "Group_Types");
        }
    }
}
