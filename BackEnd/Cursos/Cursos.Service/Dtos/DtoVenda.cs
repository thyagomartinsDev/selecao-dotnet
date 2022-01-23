using Cursos.Core;

namespace Cursos.Service.Dtos
{
    public class DtoVenda
    {
        public DtoVenda(int id, int idCurso, int idCartao, int codigoEstudante, double valorTotal)
        {
            Id = id;
            IdCurso = idCurso;
            IdCartao = idCartao;
            IdEstudante = codigoEstudante;
            ValorTotal = valorTotal;
        }

        public int Id { get; set; }
        public int IdCurso { get; set; }
        public int IdEstudante { get; set; }
        public int IdCartao { get; set; }
        public double ValorTotal { get; set; }
    }
}
