using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkConsole.Migrations
{
    public partial class MakeFieldRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
