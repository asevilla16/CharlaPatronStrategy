using Microsoft.EntityFrameworkCore.Migrations;

namespace PatronEstrategia.Migrations
{
    public partial class addingAdditionalProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SithName",
                table: "Siths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Droids",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SithName",
                table: "Siths");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Droids");
        }
    }
}
