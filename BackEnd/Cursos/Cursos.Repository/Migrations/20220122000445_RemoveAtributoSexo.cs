using Microsoft.EntityFrameworkCore.Migrations;

namespace Cursos.Repository.Migrations
{
    public partial class RemoveAtributoSexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Estudantes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Estudantes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
