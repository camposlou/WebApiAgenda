using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAgenda.Migrations
{
    public partial class Relation1xN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressPerson");

            migrationBuilder.AddColumn<int>(
                name: "IdPerson",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Address_IdPerson",
                table: "Address",
                column: "IdPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_IdPerson",
                table: "Address",
                column: "IdPerson",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_IdPerson",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_IdPerson",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "IdPerson",
                table: "Address");

            migrationBuilder.CreateTable(
                name: "AddressPerson",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressPerson", x => new { x.AddressId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_AddressPerson_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressPerson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressPerson_PersonId",
                table: "AddressPerson",
                column: "PersonId");
        }
    }
}
