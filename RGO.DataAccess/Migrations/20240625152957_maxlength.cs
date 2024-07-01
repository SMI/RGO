using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class maxlength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RGO_Types",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RGO_Release_Statuses",
    type: "character varying(250)",
    maxLength: 250,
    nullable: false,
    oldClrType: typeof(string),
    oldType: "nvarchar(20)",
    oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
    name: "Name",
    table: "Evidence_Types",
    type: "character varying(250)",
    maxLength: 250,
    nullable: false,
    oldClrType: typeof(string),
    oldType: "nvarchar(50)",
    oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
