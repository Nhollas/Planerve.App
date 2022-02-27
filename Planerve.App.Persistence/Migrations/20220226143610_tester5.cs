using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    public partial class tester5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Application",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Application");
        }
    }
}
