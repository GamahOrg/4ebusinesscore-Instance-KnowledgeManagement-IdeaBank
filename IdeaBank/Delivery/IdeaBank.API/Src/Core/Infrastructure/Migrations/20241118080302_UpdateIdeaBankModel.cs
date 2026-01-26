using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaBank.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdeaBankModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "IdeaBanks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LK_InputTypeId",
                table: "IdeaBanks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LK_InputTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LK_InputTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdeaBanks_LK_InputTypeId",
                table: "IdeaBanks",
                column: "LK_InputTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IdeaBanks_LK_InputTypes_LK_InputTypeId",
                table: "IdeaBanks",
                column: "LK_InputTypeId",
                principalTable: "LK_InputTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdeaBanks_LK_InputTypes_LK_InputTypeId",
                table: "IdeaBanks");

            migrationBuilder.DropTable(
                name: "LK_InputTypes");

            migrationBuilder.DropIndex(
                name: "IX_IdeaBanks_LK_InputTypeId",
                table: "IdeaBanks");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "IdeaBanks");

            migrationBuilder.DropColumn(
                name: "LK_InputTypeId",
                table: "IdeaBanks");
        }
    }
}
