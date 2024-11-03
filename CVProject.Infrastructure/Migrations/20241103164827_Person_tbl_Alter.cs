using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Person_tbl_Alter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CvUrl",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramProfile",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Persons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XProfile",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CvUrl",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "InstagramProfile",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "XProfile",
                table: "Persons");
        }
    }
}
