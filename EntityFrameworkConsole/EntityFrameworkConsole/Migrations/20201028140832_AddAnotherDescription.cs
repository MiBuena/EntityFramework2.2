using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkConsole.Migrations
{
    public partial class AddAnotherDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnotherDescription",
                table: "Articles",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnotherDescription",
                table: "Articles");
        }
    }
}
