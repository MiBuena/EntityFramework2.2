using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkConsole.Migrations
{
    public partial class AddArticleEditorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleEditor",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false),
                    EditorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleEditor", x => new { x.ArticleId, x.EditorId });
                    table.ForeignKey(
                        name: "FK_ArticleEditor_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleEditor_Editor_EditorId",
                        column: x => x.EditorId,
                        principalTable: "Editor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleEditor_EditorId",
                table: "ArticleEditor",
                column: "EditorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleEditor");

            migrationBuilder.DropTable(
                name: "Editor");
        }
    }
}
