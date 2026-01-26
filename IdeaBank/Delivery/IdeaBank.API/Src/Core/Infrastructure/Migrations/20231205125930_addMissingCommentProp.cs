using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaBank.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addMissingCommentProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentText",
                table: "IdeaComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentText",
                table: "IdeaComments");
        }
    }
}
