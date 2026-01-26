using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaBank.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRequestStageToIdeaBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestStage",
                table: "IdeaBanks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestStage",
                table: "IdeaBanks");
        }
    }
}
