using Microsoft.EntityFrameworkCore.Migrations;

namespace IBO.Core.BusinessService.Data.Migrations
{
    public partial class LoggerConfigAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Loggers",
                table: "Loggers");

            migrationBuilder.RenameTable(
                name: "Loggers",
                newName: "tblLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblLog",
                table: "tblLog",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblLog",
                table: "tblLog");

            migrationBuilder.RenameTable(
                name: "tblLog",
                newName: "Loggers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loggers",
                table: "Loggers",
                column: "Id");
        }
    }
}
