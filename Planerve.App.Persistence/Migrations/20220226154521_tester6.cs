using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    public partial class tester6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationName",
                table: "Application",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationName",
                table: "Application");
        }
    }
}
