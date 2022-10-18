using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAgenda.Migrations
{
    public partial class UpdatePersonPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
