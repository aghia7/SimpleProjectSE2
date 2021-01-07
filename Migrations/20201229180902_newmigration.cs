using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleProjectSE2.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    JsonContent = table.Column<string>(nullable: true),
                    Handled = table.Column<bool>(nullable: false),
                    AddedAt = table.Column<DateTime>(nullable: false),
                    HandledAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
