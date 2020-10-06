using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleProjectSE2.Migrations
{
    public partial class SomeMigr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "StudentList",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "StudentList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "StudentList",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "StudentList");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "StudentList");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "StudentList");
        }
    }
}
