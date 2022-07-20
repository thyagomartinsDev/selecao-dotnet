using Cursos.Domain.Interfaces;

namespace Cursos.Domain.Model
{
    public class Venda : EntidadeBase, IIdentityEntity
    {
        public Venda(int id, int idCurso, int idCartao, int idEstudante, double valorTotal)
        {
            Id = id;
            IdCurso = idCurso;
            IdCartao = idCartao;
            IdEstudante = idEstudante;
            ValorTotal = valorTotal;
        }

        public int Id { get; set; }
        public int IdCurso { get; set; }
        public int IdEstudante { get; set; }
        public int IdCartao { get; set; }
        public double ValorTotal { get; set; }
    }
}
