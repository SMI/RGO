using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class nullFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Datasets_RGO_ReIdentification_Configurations_RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets");

            migrationBuilder.AlterColumn<int>(
                name: "RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 22, 10, 445, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Datasets_RGO_ReIdentification_Configurations_RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets",
                column: "RGO_ReIdentificationConfigurationId",
                principalTable: "RGO_ReIdentification_Configurations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RGO_Datasets_RGO_ReIdentification_Configurations_RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets");

            migrationBuilder.AlterColumn<int>(
                name: "RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Evidence_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Group_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "RGO_Column_Templates",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "RGO_Dataset_Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "RGO_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "RGOutputs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 3, 12, 14, 18, 47, 465, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.AddForeignKey(
                name: "FK_RGO_Datasets_RGO_ReIdentification_Configurations_RGO_ReIdentificationConfigurationId",
                table: "RGO_Datasets",
                column: "RGO_ReIdentificationConfigurationId",
                principalTable: "RGO_ReIdentification_Configurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
