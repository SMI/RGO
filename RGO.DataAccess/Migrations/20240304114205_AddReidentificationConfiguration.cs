using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddReidentificationConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "RGO_ReIdentification_Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Server = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Database = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeIdentifiedColumn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityColumn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGO_ReIdentification_Configurations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGO_ReIdentification_Configurations");

            migrationBuilder.InsertData(
                table: "Group_Types",
                columns: new[] { "Id", "Created_By", "Created_Date", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9523), "Research Group", null, null, null },
                    { 2, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9525), "Data Team", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "ContactInfo", "Created_By", "Created_Date", "Name", "Notes", "OrcId", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "gerry@yahoo.ac.uk", "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9852), "Gerry Thomson", "Academic Neuroradiologist", "123ABC", null, null },
                    { 2, "grant@yahoo.ac.uk", "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9855), "Grant Mair", "Senior Clinical Lecturer in Neuroradiology", "456DEF", null, null },
                    { 3, "smarti@yahoo.ac.uk", "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9857), "Smarti Reel", "Postdoctoral Researcher", "", null, null },
                    { 4, "kara@yahoo.ac.uk", "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9859), "Kara Moraw", "EPCC Applications Developer", "", null, null }
                });

            migrationBuilder.InsertData(
                table: "RGO_Types",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[] { 1, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9891), "Annotations that have been manually created or validated by a human expert", "Ground Truth", null, null, null });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "ContactInfo", "Created_By", "Created_Date", "Group_TypeId", "Name", "Notes", "Updated_By", "Updated_Date" },
                values: new object[] { 1, null, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9814), 1, "Classification of Brain Images", null, null, null });

            migrationBuilder.InsertData(
                table: "RGOutputs",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Originating_GroupId", "RGO_TypeId", "Updated_By", "Updated_Date" },
                values: new object[] { 1, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9921), "Brain Scan Classifications", "MRI Classification Group Truth", null, 1, 1, null, null });

            migrationBuilder.InsertData(
                table: "RGO_Dataset_Templates",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "RGOutput_Id", "Updated_By", "Updated_Date" },
                values: new object[] { 1, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9952), "Classifying the type of Brain Scans, done by Gerry and Grant", "MRI Classification Group Truth", null, 1, null, null });

            migrationBuilder.InsertData(
                table: "RGO_Column_Templates",
                columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "PK_Column_Order", "Potentially_Disclosive", "RGO_Dataset_TemplateId", "Type", "Updated_By", "Updated_Date" },
                values: new object[,]
                {
                    { 1, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9985), "Identifier of this image", "Image_Identifier", null, 1, "N", 1, "Int", null, null },
                    { 2, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9989), "The ground truth that classifies the type of MRI this is e.g. T1, T2", "MRI_Classification", null, null, "N", 1, "Char", null, null },
                    { 3, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9991), "An expert who generate this ground truth (1)", "Ground_Truther_1", null, null, "N", 1, "Int", null, null },
                    { 4, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9993), "An expert who generate this ground truth (2)", "Ground_Truther_2", null, null, "N", 1, "Int", null, null },
                    { 5, "seed", new DateTime(2024, 3, 4, 11, 10, 54, 285, DateTimeKind.Utc).AddTicks(9995), "The date on which this Ground Truth was finalised", "Date_GT_Recorded", null, null, "N", 1, "Date", null, null }
                });
        }
    }
}
