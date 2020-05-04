using Microsoft.EntityFrameworkCore.Migrations;

namespace IBO.Core.BusinessService.Data.Migrations
{
    public partial class Modelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_tblProgram_ProgramId",
                table: "tblStudent");

            migrationBuilder.DropIndex(
                name: "IX_tblStudent_ProgramId",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "tblStudent");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "tblCourse",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblCourse_StudentId",
                table: "tblCourse",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCourse_tblStudent_StudentId",
                table: "tblCourse",
                column: "StudentId",
                principalTable: "tblStudent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCourse_tblStudent_StudentId",
                table: "tblCourse");

            migrationBuilder.DropIndex(
                name: "IX_tblCourse_StudentId",
                table: "tblCourse");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "tblCourse");

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "tblStudent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_ProgramId",
                table: "tblStudent",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_tblProgram_ProgramId",
                table: "tblStudent",
                column: "ProgramId",
                principalTable: "tblProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
