using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class person_imageurl_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Persons",
                newName: "WebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Persons",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Persons",
                newName: "GithubProfile");

            migrationBuilder.RenameColumn(
                name: "Driving",
                table: "Persons",
                newName: "DrivingLicense");

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "Persons",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "WebsiteUrl",
                table: "Persons",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Persons",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "GithubProfile",
                table: "Persons",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DrivingLicense",
                table: "Persons",
                newName: "Driving");
        }
    }
}
