using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Open_Source_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedTableAt",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ExpiredOfBookATable",
                table: "Tables");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedTableAt",
                table: "User_Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredOfBookATable",
                table: "User_Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedTableAt",
                table: "User_Tables");

            migrationBuilder.DropColumn(
                name: "ExpiredOfBookATable",
                table: "User_Tables");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedTableAt",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredOfBookATable",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
