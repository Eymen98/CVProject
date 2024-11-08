using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Experience_Entities_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Experiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Experiences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
