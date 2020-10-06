using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleProjectSE2.Migrations
{
    public partial class SomeMigr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "StudentList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "StudentList");

            migrationBuilder.RenameTable(
                name: "StudentList",
                newName: "StudentList");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "StudentList",
                newName: "IX_StudentList_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentList",
                table: "StudentList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentList_Groups_GroupId",
                table: "StudentList",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentList_Groups_GroupId",
                table: "StudentList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentList",
                table: "StudentList");

            migrationBuilder.RenameTable(
                name: "StudentList",
                newName: "StudentList");

            migrationBuilder.RenameIndex(
                name: "IX_StudentList_GroupId",
                table: "StudentList",
                newName: "IX_Students_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "StudentList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "StudentList",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
