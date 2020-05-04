using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBO.Core.BusinessService.Data.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblSchool_tblBoard_BoardId",
                table: "tblSchool");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSchool_tblLanguage_LanguageId",
                table: "tblSchool");

            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_tblGrade_GradeId",
                table: "tblStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_tblLanguage_LanguageId",
                table: "tblStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_tblSchool_SchoolId",
                table: "tblStudent");

            migrationBuilder.DropTable(
                name: "tblAssessmentPeriod");

            migrationBuilder.DropTable(
                name: "tblCourse");

            migrationBuilder.DropTable(
                name: "tblGrade");

            migrationBuilder.DropTable(
                name: "tblLanguage");

            migrationBuilder.DropTable(
                name: "tblProgram");

            migrationBuilder.DropTable(
                name: "tblBoard");

            migrationBuilder.DropIndex(
                name: "IX_tblStudent_GradeId",
                table: "tblStudent");

            migrationBuilder.DropIndex(
                name: "IX_tblStudent_LanguageId",
                table: "tblStudent");

            migrationBuilder.DropIndex(
                name: "IX_tblStudent_SchoolId",
                table: "tblStudent");

            migrationBuilder.DropIndex(
                name: "IX_tblSchool_BoardId",
                table: "tblSchool");

            migrationBuilder.DropIndex(
                name: "IX_tblSchool_LanguageId",
                table: "tblSchool");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "tblSchool");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "tblSchool");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "tblStudent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "tblStudent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "tblStudent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Board",
                table: "tblSchool",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "tblSchool",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "School",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "Board",
                table: "tblSchool");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "tblSchool");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "tblStudent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "tblStudent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "tblStudent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "tblSchool",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "tblSchool",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tblBoard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBoard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblGrade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromMarks = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToMarks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProgram_tblBoard_BoardId",
                        column: x => x.BoardId,
                        principalTable: "tblBoard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblAssessmentPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAssessmentPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAssessmentPeriod_tblProgram_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "tblProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCourse_tblLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tblLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCourse_tblProgram_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "tblProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCourse_tblStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tblStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_GradeId",
                table: "tblStudent",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_LanguageId",
                table: "tblStudent",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_SchoolId",
                table: "tblStudent",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSchool_BoardId",
                table: "tblSchool",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSchool_LanguageId",
                table: "tblSchool",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAssessmentPeriod_ProgramId",
                table: "tblAssessmentPeriod",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCourse_LanguageId",
                table: "tblCourse",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCourse_ProgramId",
                table: "tblCourse",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCourse_StudentId",
                table: "tblCourse",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProgram_BoardId",
                table: "tblProgram",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblSchool_tblBoard_BoardId",
                table: "tblSchool",
                column: "BoardId",
                principalTable: "tblBoard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSchool_tblLanguage_LanguageId",
                table: "tblSchool",
                column: "LanguageId",
                principalTable: "tblLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_tblGrade_GradeId",
                table: "tblStudent",
                column: "GradeId",
                principalTable: "tblGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_tblLanguage_LanguageId",
                table: "tblStudent",
                column: "LanguageId",
                principalTable: "tblLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_tblSchool_SchoolId",
                table: "tblStudent",
                column: "SchoolId",
                principalTable: "tblSchool",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
