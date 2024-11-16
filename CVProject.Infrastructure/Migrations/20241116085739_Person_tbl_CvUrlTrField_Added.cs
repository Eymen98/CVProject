using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Person_tbl_CvUrlTrField_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CvUrlTr",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CvUrlTr",
                table: "Persons");
        }
    }
}
