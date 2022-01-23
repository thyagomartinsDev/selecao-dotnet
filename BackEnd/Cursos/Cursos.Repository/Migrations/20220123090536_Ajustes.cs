using Microsoft.EntityFrameworkCore.Migrations;

namespace Cursos.Repository.Migrations
{
    public partial class Ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoCartao",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "FormaPagamento",
                table: "Vendas",
                newName: "IdEstudante");

            migrationBuilder.RenameColumn(
                name: "CodigoEstudante",
                table: "Vendas",
                newName: "IdCurso");

            migrationBuilder.AddColumn<int>(
                name: "IdCartao",
                table: "Vendas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCartao",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "IdEstudante",
                table: "Vendas",
                newName: "FormaPagamento");

            migrationBuilder.RenameColumn(
                name: "IdCurso",
                table: "Vendas",
                newName: "CodigoEstudante");

            migrationBuilder.AddColumn<int>(
                name: "CodigoCartao",
                table: "Vendas",
                type: "INTEGER",
                nullable: true);
        }
    }
}
