using Microsoft.EntityFrameworkCore.Migrations;

namespace Cursos.Repository.Migrations
{
    public partial class AjustesNasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEstudante",
                table: "Cartoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEstudante",
                table: "Cartoes");
        }
    }
}
