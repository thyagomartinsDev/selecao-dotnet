using Cursos.Core.Interfaces;

namespace Cursos.Core.Model
{
    public class Venda : EntidadeBase, IIdentityEntity
    {
        public Venda(int id, int? codigoCartao, int codigoEstudante, FormaPagamentoEnum formaPagamento, double valorTotal)
        {
            Id = id;
            CodigoCartao = codigoCartao;
            CodigoEstudante = codigoEstudante;
            FormaPagamento = formaPagamento;
            ValorTotal = valorTotal;
        }

        public int Id { get; set; }
        public int CodigoEstudante { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        public int? CodigoCartao { get; set; }
        public double ValorTotal { get; set; }
    }
}
