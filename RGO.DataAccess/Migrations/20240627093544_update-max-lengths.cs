using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RGO.Models;

#nullable disable

namespace RGO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatemaxlengths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Evidence_Type>(
                name:"Name",
                table:"Evidence_Types",
                maxLength:250
                );
            migrationBuilder.AlterColumn<RGO_Release_Status>(
               name: "Name",
               table: "RGO_Release_Statuses",
               maxLength: 250
               );
            migrationBuilder.AlterColumn<RGO_Type>(
               name: "Name",
               table: "RGO_Types",
               maxLength: 250
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
