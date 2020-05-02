using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBO.Core.BusinessService.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblBoard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBoard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblGrade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(nullable: true),
                    FromMarks = table.Column<string>(nullable: true),
                    ToMarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProgram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BoardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProgram_tblBoard_BoardId",
                        column: x => x.BoardId,
                        principalTable: "tblBoard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSchool",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Country = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    BoardId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSchool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSchool_tblBoard_BoardId",
                        column: x => x.BoardId,
                        principalTable: "tblBoard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAssessmentPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAssessmentPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAssessmentPeriod_tblProgram_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "tblProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCourse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    ProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCourse_tblLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tblLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCourse_tblProgram_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "tblProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblStudent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    GradeId = table.Column<int>(nullable: false),
                    ProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblStudent_tblSchool_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "tblSchool",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_tblProgram_BoardId",
                table: "tblProgram",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSchool_BoardId",
                table: "tblSchool",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_SchoolId",
                table: "tblStudent",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAssessmentPeriod");

            migrationBuilder.DropTable(
                name: "tblCourse");

            migrationBuilder.DropTable(
                name: "tblGrade");

            migrationBuilder.DropTable(
                name: "tblStudent");

            migrationBuilder.DropTable(
                name: "tblLanguage");

            migrationBuilder.DropTable(
                name: "tblProgram");

            migrationBuilder.DropTable(
                name: "tblSchool");

            migrationBuilder.DropTable(
                name: "tblBoard");
        }
    }
}
