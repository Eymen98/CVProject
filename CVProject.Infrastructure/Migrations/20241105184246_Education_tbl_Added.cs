using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Education_tbl_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Persons_PersonId",
                table: "Experience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experience",
                table: "Experience");

            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");

            migrationBuilder.RenameIndex(
                name: "IX_Experience_PersonId",
                table: "Experiences",
                newName: "IX_Experiences_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Institution = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Period = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonId",
                table: "Educations",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experience");

            migrationBuilder.RenameIndex(
                name: "IX_Experiences_PersonId",
                table: "Experience",
                newName: "IX_Experience_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experience",
                table: "Experience",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Persons_PersonId",
                table: "Experience",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
